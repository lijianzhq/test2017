using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;
using ZXing;
using ZXing.Common;
using ZXing.OneD;
using ZXing.Rendering;

namespace TestQRCodeCore
{
    /// <summary>
    /// 适用.NET Core的renderer
    /// </summary>
    public class BitmapRenderer : IBarcodeRenderer<Bitmap>
    {
        private static readonly Font DefaultTextFont;

        /// <summary>
        /// Gets or sets the foreground color.
        /// </summary>
        /// <value>The foreground color.</value>
        public Color Foreground
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        /// <value>The background color.</value>
        public Color Background
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        /// <value>The background color.</value>
        public Color[] BackgroundArray
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the resolution which should be used to create the bitmap
        /// If nothing is set the current system settings are used
        /// </summary>
        public float? DpiX
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the resolution which should be used to create the bitmap
        /// If nothing is set the current system settings are used
        /// </summary>
        public float? DpiY
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the text font.
        /// </summary>
        /// <value>
        /// The text font.
        /// </value>
        public Font TextFont
        {
            get;
            set;
        }

        static BitmapRenderer()
        {
            try
            {
                BitmapRenderer.DefaultTextFont = new Font("Arial", 10f, FontStyle.Regular);
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ZXing.ZKWeb.Rendering.BitmapRenderer" /> class.
        /// </summary>
        public BitmapRenderer()
        {
            this.Foreground = Color.Red;
            this.Background = Color.White;
            this.TextFont = BitmapRenderer.DefaultTextFont;
            this.BackgroundArray = new Color[] { Color.Red, Color.Yellow, Color.Blue, Color.Black };
        }

        /// <summary>
        /// Renders the specified matrix.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="format">The format.</param>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        public Bitmap Render(BitMatrix matrix, BarcodeFormat format, string content)
        {
            return this.Render(matrix, format, content, new EncodingOptions());
        }

        /// <summary>
        /// 根据点位获取颜色
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public Color GetBackColor(Int32 x, Int32 y, Int32 width, Int32 height)
        {
            if (x <= width / 2)
            {
                if (y <= height / 2)
                {
                    return this.BackgroundArray[0];
                }
                else
                {
                    return this.BackgroundArray[2];
                }
            }
            else
            {
                if (y <= height / 2)
                {
                    return this.BackgroundArray[1];
                }
                else
                {
                    return this.BackgroundArray[3];
                }
            }
        }

        /// <summary>
        /// Renders the specified matrix.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="format">The format.</param>
        /// <param name="content">The content.</param>
        /// <param name="options">The options.</param>
        /// <returns></returns>
        public Bitmap Render(BitMatrix matrix, BarcodeFormat format, string content, EncodingOptions options)
        {
            int width = matrix.Width;
            int height = matrix.Height;
            Font font = this.TextFont ?? BitmapRenderer.DefaultTextFont;
            int emptyArea = 0;
            bool outputContent = font != null &&
                                (options == null || !options.PureBarcode) &&
                                !string.IsNullOrEmpty(content) &&
                                    (format == BarcodeFormat.CODE_39 ||
                                     format == BarcodeFormat.CODE_93 ||
                                     format == BarcodeFormat.CODE_128 ||
                                     format == BarcodeFormat.EAN_13 ||
                                     format == BarcodeFormat.EAN_8 ||
                                     format == BarcodeFormat.CODABAR ||
                                     format == BarcodeFormat.ITF ||
                                     format == BarcodeFormat.UPC_A ||
                                     format == BarcodeFormat.UPC_E ||
                                     format == BarcodeFormat.MSI ||
                                     format == BarcodeFormat.PLESSEY);
            if (options != null)
            {
                if (options.Width > width)
                {
                    width = options.Width;
                }
                if (options.Height > height)
                {
                    height = options.Height;
                }
            }
            int pixelsizeWidth = width / matrix.Width;
            int pixelsizeHeight = height / matrix.Height;
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            float? num = this.DpiX;
            float? dpiX = num.HasValue ? num : this.DpiY;
            num = this.DpiY;
            float? dpiY = num.HasValue ? num : this.DpiX;
            if (dpiX.HasValue)
            {
                bmp.SetResolution(dpiX.Value, dpiY.Value);
            }
            using (Graphics g = Graphics.FromImage(bmp))
            {
                BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);
                try
                {
                    byte[] pixels = new byte[bmpData.Stride * height];
                    int padding = bmpData.Stride - 3 * width;
                    int index = 0;
                    Color color = this.Background;
                    for (int y = 0; y < matrix.Height; y++)
                    {
                        for (int pixelsizeHeightProcessed = 0; pixelsizeHeightProcessed < pixelsizeHeight; pixelsizeHeightProcessed++)
                        {
                            for (int x = 0; x < matrix.Width; x++)
                            {
                                //color = (matrix[x, y] ? this.Foreground : this.Background);
                                color = (matrix[x, y] ? GetBackColor(x, y, matrix.Width, matrix.Height) : this.Background);
                                for (int pixelsizeWidthProcessed = 0; pixelsizeWidthProcessed < pixelsizeWidth; pixelsizeWidthProcessed++)
                                {
                                    pixels[index++] = color.B;
                                    pixels[index++] = color.G;
                                    pixels[index++] = color.R;
                                }
                            }
                            for (int x2 = pixelsizeWidth * matrix.Width; x2 < width; x2++)
                            {
                                pixels[index++] = this.Background.B;
                                pixels[index++] = this.Background.G;
                                pixels[index++] = this.Background.R;
                            }
                            index += padding;
                        }
                    }
                    for (int y2 = pixelsizeHeight * matrix.Height; y2 < height; y2++)
                    {
                        for (int x3 = 0; x3 < width; x3++)
                        {
                            pixels[index++] = this.Background.B;
                            pixels[index++] = this.Background.G;
                            pixels[index++] = this.Background.R;
                        }
                        index += padding;
                    }
                    if (outputContent)
                    {
                        int textAreaHeight = font.Height;
                        emptyArea = ((height + 10 > textAreaHeight) ? textAreaHeight : 0);
                        if (emptyArea > 0)
                        {
                            index = (width * 3 + padding) * (height - emptyArea);
                            for (int y3 = height - emptyArea; y3 < height; y3++)
                            {
                                for (int x4 = 0; x4 < width; x4++)
                                {
                                    pixels[index++] = this.Background.B;
                                    pixels[index++] = this.Background.G;
                                    pixels[index++] = this.Background.R;
                                }
                                index += padding;
                            }
                        }
                    }
                    Marshal.Copy(pixels, 0, bmpData.Scan0, pixels.Length);
                }
                finally
                {
                    bmp.UnlockBits(bmpData);
                }
                if (emptyArea > 0)
                {
                    if (format != BarcodeFormat.EAN_8)
                    {
                        if (format == BarcodeFormat.EAN_13)
                        {
                            if (content.Length < 13)
                            {
                                content = OneDimensionalCodeWriter.CalculateChecksumDigitModulo10(content);
                            }
                            content = content.Insert(7, "   ");
                            content = content.Insert(1, "   ");
                        }
                    }
                    else
                    {
                        if (content.Length < 8)
                        {
                            content = OneDimensionalCodeWriter.CalculateChecksumDigitModulo10(content);
                        }
                        content = content.Insert(4, "   ");
                    }
                    SolidBrush brush = new SolidBrush(this.Foreground);
                    StringFormat expr_442 = new StringFormat();
                    expr_442.Alignment = StringAlignment.Center;
                    StringFormat drawFormat = expr_442;
                    g.DrawString(content, font, brush, (float)(pixelsizeWidth * matrix.Width / 2), (float)(height - emptyArea), drawFormat);
                }
            }
            return bmp;
        }
    }
}
