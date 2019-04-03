using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Ordering
{
    public class OrderByDescending<T, TKey> : IOrder<T>
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
    }
}
