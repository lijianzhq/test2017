using System;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.SqlServer;
using System.Linq;

namespace EFEntities
{
    public class TestDB1_DropCreateDatabaseIfModelChanges : DropCreateDatabaseIfModelChanges<TestDB1>
    {

    }

    public class ExtendedSqlGenerator : SqlServerMigrationSqlGenerator
    {
        #region 外键
        protected override void Generate(DropForeignKeyOperation dropForeignKeyOperation)
        {
            if (IsIgnoreTable(dropForeignKeyOperation.DependentTable))
                return;
            base.Generate(dropForeignKeyOperation);
        }
        protected override void Generate(AddForeignKeyOperation addForeignKeyOperation)
        {
            if (IsIgnoreTable(addForeignKeyOperation.DependentTable))
                return;
            base.Generate(addForeignKeyOperation);
        }
        #endregion

        protected Boolean IsIgnoreTable(String table)
        {
            return false;
        }
    }

    public class TestDB1 : DbContext
    {
        public static void Init(IDatabaseInitializer<TestDB1> strategy)
        {
            Database.SetInitializer(strategy);
            using (var db = new TestDB1())
            {
                db.Database.Initialize(false);
            }
            //using (var db = new TestDB1())
            //{
            //    var list = db.Students.Take(1).ToList();
            //}
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //解决EF动态建库数据库表名变为复数问题  
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new StudentMap());
            base.OnModelCreating(modelBuilder);
        }

        public TestDB1()
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        //public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
