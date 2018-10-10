using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestThread
{
    class TestTask
    {
        public static void Start()
        {
            //Task.Factory.StartNew(() => Do());
            //Console.WriteLine("function exist!");
            //DoCancel();

            //TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;
            //DoException();
            //DoTest();

            TestException2();
        }
        public static void TestException2()
        {
            TaskScheduler.UnobservedTaskException +=
                    (object sender, UnobservedTaskExceptionEventArgs eventArgs) =>
                    {
                        // 阻止程序崩溃的方法有2种  
                        //第一种是：  
                        //{
                        //    eventArgs.SetObserved();
                        //    Console.WriteLine("Exception handled");
                        //}
                        ////第二种，返回true  
                        //if (false)
                        //{
                        //    ((AggregateException)eventArgs.Exception).Handle(ex =>
                        //       {
                        //           Console.WriteLine("Exception handled");
                        //           return true;
                        //       });
                        //}
                    };
            RunTask();
            // 不断分配内存，强制让GC收集Task对象，从而触发UnobservedTaskException  
            ArrayList arr = new ArrayList();
            while (true)
            {
                try
                {
                    char[] array = new char[100000];
                    arr.Add(array);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.GetType());
                    throw;
                }
            }
        }

        private static void RunTask()
        {
            new Task(() => { throw new NullReferenceException(); }).Start();
        }

        private static void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            Console.WriteLine(e.Exception.Message);
            Console.WriteLine(e.Exception.InnerExceptions[0].StackTrace);
        }

        public static void Do()
        {
            while (true)
            {
                Console.WriteLine("do");
                Thread.Sleep(1000);
            }
        }
        static Task<Int32> t = null;
        public static void DoTest()
        {
            Console.WriteLine("count start!");
            t = new Task<Int32>(n => Sum((Int32)n), 1000000000);
            //可以现在开始，也可以以后开始 
            t.Start();
            //Wait显式的等待一个线程完成
            //t.Wait();
            //Console.WriteLine("The Sum is:" + t.Result);
            Console.WriteLine("count end!");
        }
        private static Int32 Sum(Int32 i)
        {
            Int32 sum = 0;
            for (; i > 0; i--)
                checked { sum += i; }
            return sum;
        }

        public static void DoException()
        {
            Task.Factory.StartNew(() =>
            {
                throw new Exception();
                //Int32 test = (Int32)1000000000;
                //Int32 a = 1;
                //Int32 b = 0;
                //Int32 result = a / b;
                //Console.WriteLine(result);
            });
        }

        public static void DoCancel()
        {
            CancellationTokenSource cancel = new CancellationTokenSource();
            Task t = new Task(() =>
            {
                Console.WriteLine("task start!");
                //System.Threading.Thread.Sleep(10000);
                Boolean result = cancel.Token.WaitHandle.WaitOne(10000);
                if (result)
                    cancel.Token.ThrowIfCancellationRequested();
                Console.WriteLine("cancel token wait result:{0},IsCancellationRequested:{1}", result, cancel.Token.IsCancellationRequested);
            }, cancel.Token);
            t.Start();
            t.ContinueWith((tin) =>
            {
                Console.WriteLine("task end！canceled:{0},status:{1}", tin.IsCanceled, tin.Status);
            });
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("press any  key to  cancel!");
            Int32 i = Console.Read();
            cancel.Cancel();
            t.Dispose();
        }
    }
}
