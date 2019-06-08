using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class DoubleSum : ISingleFinalizer<double, double>
    {
        public double Finalize(IQueryable<double> queryable) => queryable.Sum();
    }
}
