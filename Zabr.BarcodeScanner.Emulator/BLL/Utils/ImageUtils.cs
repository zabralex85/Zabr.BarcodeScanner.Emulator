using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using ExifLib;

namespace Zabr.BarcodeScanner.Emulator.BLL.Utils
{
    public class ImageUtils
    {
        public static int GetExifAngle(CancellationTokenSource cts, Image capturedImage)
        {
            if (cts.IsCancellationRequested)
                return 0;

            int exifAngle = 0;

            using (var ms = new MemoryStream())
            {
                capturedImage.Save(ms, ImageFormat.Jpeg);
                ms.Seek(0, SeekOrigin.Begin);

                using (var exifReader = new ExifReader(ms))
                {
                    if (!exifReader.GetTagValue<ushort>(ExifTags.Orientation, out var orientation)) return exifAngle;

                    //0 cw = 1
                    //180 = 3
                    //90 cw = 6

                    switch (orientation)
                    {
                        case 6:
                            exifAngle = 90;
                            break;
                        case 3:
                            exifAngle = 180;
                            break;
                        case 8:
                            exifAngle = 270;
                            break;
                        default:
                            exifAngle = 0;
                            break;
                    }
                }
            }

            return exifAngle;
        }
        public static Bitmap ResizeImage(CancellationTokenSource cts, Image image, int width, int height)
        {
            if (cts.IsCancellationRequested)
                return null;

            //System.Console.WriteLine("Zooming Image: " + width);

            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
        public static Bitmap RotateImage(Image inputImage, float angleDegrees, bool upsizeOk,
            bool clipOk, Color backgroundColor)
        {
            //System.Console.WriteLine("Rotate Image: " + angleDegrees);

            // Test for zero rotation and return a clone of the input image
            if (Math.Abs(angleDegrees) < 1)
                return (Bitmap)inputImage.Clone();

            // Set up old and new image dimensions, assuming upsizing not wanted and clipping OK
            int oldWidth = inputImage.Width;
            int oldHeight = inputImage.Height;
            int newWidth = oldWidth;
            int newHeight = oldHeight;
            float scaleFactor = 1f;

            // If upsizing wanted or clipping not OK calculate the size of the resulting bitmap
            if (upsizeOk || !clipOk)
            {
                double angleRadians = angleDegrees * Math.PI / 180d;

                double cos = Math.Abs(Math.Cos(angleRadians));
                double sin = Math.Abs(Math.Sin(angleRadians));
                newWidth = (int)Math.Round(oldWidth * cos + oldHeight * sin);
                newHeight = (int)Math.Round(oldWidth * sin + oldHeight * cos);
            }

            // If upsizing not wanted and clipping not OK need a scaling factor
            if (!upsizeOk && !clipOk)
            {
                scaleFactor = Math.Min((float)oldWidth / newWidth, (float)oldHeight / newHeight);
                newWidth = oldWidth;
                newHeight = oldHeight;
            }

            // Create the new bitmap object. If background color is transparent it must be 32-bit, 
            //  otherwise 24-bit is good enough.
            Bitmap newBitmap = new Bitmap(newWidth, newHeight, backgroundColor == Color.Transparent ?
                PixelFormat.Format32bppArgb : PixelFormat.Format24bppRgb);
            newBitmap.SetResolution(inputImage.HorizontalResolution, inputImage.VerticalResolution);

            // Create the Graphics object that does the work
            using (var graphicsObject = Graphics.FromImage(newBitmap))
            {
                graphicsObject.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsObject.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphicsObject.SmoothingMode = SmoothingMode.HighQuality;

                // Fill in the specified background color if necessary
                if (backgroundColor != Color.Transparent)
                    graphicsObject.Clear(backgroundColor);

                // Set up the built-in transformation matrix to do the rotation and maybe scaling
                graphicsObject.TranslateTransform(newWidth / 2f, newHeight / 2f);

                if (scaleFactor != 1f)
                    graphicsObject.ScaleTransform(scaleFactor, scaleFactor);

                graphicsObject.RotateTransform(angleDegrees);
                graphicsObject.TranslateTransform(-oldWidth / 2f, -oldHeight / 2f);

                // Draw the result 
                graphicsObject.DrawImage(inputImage, 0, 0);
            }

            return newBitmap;
        }

        public static Bitmap RotateImage(Bitmap img, float rotationAngle)
        {
            return RotateImage(img, rotationAngle, true, true, Color.White);
        }

    }
}