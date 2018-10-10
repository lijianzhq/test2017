using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

using Mini.Foundation.LogService;

namespace SWFUploadDemo
{
    public partial class fileSave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Root.LogInfo("123");
                // Get the data
                HttpPostedFile fileData = Request.Files["Filedata"];
                SaveFile(fileData);
                Response.StatusCode = 200;
                Response.Write("true");
            }
            catch (Exception ex)
            {
                Log.Root.LogError("", ex);
                // If any kind of error occurs return a 500 Internal Server error
                Response.StatusCode = 501;
                Response.Write("An error occured");
                Response.End();
            }
            finally
            {
                Response.End();
            }
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
            using (var ms = new MemoryStream())
            {
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
}