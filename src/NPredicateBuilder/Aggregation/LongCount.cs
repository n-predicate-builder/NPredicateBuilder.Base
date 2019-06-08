using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class LongCount<TSource> : ISingleFinalizer<TSource, long>
    {
        public long Finalize(IQueryable<TSource> queryable) => queryable.LongCount();
    }
}
