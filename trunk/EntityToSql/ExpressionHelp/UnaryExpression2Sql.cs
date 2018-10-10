﻿using System.Linq.Expressions;

namespace EntityToSql.ExpressionHelp
{
    class UnaryExpression2Sql : BaseExpression2Sql<UnaryExpression>
	{
		protected override SqlPack Select(UnaryExpression expression, SqlPack sqlPack)
		{
			Expression2SqlProvider.Select(expression.Operand, sqlPack);
			return sqlPack;
		}

		protected override SqlPack Where(UnaryExpression expression, SqlPack sqlPack)
		{
			Expression2SqlProvider.Where(expression.Operand, sqlPack);
			return sqlPack;
		}

		protected override SqlPack GroupBy(UnaryExpression expression, SqlPack sqlPack)
		{
			Expression2SqlProvider.GroupBy(expression.Operand, sqlPack);
			return sqlPack;
		}

		protected override SqlPack OrderBy(UnaryExpression expression, SqlPack sqlPack)
		{
			Expression2SqlProvider.OrderBy(expression.Operand, sqlPack);
			return sqlPack;
		}

		protected override SqlPack Max(UnaryExpression expression, SqlPack sqlPack)
		{
			Expression2SqlProvider.Max(expression.Operand, sqlPack);
			return sqlPack;
		}

		protected override SqlPack Min(UnaryExpression expression, SqlPack sqlPack)
		{
			Expression2SqlProvider.Min(expression.Operand, sqlPack);
			return sqlPack;
		}

		protected override SqlPack Avg(UnaryExpression expression, SqlPack sqlPack)
		{
			Expression2SqlProvider.Avg(expression.Operand, sqlPack);
			return sqlPack;
		}

		protected override SqlPack Count(UnaryExpression expression, SqlPack sqlPack)
		{
			Expression2SqlProvider.Count(expression.Operand, sqlPack);
			return sqlPack;
		}

		protected override SqlPack Sum(UnaryExpression expression, SqlPack sqlPack)
		{
			Expression2SqlProvider.Sum(expression.Operand, sqlPack);
			return sqlPack;
		}
	}
}
