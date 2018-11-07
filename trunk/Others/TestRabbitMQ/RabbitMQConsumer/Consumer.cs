using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace RabbitMQConsumer
{
    public class Consumer
    {
        public static void Receive()
        {
            var factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://guest:guest@127.0.0.1:5672//");
            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    //声明队列，主要为了防止消息接收者先运行此程序，队列还不存在时创建队列
                    channel.QueueDeclare(
                        queue: "hello",
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);

                    //创建事件驱动的消费者类型，尽量不要使用while(ture)循环来获取消息
                    EventingBasicConsumer consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine("我是消费者我接收到消息： {0}", message);
                    };

                    //指定消费队列
                    channel.BasicConsume(queue: "hello",
                        autoAck: false,
                        consumer: consumer);

                    Console.WriteLine("Press [enter] to exit.");
                    Console.ReadLine();
                }
            }
        }
    }
}
