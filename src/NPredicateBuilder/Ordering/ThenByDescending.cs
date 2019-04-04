using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Ordering
{
    internal class ThenByDescending<T, TKey> : IThenByOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        public ThenByDescending(Expression<Func<T, TKey>> orderExpression)
        {
            _orderExpression = orderExpression;
        }

        public IOrderedQueryable<T> Order(IOrderedQueryable<T> queryable)
        {
            return queryable.ThenByDescending(_orderExpression);
        }
    }
}
