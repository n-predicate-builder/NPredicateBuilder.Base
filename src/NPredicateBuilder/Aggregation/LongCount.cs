using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class LongCount<T> : ILongFinalizer<T>
    {
        public long Finalize(IQueryable<T> queryable) => queryable.LongCount();
    }
}
