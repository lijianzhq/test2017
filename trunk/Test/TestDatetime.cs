using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TestAll
{
    class TestDatetime
    {
        public static void Start()
        {
        }

        /// <summary>
        /// 测试两个日期相差的周数
        /// </summary>
        public static void TestWeek()
        {
            var day1 = DateTime.Now;
            var day2 = DateTime.Now.AddDays(-1);
        }
    }
}
