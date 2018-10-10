using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Test
{
    class TestExceptionPerformance
    {
        public static void Start()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Int32 count = 1000;
            for (var i = 0; i < count; i++)
            {
                try
                {
                    ExceptionStyle("");
                }
                catch (Exception)
                {
                }
            }
            watch.Stop();
            Console.WriteLine("take times:{0}", watch.ElapsedMilliseconds);
            watch.Reset();
            watch.Restart();
            for (var i = 0; i < count; i++)
            {
                try
                {
                    var result = ReturnResultType("");
                }
                catch (Exception)
                {
                }
            }
            watch.Stop();
            Console.WriteLine("take times:{0}", watch.ElapsedMilliseconds);
        }

        public static Boolean ExceptionStyle(String userName)
        {
            if (String.IsNullOrEmpty(userName))
            {
                //throw new Exception("xx不能为空！");
                throw new ArgumentException("xx不能为空！");
            }
            return true;
        }

        public static ExcuteResult<Boolean> ReturnResultType(String userName)
        {
            var result = new ExcuteResult<Boolean>()
            {
                Result = true,
            };
            if (String.IsNullOrEmpty(userName))
            {
                result.ShowMsg = "xx不能为空！";
                result.Result = true;
            }
            return result;
        }
    }

    class ExcuteResult<T>
    {
        public Boolean Result;
        public String ShowMsg;
        public String ErrorMsg;
        public T Value;
    }
}
