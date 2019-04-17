using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder
{
    public interface IAsyncCalculator<in T>
    {
        Task<decimal> Calculate(IQueryable<decimal> queryable);
        Task<double> Calculate(IQueryable<double> queryable);
        Task<double> Calculate(IQueryable<int> queryable);
        Task<double> Calculate(IQueryable<long> queryable);
        Task<float> Calculate(IQueryable<float> queryable);
        Task<decimal?> Calculate(IQueryable<decimal?> queryable);
        Task<double?> Calculate(IQueryable<double?> queryable);
        Task<double?> Calculate(IQueryable<int?> queryable);
        Task<double?> Calculate(IQueryable<long?> queryable);
        Task<float?> Calculate(IQueryable<float?> queryable);
    }
}
