using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class LongCount<TFinalizerIn> : ISingleFinalizer<TFinalizerIn, long>
    {
        public long Finalize(IQueryable<TFinalizerIn> queryable) => queryable.LongCount();
    }
}
