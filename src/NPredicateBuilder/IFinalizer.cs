using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder
{
    public interface IFinalizer<T>
    {
        T Finalize(IQueryable<T> queryable);
        Task<T> FinalizeAsync(IQueryable<T> queryable);
    }
}
