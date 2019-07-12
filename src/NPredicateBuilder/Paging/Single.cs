using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Paging
{
    internal class Single<TFinalizerIn> : BaseFinalizer<TFinalizerIn>, ISingleFinalizer<TFinalizerIn, TFinalizerIn>
    {
        public Single(Expression<Func<TFinalizerIn, bool>> finalizerExpression = null) : base(finalizerExpression) { }

        public TFinalizerIn Finalize(IQueryable<TFinalizerIn> queryable)
        {
            return FinalizerExpression == null ? queryable.Single() : queryable.Single(FinalizerExpression);
        }
    }
}
