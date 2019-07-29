using System.Linq;

namespace NPredicateBuilder
{
    public interface IThenByOrder<T>
    {
        IOrderedQueryable<T> Order(IOrderedQueryable<T> orderedQueryable);
    }
}
