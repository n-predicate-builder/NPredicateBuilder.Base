using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder
{
    public interface IAsyncIntFinalizer<in T>
    {
        Task<int> FinalizeAsync(IQueryable<T> queryable);
    }
}
