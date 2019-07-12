using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class Min<TFinalizerIn> : ISingleFinalizer<TFinalizerIn, TFinalizerIn>
    {
        public TFinalizerIn Finalize(IQueryable<TFinalizerIn> queryable) => queryable.Min();
    }
}
