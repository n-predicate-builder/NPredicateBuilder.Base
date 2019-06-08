using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class NullableDoubleSum : ISingleFinalizer<double?, double?>
    {
        public double? Finalize(IQueryable<double?> queryable) => queryable.Sum();
    }
}
