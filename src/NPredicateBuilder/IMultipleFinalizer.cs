using System.Linq;

namespace NPredicateBuilder
{
    public interface IMultipleFinalizer<T>
    {
        IQueryable<T> Finalize(IQueryable<T> queryable);
    }
}
