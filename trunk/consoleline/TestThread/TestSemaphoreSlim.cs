using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestThread
{
    class TestSemaphoreSlim
    {
        private static SemaphoreSlim m_freeNodes = new SemaphoreSlim(0, 5);
        public static void StartTest()
        {
            for (var i = 0; i < 10; i++)
            {
                new Thread(new ParameterizedThreadStart(Work)).Start(i);
            }
        }

        public static void Work(Object param)
        {
            Console.WriteLine("thread {0} wait for semaphore.", param);
            if (m_freeNodes.Wait(-1))
            {
                Console.WriteLine("thread {0} gets semaphore.", param);
            }
            else
            {
                Console.WriteLine("thread {0} get semaphore fail!", param);
            }
            //Int32 threadID = Convert.ToInt32(param);
            //Thread.Sleep(1000);
            //Console.WriteLine("thread {0} release semaphore.", param);
            //m_freeNodes.Release();
        }
    }
}
