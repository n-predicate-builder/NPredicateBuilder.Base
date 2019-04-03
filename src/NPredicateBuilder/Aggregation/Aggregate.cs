using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Aggregation
{
    internal class Aggregate<T> : ISingleFinalizer<T>
    {
        private readonly Expression<Func<T, T, T>> _finalizerExpression;

        public Aggregate(Expression<Func<T, T, T>> finalizerExpression)
        {
            _finalizerExpression = finalizerExpression;
        }

        public T Finalize(IQueryable<T> queryable)
        {
            return queryable.Aggregate(_finalizerExpression);
        }
    }
}
