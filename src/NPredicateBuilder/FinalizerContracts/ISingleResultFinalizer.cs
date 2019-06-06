using System.Linq;

namespace NPredicateBuilder.FinalizerContracts
{
    public interface ISingleResultFinalizer<in TSource, out TResult>
    {
        TResult Finalize(IQueryable<TSource> queryable);
    }
}
