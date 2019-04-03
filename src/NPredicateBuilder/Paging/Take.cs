using System.Linq;

namespace NPredicateBuilder.Paging
{
    internal class Take<T> : IMultipleFinalizer<T>
    {
        private readonly int _count;

        public Take(int count)
        {
            _count = count;
        }

        public IQueryable<T> Finalize(IQueryable<T> queryable)
        {
            return queryable.Take(_count);
        }
    }
}
