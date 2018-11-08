using System;
using SqlSugar;

namespace TestReadERPDataForMCloud
{
    class DBContext
    {
        [ThreadStatic]
        private static SqlSugarClient _db = null;

        public static SqlSugarClient DB
        {
            get
            {
                if (_db == null)
                {
                    _db = new SqlSugarClient(new ConnectionConfig()
                    {
                        ConnectionString = ConnectionString,
                        DbType = DbType.Oracle,//设置数据库类型
                        IsAutoCloseConnection = true,//自动释放数据务，如何存在事务，在事务结束后释放
                        InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
                    });
                }
                return _db;
            }
        }

        public static String ConnectionString
        {
            get
            {
                return "data source = 10.16.65.84/OBSTST;user id= apps; password=appsobstst;persist security info=false";
            }
        }
    }
}
