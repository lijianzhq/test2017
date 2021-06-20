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
            //测试get方式
            //DoRequestGetHttp();
            //DoRequestGetHttps();

            //测试post方式
            //DoRequestPostHttp1();
            //DoRequestPostHttp2();

            //测试post方式
            DoRequestPostHttps1();
        }

        private static void DoRequestPostHttps1()
        {
            var url = "https://localhost:8443/testHttps/testHttps1.aspx";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded"; //这个是必须设置的

            var postString = @"params=lijianxxx";

            //测试发现，如果证书是合法机构颁发的，那这段代码是不需要都行的，这里的逻辑就是为了处理自己的证书
            //if (url.ToLower().Trim().StartsWith("https"))
            //{
            //    request.ProtocolVersion = HttpVersion.Version10;
            //    //在每个HttpWebRequest实例上设置ServerCertificateValidationCallback属性
            //    request.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            //}

            var data = Encoding.UTF8.GetBytes(postString);
            request.ContentLength = data.Length;
            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }

            using (var response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                var result = reader.ReadToEnd();
                Console.WriteLine(result);
            }
        }

        private static void DoRequestPostHttp1()
        {
            var url = "http://localhost:6201/testHttps/testHttps1.aspx";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded"; //这个是必须设置的

            var postString = @"params=lijianxxx";

            var data = Encoding.UTF8.GetBytes(postString);
            request.ContentLength = data.Length;
            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }

            using (var response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                var result = reader.ReadToEnd();
                Console.WriteLine(result);
            }
        }

        private static void DoRequestPostHttp2()
        {
            var url = "http://localhost:6201/testHttps/testHttps1.aspx";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "multipart/form-data; boundary=--------------------------349149509135196915352229"; //这个是必须设置的，并且boundary分界符必须正确

            var postString = @"----------------------------349149509135196915352229
Content-Disposition: form-data; name=""params""

lijian
----------------------------349149509135196915352229--
";

            var data = Encoding.UTF8.GetBytes(postString);
            request.ContentLength = data.Length;
            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }

            using (var response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                var result = reader.ReadToEnd();
                Console.WriteLine(result);
            }
        }

        private static void DoRequestGetHttp()
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

        private static void DoRequestGetHttps()
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
