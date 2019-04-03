using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder
{
    public interface IAsyncSingleFinalizer<T>
    {
        Task<T> FinalizeAsync(IQueryable<T> queryable);
    }
}
