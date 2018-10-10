using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using Mini.Foundation.Json;
//using Mini.Foundation.Json.Newton;

namespace TestJSON
{
    public class Student
    {
        public String Name;
        public String Address;
        //[NullValueProvider]
        public String[] AddressEx;
        public Int32? Age;
        public DateTime? Birthday;
        public Student Classmate;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TestEmptyPropertyValue();
            //TestDataTable();
            TestJSON();
            Console.WriteLine("done");
            Console.Read();
        }



        static void TestJSON()
        {
            var json = "{\"state\":2,\"data\":{\"user\":{\"suc_orders\":[[\"00002040\",\"第三球 1|9.714\",2,17],[\"00002039\",\"第二球 8|9.714\",2,17],[\"00002038\",\"第二球 7|9.714\",2,17],[\"00002037\",\"第二球 6|9.714\",2,17],[\"00002036\",\"第二球 5|9.714\",2,17],[\"00002035\",\"第二球 4|9.714\",2,17],[\"00002034\",\"第二球 3|9.714\",2,17],[\"00002033\",\"第二球 2|9.714\",2,17],[\"00002032\",\"第二球 1|9.714\",2,17],[\"00002031\",\"第一球 8|9.714\",2,17],[\"00002030\",\"第一球 7|9.714\",2,17],[\"00002029\",\"第一球 6|9.714\",2,17],[\"00002028\",\"第一球 5|9.714\",2,17],[\"00002027\",\"第一球 4|9.714\",2,17],[\"00002026\",\"第一球 3|9.714\",2,17],[\"00002024\",\"第一球 2|9.714\",2,17],[\"00002022\",\"第一球 1|9.714\",2,17]],\"suc_t_amount\":34,\"suc_zhus\":17,\"account\":\"klkl1313(C盤)\",\"credit\":\"100\",\"re_credit\":\"66\",\"is_cash\":0,\"total_amount\":\"34\",\"odds_refresh\":10,\"game_limit\":{\"00\":[2,20000],\"01\":[2,50000],\"02\":[2,50000],\"03\":[2,20000],\"04\":[2,2000],\"05\":[2,5000],\"06\":[2,5000],\"07\":[2,5000],\"08\":[2,5000]" +
    "},\"version_number\":\"43\",\"new_orders\":[[\"第三球 1\",9.714,2,\"10:18:36\"],[\"第二球 8\",9.714,2,\"10:18:36\"],[\"第二球 7\",9.714,2,\"10:18:36\"],[\"第二球 6\",9.714,2,\"10:18:36\"],[\"第二球 5\",9.714,2,\"10:18:36\"],[\"第二球 4\",9.714,2,\"10:18:36\"],[\"第二球 3\",9.714,2,\"10:18:36\"],[\"第二球 2\",9.714,2,\"10:18:36\"],[\"第二球 1\",9.714,2,\"10:18:36\"],[\"第一球 8\",9.714,2,\"10:18:35\"]],\"fail_orders\":\"23\",\"orders\":\"\"}},\"errors\":[]}";

            var obj = JObject.Parse(json);
            bool hasErr = ((JObject)obj["data"]).Properties().Any(p => p.Name == "user");//或是这样
            foreach (JProperty p in obj["data"])
            {
                if (p.Name == "user")
                {

                }
            }
            //if (obj["data"].Values().SingleOrDefault(it => it.ToString() == "user") != null)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("true");
            //}
        }

        static void TestDataTable()
        {
            var table = new DataTable();
            table.Columns.Add("列1");
            table.Columns.Add("列2");
            table.Rows.Add("列1值", "列2值");
            //Console.WriteLine(MyJson.Serialize(table));
        }

        /// <summary>
        /// 测试空值序列化的改善，对于null的序列换，全部改成默认的空值，不要序列化成null
        /// </summary>
        static void TestEmptyPropertyValue()
        {
            ParentObj obj = new ChildObj();
            Console.WriteLine(obj.GetName());

            Student stu = new Student()
            {
                Name = "lijian"
            };
            String json = String.Empty;

            json = JsonConvert.SerializeObject(stu);
            Console.WriteLine(json);

            json = JsonConvert.SerializeObject(stu, new JsonSerializerSettings()
            {
                ContractResolver = new MyContractResolver(),
                //Converters = new List<JsonConverter>() {
                //      new StringConverter()
                // }
            });
            Console.WriteLine(json);

            //使用框架里面的封装好的对象
            //Console.WriteLine(MyJson.Serialize(stu, new JsonSerializerSettings()
            //{
            //    ContractResolver = new ExtendContractResolver()
            //}));
        }
    }
}
