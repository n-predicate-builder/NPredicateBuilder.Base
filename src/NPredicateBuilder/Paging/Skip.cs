using System.Linq;

namespace NPredicateBuilder.Paging
{
    internal class Skip<TFinalizerIn> : IMultipleFinalizer<TFinalizerIn, TFinalizerIn>
    {
        private readonly int _count;

        public Skip(int count) => _count = count;

        public IQueryable<TFinalizerIn> Finalize(IQueryable<TFinalizerIn> queryable) => queryable.Skip(_count);
    }
}
