using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAll
{
    public static class TestAction
    {
        public static void Start()
        {
            var i = 0;
            DoAction(new Action(() =>
           {
               i++;
               i++;
               i++;
           }));
            Console.WriteLine(i);
        }

        public static void DoAction(Action a)
        {
            a.Invoke();
        }
    }
}
