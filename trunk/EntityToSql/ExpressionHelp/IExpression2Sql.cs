using System.Linq.Expressions;

namespace EntityToSql.ExpressionHelp
{
    public interface IExpression2Sql
	{
		SqlPack Update(Expression expression, SqlPack sqlPack);

		SqlPack Select(Expression expression, SqlPack sqlPack);

		SqlPack Join(Expression expression, SqlPack sqlPack);

		SqlPack Where(Expression expression, SqlPack sqlPack);

		SqlPack In(Expression expression, SqlPack sqlPack);

		SqlPack GroupBy(Expression expression, SqlPack sqlPack);

		SqlPack OrderBy(Expression expression, SqlPack sqlPack);

		SqlPack Max(Expression expression, SqlPack sqlPack);

		SqlPack Min(Expression expression, SqlPack sqlPack);

		SqlPack Avg(Expression expression, SqlPack sqlPack);

		SqlPack Count(Expression expression, SqlPack sqlPack);

		SqlPack Sum(Expression expression, SqlPack sqlPack);
	}
}
