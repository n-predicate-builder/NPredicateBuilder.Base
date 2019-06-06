using System.Linq;
using NPredicateBuilder.FinalizerContracts;

namespace NPredicateBuilder.Paging
{
    internal class Skip<T> : IMultipleFinalizer<T>
    {
        private readonly int _count;

        public Skip(int count) => _count = count;

        public IQueryable<T> Finalize(IQueryable<T> queryable) => queryable.Skip(_count);
    }
}
