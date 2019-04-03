using NPredicateBuilder.Paging;

namespace NPredicateBuilder
{
    public static class MultipleFinalizers
    {
        public static IMultipleFinalizer<T> Skip<T>(int count)
        {
            return new Skip<T>(count);
        }

        public static IMultipleFinalizer<T> Take<T>(int count)
        {
            return new Take<T>(count);
        }
    }
}
