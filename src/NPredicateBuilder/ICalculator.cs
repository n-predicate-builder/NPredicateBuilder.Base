using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder
{
    public interface ICalculation
    {
        decimal Calculate<T>(IQueryable<T> queryable);
        Task<decimal> CalculateAsync<T>(IQueryable<T> queryable);
    }
}
