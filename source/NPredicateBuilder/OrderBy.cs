namespace NPredicateBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    internal class OrderBy<T, TKey> : IOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        public OrderBy(Expression<Func<T, TKey>> orderExpression)
        {
            _orderExpression = orderExpression;
        }

        public IOrderedQueryable<T> Order(IQueryable<T> queryable)
        {
            return queryable.OrderBy(_orderExpression);
        }

        public IOrderedEnumerable<T> Order(IEnumerable<T> enumerable)
        {
            return enumerable.OrderBy(_orderExpression.Compile());
        }
    }
}