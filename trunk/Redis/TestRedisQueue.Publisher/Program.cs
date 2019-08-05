using System;

namespace TestRedisQueue.Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            PublishWorker.Start();
            Console.WriteLine("Done!!!");
            Console.Read();
        }
    }
}
