using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Paging
{
    internal class FirstOrDefault<TSource> : BaseFinalizer<TSource>, ISingleFinalizer<TSource, TSource>
    {
        public FirstOrDefault(Expression<Func<TSource, bool>> finalizerExpression = null) : base(finalizerExpression) { }

        public TSource Finalize(IQueryable<TSource> queryable)
        {
            return FinalizerExpression == null ? queryable.FirstOrDefault() : queryable.FirstOrDefault(FinalizerExpression);
        }
    }
}
