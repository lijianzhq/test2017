using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace EntityMovie
{
    public class DB : DbContext
    {
        public DB() : base("EntityMovie")
        { }

        public DbSet<GrabWebsite> Websites
        { get; set; }
    }
}
