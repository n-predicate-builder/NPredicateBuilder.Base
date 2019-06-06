using System.Linq;

namespace NPredicateBuilder.FinalizerContracts
{
    public interface ILongFinalizer<in T>
    {
        long Finalize(IQueryable<T> queryable);
    }
}
