using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SqlSugar;
using TestSqlSugar.Models;

namespace TestSqlSugar
{
    class Test_Query
    {
        public static void Start()
        {
            //Test01();
            //Test02();
            Test03();
        }

        /// <summary>
        /// 基本的查询
        /// </summary>
        public static void Test01()
        {
            /*查询*/
            //var list1 = _db.Queryable<StudentModel>().ToList();//查询所有
            //Console.WriteLine(list1.Count());
            //var getById = _db.Queryable<StudentModel>().InSingle(10000);//根据主键查询
            //Console.WriteLine(getById == null);

            //var getByWhere = _db.Queryable<StudentModel>().Where(it => it.Id == 1).ToList();//根据条件查询
            //Console.WriteLine(getByWhere.Count);

            var total = 0;
            var getPage = DBContext2.Db.Queryable<StudentModel>().Where(it => it.Id == 95010).ToPageList(1, 2, ref total);//根据分页查询
            Console.WriteLine(getPage.Count);
            Console.WriteLine(total);
        }

        public class School
        {
            [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
            public int? Id { get; set; }
            //public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Student
        {
            //指定主键和自增列，当然数据库中也要设置主键和自增列才会有效
            //[SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
            public int Id { get; set; }
            public string Name { get; set; }
            public Int32 SchoolId { get; set; }
            public School School { get; set; }
        }

        /// <summary>
        /// 模拟导航属性的查询
        /// </summary>
        public static void Test02()
        {
            //情况1，如果用leftjoin，没有对应的school对象的时候，stu的school对象也不是空的，也会创建一个school对象的
            //所以，这种情况，通常需要把主键属性列，定义为nullable类型的（可空类型），只有这样才能准确判断是否有关联的对象
            var list = DBContext2.Db.Queryable<Student, School>((st, sc) => new object[] {
                    JoinType.Left,st.SchoolId==sc.Id,
                })
             .Select((st, sc) => new { st, sc })
             .ToList();
            var stuList = list.Select(it => { it.st.School = it.sc; return it.st; }).ToList();
            Console.WriteLine(stuList[0].School.Name);
            Console.WriteLine(stuList.Where(it => it.School.Id != null).FirstOrDefault().Name);
        }

        /// <summary>
        /// mergetable的测试
        /// </summary>
        public static void Test03()
        {
            var list = DBContext2.Db.Queryable<Student, School>((st, sc) => new object[] {
                    JoinType.Left,st.SchoolId==sc.Id,
                })
                .OrderBy((st, sc) => st.Id)
                .Select((st, sc) => new
                {
                    stID = st.Id,
                    stName = st.Name,
                    scName = sc.Name,
                    scID = sc.Id
                })
               .MergeTable()
               .ToList();
            Console.WriteLine($"{list[0].stName},{list[0].scName}");
        }
    }
}
