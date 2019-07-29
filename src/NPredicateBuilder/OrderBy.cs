using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder
{
    internal class OrderBy<T, TKey> : IOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        public OrderBy(Expression<Func<T, TKey>> orderExpression) => _orderExpression = orderExpression;

        public IOrderedQueryable<T> Order(IQueryable<T> queryable) => queryable.OrderBy(_orderExpression);
    }
}
