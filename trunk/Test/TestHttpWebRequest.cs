using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// 测试发起http请求web
    /// </summary>
    public static class TestHttpWebRequest
    {
        public static void Start()
        {
            DoRequest();
        }

        private static void DoRequest()
        {
            var url = "http://localhost:6201";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            using (var response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                var result = reader.ReadToEnd();
                Console.WriteLine(result);
            }
        }
    }
}
