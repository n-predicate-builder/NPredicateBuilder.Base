using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Paging
{
    public class First<TFinalizerIn> : BaseFinalizer<TFinalizerIn>, ISingleFinalizer<TFinalizerIn, TFinalizerIn>
    {
        public First(Expression<Func<TFinalizerIn, bool>> finalizerExpression = null) : base(finalizerExpression) { }

        public TFinalizerIn Finalize(IQueryable<TFinalizerIn> queryable)
        {
            return FinalizerExpression == null ? queryable.First() : queryable.First(FinalizerExpression);
        }
    }
}
