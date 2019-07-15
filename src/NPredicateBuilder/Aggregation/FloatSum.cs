using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class FloatSum : ISingleFinalizer<float, float>
    {
        public float Finalize(IQueryable<float> queryable) => queryable.Sum();
    }
}
