using System.Linq;

namespace NPredicateBuilder.FinalizerContracts
{
    public interface ISingleFinalizer<T>
    {
        T Finalize(IQueryable<T> queryable);     
    }
}
