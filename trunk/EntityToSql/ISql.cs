using System;
using System.Linq.Expressions;

namespace EntityToSql
{
    public interface ISql<out TResult>
    { }

    public interface ISelectSql<TSource>
    {
        /// <summary>
        /// 查询语句
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="selector"></param>
        /// <returns></returns>
        ISelectSql<TResult> Select<TResult>(Expression<Func<TSource, TResult>> selector);

        /// <summary>
        /// where语句
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        ISelectSql<TSource> Where(Expression<Func<TSource, Boolean>> predicate);

        //ISelectSql<TSource> GroupBy(Expression<Func<TSource, TSource>> selector);
        //ISelectSql<TResult> OrderBy();
        //ISelectSql<TResult> Join();
    }

    public interface IGroupBySql<TSource>
    {
       
    }


    //public interface IInsertSql<TSource> : ISql<TSource>
    //{
    //    IInsertSql<TSource> Insert(TSource new_t);
    //    TResult Returning<TResult>(Expression<Func<TResult>> selector);
    //}

    //public interface IUpdateSql<TSource> : ISql<TSource>
    //{
    //    IUpdateSql<TSource> Update();

    //    IUpdateSql<TSource> Where();
    //}

    //public interface IDeleteSql<TSource> : ISql<TSource>
    //{
    //    IDeleteSql<TSource> Delete();

    //    IDeleteSql<TSource> Where();
    //}
}
