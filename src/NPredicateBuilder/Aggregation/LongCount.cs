using System;
using System.Linq;
using System.Linq.Expressions;
using NPredicateBuilder.FinalizerContracts;

namespace NPredicateBuilder.Aggregation
{
    internal class LongCount<T> : ILongFinalizer<T>
    {
        private readonly Expression<Func<T, bool>> _finalizerExpression;

        public LongCount(Expression<Func<T, bool>> finalizerExpression) => _finalizerExpression = finalizerExpression;

        public long Finalize(IQueryable<T> queryable)
        {
            return _finalizerExpression == null ? queryable.LongCount() : queryable.LongCount(_finalizerExpression);
        }
    }
}
