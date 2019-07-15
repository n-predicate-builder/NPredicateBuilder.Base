using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    public class NullableLongAverage : ISingleFinalizer<long?, double?>
    {
        public double? Finalize(IQueryable<long?> queryable) => queryable.Average();
    }
}
