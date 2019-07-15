using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class IntAverage : ISingleFinalizer<int, double>
    {
        public double Finalize(IQueryable<int> queryable) => queryable.Average();
    }
}
