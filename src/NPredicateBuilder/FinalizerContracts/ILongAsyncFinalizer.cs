using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder.FinalizerContracts
{
    public interface ILongAsyncFinalizer<in T>
    {
        Task<long> FinalizeAsync(IQueryable<T> queryable);
    }
}
