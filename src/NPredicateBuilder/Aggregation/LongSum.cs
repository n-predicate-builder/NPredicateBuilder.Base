using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class LongSum : ISingleFinalizer<long, long>
    {
        public long Finalize(IQueryable<long> queryable) => queryable.Sum();
    }
}
