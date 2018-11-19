using System;
using System.Collections.Generic;
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
