using System.Linq;

namespace NPredicateBuilder.Paging
{
    internal class Skip<TSource> : IMultipleFinalizer<TSource, TSource>
    {
        private readonly int _count;

        public Skip(int count) => _count = count;

        public IQueryable<TSource> Finalize(IQueryable<TSource> queryable) => queryable.Skip(_count);
    }
}
