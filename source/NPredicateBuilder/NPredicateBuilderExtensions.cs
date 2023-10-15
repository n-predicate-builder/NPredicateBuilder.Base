using System;
using System.Collections.Generic;
using System.Linq;

namespace NPredicateBuilder
{
    /// <summary>
    /// Provides extension methods to query and order against an <see cref="IEnumerable{T}"/> collection.
    /// </summary>
    public static class NPredicateBuilderExtensions
    {
        /// <summary>
        /// Applies a series of predicates as filters on an IEnumerable.
        /// </summary>
        /// <typeparam name="T">The entity that you are querying.</typeparam>
        /// <param name="enumerable">An IEnumerable of type T entity.</param>
        /// <param name="baseQuery">A query object that will apply a series of filters.</param>
        /// <returns>A filtered IEnumerable of type T.</returns>
        public static IEnumerable<T> NPredicateBuilderWhere<T>(this IEnumerable<T> enumerable, BaseQuery<T> baseQuery)
        {
            if (baseQuery.SearchExpression == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            return enumerable.Where(baseQuery.SearchExpression.Compile());
        }

        /// <summary>
        /// Applies a series of orders on an IEnumerable.
        /// </summary>
        /// <typeparam name="T">The entity that you are ordering.</typeparam>
        /// <param name="enumerable">An IEnumerable of type T entity.</param>
        /// <param name="baseOrder">An order object that will apply a series of orders.</param>
        /// <returns>An IOrderedQueryable of type T.</returns>
        public static IOrderedEnumerable<T> NPredicateBuilderOrder<T>(this IEnumerable<T> enumerable, BaseOrder<T> baseOrder)
        {
            if (baseOrder.FirstOrder == null)
            {
                throw new ArgumentNullException(nameof(enumerable));
            }

            var orderedEntities = baseOrder.FirstOrder.Order(enumerable);

            foreach (var orderer in baseOrder.SecondaryOrders)
            {
                orderedEntities = orderer.Order(orderedEntities);
            }

            return orderedEntities;
        }
    }
}