using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class Min<TSource> : ISingleFinalizer<TSource, TSource>
    {
        public TSource Finalize(IQueryable<TSource> queryable) => queryable.Min();
    }
}
