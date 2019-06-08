using System;
using System.Linq.Expressions;

namespace NPredicateBuilder
{
    public abstract class BaseFinalizer<TSource>
    {
        protected readonly Expression<Func<TSource, bool>> FinalizerExpression;

        protected BaseFinalizer(Expression<Func<TSource, bool>> finalizerExpression) => FinalizerExpression = finalizerExpression;
    }
}
