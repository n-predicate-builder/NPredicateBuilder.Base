using System;
using System.Linq;

namespace NPredicateBuilder
{
    public static class NPredicateBuilderLinqExtensions
    {
        /// <summary>
        /// Applies a series of Where filters to an IQueryable interface.
        /// </summary>
        public static IQueryable<T> NPredicateBuilderLinqWhere<T>(this IQueryable<T> queryable, BaseQuery<T> baseQuery)
        {
            if (baseQuery.SearchExpression == null) throw new ArgumentNullException("There must be at least one predicate to filter by.");

            return queryable.Where(baseQuery.SearchExpression);
        }

        /// <summary>
        /// Applies a series of Orders to an IQueryable interface.
        /// </summary>
        public static IOrderedQueryable<T> NPredicateBuilderLinqOrder<T>(this IQueryable<T> queryable, BaseOrder<T> baseOrder)
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
