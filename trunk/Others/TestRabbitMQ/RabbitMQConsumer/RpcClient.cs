using System;
using System.Text;
using System.Threading;

using RabbitMQ;
using RabbitMQ.Client;
using RabbitMQ.Client.MessagePatterns;

namespace RabbitMQConsumer
{
    internal class RpcClient : SimpleRpcClient
    {
        public static void Start()
        {
            var factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://guest:guest@127.0.0.1:5672//");
            var conn = factory.CreateConnection();
            using (var chanel = conn.CreateModel())
            {
                var msgCount = 0;
                var address = new PublicationAddress(exchangeType: ExchangeType.Direct, exchangeName: string.Empty, routingKey: "test2");
                var client = new RpcClient(chanel, address);
                while (true)
                {
                    Console.WriteLine($"请输入要发送的消息：");
                    var inputStr = Console.ReadLine();
                    var rsp = client.Call(Encoding.UTF8.GetBytes(inputStr));
                    Console.WriteLine($"返回消息{++msgCount}：{Encoding.UTF8.GetString(rsp)}");
                }
            }
        }

        /// <summary>
        /// 多线程去调用
        /// </summary>
        public static void Start_MutiThread()
        {
            var factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://guest:guest@127.0.0.1:5672//");
            var conn = factory.CreateConnection();
            //using (var chanel = conn.CreateModel())
            var chanel = conn.CreateModel();
            {
                var address = new PublicationAddress(exchangeType: ExchangeType.Direct, exchangeName: string.Empty, routingKey: "test2");
                for (var i = 1; i <= 4; i++)
                {
                    new Thread(new ThreadStart(() =>
                    {
                        //经过测试，client必须是单线程调用，不支持多线程调用
                        var client = new RpcClient(chanel, address);
                        while (true)
                        {
                            //发送消息
                            var msg = $"[{Thread.CurrentThread.Name}]发送的消息！";
                            var rsp = client.Call(Encoding.UTF8.GetBytes(msg));
                            Thread.Sleep(1000 * i);
                        }
                    }))
                    { Name = $"线程{i}" }
                    .Start();
                }

            }
        }

        public RpcClient(IModel model, PublicationAddress address) : base(model, address)
        { }
    }
}
