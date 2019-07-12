using System.Linq;

namespace NPredicateBuilder
{
    public interface IMultipleFinalizer<in TFinalizerIn, out TFinalizerOut>
    {
        IQueryable<TFinalizerOut> Finalize(IQueryable<TFinalizerIn> queryable);
    }
}
