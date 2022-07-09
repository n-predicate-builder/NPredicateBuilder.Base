namespace NPredicateBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    internal class OrderByDescending<T, TKey> : IOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        public OrderByDescending(Expression<Func<T, TKey>> orderExpression)
        {
            _orderExpression = orderExpression;
        }

        public IOrderedQueryable<T> Order(IQueryable<T> queryable)
        {
            return queryable.OrderByDescending(_orderExpression);
        }

        public IOrderedEnumerable<T> Order(IEnumerable<T> enumerable)
        {
            return enumerable.OrderByDescending(_orderExpression.Compile());
        }
    }
}