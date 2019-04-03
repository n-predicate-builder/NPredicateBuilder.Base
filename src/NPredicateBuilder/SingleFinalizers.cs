using System;
using System.Linq.Expressions;
using NPredicateBuilder.Aggregation;
using NPredicateBuilder.Paging;

namespace NPredicateBuilder
{
    public static class SingleFinalizers
    {
        public static ISingleFinalizer<T> First<T>(Expression<Func<T, bool>> finalizerExpression = default)
        {
            return new First<T>(finalizerExpression);
        }

        public static ISingleFinalizer<T> FirstOrDefault<T>(Expression<Func<T, bool>> finalizerExpression = default)
        {
            return new FirstOrDefault<T>(finalizerExpression);
        }

        public static ISingleFinalizer<T> Single<T>(Expression<Func<T, bool>> finalizerExpression = default)
        {
            return new Single<T>(finalizerExpression);
        }

        public static ISingleFinalizer<T> SingleOrDefault<T>(Expression<Func<T, bool>> finalizerExpression = default)
        {
            return new SingleOrDefault<T>(finalizerExpression);
        }

        public static ISingleFinalizer<T> Aggregate<T>(Expression<Func<T, T, T>> finalizerExpression)
        {
            return new Aggregate<T>(finalizerExpression);
        }
    }
}
