using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class LongCount<TFinalizerIn> : ISingleFinalizer<TFinalizerIn, long>
    {
        public long Finalize(IQueryable<TFinalizerIn> queryable) => queryable.LongCount();
    }
}
