using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace RabbitMQProducer
{
    public class Producer
    {
        public static void Send()
        {
            //创建连接连接到RabbitMQ服务器，就是一个位于客户端和Broker之间的TCP连接，建议共用此TCP连接，每次使用时创建一个新的channel即可，
            var factory = new ConnectionFactory();
            IConnection connection = null;
            //方式1：使用AMQP协议URL amqp://username:password@hostname:port/virtual host 可通过http://127.0.0.1:15672/ RabbitMQWeb管理页面查看每个参数的具体内容
            factory.Uri = new Uri("amqp://guest:guest@127.0.0.1:5672//");
            connection = factory.CreateConnection();

            ////方式2：使用ConnectionFactory属性赋值
            //factory.UserName = ConnectionFactory.DefaultUser;
            //factory.Password = ConnectionFactory.DefaultPass;
            //factory.VirtualHost = ConnectionFactory.DefaultVHost;
            //factory.HostName = "127.0.0.1"; //设置RabbitMQ服务器所在的IP或主机名
            //factory.Port = AmqpTcpEndpoint.UseDefaultPort;
            //connection = factory.CreateConnection();

            ////方式3：使用CreateConnection方法创建连接，默认使用第一个地址连接服务端，如果第一个不可用会依次使用后面的连接
            //List<AmqpTcpEndpoint> endpoints = new List<AmqpTcpEndpoint>() {
            // new AmqpTcpEndpoint() { HostName="localhost1",Port=5672},
            // new AmqpTcpEndpoint() { HostName="localhost2",Port=5672},
            // new AmqpTcpEndpoint() { HostName="localhost3",Port=5672},
            // new AmqpTcpEndpoint() { HostName="localhost4",Port=5672}
            //};
            //connection = factory.CreateConnection(endpoints);

            using (connection)
            {
                //创建一个消息通道，在客户端的每个连接里，可建立多个channel，每个channel代表一个会话任务。类似与Hibernate中的Session
                //AMQP协议规定只有通过channel才能指定AMQP命令，所以仅仅在创建了connection后客户端还是不能发送消息的,必须要创建一个channel才行
                //RabbitMQ建议客户端线程之间不要共用Channel,至少要保证共用Channel的线程发送消息必须是串行的，但是建议尽量共用Connection
                using (IModel channel = connection.CreateModel())
                {
                    //创建一个queue（消息队列）
                    channel.QueueDeclare(
                        queue: "hello",
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);

                    string message = "你好消费者，我是生产者发送的消息";

                    //往队列中发出一条消息 使用了默认交换机并且绑定路由键（route key）与队列名称相同
                    channel.BasicPublish(
                        exchange: "",
                        routingKey: "hello",
                        basicProperties: null,
                        body: Encoding.UTF8.GetBytes(message));

                    Console.WriteLine($"我是生产者，我发送了一条消息{message}");
                    Console.WriteLine(" Press [enter] to exit.");
                    Console.ReadLine();
                }
            }
        }
    }
}
