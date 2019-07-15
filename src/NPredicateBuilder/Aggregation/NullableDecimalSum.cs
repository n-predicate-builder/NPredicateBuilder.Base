using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class NullableDecimalSum : ISingleFinalizer<decimal?, decimal?>
    {
        public decimal? Finalize(IQueryable<decimal?> queryable) => queryable.Sum();
    }
}
