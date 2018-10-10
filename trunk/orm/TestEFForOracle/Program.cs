using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFForOracle
{
    class Program
    {
        static void Main(string[] args)
        {
            DB.SaveUploadFileRecord(new UploadFile()
            {
                SavePath = "xxxx",
                CODE = DB.GetGuid(),
                FileName = "aaaaaa",
                CreateBy = "1",
                LastUpdateBy = "1"
            });
            using (var db = new DB())
            {
                Console.WriteLine(db.UploadFiles.Count());
            }
            Console.WriteLine("done");
            Console.Read();
        }
    }
}
