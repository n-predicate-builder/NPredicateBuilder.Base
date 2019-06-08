using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class IntSum : ISingleFinalizer<int, int>
    {
        public int Finalize(IQueryable<int> queryable) => queryable.Sum();
    }
}
