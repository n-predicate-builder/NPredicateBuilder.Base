using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class Count<TSource> : ISingleFinalizer<TSource, int>
    {
        public int Finalize(IQueryable<TSource> queryable) => queryable.Count();
    }
}
