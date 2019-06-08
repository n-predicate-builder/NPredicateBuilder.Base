using System;
using System.Linq.Expressions;
using NPredicateBuilder.Aggregation;
using NPredicateBuilder.Paging;

namespace NPredicateBuilder
{
    public static class Finalizers
    {
        public static ISingleFinalizer<TSource, int> Count<TSource>() => new Count<TSource>();
        public static ISingleFinalizer<TSource, long> LongCount<TSource>() => new LongCount<TSource>();
        public static ISingleFinalizer<TSource, TSource> Min<TSource>() => new Min<TSource>();
        public static ISingleFinalizer<TSource, TSource> Max<TSource>() => new Max<TSource>();
        public static ISingleFinalizer<TSource, TSource> First<TSource>(Expression<Func<TSource, bool>> finalizerExpression = default) => new First<TSource>(finalizerExpression);
        public static ISingleFinalizer<TSource, TSource> FirstOrDefault<TSource>(Expression<Func<TSource, bool>> finalizerExpression = default) => new FirstOrDefault<TSource>(finalizerExpression);
        public static ISingleFinalizer<TSource, TSource> Single<TSource>(Expression<Func<TSource, bool>> finalizerExpression = default) => new Single<TSource>(finalizerExpression);
        public static ISingleFinalizer<TSource, TSource> SingleOrDefault<TSource>(Expression<Func<TSource, bool>> finalizerExpression = default) => new SingleOrDefault<TSource>(finalizerExpression);
        public static IMultipleFinalizer<TSource, TSource> Skip<TSource>(int count) => new Skip<TSource>(count);
        public static IMultipleFinalizer<TSource, TSource> Take<TSource>(int count) => new Take<TSource>(count);
        public static ISingleFinalizer<decimal, decimal> DecimalAverage() => new DecimalAverage();
        public static ISingleFinalizer<double, double> DoubleAverage() => new DoubleAverage();
        public static ISingleFinalizer<int, double> IntAverage() => new IntAverage();
        public static ISingleFinalizer<long, double> LongAverage() => new LongAverage();
        public static ISingleFinalizer<float, float> FloatAverage() => new FloatAverage();
        public static ISingleFinalizer<decimal?, decimal?> NullableDecimalAverage() => new NullableDecimalAverage();
        public static ISingleFinalizer<double?, double?> NullableDoubleAverage() => new NullableDoubleAverage();
        public static ISingleFinalizer<int?, double?> NullableIntAverage() => new NullableIntAverage();
        public static ISingleFinalizer<long?, double?> NullableLongAverage() => new NullableLongAverage();
        public static ISingleFinalizer<float?, float?> NullableFloatAverage() => new NullableFloatAverage();
        public static ISingleFinalizer<decimal, decimal> DecimalSum() => new DecimalSum();
        public static ISingleFinalizer<double, double> DoubleSum() => new DoubleSum();
        public static ISingleFinalizer<int, int> IntSum() => new IntSum();
        public static ISingleFinalizer<long, long> LongSum() => new LongSum();
        public static ISingleFinalizer<float, float> FloatSum() => new FloatSum();
        public static ISingleFinalizer<decimal?, decimal?> NullableDecimalSum() => new NullableDecimalSum();
        public static ISingleFinalizer<double?, double?> NullableDoubleSum() => new NullableDoubleSum();
        public static ISingleFinalizer<int?, int?> NullableIntSum() => new NullableIntSum();
        public static ISingleFinalizer<long?, long?> NullableLongSum() => new NullableLongSum();
        public static ISingleFinalizer<float?, float?> NullableFloatSum() => new NullableFloatSum();
    }
}
