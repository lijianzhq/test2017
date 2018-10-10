using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tesseract;

namespace TestTesseract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start!!!");
            //TestCracker.Start();
            TestTesseractHelper.Start();
            Console.WriteLine("end!!!");
            Console.Read();
        }
    }
}
