using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TestProcess
{
    class TestThreadPriority
    {
        public static void Start()
        {
            StartThread(ThreadPriority.Highest);
            StartThread(ThreadPriority.Lowest);
        }

        public static void StartThread(ThreadPriority priority)
        {
            Thread t = new Thread(new ParameterizedThreadStart((o) =>
            {
                var p = Process.GetCurrentProcess();
                Thread currentThread = (Thread)o;
                Double i = 1;
                while (true)
                {
                    i++;
                    if (i % 1000000000 == 0) Console.WriteLine($"process:{p.PriorityClass.ToString()},thread:{currentThread.Name},{i}");
                }
            }));
            t.Priority = priority;
            t.Name = priority.ToString();
            t.Start(t);
        }
    }
}
