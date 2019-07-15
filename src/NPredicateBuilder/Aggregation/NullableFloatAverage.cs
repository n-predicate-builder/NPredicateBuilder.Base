using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class NullableFloatAverage : ISingleFinalizer<float?, float?>
    {
        public float? Finalize(IQueryable<float?> queryable) => queryable.Average();
    }
}
