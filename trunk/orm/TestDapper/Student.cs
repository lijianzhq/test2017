using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDapper
{
    public class Student
    {
        public int Id { get; set; }
        public int? SchoolId { get; set; }
        public string Name { get; set; }
        public DateTime? CreateTime { get; set; }
        public int TestId { get; set; }
        public decimal? TestCount { get; set; }
    }
}
