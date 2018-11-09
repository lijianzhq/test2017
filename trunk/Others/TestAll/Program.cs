using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAll
{
    class Program
    {
        static void Main(string[] args)
        {
            double d1 = 148163.1;
            double d2 = 82692.09;
            double d3 = d1 - d2;
            Console.WriteLine(d3);

            //float a1= (double)1.0;
            float f1 = 148163.1f;
            float f2 = 82692.09f;
            float f3 = f1 - f2;
            Console.WriteLine(d3);
            Console.WriteLine(f3);
            Console.Read();
        }
    }
}
