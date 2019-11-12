using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAll
{
    class TestLinq
    {
        public static void Start()
        {
            Test1();
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Test1()
        {
            var data = new List<Student>();
            data.Add(new Student()
            {
                Age = 10,
                Age2 = 11,
            });
            data.Add(new Student()
            {
                Age = 10,
                Age2 = 12,
            });
            data.Add(new Student()
            {
                Age = 11,
                Age2 = 10,
            });
            foreach (var s in data.OrderBy(it => it.Age).ThenBy(it => it.Age2))
            {
                Console.WriteLine($"{s.Age}-{s.Age2}");
            }
        }

        public class Student
        {
            public Int32 Age { get; set; }

            public Int32 Age2 { get; set; }
        }
    }
}
