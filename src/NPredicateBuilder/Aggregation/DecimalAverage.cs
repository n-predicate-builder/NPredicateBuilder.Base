using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class DecimalAverage : ISingleFinalizer<decimal, decimal>
    {
        public decimal Finalize(IQueryable<decimal> queryable) => queryable.Average();
    }
}
