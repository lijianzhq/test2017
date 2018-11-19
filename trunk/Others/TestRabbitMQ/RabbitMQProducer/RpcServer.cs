using System;
using System.Text;
using System.Threading;
using RabbitMQ;
using RabbitMQ.Client;
using RabbitMQ.Client.MessagePatterns;

namespace RabbitMQProducer
{
    internal class RpcServer : SimpleRpcServer
    {
        public static void Start()
        {
            new Thread(new ThreadStart(new Action(() =>
            {
                try
                {
                    var factory = new ConnectionFactory();
                    IConnection connection = null;
                    //方式1：使用AMQP协议URL amqp://username:password@hostname:port/virtual host 可通过http://127.0.0.1:15672/ RabbitMQWeb管理页面查看每个参数的具体内容
                    factory.Uri = new Uri("amqp://guest:guest@127.0.0.1:5672//");
                    connection = factory.CreateConnection();
                    //创建返回一个新的频道
                    using (var channel = connection.CreateModel())
                    {
                        //创建一个rpc queue
                        channel.QueueDeclare("test", true, false, false, null);
                        SimpleRpcServer rpc = new RpcServer(new Subscription(channel, "test2"));
                        Console.WriteLine("服务端启动成功！！");
                        rpc.MainLoop();
                        Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }))).Start();
        }

        public RpcServer(Subscription subscription) : base(subscription)
        {

        }

        private Int32 _msgCount = 0;
        public override byte[] HandleSimpleCall(bool isRedelivered, IBasicProperties requestProperties, byte[] body, out IBasicProperties replyProperties)
        {
            replyProperties = null;
            //return base.HandleSimpleCall(isRedelivered, requestProperties, body, out replyProperties);
            var receiveData = Encoding.UTF8.GetString(body);
            Console.WriteLine($"接收到消息{++_msgCount}：{receiveData}");
            return Encoding.UTF8.GetBytes("接收成功！");
        }

        public override void HandleSimpleCast(bool isRedelivered, IBasicProperties requestProperties, byte[] body)
        {
            base.HandleSimpleCast(isRedelivered, requestProperties, body);
        }

        public override byte[] HandleCall(bool isRedelivered, IBasicProperties requestProperties, byte[] body, out IBasicProperties replyProperties)
        {
            return base.HandleCall(isRedelivered, requestProperties, body, out replyProperties);
        }
    }
}
