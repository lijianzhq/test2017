using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.Entity.Design;
using System.Data.Metadata.Edm;
using System.Collections;

//using EntityToSql;

namespace TestEF
{
    public class User
    {
        public String Name;
        public String Password;
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestRead();
            Console.Read();
        }

        static void TestGetSQL()
        {
            User s = new User();
            //SqlBuilder sqlBuilder = new SqlBuilder();
            //ISql<User> userQ = sqlBuilder.Select<User>()
            //ISelectSql<User> userList = 
            //var q1 = userList.Select(u => new { u.Name }).Where(u => u.Name == "");
            //Console.WriteLine(q1.ToString());

            //SqlProvider provider = new SqlProvider();
            //ISelectSql<User> q1 = provider.CreateSelectSql<User>().Select(u => u);
            //Console.WriteLine(q1.ToString());
        }

        static void LoadEDMFile()
        {
            //Environment.NewLine;
            String test = @"/// <summary>
                            /// {0}
                            /// </summary>";
            //var itemCollection = new EdmMetadataLoader(new DynamicHost() , textTransform.Errors).CreateEdmItemCollection(inputFile);
            var sourcePath = @"D:\01.Work\Test\Test2017\trunk\TestEF\Model1.edmx";
            var root = XElement.Load(sourcePath, LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
            XElement element = root.Elements()
                  .Where(e => e.Name.LocalName == "Runtime")
                  .Elements()
                  .Where(e => e.Name.LocalName == "ConceptualModels")
                  .Elements()
                  .Where(e => e.Name.LocalName == "Schema")
                  .FirstOrDefault()
                      ?? root;
        }

        static void TestRead()
        {
            //using (TestEntities db = new TestEntities())
            //{
            //    IQueryable<t_student> q = from s in db.t_student
            //                              select s;
            //    foreach (t_student s in q)
            //    {
            //        Console.WriteLine("loginname:{0},username:{1}", s.loginname, s.username);
            //    }
            //}
            using (TestEntities db = new TestEntities())
            {
                //DateTime date = DateTime.Parse("2017-10-10");
                ////var q = db.t_student.Select(s => s).Where(s => s.loginname == "||(select count(*) from T_PQ_BU_DEFECT_QUES)||" && s.birthday == date);
                //var q = db.t_student.Select(s => s).Where(s => true);
                //var q2 = db.t_student.Where(s => true);
                //var q3 = db.t_student.OrderBy(s => s.Id);
                //var q4 = db.t_student.Where(s => s.birthday == date).OrderBy(s => s.Id);
                ////var q4 = db.t_student.OrderBy(s => s.Id).Where(s => s.birthday == date);
                ////var q5 = db.t_student.Where(s => s.birthday == date).OrderBy(s => s.Id).Select(s => new { s.Id });
                //IQueryable<dynamic> q5 = db.t_student.Where(s => s.birthday == date).OrderBy(s => s.Id).Select(s => new { s.birthday });
                //var q6 = db.t_student
                //    .Where(s => s.birthday == date)
                //    .OrderBy(s => s.Id)
                //    .Select(s => new { s.birthday })
                //    .GroupBy(s => s.birthday)
                //    .Select(e => new { });
                var q7 = db.t_student
                    .GroupBy(s => s.sex);
                var q8 = db.t_student
                           .OrderBy(it => new { it.birthday });
                var q9 = db.t_student.Join(db.t_student, outer => outer.Id, inner => inner.Id, (outer, inner) => new { sex1 = outer.sex, sex2 = inner.sex });
                //Console.WriteLine(q.ToString());
                //Console.WriteLine(q2.ToString());
                //Console.WriteLine(q3.ToString());
                //Console.WriteLine(q4.ToString());
                //Console.WriteLine(q5.ToString());
                //Console.WriteLine(q6.ToString());
                //Console.WriteLine(q7.ToString());
                Console.WriteLine(q9.ToString());
                //foreach (t_student s in q)
                //{
                //    Console.WriteLine("loginname:{0},username:{1}", s.loginname, s.username);
                //}
            }
        }

        static void TestAdd()
        {
            for (var i = 0; i < 100; i++)
            {
                t_student stu = new t_student()
                {
                    loginname = "test_" + i,
                    username = "测试_" + i
                };
                Add(stu);
            }
        }

        static void Add(t_student s)
        {
            using (TestEntities db = new TestEntities())
            {
                db.t_student.Add(s);
                db.SaveChanges();
            }
        }
    }
}

