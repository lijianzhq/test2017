using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestString
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestInsert();
            //TestIndexOf();
            //TestRegex.Test();
            //TestFor();
            //TestAddChar();

            Console.WriteLine("done");
            Console.Read();
        }

        public static void TestAddChar()
        {
            var str = @"Json格式为：
                        jjjjj";
            AddCharAtRowFirst(str);
        }

        public static StringBuilder AddCharAtRowFirst(String text)
        {
            var data = text.Split(new String[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();
            foreach (var item in data)
            {
                sb.AppendFormat("///{0}",item);
                sb.AppendLine();
            }
            return sb;
        }

        public static void TestFor()
        {
            for(var i=3;i<2;i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void TestInsert()
        {
            String text1 = "lijian";
            Console.WriteLine(text1);
            Console.WriteLine(text1.Insert(text1.IndexOf("jian"), " "));
        }

        public static void TestIndexOf()
        {
            String text1 = "(fffff.aacccc.bbb)()";
            Console.WriteLine(text1.Length);
            Int32 startIndex = text1.IndexOf('(');
            Console.WriteLine(text1.IndexOf('(', startIndex + 1, text1.Length - startIndex - 1));
        }
    }
}
