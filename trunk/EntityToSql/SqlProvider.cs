using System;

namespace EntityToSql
{
    public class SqlProvider : ISqlProvider
    {
        public ISelectSql<TSource> CreateSelectSql<TSource>()
        {
            return new SqlServerSelectSql<TSource>(this);
        }
    }
}
