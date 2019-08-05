using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDBAccess
{
    public partial class DataTypeReadTest : Form
    {
        protected String _connectionStr = "server=LIJIAN42889\\SQLSERVER2017;uid=sa;pwd=sa;database=zhaoji;Connect Timeout=3600";

        public DataTypeReadTest()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Test_Click(object sender, EventArgs e)
        {
            using (var reader = GetReader("select top 1 * from Z_TEST"))
            {
                reader.Read();
                var sb = new StringBuilder();
                var fieldCount = reader.FieldCount;
                for (var i = 0; i < fieldCount; i++)
                {
                    sb.Append(reader.GetValue(i));
                    sb.AppendLine();
                }
                textBox1.Text = sb.ToString();
            }
        }

        protected virtual DbDataReader GetReader(String sql)
        {
            var conn = GetConnection(this._connectionStr);
            var command = conn.CreateCommand();
            command.Connection = conn;
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            return command.ExecuteReader();
        }

        protected virtual DbConnection GetConnection(String connectionStr, Boolean autoOpen = true)
        {
            var factory = GetFactory();
            var connection = factory.CreateConnection();
            connection.ConnectionString = connectionStr;
            if (autoOpen && connection.State != ConnectionState.Open) connection.Open();
            return connection;
        }

        protected virtual DbProviderFactory GetFactory()
        {
            return SqlClientFactory.Instance;
        }
    }
}
