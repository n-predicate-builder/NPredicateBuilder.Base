using System.Linq;

namespace NPredicateBuilder
{
    public interface IIntFinalizer<in T>
    {
        int Finalize(IQueryable<T> queryable);
    }
}
