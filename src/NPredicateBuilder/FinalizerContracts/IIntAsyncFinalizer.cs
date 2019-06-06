using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder.FinalizerContracts
{
    public interface IIntAsyncFinalizer<in T>
    {
        Task<int> FinalizeAsync(IQueryable<T> queryable);
    }
}
