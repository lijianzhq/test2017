using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace TestThread
{
    class TestConcurrentDictionary
    {
        public static void Start()
        {
            TestForeach();
        }

        private static ConcurrentDictionary<String, Object> testCache = new ConcurrentDictionary<string, object>();
        private static ConcurrentBag<String> keyCache = new ConcurrentBag<String>();
        private static void TestForeach()
        {
            Task.Factory.StartNew(() =>
            {
                Int32 i = 0;
                while (true)
                {
                    String key = i++.ToString();
                    if (testCache.TryAdd(key, null))
                        keyCache.Add(key);
                    Thread.Sleep(500);
                }
            });
            Task.Factory.StartNew(() =>
            {
                Object val = null;
                String key = String.Empty;
                while (true)
                {
                    if (keyCache.TryTake(out key))
                        testCache.TryRemove(key, out val);
                    Thread.Sleep(600);
                }
            });
            Task.Factory.StartNew(()=> {
                while (true)
                {
                    foreach (var item in testCache)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("-------------------------------");
                    Thread.Sleep(1000);
                }
            });
        }

        private static void TestMutilThread()
        {
            TestConcurrentDictionary testDic = new TestConcurrentDictionary();
            for (var i = 0; i < 50; i++)
            {
                new Thread(new ThreadStart(() =>
                {
                    testDic.ThreadIn();
                })).Start();
            }
        }

        private ConcurrentDictionary<String, Int32> _dic = new ConcurrentDictionary<string, int>();
        //private Dictionary<String, Int32> _dic = new Dictionary<string, int>();
        private Int32 identity = 0;
        public void ThreadIn()
        {
            while (true)
            {
                Int32 tempVal = 0;
                SpinWait.SpinUntil(() => _dic.TryAdd("lijian", 1));
                Interlocked.Increment(ref identity);
                if (identity > 1)
                    Console.WriteLine("error!");
                //Console.WriteLine("enter!");
                //Console.WriteLine("exists!");
                identity = 0;
                _dic.TryRemove("lijian", out tempVal);
            }
        }
    }

    public static class DicExtension
    {
        public static Boolean TryAdd<TKey, TValue>(this Dictionary<TKey, TValue> target, TKey key, TValue value)
        {
            if (!target.ContainsKey(key))
            {
                target.Add(key, value);
                return true;
            }
            return false;
        }

        public static Boolean TryRemove<Tkey, TValue>(this Dictionary<Tkey, TValue> target, Tkey key, out TValue value)
        {
            value = default(TValue);
            if (target.ContainsKey(key))
            {
                value = target[key];
                target.Remove(key);
                return true;
            }
            return false;
        }

    }
}
