using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using EntityToSql.ExpressionHelp;

namespace EntityToSql
{
    public class SqlServerSelectSql<TSource> : ISelectSql<TSource>
    {
        /// <summary>
        /// 操作类型
        /// </summary>
        protected enum OperationType
        {
            Select,
            Where
        }
        protected Dictionary<OperationType, Expression> _expList = new Dictionary<OperationType, Expression>();
        protected ISqlProvider _sqlProvider = null;
        protected SqlPack _sqlpack = null;
        protected ExpressionProvider _expressionProvider = null;

        public SqlServerSelectSql(ISqlProvider sqlProvider)
        {
            _sqlProvider = sqlProvider;
        }

        public virtual ISelectSql<TResult> Select<TResult>(Expression<Func<TSource, TResult>> selector)
        {
            //_expList.Add(OperationType.Select, selector);
            if (typeof(TSource) == typeof(TResult))
            {
                return this as ISelectSql<TResult>;
            }
            else
            {
                return _sqlProvider.CreateSelectSql<TResult>();
            }
            _expressionProvider.
        }

        public virtual ISelectSql<TSource> Where(Expression<Func<TSource, bool>> predicate)
        {
            _expList.Add(OperationType.Where, predicate);
            return this;
        }

        public virtual override string ToString()
        {
            foreach (KeyValuePair<OperationType, Expression> item in _expList)
            {
                if (item.Key != OperationType.Select)
                {
                }
            }
            return base.ToString();
        }

        /// <summary>
        /// 构造select语句
        /// </summary>
        /// <param name="exp"></param>
        protected virtual void CreateSelectSql(Expression exp = null)
        {
            //if (exp == null)
            //    _sqlStrBuilder.AppendFormat("SELECT * FROM {0}", GetTableAliasName());
            //else
            //    _sqlStrBuilder.AppendFormat("SELECT * FROM {0}", GetTableAliasName());
        }

        protected virtual String GetTableName()
        {
            return typeof(TSource).Name;
        }
    }
}
