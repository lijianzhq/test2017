using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityToSql
{
    public class SqlPack
	{
		private static readonly List<string> S_listEnglishWords = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", };

		private Dictionary<string, string> _dicTableName = new Dictionary<string, string>();
		private Queue<string> _queueEnglishWords = new Queue<string>(S_listEnglishWords);

		public bool IsSingleTable { get; set; }

		public List<string> SelectFields { get; set; }

		public string SelectFieldsStr
		{
			get
			{
				return string.Join(",", this.SelectFields);
			}
		}

		public int Length
		{
			get
			{
				return this.Sql.Length;
			}
		}

		public StringBuilder Sql { get; set; }

		public DatabaseType DatabaseType { get; set; }

		public Dictionary<string, object> DbParams { get; private set; }

		private string DbParamPrefix
		{
			get
			{
				switch (this.DatabaseType)
				{
					case DatabaseType.SQLite:
					case DatabaseType.SQLServer: return "@";
					case DatabaseType.MySQL: return "?";
					case DatabaseType.Oracle: return ":";
					default: return "";
				}
			}
		}

		public char this[int index]
		{
			get
			{
				return this.Sql[index];
			}
		}

		public SqlPack()
		{
			this.DbParams = new Dictionary<string, object>();
			this.Sql = new StringBuilder();
			this.SelectFields = new List<string>();

		}

		public static SqlPack operator +(SqlPack sqlPack, string sql)
		{
			sqlPack.Sql.Append(sql);
			return sqlPack;
		}

		public void Clear()
		{
			this.SelectFields.Clear();
			this.Sql.Clear();
			this.DbParams.Clear();
			this._dicTableName.Clear();
			this._queueEnglishWords = new Queue<string>(S_listEnglishWords);
		}

		public void AddDbParameter(object parameterValue)
		{
			if (parameterValue == null || parameterValue == DBNull.Value)
			{
				this.Sql.Append(" null");
			}
			else
			{
				string name = this.DbParamPrefix + "param" + this.DbParams.Count;
				this.DbParams.Add(name, parameterValue);
				this.Sql.Append(" " + name);
			}
		}

		public bool SetTableAlias(string tableName)
		{
			if (!this._dicTableName.Keys.Contains(tableName))
			{
				this._dicTableName.Add(tableName, this._queueEnglishWords.Dequeue());
				return true;
			}
			return false;
		}

		public string GetTableAlias(string tableName)
		{
			if (!this.IsSingleTable && this._dicTableName.Keys.Contains(tableName))
			{
				return this._dicTableName[tableName];
			}
			return "";
		}

		public override string ToString()
		{
			return this.Sql.ToString();
		}

	}
}