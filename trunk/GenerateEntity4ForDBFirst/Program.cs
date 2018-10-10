using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenerateEntity4ForDBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new DB("OracleDbContext"))
            //{
            //    var file = new UPLOADFILE()
            //    {
            //        CODE = Guid.NewGuid().ToString("N")
            //    };
            //    db.UploadFiles.Add(file);
            //    db.SaveChanges();
            //}

            //using (var db = new DB("User Id=test;Password=guanliyuan;Data Source=orcl"))
            //{
            //    var file = new UPLOADFILE()
            //    {
            //        CODE = Guid.NewGuid().ToString("N")
            //    };
            //    db.UploadFiles.Add(file);
            //    db.SaveChanges();
            //}

            //using (var conn = new OracleConnection("User Id=MQCSBUS;Password=MQCSBUS;Data Source=172.26.136.162/KFMQCS"))
            //{
            //    using (var db = new DB(conn))
            //    {
            //        var obj = new T_PQ_BU_PROD_GROUP_CM()
            //        {
            //            PROD_GROUP_CM_ID = Guid.NewGuid().ToString("N")
            //        };
            //        db.T_PQ_BU_PROD_GROUP_CM.Add(obj);
            //        db.SaveChanges();
            //    }
            //}

            using (var conn = new OracleConnection("User Id=MQCSBUS;Password=MQCSBUS;Data Source=172.26.136.162/KFMQCS"))
            {
                using (var db = new DB(conn))
                {
                    var obj = new T_PQ_BU_PROD_GROUP_CM()
                    {
                        PROD_GROUP_CM_ID = Guid.NewGuid().ToString("N")
                    };
                    db.T_PQ_BU_PROD_GROUP_CM.Add(obj);
                    db.SaveChanges();
                }
            }

            Console.WriteLine("done");
            Console.Read();
        }
    }
}
