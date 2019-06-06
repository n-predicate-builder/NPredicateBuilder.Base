using System;
using System.Linq;
using System.Linq.Expressions;
using NPredicateBuilder.FinalizerContracts;

namespace NPredicateBuilder.Aggregation
{
    internal class Count<T> : IIntFinalizer<T>
    {
        private readonly Expression<Func<T, bool>> _finalizerExpression;

        public Count(Expression<Func<T, bool>> finalizerExpression) => _finalizerExpression = finalizerExpression;

        public int Finalize(IQueryable<T> queryable)
        {
            return _finalizerExpression == null ? queryable.Count() : queryable.Count(_finalizerExpression);
        }
    }
}
