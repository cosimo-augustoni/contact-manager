using System.Linq.Expressions;

namespace contact_manager.Models.Domain.Search
{
    public static class ExpressionHelper
   {
      public static Expression<Func<T, bool>> Or<T>(Expression<Func<T, bool>> filter1, Expression<Func<T, bool>> filter2)
      {
         var parameter = Expression.Parameter(typeof(T));

         var replaceExpression1 = ReplaceParameter(filter1, parameter);
         var replaceExpression2 = ReplaceParameter(filter2, parameter);

         var body = Expression.Or(replaceExpression1,  replaceExpression2);

         return Expression.Lambda<Func<T, bool>>(body, parameter);
      }

      public static Expression ReplaceParameter<T, TReturn>(Expression<Func<T, TReturn>> expression, Expression newParameter)
      {
         return ReplaceParameter(expression.Body, expression.Parameters[0], newParameter);
      }

      public static Expression ReplaceParameter(Expression expression, Expression oldParameter, Expression newParameter)
      {
         return new ReplaceParameterExpressionVisitor(oldParameter, newParameter).Visit(expression);
      }

      private class ReplaceParameterExpressionVisitor : ExpressionVisitor
      {
         private readonly Expression _oldParameter;

         private readonly Expression _newParameter;

         public ReplaceParameterExpressionVisitor(Expression oldParameter, Expression newParameter)
         {
            this._oldParameter = oldParameter;
            this._newParameter = newParameter;
         }

         protected override Expression VisitParameter(ParameterExpression node)
         {
            if (node == this._oldParameter)
               return this._newParameter;

            return base.VisitParameter(node);
         }
      }
   }
}
