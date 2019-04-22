using System;
using System.Linq.Expressions;
using NPredicateBuilder.Paging;

namespace NPredicateBuilder
{
    public static class SingleFinalizers
    {
        /// <summary>
        /// Creates a finalizer that will execute a First operation.
        /// </summary>
        /// <typeparam name="T">The type that you are querying against.</typeparam>
        /// <param name="finalizerExpression">An optional expression that will execute inside the first operation.</param>
        /// <returns>A first finalizer of type T.</returns>
        public static ISingleFinalizer<T> First<T>(Expression<Func<T, bool>> finalizerExpression = default) => new First<T>(finalizerExpression);

        /// <summary>
        /// Creates a finalizer that will execute the First Or Default operation.
        /// </summary>
        /// <typeparam name="T">The type that you are querying against.</typeparam>
        /// <param name="finalizerExpression">An optional expression that will execute inside the first or default operation.</param>
        /// <returns>A first or default finalizer of type T.</returns>
        public static ISingleFinalizer<T> FirstOrDefault<T>(Expression<Func<T, bool>> finalizerExpression = default) => new FirstOrDefault<T>(finalizerExpression);

        /// <summary>
        /// Creates a finalizer that will execute the Single operation.
        /// </summary>
        /// <typeparam name="T">The type that you are querying against.</typeparam>
        /// <param name="finalizerExpression">An optional expression that will execute inside the single operation.</param>
        /// <returns>A single finalizer of type T.</returns>
        public static ISingleFinalizer<T> Single<T>(Expression<Func<T, bool>> finalizerExpression = default) => new Single<T>(finalizerExpression);

        /// <summary>
        /// Creates a finalizer that will execute the Single Or Default operation.
        /// </summary>
        /// <typeparam name="T">The type that you are querying against.</typeparam>
        /// <param name="finalizerExpression">An optional expression that will execute inside the single or default operation.</param>
        /// <returns>A single or default finalizer of type T.</returns>
        public static ISingleFinalizer<T> SingleOrDefault<T>(Expression<Func<T, bool>> finalizerExpression = default) => new SingleOrDefault<T>(finalizerExpression);
    }
}
