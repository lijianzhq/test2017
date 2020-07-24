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
            //Test2();
            //Test3();
            Test4();
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

        public static void Test3()
        {
            var date1 = DateTime.Parse("2020-06-09 20:50:01");
            Console.WriteLine(date1.DayOfWeek);
        }

        public static void Test4()
        {
            var date1 = GetWeekFirstDayMon(DateTime.Now);
            Console.WriteLine(date1);
            Console.WriteLine(date1.AddDays(7));
        }

        public static DateTime convertJavaLongtimeToDatetime(long time_JAVA_Long)
        {
            DateTime dt_1970 = new DateTime(1970, 1, 1, 0, 0, 0);        //年月日时分秒
            long tricks_1970 = dt_1970.Ticks;                           //1970年1月1日刻度                         
            long time_tricks = tricks_1970 + time_JAVA_Long * 10000;    //日志日期刻度                         
            DateTime dt = new DateTime(time_tricks).AddHours(8);        //+8小时,转化为DateTime
            return dt;
        }

        /// <summary>
        /// 得到本周第一天(以星期一为第一天)
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime GetWeekFirstDayMon(DateTime datetime)
        {
            //星期一为第一天
            int weeknow = Convert.ToInt32(datetime.DayOfWeek);

            //因为是以星期一为第一天，所以要判断weeknow等于0时，要向前推6天。
            weeknow = (weeknow == 0 ? (7 - 1) : (weeknow - 1));
            int daydiff = (-1) * weeknow;

            //本周第一天
            string FirstDay = datetime.AddDays(daydiff).ToString("yyyy-MM-dd");
            return Convert.ToDateTime(FirstDay);
        }

        /// <summary>
        /// 获取一年中的周
        /// </summary>
        /// <param name="dt">日期</param>
        /// <returns></returns>
        public static int GetWeekOfYear(DateTime dt)
        {
            System.Globalization.GregorianCalendar gc = new System.Globalization.GregorianCalendar();
            int weekOfYear = gc.GetWeekOfYear(dt, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            return weekOfYear;
        }

        /// <summary>
        /// 根据一年中的第几周获取该周的开始日期与结束日期
        /// </summary>
        /// <param name="year"></param>
        /// <param name="weekNumber"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public static Tuple<DateTime, DateTime> GetFirstEndDayOfWeek(int year, int weekNumber, System.Globalization.CultureInfo culture)
        {
            System.Globalization.Calendar calendar = culture.Calendar;
            DateTime firstOfYear = new DateTime(year, 1, 1, calendar);
            DateTime targetDay = calendar.AddWeeks(firstOfYear, weekNumber - 1);
            DayOfWeek firstDayOfWeek = culture.DateTimeFormat.FirstDayOfWeek;

            while (targetDay.DayOfWeek != firstDayOfWeek)
            {
                targetDay = targetDay.AddDays(-1);
            }

            return Tuple.Create<DateTime, DateTime>(targetDay, targetDay.AddDays(6));
        }
    }
}
