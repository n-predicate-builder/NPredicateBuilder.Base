namespace NPredicateBuilder
{
    using System.Collections.Generic;
    using System.Linq;

    public interface IOrder<T>
    {
        IOrderedQueryable<T> Order(IQueryable<T> queryable);

        IOrderedEnumerable<T> Order(IEnumerable<T> enumerable);
    }
}