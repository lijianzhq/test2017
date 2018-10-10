using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

using Mini.Foundation.LogService;

namespace TestUploadFile
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //如果进行了分片
            if (context.Request.Form.AllKeys.Any(m => m == "chunk"))
            {
                //取得chunk和chunks
                int chunk = Convert.ToInt32(context.Request.Form["chunk"]);//当前分片在上传分片中的顺序（从0开始）
                int chunks = Convert.ToInt32(context.Request.Form["chunks"]);//总分片数
                Log.Root.LogDebug($"chunks:{chunks}");
                //根据GUID创建用该GUID命名的临时文件夹
                string folder = context.Server.MapPath("~/1/" + context.Request["guid"] + "/");
                string path = folder + chunk;

                //建立临时传输文件夹
                if (!Directory.Exists(Path.GetDirectoryName(folder)))
                    Directory.CreateDirectory(folder);

                FileStream addFile = new FileStream(path, FileMode.Append, FileAccess.Write);
                BinaryWriter AddWriter = new BinaryWriter(addFile);
                //获得上传的分片数据流
                HttpPostedFile file = context.Request.Files[0];
                Stream stream = file.InputStream;

                BinaryReader TempReader = new BinaryReader(stream);
                //将上传的分片追加到临时文件末尾
                AddWriter.Write(TempReader.ReadBytes((int)stream.Length));
                //关闭BinaryReader文件阅读器
                TempReader.Close();
                stream.Close();
                AddWriter.Close();
                addFile.Close();

                TempReader.Dispose();
                stream.Dispose();
                AddWriter.Dispose();
                addFile.Dispose();

                context.Response.Write("{\"chunked\" : true, \"hasError\" : true, \"f_ext\" : \"" + Path.GetExtension(file.FileName) + "\"}");
            }
            else//没有分片直接保存
            {
                context.Request.Files[0].SaveAs(context.Server.MapPath("~/1/" + DateTime.Now.ToFileTime() + Path.GetExtension(context.Request.Files[0].FileName)));
                context.Response.Write("{\"chunked\" : false, \"hasError\" : false}");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}