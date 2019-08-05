using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace TestFileIO2
{
    class TestWriteRemoteServer
    {
        public static void Start()
        {
            var localPath = @"Request_Log\20190629\16.00.txt";
            var shareFolder = "\\\\10.16.90.157\\RequestShare9000";
            //var shareFolder = "\\\\10.16.90.157\\RequestShare";
            var shareUser = "Administrator";
            var sharePassword = "QWE@sdzxc";
            var shareFileName = "16.00.txt";

            //连接服务器
            connectState(shareFolder, shareUser, sharePassword);

            CopyToRemoteServer(localPath, shareFolder, shareFileName);
        }

        /// <summary>
        /// 向远程文件夹保存本地内容
        /// </summary>
        /// <param name="localPath">要保存的文件的路径，如果保存文件到共享文件夹，这个路径就是本地文件路径如：@"D:\1.avi"</param>
        /// <param name="shareDir">保存文件的路径，不含名称及扩展名</param>
        /// <param name="shareFileName">保存文件的名称以及扩展名</param>
        private static void CopyToRemoteServer(string localPath, string shareDir, string shareFileName)
        {
            try
            {
                FileStream inFileStream = new FileStream(localPath, FileMode.Open);

                if (!Directory.Exists(shareDir))
                {
                    Directory.CreateDirectory(shareDir);
                }
                shareDir = Path.Combine(shareDir, shareFileName);
                FileStream outFileStream = new FileStream(shareDir, FileMode.Append, FileAccess.Write);

                byte[] buf = new byte[inFileStream.Length];
                int byteCount;
                while ((byteCount = inFileStream.Read(buf, 0, buf.Length)) > 0)
                {
                    outFileStream.Write(buf, 0, byteCount);
                }

                inFileStream.Flush();
                inFileStream.Close();
                outFileStream.Flush();
                outFileStream.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 连接远程共享文件夹
        /// </summary>
        /// <param name="shareFolder">远程共享文件夹的路径</param>
        /// <param name="userName">用户名</param>
        /// <param name="passWord">密码</param>
        /// <returns></returns>
        private static bool connectState(string shareFolder, string userName, string passWord)
        {
            bool Flag = false;
            Process proc = new Process();
            try
            {
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                string dosLine = "net use " + shareFolder + " " + passWord + " /user:" + userName;
                proc.StandardInput.WriteLine(dosLine);
                proc.StandardInput.WriteLine("exit");
                while (!proc.HasExited)
                {
                    proc.WaitForExit(1000);
                }
                string errormsg = proc.StandardError.ReadToEnd();
                proc.StandardError.Close();
                if (string.IsNullOrEmpty(errormsg))
                {
                    Flag = true;
                }
                else
                {
                    throw new Exception(errormsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                proc.Close();
                proc.Dispose();
            }
            return Flag;
        }
    }
}
