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

            TestInterlocked.Start();

            Console.WriteLine("end");
            Console.Read();
        }
    }
}
