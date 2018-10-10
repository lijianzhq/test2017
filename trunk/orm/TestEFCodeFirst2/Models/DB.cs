using System;
using System.Data.Entity;

namespace TestEFCodeFirst2.Models
{
    public class DB : DbContext
    {
        public DB() : base("TestDB")
        { }

        public DbSet<Donator> Donators
        { get; set; }

        public DbSet<PayWay> PayWays
        { get; set; }
    }
}