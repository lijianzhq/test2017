using System;
using System.Drawing;
using System.Drawing.Imaging;
using ZXing;
using ZXing.QrCode;

namespace TestQRCodeCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Generate1("123");
            Console.WriteLine("Hello World!");
            Console.Read();
        }

        /// <summary>
        /// 生成二维码,保存成图片
        /// </summary>
        static void Generate1(string text)
        {
            var writer = new BarcodeWriter();
            ((BitmapRenderer)writer.Renderer).BackgroundArray = new Color[] {
                                                 ColorTranslator.FromHtml("#FFCE2F"),
                                                 ColorTranslator.FromHtml("#43E4D1"),
                                                 ColorTranslator.FromHtml("#FCF588"),
                                                 ColorTranslator.FromHtml("#1082CA")};
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
    }
}
