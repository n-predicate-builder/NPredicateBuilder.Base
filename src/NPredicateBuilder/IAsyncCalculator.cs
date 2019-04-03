using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder
{
    public interface IAsyncCalculator<in T>
    {
        Task<decimal> CalculateAsync(IQueryable<T> queryable);
    }
}
