using System.Linq;

namespace NPredicateBuilder.Paging
{
    public class Take<TFinalizerIn> : IMultipleFinalizer<TFinalizerIn, TFinalizerIn>
    {
        private readonly int _count;

        public Take(int count) => _count = count;

        public IQueryable<TFinalizerIn> Finalize(IQueryable<TFinalizerIn> queryable) => queryable.Take(_count);
    }
}
