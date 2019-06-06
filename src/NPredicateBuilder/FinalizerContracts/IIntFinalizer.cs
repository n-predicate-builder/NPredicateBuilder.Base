using System.Linq;

namespace NPredicateBuilder.FinalizerContracts
{
    public interface IIntFinalizer<in T>
    {
        int Finalize(IQueryable<T> queryable);
    }
}
