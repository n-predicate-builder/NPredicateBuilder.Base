using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder
{
    public interface ISingleAsyncFinalizer<in TFinalizerIn, TFinalizerOut>
    {
        Task<TFinalizerOut> FinalizeAsync(IQueryable<TFinalizerIn> queryable);
    }
}
