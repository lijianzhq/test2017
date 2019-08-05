using System;
using System.Collections.Generic;
using System.Text;

namespace TestRedisQueue.Publisher
{
    /// <summary>
    /// 发布者
    /// </summary>
    class PublishWorker
    {
        public static void Start()
        {
            CSRedis.CSRedisClient csredis = new CSRedis.CSRedisClient("10.16.40.172:6380,prefix=aps2_,password=@midea2018@");
            RedisHelper.Initialization(csredis);

            new PublishWorker().StartWorking();
        }

        public void StartWorking()
        {
            Int32 i = 0;
            while (true)
            {
                RedisHelper.LPush("AFSWeb.MSGCacheLogKey", i++);
                Console.WriteLine($"push:{i}");
                //System.Threading.Thread.Sleep(5000);
                Console.Read();
            }
        }
    }
}
