using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class LongAverage : ISingleFinalizer<long, double>
    {
        public double Finalize(IQueryable<long> queryable) => queryable.Average();
    }
}
