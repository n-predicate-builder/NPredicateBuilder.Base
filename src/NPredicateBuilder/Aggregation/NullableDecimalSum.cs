using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class NullableDecimalSum : ISingleFinalizer<decimal?, decimal?>
    {
        public decimal? Finalize(IQueryable<decimal?> queryable) => queryable.Sum();
    }
}
