using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class Max<T> : ISingleFinalizer<T>
    {
        public T Finalize(IQueryable<T> queryable) => queryable.Max();
    }
}
