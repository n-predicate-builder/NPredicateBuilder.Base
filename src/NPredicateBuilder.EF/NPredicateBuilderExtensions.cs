using System;
using System.Linq;
using LinqKit;

namespace NPredicateBuilder.EF
{
    public static class NPredicateBuilderExtensions
    {
        /// <summary>
        /// Applies a series of Where filters to an IQueryable interface.
        /// </summary>
        public static IQueryable<T> NPredicateBuilderWhere<T>(this IQueryable<T> queryable, BaseQuery<T> baseQuery)
        {
            if (baseQuery.SearchExpression == null) throw new ArgumentNullException("There must be at least one predicate to filter by.");

            return queryable.AsExpandable().Where(baseQuery.SearchExpression);
        }

        /// <summary>
        /// Applies a series of Orders to an IQueryable interface.
        /// </summary>
        public static IOrderedQueryable<T> NPredicateBuilderOrder<T>(this IQueryable<T> queryable, BaseOrder<T> baseOrder)
        {
            if (baseOrder.FirstOrder == null) throw new ArgumentNullException("There must be an OrderBy or OrderBy Descending to order by.");

            var orderedEntities = baseOrder.FirstOrder.Order(queryable);

            foreach (var orderer in baseOrder.SecondaryOrders)
            {
                orderedEntities = orderer.Order(orderedEntities);
            }

            return orderedEntities;
        }
    }
}
