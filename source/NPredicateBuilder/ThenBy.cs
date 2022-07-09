namespace NPredicateBuilder
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    internal class ThenBy<T, TKey> : IThenByOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        public ThenBy(Expression<Func<T, TKey>> orderExpression)
        {
            _orderExpression = orderExpression;
        }

        public IOrderedQueryable<T> Order(IOrderedQueryable<T> orderedQueryable)
        {
            return orderedQueryable.ThenBy(_orderExpression);
        }

        public IOrderedEnumerable<T> Order(IOrderedEnumerable<T> orderedEnumerable)
        {
            return orderedEnumerable.ThenBy(_orderExpression.Compile());
        }
    }
}