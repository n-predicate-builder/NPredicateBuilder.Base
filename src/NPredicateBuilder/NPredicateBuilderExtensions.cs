using LinqKit;
using System.Linq;

namespace NPredicateBuilder
{
    public static class NPredicateBuilderExtensions
    {
        public static IQueryable<T> NPredicateBuilderWhere<T>(this IQueryable<T> queryable, BaseQuery<T> baseQuery)
        {
            return queryable.AsExpandable().Where(baseQuery.SearchExpression);
        }

        public static IOrderedQueryable<T> NPredicateBuilderOrder<T>(this IQueryable<T> queryable, BaseOrder<T> baseOrder)
        {
            var orderedEntities = baseOrder.FirstOrder.Order(queryable);

            foreach (var orderer in baseOrder.SecondaryOrders)
            {
                orderedEntities = orderer.Order(orderedEntities);
            }

            return orderedEntities;
        }
    }
}
