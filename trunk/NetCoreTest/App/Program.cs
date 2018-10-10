using System;

using Library;

namespace App
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thing t = new Thing();
            Console.WriteLine($"The number is {t.Get(38)}");
            Console.Read();
        }
    }
}
