using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

using Mini.Foundation.LogService;

namespace TestUploadFile
{
    /// <summary>
    /// MergeFiles 的摘要说明
    /// </summary>
    public class MergeFiles : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                string guid = context.Request.Params["guid"];
                string fileExt = context.Request.Params["fileExt"];
                string folder = context.Server.MapPath("~/1/" + context.Request["guid"] + "/");
                var files = Directory.GetFiles(folder);
                var filePath = context.Server.MapPath("~/1/" + context.Request["guid"]) + "." + fileExt;
                using (var file = File.Create(filePath))
                {
                    foreach (String tempFile in files)
                    {
                        var bytes = File.ReadAllBytes(tempFile);
                        file.Write(bytes, 0, bytes.Length);
                    }
                    file.Flush();
                }
            }
            catch (Exception ex)
            {
                Log.Root.LogError("", ex);
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