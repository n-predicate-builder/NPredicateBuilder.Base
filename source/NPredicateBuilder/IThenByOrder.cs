namespace NPredicateBuilder
{
    using System.Linq;

    public interface IThenByOrder<T>
    {
        IOrderedQueryable<T> Order(IOrderedQueryable<T> orderedQueryable);

        IOrderedEnumerable<T> Order(IOrderedEnumerable<T> orderedEnumerable);
    }
}