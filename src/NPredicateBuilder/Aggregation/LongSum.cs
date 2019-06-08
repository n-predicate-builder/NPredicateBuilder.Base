using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class LongSum : ISingleFinalizer<long, long>
    {
        public long Finalize(IQueryable<long> queryable) => queryable.Sum();
    }
}
