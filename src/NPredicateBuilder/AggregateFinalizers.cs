using NPredicateBuilder.Aggregation;

namespace NPredicateBuilder
{
    public static class AggregateFinalizers
    {
        public static IIntFinalizer<T> Count<T>() => new Count<T>();

        public static ILongFinalizer<T> LongCount<T>() => new LongCount<T>();

        public static ISingleFinalizer<T> Min<T>() => new Min<T>();

        public static ISingleFinalizer<T> Max<T>() => new Max<T>();
    }
}
