using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class Max<TSource> : ISingleFinalizer<TSource, TSource>
    {
        public TSource Finalize(IQueryable<TSource> queryable) => queryable.Max();
    }
}
