using System.Linq;

namespace NPredicateBuilder
{
    public interface ISingleFinalizer<in TFinalizerIn, out IFinalizerOut>
    {
        IFinalizerOut Finalize(IQueryable<TFinalizerIn> queryable);     
    }
}
