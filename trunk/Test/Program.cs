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
            TestLinq.Start();

            //Console.WriteLine(Encoding.GetEncoding("text/html"));
            //Test1();
            //collectionTest.TestHashSet.Test();
            //collectionTest.TestList.Test();
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
