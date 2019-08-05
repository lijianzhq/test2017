using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ZXing;

namespace TestQRCodeCore
{
    /// <summary>
    /// A smart class to encode some content to a barcode image
    /// </summary>
    public class BarcodeWriter : BarcodeWriter<Bitmap>
    {
        /// <summary>
        /// </summary>
        public BarcodeWriter()
        {
            base.Renderer = new BitmapRenderer();
        }
    }
}
