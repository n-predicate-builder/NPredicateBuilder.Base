using System;
using System.Linq;
using System.Linq.Expressions;
using NPredicateBuilder.FinalizerContracts;

namespace NPredicateBuilder.Aggregation
{
    internal class ResultMin<TSource, TResult> : ISingleResultFinalizer<TSource, TResult>
    {
        private readonly Expression<Func<TSource, TResult>> _finalizerExpression;

        public ResultMin(Expression<Func<TSource, TResult>> finalizerExpression)
        {
            _finalizerExpression = finalizerExpression;
        }

        public TResult Finalize(IQueryable<TSource> queryable) => queryable.Min(_finalizerExpression);
    }
}
