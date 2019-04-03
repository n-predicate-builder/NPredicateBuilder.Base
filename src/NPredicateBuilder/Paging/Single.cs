using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Paging
{
    internal class Single<T> : ISingleFinalizer<T>
    {
        private readonly Expression<Func<T, bool>> _finalizerExpression;

        public Single()
        {
            
        }

        public Single(Expression<Func<T, bool>> finalizerExpression)
        {
            _finalizerExpression = finalizerExpression;
        }

        public T Finalize(IQueryable<T> queryable)
        {
            return _finalizerExpression == null ? queryable.Single() : queryable.Single(_finalizerExpression);
        }
    }
}
