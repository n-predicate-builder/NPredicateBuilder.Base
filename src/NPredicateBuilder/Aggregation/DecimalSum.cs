using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class DecimalSum : ISingleFinalizer<decimal, decimal>
    {
        public decimal Finalize(IQueryable<decimal> queryable) => queryable.Sum();
    }
}
