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
    }

    public class TestGroupData
    {
        public String Name { get; set; }

        public DateTime Birthday { get; set; }
    }
}
