using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class NullableIntSum : ISingleFinalizer<int?, int?>
    {
        public int? Finalize(IQueryable<int?> queryable) => queryable.Sum();
    }
}
