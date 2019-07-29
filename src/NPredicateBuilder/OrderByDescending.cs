using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder
{
    internal class OrderByDescending<T, TKey> : IOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        public OrderByDescending(Expression<Func<T, TKey>> orderExpression) => _orderExpression = orderExpression;

        public IOrderedQueryable<T> Order(IQueryable<T> queryable) => queryable.OrderByDescending(_orderExpression);
    }
}
