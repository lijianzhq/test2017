using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;

using Mini.Foundation.LogService;

namespace TestUploadFile
{
    public partial class FileSave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //客户端上传的文件   
                System.Web.HttpFileCollection postFiles = System.Web.HttpContext.Current.Request.Files;
                Log.Root.LogDebug("count:" + Request.Files.Count);
                if (postFiles.Count > 0)
                {
                    for (var i = 0; i < postFiles.Count; i++)
                    {
                        SaveFile(postFiles[i]);
                    }
                }
                //SaveFile2();
            }
            catch (Exception ex)
            {
                Log.Root.LogDebug("", ex);
            }
            //Response.Write("{'result':'success'}");
            //Response.End();
        }

        protected void SaveFile2()
        {
            string basePath = "./NewFolder1/";
            string name;
            basePath = System.Web.HttpContext.Current.Server.MapPath(basePath);
            HttpFileCollection files = System.Web.HttpContext.Current.Request.Files;
            if (!System.IO.Directory.Exists(basePath))
            {
                System.IO.Directory.CreateDirectory(basePath);
            }
            var suffix = files[0].ContentType.Split('/');
            //获取文件格式  
            //var _suffix = suffix[1].Equals("jpeg", StringComparison.CurrentCultureIgnoreCase) ? "" : suffix[1];  
            var _suffix = suffix[1];
            var _temp = System.Web.HttpContext.Current.Request["name"];
            //如果不修改文件名，则创建随机文件名  
            if (!string.IsNullOrEmpty(_temp))
            {
                name = _temp;
            }
            else
            {
                Random rand = new Random(24 * (int)DateTime.Now.Ticks);
                name = rand.Next() + "." + _suffix;
            }
            //文件保存  
            var full = basePath + name;
            files[0].SaveAs(full);
            var _result = "{\"jsonrpc\" : \"2.0\", \"result\" : null, \"id\" : \"" + name + "\"}";
            System.Web.HttpContext.Current.Response.Write(_result);
        }

        protected void SaveFile(HttpPostedFile file)
        {
            //文件大小   
            long size = file.ContentLength;
            ////文件类型   
            string type = file.ContentType;
            ////文件名   
            string name = file.FileName;
            ////文件格式   
            string fileExtension = System.IO.Path.GetExtension(name);

            //if (_tp.ToLower() == ".jpg" || _tp.ToLower() == ".jpeg" || _tp.ToLower() == ".gif" || _tp.ToLower() == ".png" || _tp.ToLower() == ".swf")
            //{
            //    //获取文件流   
            //    System.IO.Stream stream = _file[0].InputStream;
            //    //保存文件   
            //    string saveName = DateTime.Now.ToString("yyyyMMddHHmmss") + _tp;
            //    string path = Path.Combine(Server.MapPath("~") + "upload/") + saveName;
            //    _file[0].SaveAs(path);
            //}
            var ms = new MemoryStream();
            using (var fs = file.InputStream)
            {
                var buffer = new Byte[1024];
                Int32 read = fs.Read(buffer, 0, buffer.Length);
                while (read > 0)
                {
                    ms.Write(buffer, 0, read);
                    read = fs.Read(buffer, 0, buffer.Length);
                }
            }
            ms.Seek(0, SeekOrigin.Begin);

            String fileName = String.Format("{0}{1}", Guid.NewGuid().ToString("N"), fileExtension);
            var path = Path.Combine(Server.MapPath("~"), "upload");
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            using (var fs = File.Create(Path.Combine(path, fileName)))
            {
                var buffer = new Byte[1024];
                Int32 read = ms.Read(buffer, 0, buffer.Length);
                while (read > 0)
                {
                    fs.Write(buffer, 0, read);
                    read = ms.Read(buffer, 0, buffer.Length);
                }
                fs.Close();
            }
            ms.Seek(0, SeekOrigin.Begin);

            //using (var stream = new FtpClient(IPAddress.Parse("127.0.0.1"), "ftpuser", "123456").OpenWrite(fileName))
            //{
            //    var buffer = new Byte[1024];

            //    Int32 read = ms.Read(buffer, 0, buffer.Length);
            //    while (read > 0)
            //    {
            //        stream.Write(buffer, 0, read);
            //        read = ms.Read(buffer, 0, buffer.Length);
            //    }
            //    stream.Close();
            //}
        }
    }
}