using System;
using System.Linq.Expressions;

namespace NPredicateBuilder.Base
{
    public abstract class BaseQuery<T>
    {
        private Expression<Func<T, bool>> _expression;

        public Expression<Func<T, bool>> AsExpression()
        {
            return _expression;
        }

        private Expression<Func<T, bool>> Or(Expression<Func<T, bool>> nextExpression)
        {
            var invokedExpression = Expression.Invoke(nextExpression, _expression.Parameters);
            return Expression.Lambda<Func<T, bool>>(Expression.OrElse(_expression.Body, invokedExpression), _expression.Parameters);
        }

        private Expression<Func<T, bool>> And(Expression<Func<T, bool>> nextExpression)
        {
            var invokedExpression = Expression.Invoke(nextExpression, _expression.Parameters);
            return Expression.Lambda<Func<T, bool>>(Expression.AndAlso(_expression.Body, invokedExpression), _expression.Parameters);
        }

        public BaseQuery<T> And(BaseQuery<T> currentQuery)
        {
            _expression = And(currentQuery.AsExpression());
            return this;
        }

        public BaseQuery<T> Or(BaseQuery<T> currentQuery)
        {
            _expression = Or(currentQuery.AsExpression());
            return this;
        }

        protected void AddAndCriteria(Expression<Func<T, bool>> nextExpression)
        {
            _expression = _expression == null ? nextExpression : And(nextExpression);
        }

        protected void AddOrCriteria(Expression<Func<T, bool>> nextExpression)
        {
            _expression = _expression == null ? nextExpression : Or(nextExpression);
        }
    }
}
