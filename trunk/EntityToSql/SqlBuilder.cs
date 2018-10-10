using System;
using System.Linq;
using System.Linq.Expressions;

namespace EntityToSql
{
    /// <summary>
    /// select语句抽象：
    /// select [*] from [table] [t1]
    /// [[left] join [table2] [t2] [t1.xx on t2.xx]]
    /// [where [xx = xx] [and or] [xx = xx]]
    /// [group by [xx,xx]]
    /// [order by [xx,xx]]
    /// 
    /// insert语句抽象：
    /// insert into [table]([xxx]) values([xxx])
    /// [returning xx into xx]
    /// 
    /// update语句抽象：
    /// update [table] set
    /// [xx = xx,xx = xx]
    /// [where [xx = xx] [and or] [xx = xx]]
    /// 
    /// delete语句抽象：
    /// delete [table]
    /// [where [xx = xx] [and or] [xx = xx]]
    /// </summary>
    public static class SqlBuilder
    {
        public static ISelectSql<TResult> Select<TSource, TResult>(this ISql<TSource> sql, Expression<Func<TSource, TResult>> selector)
        {
            return sql.Select(selector);
        }
    }
}
