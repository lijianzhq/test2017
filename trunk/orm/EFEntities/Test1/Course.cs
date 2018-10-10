using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFEntities
{
    public class Course
    {
        public Int32 ID { get; set; }

        /// <summary>
        /// 课程名称
        /// </summary>
        [StringLength(100)]
        public String Name { get; set; }

        public virtual HashSet<Student> Students { get; set; }
    }
}
