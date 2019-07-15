using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class FloatAverage : ISingleFinalizer<float, float>
    {
        public float Finalize(IQueryable<float> queryable) => queryable.Average();
    }
}
