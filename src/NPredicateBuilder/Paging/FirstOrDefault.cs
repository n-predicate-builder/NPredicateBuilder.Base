using System;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Paging
{
    public class FirstOrDefault<TFinalizerIn> : BaseFinalizer<TFinalizerIn>, ISingleFinalizer<TFinalizerIn, TFinalizerIn>
    {
        public FirstOrDefault(Expression<Func<TFinalizerIn, bool>> finalizerExpression = null) : base(finalizerExpression) { }

        public TFinalizerIn Finalize(IQueryable<TFinalizerIn> queryable)
        {
            return FinalizerExpression == null ? queryable.FirstOrDefault() : queryable.FirstOrDefault(FinalizerExpression);
        }
    }
}
