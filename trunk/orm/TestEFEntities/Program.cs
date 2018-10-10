using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EFEntities;

namespace TestEFEntities
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Test1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().ToString());
            }
            Console.WriteLine("done");
            Console.Read();
        }

        static void Test1()
        {
            TestDB1.Init(new TestDB1_DropCreateDatabaseIfModelChanges());
            //添加数据
            //using (var db = new TestDB1())
            //{
            //    db.Students.Add(new Student()
            //    {
            //        Age = 10,
            //        Name = "lijian",
            //        Courses = new HashSet<Course>
            //        {
            //             new Course
            //             {
            //                 Name = "语文",
            //             }
            //        },
            //        Details = new StudentDetails
            //        {
            //            Address = "XXX"
            //        }
            //    });
            //    db.SaveChanges();
            //}

            //删除数据（测试级联删除）
            //using (var db = new TestDB1())
            //{
            //    var course = new Course() { ID = 1 };
            //    db.Courses.Attach(course);
            //    db.Courses.Remove(course);
            //    Console.WriteLine(db.SaveChanges());
            //}

            //查询数据（测试延迟查询）
            //using (var db = new TestDB1())
            //{
            //    var stu = db.Students.FirstOrDefault();
            //    Console.WriteLine(stu?.Details?.Address);
            //}
        }
    }
}
