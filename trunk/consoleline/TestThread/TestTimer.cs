using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestThread
{
    class TestTimer
    {
        public static void Start()
        {
            Timer t = new Timer(new TimerCallback((o) => Do()), null, 0, -1);
            Console.WriteLine("function exist!");
        }

        public static void Do()
        {
            while (true)
            {
                Console.WriteLine("timer do!!!");
                Thread.Sleep(1000);
            }
        }
    }
}
