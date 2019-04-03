using System.Linq;

namespace NPredicateBuilder.Ordering
{
    public interface IOrder<T>
    {
        IOrderedQueryable<T> Order(IQueryable<T> queryable);
    }
}
