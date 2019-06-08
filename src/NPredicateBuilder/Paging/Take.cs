using System.Linq;

namespace NPredicateBuilder.Paging
{
    internal class Take<TSource> : IMultipleFinalizer<TSource, TSource>
    {
        private readonly int _count;

        public Take(int count) => _count = count;

        public IQueryable<TSource> Finalize(IQueryable<TSource> queryable) => queryable.Take(_count);
    }
}
