using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class Min<T> : ISingleFinalizer<T>
    {
        public T Finalize(IQueryable<T> queryable) => queryable.Min();
    }
}
