using System;
using System.Linq.Expressions;
using NPredicateBuilder.Aggregation;
using NPredicateBuilder.FinalizerContracts;
using NPredicateBuilder.Paging;

namespace NPredicateBuilder
{
    public static class Finalizers
    {
        //Aggregate Methods

        public static IIntFinalizer<T> Count<T>(Expression<Func<T, bool>> finalizerExpression = default) => new Count<T>(finalizerExpression);

        public static ILongFinalizer<T> LongCount<T>(Expression<Func<T, bool>> finalizerExpression = default) => new LongCount<T>(finalizerExpression);

        public static ISingleFinalizer<T> Min<T>() => new Min<T>();

        public static ISingleResultFinalizer<TSource, TResult>Min<TSource, TResult>(Expression<Func<TSource, TResult>> finalizerExpression) => new ResultMin<TSource, TResult>(finalizerExpression);

        public static ISingleFinalizer<T> Max<T>() => new Max<T>();

        //Paging Methods

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
