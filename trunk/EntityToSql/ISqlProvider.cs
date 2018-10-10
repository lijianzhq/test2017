namespace EntityToSql
{
    public interface ISqlProvider
    {
        ISelectSql<TSource> CreateSelectSql<TSource>();
    }
}