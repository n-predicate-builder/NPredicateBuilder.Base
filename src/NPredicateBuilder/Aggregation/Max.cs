using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class Max<TFinalizerIn> : ISingleFinalizer<TFinalizerIn, TFinalizerIn>
    {
        public TFinalizerIn Finalize(IQueryable<TFinalizerIn> queryable) => queryable.Max();
    }
}
