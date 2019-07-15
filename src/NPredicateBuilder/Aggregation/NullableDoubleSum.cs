using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class NullableDoubleSum : ISingleFinalizer<double?, double?>
    {
        public double? Finalize(IQueryable<double?> queryable) => queryable.Sum();
    }
}
