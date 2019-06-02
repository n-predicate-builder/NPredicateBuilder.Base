using System.Linq;

namespace NPredicateBuilder
{
    public interface ILongFinalizer<in T>
    {
        long Finalize(IQueryable<T> queryable);
    }
}
