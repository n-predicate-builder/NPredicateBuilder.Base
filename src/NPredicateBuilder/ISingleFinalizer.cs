using System.Linq;

namespace NPredicateBuilder
{
    public interface ISingleFinalizer<T>
    {
        T Finalize(IQueryable<T> queryable);     
    }
}
