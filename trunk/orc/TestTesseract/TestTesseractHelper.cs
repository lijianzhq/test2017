using System;
using System.Collections.Generic;
using System.Drawing;
using Tesseract;

namespace TestTesseract
{
    class TestTesseractHelper
    {
        public static void Start()
        {
            //解析验证码
            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                engine.SetVariable("tessedit_char_whitelist", "ABCDEFGHIJKLMNOPQRSTUVWXZY");
                using (var bitmap = new Bitmap(Bitmap.FromFile(@"images\ImageCheck.jpg")))
                {
                    UnCodebase ud = new UnCodebase(bitmap);
                    var newBitmap = ud.GrayByPixels();
                    ud.ClearNoise(128, 2);
                    newBitmap.Save(@"images\ImageCheck_new.jpg");
                    using (var entity = engine.Process(newBitmap))
                    {
                        Console.WriteLine(entity.GetText());
                    }
                }
            }
        }
    }
}
