using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

using Mini.Framework.EFCommon;

namespace GenerateEntity4ForDBFirst2
{
    class DB : BasicDb<DB>
    {
        public DB(String connectionString)
            : base(connectionString)
        { }

        public DB(DbConnection conn)
            : base(conn, true)
        { }

        public virtual DbSet<T_PQ_BU_PROD_GROUP_CM> T_PQ_BU_PROD_GROUP_CM { get; set; }
    }
}
