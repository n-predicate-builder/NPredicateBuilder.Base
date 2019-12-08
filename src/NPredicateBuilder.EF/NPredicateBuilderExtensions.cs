using System;
using System.Linq;
using LinqKit;

namespace NPredicateBuilder.EF
{
    public static class NPredicateBuilderExtensions
    {
        /// <summary>
        /// Applies a series of predicates as filters on an IQueryable.
        /// </summary>
        /// <typeparam name="T">The entity that you are querying.</typeparam>
        /// <param name="queryable">An IQueryable of type T entity.</param>
        /// <param name="baseQuery">A query object that will apply a series of filters.</param>
        /// <returns>A filtered IQueryable of type T.</returns>
        public static IQueryable<T> NPredicateBuilderWhere<T>(this IQueryable<T> queryable, BaseQuery<T> baseQuery)
        {
            if (baseQuery.SearchExpression == null) throw new ArgumentNullException(nameof(queryable));

            return queryable.AsExpandable().Where(baseQuery.SearchExpression);
        }

        /// <summary>
        /// Applies a series of orders on an IQueryable.
        /// </summary>
        /// <typeparam name="T">The entity that you are ordering.</typeparam>
        /// <param name="queryable">An IQueryable of type T entity.</param>
        /// <param name="baseOrder">An order object that will apply a series of orders.</param>
        /// <returns>An IOrderedQueryable of type T.</returns>
        public static IOrderedQueryable<T> NPredicateBuilderOrder<T>(this IQueryable<T> queryable, BaseOrder<T> baseOrder)
        {
            if (baseOrder.FirstOrder == null) throw new ArgumentNullException(nameof(queryable));

            var orderedEntities = baseOrder.FirstOrder.Order(queryable);

            foreach (var orderer in baseOrder.SecondaryOrders)
            {
                orderedEntities = orderer.Order(orderedEntities);
            }

            return orderedEntities;
        }
    }
}
