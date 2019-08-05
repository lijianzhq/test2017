using System;

namespace TestRedisQueue.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumeWorker.Start();
            Console.WriteLine("Done!!!");
            Console.Read();
        }
    }
}
