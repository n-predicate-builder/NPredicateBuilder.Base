using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Paging
{
    internal class Single<TSource> : BaseFinalizer<TSource>, ISingleFinalizer<TSource, TSource>
    {
        public Single(Expression<Func<TSource, bool>> finalizerExpression = null) : base(finalizerExpression) { }

        public TSource Finalize(IQueryable<TSource> queryable)
        {
            return FinalizerExpression == null ? queryable.Single() : queryable.Single(FinalizerExpression);
        }
    }
}
