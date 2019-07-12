using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class Count<TFinalizerIn> : ISingleFinalizer<TFinalizerIn, int>
    {
        public int Finalize(IQueryable<TFinalizerIn> queryable) => queryable.Count();
    }
}
