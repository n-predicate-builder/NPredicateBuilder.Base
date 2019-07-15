using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class NullableIntAverage : ISingleFinalizer<int?, double?>
    {
        public double? Finalize(IQueryable<int?> queryable) => queryable.Average();
    }
}
