using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class NullableDecimalAverage : ISingleFinalizer<decimal?, decimal?>
    {
        public decimal? Finalize(IQueryable<decimal?> queryable) => queryable.Average();
    }
}
