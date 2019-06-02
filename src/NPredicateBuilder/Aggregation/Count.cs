using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class Count<T> : IIntFinalizer<T>
    {
        public int Finalize(IQueryable<T> queryable) => queryable.Count();
    }
}
