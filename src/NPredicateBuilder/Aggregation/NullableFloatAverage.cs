using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class NullableFloatAverage : ISingleFinalizer<float?, float?>
    {
        public float? Finalize(IQueryable<float?> queryable) => queryable.Average();
    }
}
