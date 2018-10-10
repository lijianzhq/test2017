using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Entities())
            {
                db.UPLOADFILE.Add(new UPLOADFILE()
                {
                    CODE = Guid.NewGuid().ToString("N")
                });
                db.SaveChanges();
            }
            Console.WriteLine("line");
            Console.Read();
        }
    }
}
