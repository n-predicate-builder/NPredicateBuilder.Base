using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Paging
{
    internal class First<T> : ISingleFinalizer<T>
    {
        private readonly Expression<Func<T, bool>> _finalizerExpression;

        public First(Expression<Func<T, bool>> finalizerExpression)
        {
            _finalizerExpression = finalizerExpression;
        }

        public T Finalize(IQueryable<T> queryable)
        {
            return _finalizerExpression == null ? queryable.First() : queryable.First(_finalizerExpression);
        }
    }
}
