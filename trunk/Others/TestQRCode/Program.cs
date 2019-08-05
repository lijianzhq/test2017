using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.QrCode.Internal;

namespace TestQRCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Generate3("123");
            //Generate1("123");
            Console.WriteLine("done");
            Console.Read();
        }

        /// <summary>
        /// 生成二维码,保存成图片
        /// </summary>
        static void Generate1(string text)
        {
            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            QrCodeEncodingOptions options = new QrCodeEncodingOptions();
            options.DisableECI = true;
            //设置内容编码
            options.CharacterSet = "UTF-8";
            //设置二维码的宽度和高度
            options.Width = 500;
            options.Height = 500;
            //设置二维码的边距,单位不是固定像素
            options.Margin = 1;
            writer.Options = options;

            Bitmap map = writer.Write(text);
            string filename = @"D:\ProgramData\lijian42\桌面\generate1.png";
            map.Save(filename, ImageFormat.Png);
            map.Dispose();
        }

        /// <summary>
        /// 生成带Logo的二维码
        /// </summary>
        /// <param name="text"></param>
        static void Generate3(string text)
        {
            //Logo 图片
            Bitmap logo = new Bitmap(@"D:\01.Work\mcloud\creative-aps-web\aps-web\src\Creative.AFS.Web.AspNetCore\bin\Debug\netcoreapp2.2\2.jpg");
            //构造二维码写码器
            MultiFormatWriter writer = new MultiFormatWriter();
            Dictionary<EncodeHintType, object> hint = new Dictionary<EncodeHintType, object>();
            hint.Add(EncodeHintType.CHARACTER_SET, "UTF-8");
            hint.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);

            //生成二维码 
            BitMatrix bm = writer.encode(text, BarcodeFormat.QR_CODE, 300, 300, hint);
            BarcodeWriter barcodeWriter = new BarcodeWriter();
            Bitmap map = barcodeWriter.Write(bm);

            //获取二维码实际尺寸（去掉二维码两边空白后的实际尺寸）
            int[] rectangle = bm.getEnclosingRectangle();

            //计算插入图片的大小和位置
            int middleW = Math.Min((int)(rectangle[2] / 3.5), logo.Width);
            int middleH = Math.Min((int)(rectangle[3] / 3.5), logo.Height);
            int middleL = (map.Width - middleW) / 2;
            int middleT = (map.Height - middleH) / 2;

            //img转换成bmp格式，否则后面无法创建Graphics对象
            Bitmap bmpimg = new Bitmap(map.Width, map.Height, PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(bmpimg))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                //将二维码插入图片
                g.DrawImage(map, 0, 0);

                //白底
                g.FillRectangle(Brushes.White, middleL, middleT, middleW, middleH);
                //将logo插入图片
                g.DrawImage(logo, middleL, middleT, middleW, middleH);
            }
            //Graphics myGraphic = Graphics.FromImage(bmpimg);
            ////白底
            //myGraphic.FillRectangle(Brushes.White, middleL, middleT, middleW, middleH);
            //myGraphic.DrawImage(logo, middleL, middleT, middleW, middleH);

            //保存成图片
            bmpimg.Save(@"D:\01.Work\mcloud\creative-aps-web\aps-web\src\Creative.AFS.Web.AspNetCore\bin\Debug\netcoreapp2.2\4.png", ImageFormat.Png);
        }
    }
}
