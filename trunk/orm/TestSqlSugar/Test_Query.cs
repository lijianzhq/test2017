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
    }
}
