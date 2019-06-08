using System.Linq;

namespace NPredicateBuilder
{
    public interface ISingleFinalizer<in TSource, out TResult>
    {
        TResult Finalize(IQueryable<TSource> queryable);     
    }
}
