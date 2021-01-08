using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Test();
            //Testyield.Start();
            //TestSemaphore.Start();
            //TestExcel.Start();
            //TestAsciiCode();
            //TestExceptionPerformance.Start();

            //TestForeachDic.Test1();
            //TestHttpUtility.Test();

            //Console.WriteLine(String.Format("{0}.bbbbb", "aaa"));
            //Console.WriteLine(String.Format(".bbbbb", "aaa"));
            //TestDic.Test();
            //testPolymorphism.Test.Start();
            //TestLinq.Start();

            //Console.WriteLine(Encoding.GetEncoding("text/html"));
            //Test1();
            //collectionTest.TestHashSet.Test();
            //collectionTest.TestList.Test();
            //collectionTest.TestQueue.Start();
            //TestCreatePath();
            //TestPLZH.Test();
            //TestConvert();
            //"aa".CallExtesion();
            //String aa = null;
            //aa.CallExtesion();

            //Convert.ToString(DBNull.Value);
            //Convert.ToString(null);
            //Console.WriteLine(String.Format("fda", "fdafd"));

            //TestArray();
            //Console.WriteLine("01".TrimStart('0'));

            //TestEnum.Start();

            //TestDatetime.Start();
            //TestList.Test();
            //TestIO.Start();
            TestString.Start();

            //TestExpression.Start();
            //TestReflection.Start();
            //TestCollection.Start();

            //TestTemp.Start();
            //TestByte.Start();

            //Int32.TryParse("00D1", System.Globalization.NumberStyles.AllowHexSpecifier, null, out Int32 binNum);
            //Console.WriteLine(binNum);

            //Console.WriteLine(Convert.ToString(43.ToString("x8")));
            //TestDatetime.Test4();

            //TestFloatDouble.Start();
            //TestIsAssignableFrom.Start();

            var data = -0.000002514038811731m;
            Console.WriteLine("done");
            Console.Read();
        }

        static void TestArray()
        {
            var i = 0;
            var data = new String[3] { "1", "2", "3" };
            Console.Write(data[i++]);
            Console.Write(data[i++]);
            Console.Write(data[i++]);
        }

        static void CallExtesion(this String text)
        {
            Console.WriteLine(text);
        }

        public static void TestConvert()
        {
            Int32 i = -1;
            Int32.TryParse("", out i);
            Console.WriteLine(i);
            //Console.WriteLine(Convert.ToInt32(""));
        }

        public static void TestCreatePath()
        {
            Directory.CreateDirectory(@"d:\1\2\3\4");
        }

        public static void Test1()
        {
            //List<String> data = new List<string>();
            List<String> data = null;
            if (data?.Count > 0)
            {
                Console.WriteLine(">0");
            }
            else if (data?.Count == 0)
            {
                Console.WriteLine("=0");
            }
            else
            {
                Console.WriteLine("else");
            }
        }

        public static void TestAsciiCode()
        {
            Console.Write("10 is the ascii code of the char:{0}", (Char)97);
            Console.WriteLine();
            Console.Write("a ascii code is:{0}", (UInt16)'a');
        }

        public static void Test()
        {
            Int32 a = 12;
            Int32 b = a++;
            Console.WriteLine(b);
            Console.WriteLine(a);

            a = 12;
            b = ++a;
            Console.WriteLine(b);
            Console.WriteLine(a);
        }
    }
}
