using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder
{
    public interface ISingleAsyncFinalizer<in TSource, TResult>
    {
        Task<TResult> FinalizeAsync(IQueryable<TSource> queryable);
    }
}
