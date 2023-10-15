using System.Collections.Generic;
using System.Linq;

namespace NPredicateBuilder
{
    /// <summary>
    /// An interface that defines an order.
    /// </summary>
    /// <typeparam name="T">The type of the Entity that is being ordered.</typeparam>
    public interface IOrder<T>
    {
        /// <summary>
        /// An interface for ordering against an <see cref="IQueryable"/> entity.
        /// </summary>
        /// <param name="queryable">A list of entities to be ordered against.</param>
        /// <returns>An <see cref="IOrderedQueryable"/> interface that has been ordered.</returns>
        IOrderedQueryable<T> Order(IQueryable<T> queryable);

        /// <summary>
        /// An interface for ordering against an <see cref="IEnumerable{T}"/> entity.
        /// </summary>
        /// <param name="enumerable">A list of entities to be ordered against.</param>
        /// <returns>An <see cref="IOrderedQueryable"/> interface that has been ordered.</returns>
        IOrderedEnumerable<T> Order(IEnumerable<T> enumerable);
    }
}