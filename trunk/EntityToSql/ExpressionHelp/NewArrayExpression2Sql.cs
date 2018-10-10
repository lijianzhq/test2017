using System.Linq.Expressions;

namespace EntityToSql.ExpressionHelp
{
    class NewArrayExpression2Sql : BaseExpression2Sql<NewArrayExpression>
	{
		protected override SqlPack In(NewArrayExpression expression, SqlPack sqlPack)
		{
			sqlPack += "(";

			foreach (Expression expressionItem in expression.Expressions)
			{
				Expression2SqlProvider.In(expressionItem, sqlPack);
			}

			if (sqlPack.Sql[sqlPack.Sql.Length - 1] == ',')
			{
				sqlPack.Sql.Remove(sqlPack.Sql.Length - 1, 1);
			}

			sqlPack += ")";

			return sqlPack;
		}
	}
}
