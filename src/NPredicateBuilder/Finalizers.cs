using System;
using System.Linq.Expressions;
using NPredicateBuilder.Aggregation;
using NPredicateBuilder.Paging;

namespace NPredicateBuilder
{
    public static class Finalizers
    {
        public static ISingleFinalizer<TFinalizerIn, int> Count<TFinalizerIn>() => new Count<TFinalizerIn>();
        public static ISingleFinalizer<TFinalizerIn, long> LongCount<TFinalizerIn>() => new LongCount<TFinalizerIn>();
        public static ISingleFinalizer<TFinalizerIn, TFinalizerIn> Min<TFinalizerIn>() => new Min<TFinalizerIn>();
        public static ISingleFinalizer<TFinalizerIn, TFinalizerIn> Max<TFinalizerIn>() => new Max<TFinalizerIn>();
        public static ISingleFinalizer<TFinalizerIn, TFinalizerIn> First<TFinalizerIn>(Expression<Func<TFinalizerIn, bool>> finalizerExpression) => new First<TFinalizerIn>(finalizerExpression);
        public static ISingleFinalizer<TFinalizerIn, TFinalizerIn> First<TFinalizerIn>() => new First<TFinalizerIn>();
        public static ISingleFinalizer<TFinalizerIn, TFinalizerIn> FirstOrDefault<TFinalizerIn>(Expression<Func<TFinalizerIn, bool>> finalizerExpression) => new FirstOrDefault<TFinalizerIn>(finalizerExpression);
        public static ISingleFinalizer<TFinalizerIn, TFinalizerIn> FirstOrDefault<TFinalizerIn>() => new FirstOrDefault<TFinalizerIn>();
        public static ISingleFinalizer<TFinalizerIn, TFinalizerIn> Single<TFinalizerIn>(Expression<Func<TFinalizerIn, bool>> finalizerExpression) => new Single<TFinalizerIn>(finalizerExpression);
        public static ISingleFinalizer<TFinalizerIn, TFinalizerIn> Single<TFinalizerIn>() => new Single<TFinalizerIn>();
        public static ISingleFinalizer<TFinalizerIn, TFinalizerIn> SingleOrDefault<TFinalizerIn>(Expression<Func<TFinalizerIn, bool>> finalizerExpression) => new SingleOrDefault<TFinalizerIn>(finalizerExpression);
        public static ISingleFinalizer<TFinalizerIn, TFinalizerIn> SingleOrDefault<TFinalizerIn>() => new SingleOrDefault<TFinalizerIn>();
        public static IMultipleFinalizer<TFinalizerIn, TFinalizerIn> Skip<TFinalizerIn>(int count) => new Skip<TFinalizerIn>(count);
        public static IMultipleFinalizer<TFinalizerIn, TFinalizerIn> Take<TFinalizerIn>(int count) => new Take<TFinalizerIn>(count);
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
