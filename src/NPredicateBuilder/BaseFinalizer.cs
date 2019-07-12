using System;
using System.Linq.Expressions;

namespace NPredicateBuilder
{
    public abstract class BaseFinalizer<TFinalizerIn>
    {
        protected readonly Expression<Func<TFinalizerIn, bool>> FinalizerExpression;

        protected BaseFinalizer(Expression<Func<TFinalizerIn, bool>> finalizerExpression) => FinalizerExpression = finalizerExpression;
    }
}
