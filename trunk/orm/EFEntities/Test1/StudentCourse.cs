using System;
using System.Collections.Generic;

namespace EFEntities
{
    /// <summary>
    /// 学生选修课映射表
    /// </summary>
    public class StudentCourse
    {
        public Int32 ID { get; set; }

        public Int32 CourseID { get; set; }

        public Int32 StudentID { get; set; }

        public virtual HashSet<Student> Students { get; set; }

        public virtual HashSet<Course> Courses { get; set; }
    }
}
