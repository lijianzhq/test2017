using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;

namespace TestUploadFile
{
    public partial class PostFileToFTP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 发送文件到ftp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            FTPHelper.FtpServerIP = "127.0.0.1";
            FTPHelper.FtpPassword = "123456";
            FTPHelper.FtpUserID = "ftpuser";
            Response.Write(FTPHelper.FtpUploadFile(txt_FilePath.Text));
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            var file = new FileInfo(txt_FilePath.Text);
            var buffer = new Byte[1024];
            using (var stream = new FtpClient(IPAddress.Parse("127.0.0.1"), "ftpuser", "123456").OpenWrite(file.Name))
            {
                using (var fs = file.OpenRead())
                {
                    Int32 read = fs.Read(buffer, 0, buffer.Length);
                    while(read>0)
                    {
                        stream.Write(buffer, 0, read);
                        read = fs.Read(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}