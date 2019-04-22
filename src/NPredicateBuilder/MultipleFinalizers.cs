using NPredicateBuilder.Paging;

namespace NPredicateBuilder
{
    public static class MultipleFinalizers
    {
        /// <summary>
        /// Creates a finalizer that will execute the Skip operation.
        /// </summary>
        /// <typeparam name="T">The type that you are querying against.</typeparam>
        /// <param name="count">The number of entities that you wish to skip.</param>
        /// <returns>A skip finalizer of type T.</returns>
        public static IMultipleFinalizer<T> Skip<T>(int count) => new Skip<T>(count);

        /// <summary>
        /// Creates a finalizer that will execute the Take operation.
        /// </summary>
        /// <typeparam name="T">The type that you are querying against.</typeparam>
        /// <param name="count">The number of entities that you wish to take.</param>
        /// <returns>A take finalizer of type T.</returns>
        public static IMultipleFinalizer<T> Take<T>(int count) => new Take<T>(count);
    }
}
