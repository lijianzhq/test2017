using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Test
{
    class TestSemaphore
    {
        private static Semaphore _semaphore = new Semaphore(2, 3);
        private static Int32 _threadCount = 3;

        public static void Start()
        {
            for (var i = 0; i < _threadCount; i++)
            {
                new Thread(new ThreadStart(() =>
                {
                    ThreadStart();
                })).Start();
            }
            Timer timer = new Timer((o) =>
            {
                ShowMsg("release");
                _semaphore.Release();
            }, null, 0, Timeout.Infinite);
        }

        public static void ThreadStart()
        {
            ShowMsg("wait");
            _semaphore.WaitOne();
            ShowMsg("enter");
            Thread.Sleep(1000);
            ShowMsg("exist");
            _semaphore.Release();
        }

        private static void ShowMsg(String msg)
        {
            Console.WriteLine($"thread {Thread.CurrentThread.ManagedThreadId} {msg}!");
        }
    }
}
