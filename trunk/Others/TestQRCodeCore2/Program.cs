using System;

namespace TestQRCodeCore2
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeHelper.CreateCodeEwm("https://www.cnblogs.com/zcm123/p/6535244.html", @"D:\ProgramData\lijian42\桌面\generate1.png");
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
