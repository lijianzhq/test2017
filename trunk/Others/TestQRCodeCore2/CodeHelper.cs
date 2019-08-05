using System;
using System.Collections.Generic;
using System.DrawingCore;
using System.DrawingCore.Imaging;
using System.IO;
using System.Text;
using ZXing;
using ZXing.Common;

namespace TestQRCodeCore2
{
    /// <summary>
    /// 二维码和条形码
    /// </summary>
    public class CodeHelper
    {
        // 生成二维码
        public static void CreateCodeEwm(string message, string gifFileName, int width = 600, int height = 600)
        {
            int heig = width;
            if (width > height)
            {
                heig = height;
                width = height;
            }
            if (string.IsNullOrWhiteSpace(message))
            {
                return;
            }
            string dir = Path.GetDirectoryName(gifFileName);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            var w = new ZXing.QrCode.QRCodeWriter();

            BitMatrix b = w.encode(message, BarcodeFormat.QR_CODE, width, heig);
            var zzb = new ZXing.ZKWeb.BarcodeWriter();
            zzb.Options = new EncodingOptions()
            {
                Margin = 0,
            };
            Bitmap b2 = zzb.Write(b);

            //Logo 图片
            Bitmap logo = new Bitmap(@"D:\01.Work\mcloud\creative-aps-web\aps-web\src\Creative.AFS.Web.AspNetCore\bin\Debug\netcoreapp2.2\2.jpg");

            //计算插入图片的大小和位置
            int middleW = Math.Min((int)(b2.Width / 3.5), logo.Width);
            int middleH = Math.Min((int)(b2.Height / 3.5), logo.Height);
            int middleL = (b2.Width - middleW) / 2;
            int middleT = (b2.Height - middleH) / 2;

            //将img转换成bmp格式，否则后面无法创建Graphics对象
            var newBitmap = new Bitmap(b2.Width, b2.Height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.InterpolationMode = System.DrawingCore.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.DrawingCore.Drawing2D.SmoothingMode.HighQuality;
                g.CompositingQuality = System.DrawingCore.Drawing2D.CompositingQuality.HighQuality;
                //将二维码插入图片
                g.DrawImage(b2, 0, 0);
                //白底
                g.FillRectangle(Brushes.White, middleL, middleT, middleW, middleH);
                //画上logo
                g.DrawImage(logo, middleL, middleT, middleW, middleH);
            }

            newBitmap.Save(gifFileName, ImageFormat.Png);
            newBitmap.Dispose();
            b2.Dispose();
            logo.Dispose();
        }

        /// <summary>
        /// 读取二维码或者条形码从图片
        /// </summary>
        /// <param name="imgFile"></param>
        /// <returns></returns>
        public static string ReadFromImage(string imgFile)
        {

            if (string.IsNullOrWhiteSpace(imgFile))
            {
                return "";
            }
            Image img = Image.FromFile(imgFile);
            Bitmap b = new Bitmap(img);

            //该类名称为BarcodeReader,可以读二维码和条形码
            var zzb = new ZXing.ZKWeb.BarcodeReader();
            zzb.Options = new DecodingOptions
            {
                CharacterSet = "UTF-8"
            };
            Result r = zzb.Decode(b);
            string resultText = r.Text;
            b.Dispose();
            img.Dispose();

            return resultText;

        }

        //将Bitmap  写为byte[]的方法
        public static byte[] BitmapToArray(Bitmap bmp)
        {
            byte[] byteArray = null;

            using (MemoryStream stream = new MemoryStream())
            {

                bmp.Save(stream, ImageFormat.Png);
                byteArray = stream.GetBuffer();
            }

            return byteArray;
        }

        // 生成条形码
        public static void CreateCodeTxm(string message, string gifFileName, int width, int height)
        {

            if (string.IsNullOrWhiteSpace(message))
            {
                return;
            }

            var w = new ZXing.OneD.CodaBarWriter();
            BitMatrix b = w.encode(message, BarcodeFormat.ITF, width, height);
            var zzb = new ZXing.ZKWeb.BarcodeWriter();
            zzb.Options = new EncodingOptions()
            {
                Margin = 3,
                PureBarcode = true
            };
            string dir = Path.GetDirectoryName(gifFileName);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            Bitmap b2 = zzb.Write(b);
            b2.Save(gifFileName, ImageFormat.Gif);
            b2.Dispose();
        }
    }
}