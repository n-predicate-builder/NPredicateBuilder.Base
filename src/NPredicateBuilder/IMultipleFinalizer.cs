using System.Linq;

namespace NPredicateBuilder
{
    public interface IMultipleFinalizer<in TSource, out TResult>
    {
        IQueryable<TResult> Finalize(IQueryable<TSource> queryable);
    }
}
