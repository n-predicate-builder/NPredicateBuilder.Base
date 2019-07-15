using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class Max<TFinalizerIn> : ISingleFinalizer<TFinalizerIn, TFinalizerIn>
    {
        public TFinalizerIn Finalize(IQueryable<TFinalizerIn> queryable) => queryable.Max();
    }
}
