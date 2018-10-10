using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestThread
{
    class TestSemaphore
    {
        private static Semaphore m_freeNodes = new Semaphore(0, 5);
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
            m_freeNodes.WaitOne();
            //Int32 threadID = Convert.ToInt32(param);
            Console.WriteLine("thread {0} gets semaphore.", param);
            //Thread.Sleep(1000);
            //Console.WriteLine("thread {0} release semaphore.", param);
            //m_freeNodes.Release();
        }
    }
}