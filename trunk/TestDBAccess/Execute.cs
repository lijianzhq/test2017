using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using Oracle.ManagedDataAccess;

namespace TestDBAccess
{
    abstract class Execute
    {
        private Stopwatch _stopwatch = new Stopwatch();
        private String _connectionStr = String.Empty;
        private Int32 _execRecordCount = 1;

        public Execute(String connectionStr, Int32 execRecordCount = 0)
        {
            this._connectionStr = connectionStr;
            this._execRecordCount = execRecordCount;
        }

        public virtual void Start()
        {
            _stopwatch.Start();
            DoStart();
            _stopwatch.Stop();
        }

        /// <summary>
        /// 总执行时间
        /// </summary>
        /// <returns></returns>
        public virtual Double TotalSeconds()
        {
            return _stopwatch.Elapsed.TotalSeconds;
        }

        /// <summary>
        /// 执行sql
        /// </summary>
        /// <param name="sql"></param>
        public virtual Int32 ExecString(String sql)
        {
            var command = GetDbCommand(sql);
            using (var conn = GetDbConnection(this._connectionStr))
            {
                command.Connection = conn;
                return command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 获取provider
        /// </summary>
        /// <returns></returns>
        protected abstract DbProviderFactory GetDbProviderFactory();

        /// <summary>
        /// 获取连接对象
        /// </summary>
        /// <param name="connectionStr"></param>
        /// <returns></returns>
        protected virtual DbConnection GetDbConnection(String connectionStr, Boolean autoOpen = true)
        {
            var conn = GetDbProviderFactory().CreateConnection();
            conn.ConnectionString = connectionStr;
            if (autoOpen && conn.State != System.Data.ConnectionState.Open)
                conn.Open();
            return conn;
        }

        /// <summary>
        /// 数据库命令对象
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns></returns>
        protected virtual DbCommand GetDbCommand(String commandText)
        {
            var command = GetDbProviderFactory().CreateCommand();
            command.CommandText = commandText;
            return command;
        }

        /// <summary>
        /// 开始执行
        /// </summary>
        protected virtual void DoStart()
        {
            var sqlValuesBuilder = new StringBuilder();
            var sql = "insert into student(name) values{0}";
            var command = GetDbCommand(sql);
            using (var conn = GetDbConnection(this._connectionStr))
            {
                for (var i = 0; i < this._execRecordCount; i++)
                {
                    var paramName = $"@name{i}";
                    var param = command.CreateParameter();
                    param.ParameterName = paramName;
                    param.Value = $"zhq{i}";
                    command.Parameters.Add(param);
                    sqlValuesBuilder.Append($"({paramName})");
                    if (i > 0) sqlValuesBuilder.Append(",");
                }
                command.Connection = conn;
                command.ExecuteNonQuery();
            }
        }
    }
}
