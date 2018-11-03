using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SqlSugar;
using TestSqlSugar.Models;

namespace TestSqlSugar
{
    //[SugarTable("STudent")]
    public class Student
    {
        //[SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "ID")]
        public int Id { get; set; }
        public int? SchoolId { get; set; }
        public string Name { get; set; }
        public DateTime? CreateTime { get; set; }

        //[SugarColumn(IsIgnore = true)]
        public int TestId { get; set; }
    }

    class Test_Update
    {
        public static void Start()
        {
            /*更新*/
            //var data2 = new Student() { Id = 1, Name = "jack" };
            //Console.WriteLine(DBContext2.Db.Updateable(data2).ExecuteCommand());

            var stus = new Student[]{
                new Student() {Id=95025,Name="95025"},
                new Student() {Id=95024,Name="95024"},
                new Student() {Id=95023,Name="95023"},
            };
            //这种方式要求model的属性必须指定主键属性
            //var effectRow = DBContext2.Db.Updateable(stus).ExecuteCommand();
            //Console.WriteLine(effectRow);

            //这种方式不要求model指定主键属性
            //var effectRow = DBContext2.Db.Updateable(stus)
            //                    .WhereColumns(it => it.Id)
            //                    .ExecuteCommand();
            //Console.WriteLine(effectRow);

            //这种情况，model类型的属性字段与数据库的字段没有一一对应的，model类型的字段比数据库字段多的情况
            //第一：model类型的属性字段增加一个SugarColumn(IsIgnore = true);
            //第二：用updatecolumns指定要更新的列，注意：updatecolumns必须要加上wehrecolumns的列
            var effectRow = DBContext2.Db.Updateable<Student>(stus)
                            .UpdateColumns(it => new { it.Name, it.Id })
                            .WhereColumns(it => it.Id)
                            .ExecuteCommand();
            Console.WriteLine(effectRow);
        }
    }
}
