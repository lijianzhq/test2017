using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TestThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start!!!");
            //TestSemaphore.StartTest();
            //TestSemaphoreSlim.StartTest();
            //TestAutoResetEvent.Start();
            //TestConcurrentDictionary.Start();
            //TestTimer.Start();
            //TestProcess.Start();

            //Thread t = new Thread(() =>
            //{
            //    TestTask.Start();
            //});
            //t.Start();
            //t = null;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            TestTask.Start();
            Thread.Sleep(2000);
            Console.WriteLine("end!!!!");
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.Read();
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Console.WriteLine("CurrentDomain_UnhandledException");
        }
    }
}
