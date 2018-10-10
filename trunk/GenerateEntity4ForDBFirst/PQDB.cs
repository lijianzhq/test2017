using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

using System.Configuration;
using Mini.Framework.EFCommon;

namespace GenerateEntity4ForDBFirst
{
    //class PQDB : PQ_Entity.PQ_KFMQCS
    //{
    //    public PQDB()
    //        : base("metadata=res://*/PQ_Entity.PQ.csdl|res://*/PQ_Entity.PQ.ssdl|res://*/PQ_Entity.PQ.msl;provider=Oracle.ManagedDataAccess.Client;provider connection string=\"DATA SOURCE=172.26.136.162:1521/KFMQCS;PASSWORD=PQ;PERSIST SECURITY INFO=True;USER ID=PQ\"")
    //    { }
    //}

    class PQDB : BasicDb
    {
        public PQDB(String connectionStr)
            : base(connectionStr)
        { }

        public PQDB(DbConnection conn)
           : base(conn, true)
        { }

        public virtual DbSet<T_PQ_BU_PROD_GROUP_CM> T_PQ_BU_PROD_GROUP_CM { get; set; }
    }
}
