using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class NullableLongSum : ISingleFinalizer<long?, long?>
    {
        public long? Finalize(IQueryable<long?> queryable) => queryable.Sum();
    }
}
