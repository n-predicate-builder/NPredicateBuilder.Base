using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Organizers
{
    public class ThenByDescending<T, TKey> : IOrganizer<T>
    {
        private readonly Expression<Func<T, TKey>> _organizerExpression;

        public ThenByDescending(Expression<Func<T, TKey>> organizerExpression)
        {
            _organizerExpression = organizerExpression;
        }

        public IOrderedQueryable<T> Organize(IQueryable<T> queryable)
        {
            var asOrdered = (IOrderedQueryable<T>)queryable;
            return asOrdered.ThenByDescending(_organizerExpression);
        }
    }
}
