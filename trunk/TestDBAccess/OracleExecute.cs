using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess;

namespace TestDBAccess
{
    class OracleExecute : Execute
    {
        public OracleExecute(String connectionStr, Int32 execRecordCount = 0) : base(connectionStr, execRecordCount)
        { }

        protected override DbProviderFactory GetDbProviderFactory()
        {
            return Oracle.ManagedDataAccess.Client.OracleClientFactory.Instance;
        }
    }
}
