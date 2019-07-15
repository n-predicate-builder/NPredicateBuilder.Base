using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class NullableDoubleAverage : ISingleFinalizer<double?, double?>
    {
        public double? Finalize(IQueryable<double?> queryable) => queryable.Average();
    }
}
