using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TestPLZH
    {
        public static void Test()
        {
            //总密码数
            //小写字母26+10数字，密码长度6位+5特殊字符
            Console.WriteLine(CountTotalRecordCount(60, 8));
            //Console.WriteLine(CountRecordCount(3, 3));
            //Console.WriteLine(CountTotalRecordCount(2));
            //Console.WriteLine(CountRecordCount(6, 6));
            //Console.WriteLine(CountRecordCount(6, 4));
        }

        /// <summary>
        /// 根据字符长度，计算出所有的[1-maxGetLength]之间所有的取值长度的排列个数总和
        /// </summary>
        /// <param name="wordLength"></param>
        /// <param name="maxGetLength"></param>
        /// <returns></returns>
        static Double CountTotalRecordCount(UInt64 wordLength, UInt64 maxGetLength)
        {
            checked
            {
                Double sum = 0;
                for (var i = 1ul; i <= maxGetLength; i++)
                    sum += CountRecordCount(wordLength, i);
                return sum;
            }
        }

        /// <summary>
        /// 根据字符长度以及取值长度，计算出所有的排列个数
        /// </summary>
        /// <param name="wordLength">字符长度</param>
        /// <param name="getLength">取值长度</param>
        /// <returns></returns>
        static UInt64 CountRecordCount(UInt64 wordLength, UInt64 getLength)
        {
            checked
            {
                if (wordLength == getLength)
                    return (UInt64)JC(wordLength);
                return (UInt64)(JC(wordLength) / JC(wordLength - getLength));
            }
        }

        static Double JC(UInt64 n)
        {
            checked
            {
                Double jc1 = 1;
                for (Double i = 1; i <= n; i++)
                    jc1 = jc1 * i;
                return jc1;
            }
        }
    }
}
