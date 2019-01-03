using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAll
{
    class TestTask
    {
        public static void Start()
        {
            TestBlockCollection2();
        }

        public static void TestBlockCollection2()
        {
            // Increase or decrease this value as desired.
            int itemsToAdd = 10;

            // Preserve all the display output for Adds and Takes
            //Console.SetBufferSize(80, (itemsToAdd * 2) + 3);

            // A bounded collection. Increase, decrease, or remove the
            // maximum capacity argument to see how it impacts behavior.
            BlockingCollection<int> numbers = new BlockingCollection<int>(50);


            // A simple blocking consumer with no cancellation.

            var syncDataTask = Task.Factory.StartNew(new Action(() => { }));
            var newSyncDataTask = syncDataTask.ContinueWith((tskIn) =>
            {
                int i = -1;
                while (!numbers.IsCompleted)
                {
                    try
                    {
                        i = numbers.Take();
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("Adding was completed!");
                        break;
                    }
                    Console.WriteLine("Take:{0},threadid:{1} ", i, Thread.CurrentThread.ManagedThreadId);

                    // Simulate a slow consumer. This will cause
                    // collection to fill up fast and thus Adds wil block.
                    //Thread.SpinWait(100000);
                    //Thread.Sleep(1000 * 10);
                }
                //i = numbers.Take();
                Console.WriteLine("\r\nNo more items to take. Press the Enter key to exit.");
            });

            // A simple blocking producer with no cancellation.
            Task.Run(() =>
            {
                //for (int i = 0; i < itemsToAdd; i++)
                //{
                //    numbers.Add(i);
                //    Console.WriteLine("Add:{0} Count={1}", i, numbers.Count);
                //    //Thread.Sleep(100);
                //}

                // See documentation for this method.
                Thread.Sleep(1000);
                numbers.CompleteAdding();
                Console.WriteLine("CompleteAdding");
            });
        }

        public static void TestBlockCollection()
        {
            // Increase or decrease this value as desired.
            int itemsToAdd = 10;

            // Preserve all the display output for Adds and Takes
            //Console.SetBufferSize(80, (itemsToAdd * 2) + 3);

            // A bounded collection. Increase, decrease, or remove the
            // maximum capacity argument to see how it impacts behavior.
            BlockingCollection<int> numbers = new BlockingCollection<int>(50);


            // A simple blocking consumer with no cancellation.
            Task.Run(() =>
            {
                int i = -1;
                while (!numbers.IsCompleted)
                {
                    try
                    {
                        i = numbers.Take();
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("Adding was completed!");
                        break;
                    }
                    Console.WriteLine("Take:{0},threadid:{1} ", i, Thread.CurrentThread.ManagedThreadId);

                    // Simulate a slow consumer. This will cause
                    // collection to fill up fast and thus Adds wil block.
                    //Thread.SpinWait(100000);
                    Thread.Sleep(1000 * 10);
                }

                Console.WriteLine("\r\nNo more items to take. Press the Enter key to exit.");
            });

            // A simple blocking producer with no cancellation.
            Task.Run(() =>
            {
                for (int i = 0; i < itemsToAdd; i++)
                {
                    numbers.Add(i);
                    Console.WriteLine("Add:{0} Count={1}", i, numbers.Count);
                    //Thread.Sleep(100);
                }

                // See documentation for this method.
                numbers.CompleteAdding();
                Console.WriteLine("CompleteAdding");
            });
        }

        public static void TestContinueTask()
        {
            var task = new Task(new Action(() =>
            {
                Console.WriteLine("start");
            }));
            task.Start();
            Thread.Sleep(1000);
            Task continueTask = null;
            for (var i = 0; i < 100000; i++)
            {
                //task.ContinueWith(new Action<Task>((t) =>
                continueTask = (continueTask ?? task).ContinueWith(new Action<Task, Object>((t, o) =>
                {
                    Console.WriteLine($"continue{o}");
                }), i);
            }
        }
    }
}
