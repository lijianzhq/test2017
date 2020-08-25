using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestFloatDouble
    {
        public static void Start()
        {
            //Test2();
            Test3();
            Console.Read();
        }

        public static void Test3()
        {
            var str = "1.11689E-06";
            //decimal sss = Convert.ToDecimal(System.Decimal.Parse(("7.06E-05").ToString(), System.Globalization.NumberStyles.Float));
            Console.WriteLine(System.Decimal.Parse(str, System.Globalization.NumberStyles.Float));
        }

        public static void Test2()
        {
            var num = "0.000001116";
            Decimal.TryParse(num, out decimal number);
            Console.WriteLine(number);
        }

        public static void Test1()
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
        }
    }
}
