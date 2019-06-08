using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class NullableLongAverage : ISingleFinalizer<long?, double?>
    {
        public double? Finalize(IQueryable<long?> queryable) => queryable.Average();
    }
}
