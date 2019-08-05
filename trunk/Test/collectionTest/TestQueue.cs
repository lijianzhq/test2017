using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.collectionTest
{
    public static class TestQueue
    {
        public static void Start()
        {
            //Test();
            Test2();
        }

        public static void Test()
        {
            var queue = new Queue<Int32>(2);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        public static void Test2()
        {
            var queue = new Queue<Int32>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(6);
            foreach (var item in queue.Take(2))
            {
                Console.WriteLine(item);
            }
            foreach (var item in queue.Take(2))
            {
                Console.WriteLine(item);
            }
            foreach (var item in queue.Reverse().Take(2))
            {
                Console.WriteLine(item);
            }
        }
    }
}
