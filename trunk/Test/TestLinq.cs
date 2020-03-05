using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TestLinq
    {
        public static void Start()
        {
            TestGroupBy();
        }

        public static void Test()
        {
            var keyName = "zhq";
            var keyNameChars = keyName.ToCharArray().Select(it => { Console.WriteLine(it); return it.ToString(); });
            Console.WriteLine("keyNameCharsLength:");
            Console.WriteLine(keyNameChars.Count());
            Console.WriteLine(keyNameChars.Count());
        }

        /// <summary>
        /// 
        /// </summary>
        public static void TestGroupBy()
        {
            var dataList = new List<TestGroupData>() {
                 new TestGroupData(){
                      Birthday = new DateTime(2019,5,1),
                      Name = "lijian",
                 },
                  new TestGroupData(){
                      Birthday = new DateTime(2019,5,1),
                      Name = "lijian2",
                 },
                 new TestGroupData(){
                      Birthday = new DateTime(2019,6,1),
                      Name = "lijian2",
                 },
            };

            var groups = dataList.GroupBy(it => new { birthday = it.Birthday.ToString("yyyy-MM") });
            Console.WriteLine(groups.Count());
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

    }

    public class Student
    {
        public Int32 Age { get; set; }

        public Int32 Age2 { get; set; }
    }

    public class TestGroupData
    {
        public String Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}
