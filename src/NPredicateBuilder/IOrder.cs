using System.Linq;

namespace NPredicateBuilder
{ 
    public interface IOrder<T>
    {
        IOrderedQueryable<T> Order(IQueryable<T> queryable);
    }
}
