using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using ZXing;
using ZXing.Common;

namespace Zabr.BarcodeScanner.Emulator.BLL.Utils
{
    public class ZxingUtils
    {
        public static bool Detect(Bitmap capturedImage)
        {
            var source = new BitmapLuminanceSource(capturedImage);
            var binarizer = new HybridBinarizer(source);
            var bbitmap = new BinaryBitmap(binarizer);

            var detect = ZXing.PDF417.Internal.Detector.detect(bbitmap, null, false);
            var result = detect.Points.Count > 0;

            return result;
        }

        public static string DecodeInner(CancellationTokenSource cts, ICloneable image)
        {
            if (cts != null && cts.IsCancellationRequested)
                return null;

            Result tmpResult;

            using (var bitmap = (Bitmap) image.Clone())
            {
                var reader = new BarcodeReader
                {
                    Options =
                    {
                        PossibleFormats = new List<BarcodeFormat>
                        {
                            BarcodeFormat.PDF_417
                        },
                        TryHarder = false,
                        PureBarcode = false
                    },
                    AutoRotate = false,
                    TryInverted = true
                };
                tmpResult = reader.Decode(bitmap);
            }

            if (tmpResult != null && !string.IsNullOrEmpty(tmpResult.Text))
            {
                return tmpResult.Text;
            }

            return null;
        }
    }
}