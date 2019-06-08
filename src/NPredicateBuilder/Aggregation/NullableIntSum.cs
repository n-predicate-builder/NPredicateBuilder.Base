using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class NullableIntSum : ISingleFinalizer<int?, int?>
    {
        public int? Finalize(IQueryable<int?> queryable) => queryable.Sum();
    }
}
