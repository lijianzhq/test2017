using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFEntities
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            //        HasMany(d => d.PayWays)
            //.WithRequired()
            //.HasForeignKey(p => p.DonatorId);  //将Name设置为必须的
            HasMany(p => p.Courses)
                .WithMany()
                .Map(a => {
                    a.MapLeftKey("StudentID");
                    a.MapRightKey("CourseID");
                    a.ToTable("StudentCourse");
                });
        }
    }

    public class Student
    {
        public Int32 ID { get; set; }

        /// <summary>
        /// 学生名称
        /// </summary>
        [StringLength(100)]
        public String Name { get; set; } = "";

        public Int32 Age { get; set; } = -1;

        public Int32 DetailsID { get; set; }

        [ForeignKey("DetailsID")]
        public virtual StudentDetails Details { get; set; }

        public virtual HashSet<Course> Courses { get; set; }
    }
}
