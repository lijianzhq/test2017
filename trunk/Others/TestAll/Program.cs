using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAll
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestFloatDouble.Start();
            //TestTask.Start();

            //TestAction.Start();
            //TestCollection.Start();

            //TestInterlocked.Start();
            //TestEncoding.Start();

            //TestComparer.Start();

            //var i = 1;
            //Show(i++);

            var str = "aaa.bb";
            Console.WriteLine(str.Substring(str.IndexOf(".")));

            Console.WriteLine("end");
            Console.Read();
        }

        static void Show(Int32 index)
        {
            Console.WriteLine(index);
        }
    }
}
