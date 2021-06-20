using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TestYield
    {
        public static void Start()
        {
            foreach (int i in Power(2, 8, ""))
            {
                Console.Write("{0} ", i);
            }
        }

        public static IEnumerable<int> Power(int number, int exponent, string s)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
            yield return 3;
            yield return 4;
            yield return 5;
        }
    }
}
