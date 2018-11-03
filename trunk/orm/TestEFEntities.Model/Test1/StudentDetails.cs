using System;
using System.ComponentModel.DataAnnotations;

namespace EFEntities
{
    public class StudentDetails
    {
        [Key]
        public Int32 ID { get; set; }

        [StringLength(1000)]
        public String Address { get; set; }
    }
}
