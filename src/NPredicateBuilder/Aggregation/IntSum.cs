using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class IntSum : ISingleFinalizer<int, int>
    {
        public int Finalize(IQueryable<int> queryable) => queryable.Sum();
    }
}
