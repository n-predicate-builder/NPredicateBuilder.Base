using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class NullableFloatSum : ISingleFinalizer<float?, float?>
    {
        public float? Finalize(IQueryable<float?> queryable) => queryable.Sum();
    }
}
