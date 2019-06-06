using System.Linq;
using NPredicateBuilder.FinalizerContracts;

namespace NPredicateBuilder.Aggregation
{
    internal class Max<T> : ISingleFinalizer<T>
    {
        public T Finalize(IQueryable<T> queryable) => queryable.Max();
    }
}
