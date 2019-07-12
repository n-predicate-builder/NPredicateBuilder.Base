using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Paging
{
    internal class SingleOrDefault<TFinalizerIn> : BaseFinalizer<TFinalizerIn>, ISingleFinalizer<TFinalizerIn, TFinalizerIn>
    {
        public SingleOrDefault(Expression<Func<TFinalizerIn, bool>> finalizerExpression = null) : base(finalizerExpression) { }

        public TFinalizerIn Finalize(IQueryable<TFinalizerIn> queryable)
        {
            return FinalizerExpression == null ? queryable.SingleOrDefault() : queryable.SingleOrDefault(FinalizerExpression);
        }
    }
}
