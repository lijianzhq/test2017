using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TestForAll
{
    public partial class testPostData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var postData = "";
            using (var reader = new System.IO.StreamReader(Request.InputStream))
            {
                postData = reader.ReadToEnd();
                if (!string.IsNullOrEmpty(postData))
                {
                    var filePath = "post.txt";
                    var fileFullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);
                    using (var fs = File.Create(fileFullPath))
                    {
                        using (var sw = new StreamWriter(fs))
                        {
                            sw.Write(postData);
                        }
                    }
                }
            }
            Response.Write(postData);
            Response.End();
        }
    }
}