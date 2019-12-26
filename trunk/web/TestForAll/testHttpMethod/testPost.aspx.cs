using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestForAll.testHttpMethod
{
    public partial class testPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current != null)
            {
                Stream inputStream = HttpContext.Current.Request.InputStream;
                Byte[] buffer = new Byte[1024];
                Int32 read = 0;
                StringBuilder sb = new StringBuilder();
                do
                {
                    read = inputStream.Read(buffer, 0, buffer.Length);
                    sb.Append(HttpContext.Current.Request.ContentEncoding.GetString(buffer, 0, read));
                } while (read > 0);
                var postStr = HttpUtility.UrlDecode(sb.ToString());
                File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "postStr.txt"), postStr);
            }
        }
    }
}