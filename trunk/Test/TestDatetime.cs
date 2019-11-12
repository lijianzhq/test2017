using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TestDatetime
    {
        public static void Start()
        {
            //DateTime now = DateTime.Now;
            //(now - now.AddYears(1)).TotalMilliseconds 
            //Test1();
            Test2();
        }

        public static void Test1()
        {
            //var date = new DateTime(1564939477162);
            Console.WriteLine(convertJavaLongtimeToDatetime(1565072746074));
        }

        public static void Test2()
        {
            var date1 = DateTime.Parse("2019-09-16 20:50:01");
            var date2 = DateTime.Parse("2019-09-17 00:50:01");
            Console.WriteLine((date2 - date1).TotalDays);
            Console.WriteLine((date2 - date1).Days);
        }
        public static DateTime convertJavaLongtimeToDatetime(long time_JAVA_Long)
        {
            DateTime dt_1970 = new DateTime(1970, 1, 1, 0, 0, 0);        //年月日时分秒
            long tricks_1970 = dt_1970.Ticks;                           //1970年1月1日刻度                         
            long time_tricks = tricks_1970 + time_JAVA_Long * 10000;    //日志日期刻度                         
            DateTime dt = new DateTime(time_tricks).AddHours(8);        //+8小时,转化为DateTime
            return dt;
        }
    }
}
