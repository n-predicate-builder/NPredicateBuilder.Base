using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Ordering
{
    public class ThenBy<T, TKey> : IOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        public ThenBy(Expression<Func<T, TKey>> orderExpression)
        {
            _orderExpression = orderExpression;
        }

        public IOrderedQueryable<T> Order(IQueryable<T> queryable)
        {
            var asOrdered = (IOrderedQueryable<T>)queryable;

            return asOrdered.ThenBy(_orderExpression);
        }
    }
}
