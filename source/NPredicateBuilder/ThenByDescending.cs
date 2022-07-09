namespace NPredicateBuilder
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    internal class ThenByDescending<T, TKey> : IThenByOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        public ThenByDescending(Expression<Func<T, TKey>> orderExpression)
        {
            _orderExpression = orderExpression;
        }

        public IOrderedQueryable<T> Order(IOrderedQueryable<T> orderedQueryable)
        {
            return orderedQueryable.ThenByDescending(_orderExpression);
        }

        public IOrderedEnumerable<T> Order(IOrderedEnumerable<T> orderedEnumerable)
        {
            return orderedEnumerable.ThenByDescending(_orderExpression.Compile());
        }
    }
}