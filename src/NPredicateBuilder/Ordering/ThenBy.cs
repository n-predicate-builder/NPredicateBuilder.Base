using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Ordering
{
    internal class ThenBy<T, TKey> : IThenByOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        public ThenBy(Expression<Func<T, TKey>> orderExpression) => _orderExpression = orderExpression;

        public IOrderedQueryable<T> Order(IOrderedQueryable<T> queryable) => queryable.ThenBy(_orderExpression);
    }
}
