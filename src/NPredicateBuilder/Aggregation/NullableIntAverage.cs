using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class NullableIntAverage : ISingleFinalizer<int?, double?>
    {
        public double? Finalize(IQueryable<int?> queryable) => queryable.Average();
    }
}
