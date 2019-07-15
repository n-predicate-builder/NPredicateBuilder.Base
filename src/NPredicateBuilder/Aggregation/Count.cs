using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class Count<TFinalizerIn> : ISingleFinalizer<TFinalizerIn, int>
    {
        public int Finalize(IQueryable<TFinalizerIn> queryable) => queryable.Count();
    }
}
