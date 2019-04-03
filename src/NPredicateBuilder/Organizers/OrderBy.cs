using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Organizers
{
    internal class OrderBy<T, TKey> : IOrganizer<T>
    {
        private readonly Expression<Func<T, TKey>> _organizerExpression;

        public OrderBy(Expression<Func<T, TKey>> organizerExpression)
        {
            _organizerExpression = organizerExpression;
        }

        public IOrderedQueryable<T> Organize(IQueryable<T> queryable)
        {
            return queryable.OrderBy(_organizerExpression);
        }
    }
}
