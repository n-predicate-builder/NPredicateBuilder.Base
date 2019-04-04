using System.Linq;

namespace NPredicateBuilder.Ordering
{
    public interface IThenByOrder<T>
    {
        IOrderedQueryable<T> Order(IOrderedQueryable<T> orderedQueryable);
    }
}
