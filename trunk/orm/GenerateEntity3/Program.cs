using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerateEntity3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new GenerateEntity3.Entities())
            {
                var file = new GenerateEntity3.UPLOADFILE()
                {
                    CODE = Guid.NewGuid().ToString("N")
                };
                db.UPLOADFILE.Add(file);
                db.SaveChanges();
            }

            Console.WriteLine("done");
            Console.Read();
        }
    }
}
