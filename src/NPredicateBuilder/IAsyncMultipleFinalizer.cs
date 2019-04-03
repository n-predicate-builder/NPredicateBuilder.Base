using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder
{
    public interface IAsyncMultipleFinalizer<T>
    {
        Task<IQueryable<T>> FinalizeAsync(IQueryable<T> queryable);
    }
}
