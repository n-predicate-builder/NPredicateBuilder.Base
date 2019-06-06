using System;
using System.Linq;
using System.Linq.Expressions;
using NPredicateBuilder.FinalizerContracts;

namespace NPredicateBuilder.Paging
{
    internal class SingleOrDefault<T> : ISingleFinalizer<T>
    {
        private readonly Expression<Func<T, bool>> _finalizerExpression;

        public SingleOrDefault(Expression<Func<T, bool>> finalizerExpression) => _finalizerExpression = finalizerExpression;

        public T Finalize(IQueryable<T> queryable)
        {
            return _finalizerExpression == null ? queryable.SingleOrDefault() : queryable.SingleOrDefault(_finalizerExpression);
        }
    }
}
