using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder
{
    /// <inheritdoc />
    internal class ThenBy<T, TKey> : IThenByOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThenBy{T, TKey}"/> class.
        /// </summary>
        /// <param name="orderExpression">A func to define a continuation of an order for an entity.</param>
        public ThenBy(Expression<Func<T, TKey>> orderExpression)
        {
            _orderExpression = orderExpression;
        }

        /// <inheritdoc/>
        public IOrderedQueryable<T> Order(IOrderedQueryable<T> orderedQueryable)
        {
            return orderedQueryable.ThenBy(_orderExpression);
        }

        /// <inheritdoc/>
        public IOrderedEnumerable<T> Order(IOrderedEnumerable<T> orderedEnumerable)
        {
            return orderedEnumerable.ThenBy(_orderExpression.Compile());
        }
    }
}