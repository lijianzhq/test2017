using System;
using System.Drawing;

namespace TestTesseract
{
    class TestCracker
    {
        public static void Start()
        {
            var cracker = new Cracker();
            using (var bitmap = new Bitmap(Bitmap.FromFile(@"images\ImageCheck.jpg")))
            {
                var result = cracker.Read(bitmap);
                Console.WriteLine(result);
            }
        }
    }
}
