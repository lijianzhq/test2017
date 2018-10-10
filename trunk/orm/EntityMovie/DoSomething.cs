using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityMovie
{
    public class DoSomething
    {
        public static void Do()
        {
            using (var db = new EntityMovie.DB())
            {
                db.Websites.Add(new EntityMovie.GrabWebsite()
                {
                    Url = "xxx"
                });
                db.SaveChanges();
            }
        }
    }
}
