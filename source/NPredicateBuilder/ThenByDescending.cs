using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder
{
    /// <inheritdoc />
    internal class ThenByDescending<T, TKey> : IThenByOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThenByDescending{T, TKey}"/> class.
        /// </summary>
        /// <param name="orderExpression">A func for describing a descending continuation order for an entity.</param>
        public ThenByDescending(Expression<Func<T, TKey>> orderExpression)
        {
            _orderExpression = orderExpression;
        }

        /// <inheritdoc />
        public IOrderedQueryable<T> Order(IOrderedQueryable<T> orderedQueryable)
        {
            return orderedQueryable.ThenByDescending(_orderExpression);
        }

        /// <inheritdoc />
        public IOrderedEnumerable<T> Order(IOrderedEnumerable<T> orderedEnumerable)
        {
            return orderedEnumerable.ThenByDescending(_orderExpression.Compile());
        }
    }
}