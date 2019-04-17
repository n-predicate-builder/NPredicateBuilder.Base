using System.Linq;

namespace NPredicateBuilder
{
    public interface ICalculator
    {
        decimal Calculate(IQueryable<decimal> queryable);
        double Calculate(IQueryable<double> queryable);
        double Calculate(IQueryable<int> queryable);
        double Calculate(IQueryable<long> queryable);
        float Calculate(IQueryable<float> queryable);
        decimal? Calculate(IQueryable<decimal?> queryable);
        double? Calculate(IQueryable<double?> queryable);
        double? Calculate(IQueryable<int?> queryable);
        double? Calculate(IQueryable<long?> queryable);
        float? Calculate(IQueryable<float?> queryable);
    }
}
