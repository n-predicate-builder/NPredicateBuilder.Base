using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Organizers
{
    public class ThenBy<T, TKey> : IOrganizer<T>
    {
        private readonly Expression<Func<T, TKey>> _organizerExpression;

        public ThenBy(Expression<Func<T, TKey>> organizerExpression)
        {
            _organizerExpression = organizerExpression;
        }

        public IOrderedQueryable<T> Organize(IQueryable<T> queryable)
        {
            var asOrdered = (IOrderedQueryable<T>)queryable;

            return asOrdered.ThenBy(_organizerExpression);
        }
    }
}
