using System;
using System.Collections.Generic;
using System.Text;

namespace TestRedisQueue.Client
{
    /// <summary>
    /// 发布者
    /// </summary>
    class ConsumeWorker
    {
        public static void Start()
        {
            CSRedis.CSRedisClient csredis = new CSRedis.CSRedisClient("10.16.40.172:6380,prefix=aps2_,password=@midea2018@");
            RedisHelper.Initialization(csredis);

            new ConsumeWorker().StartWorking();
        }

        public void StartWorking()
        {
            while (true)
            {
                Console.WriteLine($"Length:{RedisHelper.LLen("AFSWeb.MSGCacheLogKey")}");
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
}
