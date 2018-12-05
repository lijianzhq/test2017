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
            conn.CallbackException += Conn_CallbackException;
            conn.ConnectionRecoveryError += Conn_ConnectionRecoveryError;
            Console.WriteLine(conn.IsOpen);
            using (var chanel = conn.CreateModel())
            {
                chanel.ModelShutdown += Chanel_ModelShutdown;
                var msgCount = 0;
                var address = new PublicationAddress(exchangeType: ExchangeType.Direct, exchangeName: string.Empty, routingKey: "test2");
                var client = new RpcClient(chanel, address);
                client.TimedOut += Client_TimedOut;
                client.Disconnected += Client_Disconnected;
                client.TimeoutMilliseconds = 5000;
                while (true)
                {
                    Console.WriteLine(conn.IsOpen);
                    Console.WriteLine($"请输入要发送的消息：");
                    var inputStr = Console.ReadLine();
                    var rsp = client.Call(Encoding.UTF8.GetBytes(inputStr));
                    Console.WriteLine($"返回消息{++msgCount}：{Encoding.UTF8.GetString(rsp)}");
                }
            }
        }

        private static void Client_Disconnected(object sender, EventArgs e)
        {
            Console.WriteLine("Client_Disconnected");
        }

        private static void Client_TimedOut(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void Chanel_ModelShutdown(object sender, ShutdownEventArgs e)
        {
            Console.WriteLine(e.ReplyText);
        }

        private static void Conn_ConnectionRecoveryError(object sender, RabbitMQ.Client.Events.ConnectionRecoveryErrorEventArgs e)
        {
            Console.WriteLine(e.Exception.Message);
        }

        private static void Conn_CallbackException(object sender, RabbitMQ.Client.Events.CallbackExceptionEventArgs e)
        {
            Console.WriteLine(e.Exception.Message);
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
