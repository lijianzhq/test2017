using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestThread
{
    class TestAutoResetEvent
    {
        private static AutoResetEvent m_resetEvent = null;
        public static void Start()
        {
            m_resetEvent = new AutoResetEvent(false);
            Do();
        }

        public static void Do()
        {
            Console.WriteLine("thread {0} wait for an event!", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("2 secondes later will release an event!");
            //new Thread(new ThreadStart(() =>
            //{
            //    Console.WriteLine("thread {0} raise event!", Thread.CurrentThread.ManagedThreadId);
            //    Thread.Sleep(1000);
            //    m_resetEvent.Set();
            //})).Start();
            Timer t = new Timer(new TimerCallback(o =>
            {
                Console.WriteLine("thread {0} raise event!", Thread.CurrentThread.ManagedThreadId);
                m_resetEvent.Set();
            }), null,1 * 1000, -1);
            Thread.Sleep(3000);
            Console.WriteLine("start waiting!");
            m_resetEvent.WaitOne();
            Console.WriteLine("get an event!");
        }
    }
}
