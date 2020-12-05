using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Zabr.BarcodeScanner.Emulator.BLL.Utils
{
    public class DecoderUtils
    {
        public static async Task<string> DecodeGlobalAsync(byte[] byteArray, int limitElapsed = 3000)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            cts.CancelAfter(limitElapsed);

            var task = Task.Run(() => { return Decode(cts, byteArray); }, cts.Token);
            var result = await task;
            return result;
        }

        private static string Decode(CancellationTokenSource cts, byte[] byteArray)
        {
            if (byteArray == null)
                return null;

            if (byteArray.Length == 0)
                return null;

            string resultStr;
            using (var memoryStream = new MemoryStream(byteArray))
            {
                using (var image = Image.FromStream(memoryStream))
                {
                    using (var capturedImage = (Bitmap)image.Clone())
                    {
                        resultStr = ZxingUtils.DecodeInner(cts, capturedImage);

                        if (string.IsNullOrEmpty(resultStr))
                        {
                            resultStr = DoZoomAndRotateByCommonAngles(cts, capturedImage);
                        }
                    }
                }
            }

            return resultStr;
        }

        private static string DoZoomAndRotateByCommonAngles(CancellationTokenSource cts, Image capturedImage)
        {
            int exifAngle = ImageUtils.GetExifAngle(cts, capturedImage);
            string resultStr;

            if (exifAngle != 0)
            {
                resultStr = DoZoomAndRotate(cts, capturedImage, exifAngle);
                if (!string.IsNullOrEmpty(resultStr)) return resultStr;
            }
            else
            {
                resultStr = DoZoomAndRotate(cts, capturedImage, 0);
                if (!string.IsNullOrEmpty(resultStr)) return resultStr;
            }

            for (int z = 1; z < 271; z++)
            {
                resultStr = DoZoomAndRotate(cts, capturedImage, z);
                if (!string.IsNullOrEmpty(resultStr)) return resultStr;

                z += z == 1 ? 88 : 89;
            }

            for (int i = -10; i < 10; i++)
            {
                if (i == 0) continue;
                resultStr = DoZoomAndRotate(cts, capturedImage, i);
                if (!string.IsNullOrEmpty(resultStr)) return resultStr;
            }

            return resultStr;
        }

        private static string DoZoomAndRotate(CancellationTokenSource cts, ICloneable capturedImage, int z)
        {
            if (cts.IsCancellationRequested)
                return null;

            string resultStr;

            using (var capturedImageTmp = (Bitmap)capturedImage.Clone())
            {
                using (var capturedImageTmpNew = ImageUtils.RotateImage(capturedImageTmp, z))
                {
                    resultStr = ZxingUtils.DecodeInner(cts, capturedImageTmpNew);

                    if (!string.IsNullOrEmpty(resultStr))
                        return resultStr;

                    resultStr = DoZoomAndRead(cts, capturedImageTmpNew);
                }
            }

            return resultStr;
        }

        private static string DoZoomAndRead(CancellationTokenSource cts, Bitmap capturedImage)
        {
            if (cts.IsCancellationRequested)
                return null;

            string resultStr = null;
            int height = capturedImage.Height;
            int width = capturedImage.Width;

            for (int i = 0; i < 10; i++)
            {
                height += (int)Math.Round(height / 100F * 10F);
                width += (int)Math.Round(width / 100F * 10F);

                capturedImage = ImageUtils.ResizeImage(cts, capturedImage, width, height);
                resultStr = ZxingUtils.DecodeInner(cts, capturedImage);
                if (!string.IsNullOrEmpty(resultStr)) break;
            }

            return resultStr;
        }
    }
}
