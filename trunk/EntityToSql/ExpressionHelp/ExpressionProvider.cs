using System;
using System.Linq.Expressions;

namespace EntityToSql.ExpressionHelp
{
    public class ExpressionProvider
    {
        public String GetExpressionStr(Expression exp)
        {
            if (exp is UnaryExpression)
            {
                return GetExpressionStr(((UnaryExpression)exp).Operand);
            }
            if(exp is MemberExpression)
            {

            }
            throw new ArgumentException("exp");
        }
    }
}
