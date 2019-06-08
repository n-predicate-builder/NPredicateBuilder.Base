using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class IntAverage : ISingleFinalizer<int, double>
    {
        public double Finalize(IQueryable<int> queryable) => queryable.Average();
    }
}
