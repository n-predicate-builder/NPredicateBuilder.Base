using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Paging
{
    internal class SingleOrDefault<TSource> : BaseFinalizer<TSource>, ISingleFinalizer<TSource, TSource>
    {
        public SingleOrDefault(Expression<Func<TSource, bool>> finalizerExpression = null) : base(finalizerExpression) { }

        public TSource Finalize(IQueryable<TSource> queryable)
        {
            return FinalizerExpression == null ? queryable.SingleOrDefault() : queryable.SingleOrDefault(FinalizerExpression);
        }
    }
}
