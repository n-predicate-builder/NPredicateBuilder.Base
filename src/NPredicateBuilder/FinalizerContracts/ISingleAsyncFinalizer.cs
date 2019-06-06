using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder.FinalizerContracts
{
    public interface ISingleAsyncFinalizer<T>
    {
        Task<T> FinalizeAsync(IQueryable<T> queryable);
    }
}
