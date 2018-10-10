using System;
using System.Data.Entity;

namespace TestEFCodeFirst2
{
    public class Storage
    {
        /// <summary>
        /// 数据库初始化
        /// </summary>
        public static void Init()
        {
            Database.SetInitializer(new TestDBInitializer());
        }
    }

    public class TestDBInitializer : DropCreateDatabaseIfModelChanges<Models.DB>
    {

    }
}