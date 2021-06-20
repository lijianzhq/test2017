using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
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
            //DoRequest1();
            DoRequest2();
        }

        private static void DoRequest1()
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

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受  
            //return false;
        }

        private static void DoRequest2()
        {
            var url = "https://localhost:8442";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            if (url.ToLower().Trim().StartsWith("https"))
            {
                request.ProtocolVersion = HttpVersion.Version10;
                //在每个HttpWebRequest实例上设置ServerCertificateValidationCallback属性
                request.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            }

            using (var response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                var result = reader.ReadToEnd();
                Console.WriteLine(result);
            }
        }
    }
}
