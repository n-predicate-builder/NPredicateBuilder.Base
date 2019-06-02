using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder
{
    public interface ILongAsyncFinalizer<in T>
    {
        Task<long> FinalizeAsync(IQueryable<T> queryable);
    }
}
