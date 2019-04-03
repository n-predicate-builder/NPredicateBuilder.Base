using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Organizers
{
    public class OrderByDescending<T, TKey> : IOrganizer<T>
    {
        private readonly Expression<Func<T, TKey>> _organizerExpression;

        public OrderByDescending(Expression<Func<T, TKey>> organizerExpression)
        {
            _organizerExpression = organizerExpression;
        }

        public IOrderedQueryable<T> Organize(IQueryable<T> queryable)
        {
            return queryable.OrderByDescending(_organizerExpression);
        }
    }
}
