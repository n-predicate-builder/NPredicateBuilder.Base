using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class NullableDecimalAverage : ISingleFinalizer<decimal?, decimal?>
    {
        public decimal? Finalize(IQueryable<decimal?> queryable) => queryable.Average();
    }
}
