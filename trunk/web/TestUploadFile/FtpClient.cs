using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace TestUploadFile
{
    public class FtpClient
    {
        public String UserID
        {
            get;
            protected set;
        }

        public String Password
        {
            get;
            protected set;
        }

        public String FtpUrl
        {
            get;
            protected set;
        }

        public FtpClient(IPAddress serverIP, String userID, String password)
        {
            this.UserID = userID;
            this.Password = password;
            this.FtpUrl = String.Format("ftp://{0}/", serverIP.ToString());
        }

        public FtpClient(String ftpUrl, String userID, String password)
        {
            this.UserID = userID;
            this.Password = password;
            this.FtpUrl = ftpUrl.EndsWith("/") ? ftpUrl : ftpUrl + "/";
        }

        /// <summary>
        /// 打开一个上传流
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public virtual Stream OpenWrite(String fileName)
        {
            Uri uri = new Uri(this.FtpUrl + fileName);
            var reqFTP = (FtpWebRequest)FtpWebRequest.Create(uri);
            reqFTP.KeepAlive = false;
            reqFTP.UseBinary = true;
            reqFTP.Credentials = new NetworkCredential(this.UserID, this.Password);//用户，密码
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;//向服务器发出下载请求命令
            //reqFTP.ContentLength = finfo.Length;//为request指定上传文件的大小
            var response = reqFTP.GetResponse() as FtpWebResponse;
            Int32 buffLength = 1024;
            Byte[] buff = new Byte[buffLength];
            return reqFTP.GetRequestStream();
        }
    }
}