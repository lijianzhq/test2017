using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using FluentFTP;

namespace TestFTP
{
    class Program
    {
        static void Main(string[] args)
        {
            FtpClient client22 = new FtpClient();
            using (FtpClient conn = new FtpClient())
            {
                conn.Host = "127.0.0.1";
                conn.Credentials = new NetworkCredential("ftpuser", "123456");
                using (Stream ostream = conn.OpenWrite("/1/aaa"))
                {
                    try
                    {
                        // istream.Position is incremented accordingly to the writes you perform
                        var writer =new BinaryWriter(ostream);
                        writer.Write("xx");
                    }
                    finally
                    {
                        ostream.Close();
                    }
                }
                conn.CreateDirectory("/2/3/4");
            }
            // create an FTP client
            using (FtpClient client = new FtpClient("127.0.0.1"))
            {
                // if you don't specify login credentials, we use the "anonymous" user account
                client.Credentials = new NetworkCredential("ftpuser", "123456");

                // begin connecting to the server
                client.Connect();

                // get a list of files and directories in the "/htdocs" folder
                foreach (FtpListItem item in client.GetListing("/htdocs"))
                {

                    // if this is a file
                    if (item.Type == FtpFileSystemObjectType.File)
                    {

                        // get the file size
                        long size = client.GetFileSize(item.FullName);

                    }

                    // get modified date/time of the file or folder
                    DateTime time = client.GetModifiedTime(item.FullName);

                    // calculate a hash for the file on the server side (default algorithm)
                    FtpHash hash = client.GetHash(item.FullName);
                }
                // upload a file
                
            }

            Console.WriteLine("done");
            Console.Read();
        }
    }
}
