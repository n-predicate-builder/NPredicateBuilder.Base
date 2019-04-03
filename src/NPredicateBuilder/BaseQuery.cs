using System;
using System.Linq.Expressions;

namespace NPredicateBuilder
{
    public abstract class BaseQuery<T>
    {
        public Expression<Func<T, bool>> SearchExpression { get; private set; }

        private Expression<Func<T, bool>> Or(Expression<Func<T, bool>> nextExpression)
        {
            var invokedExpression = Expression.Invoke(nextExpression, SearchExpression.Parameters);
            return Expression.Lambda<Func<T, bool>>(Expression.OrElse(SearchExpression.Body, invokedExpression), SearchExpression.Parameters);
        }

        private Expression<Func<T, bool>> And(Expression<Func<T, bool>> nextExpression)
        {
            var invokedExpression = Expression.Invoke(nextExpression, SearchExpression.Parameters);
            return Expression.Lambda<Func<T, bool>>(Expression.AndAlso(SearchExpression.Body, invokedExpression), SearchExpression.Parameters);
        }

        public BaseQuery<T> And(BaseQuery<T> currentQuery)
        {
            SearchExpression = And(currentQuery.SearchExpression);
            return this;
        }

        public BaseQuery<T> Or(BaseQuery<T> currentQuery)
        {
            SearchExpression = Or(currentQuery.SearchExpression);
            return this;
        }

        protected void AddAndCriteria(Expression<Func<T, bool>> nextExpression)
        {
            SearchExpression = SearchExpression == null ? nextExpression : And(nextExpression);
        }

        protected void AddOrCriteria(Expression<Func<T, bool>> nextExpression)
        {
            SearchExpression = SearchExpression == null ? nextExpression : Or(nextExpression);
        }
    }
}
