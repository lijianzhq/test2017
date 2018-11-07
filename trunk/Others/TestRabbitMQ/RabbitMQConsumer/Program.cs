using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Consumer.Receive();
        }
    }
}
