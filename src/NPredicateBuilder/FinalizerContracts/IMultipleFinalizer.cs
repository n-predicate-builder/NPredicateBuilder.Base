using System.Linq;

namespace NPredicateBuilder.FinalizerContracts
{
    public interface IMultipleFinalizer<T>
    {
        IQueryable<T> Finalize(IQueryable<T> queryable);
    }
}
