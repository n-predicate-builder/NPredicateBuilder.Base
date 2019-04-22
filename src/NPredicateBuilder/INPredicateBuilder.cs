using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPredicateBuilder.Ordering;

namespace NPredicateBuilder
{
    public interface INPredicateBuilder<T>
    { 
        /// <summary>
        /// A single entity query that accepts a BaseQuery and Finalizer.
        /// </summary>
        /// <param name="baseQuery">A BaseQuery object.</param>
        /// <param name="singleFinalizer">A SingleFinalizer object.</param>
        /// <returns>An object of type T from the result of a query.</returns>
        T Entity(BaseQuery<T> baseQuery, ISingleFinalizer<T> singleFinalizer);

        /// <summary>
        /// A single entity query that accepts a BaseQuery, BaseOrder, and Finalizer.
        /// </summary>
        /// <param name="baseQuery">A BaseQuery object.</param>
        /// <param name="baseOrder">A BaseOrder object.</param>
        /// <param name="singleFinalizer">A SingleFinalizer object.</param>
        /// <returns>An object of type T from the result of a query.</returns>
        T Entity(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder, ISingleFinalizer<T> singleFinalizer);

        /// <summary>
        /// An async single entity query that accepts a BaseQuery and Finalizer.
        /// </summary>
        /// <param name="baseQuery">A BaseQuery object.</param>
        /// <param name="singleFinalizer">A SingleFinalizer object.</param>
        /// <returns>A Task of type T from the result of a query.</returns>
        Task<T> EntityAsync(BaseQuery<T> baseQuery, IAsyncSingleFinalizer<T> singleFinalizer);

        /// <summary>
        /// An async single entity query that accepts a BaseQuery, BaseOrder, and Finalizer.
        /// </summary>
        /// <param name="baseQuery">A BaseQuery object.</param>
        /// <param name="baseOrder">A BaseOrder object.</param>
        /// <param name="singleFinalizer">A SingleFinalizer object.</param>
        /// <returns>A Task of type T from the result of a query.</returns>
        Task<T> EntityAsync(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder, IAsyncSingleFinalizer<T> singleFinalizer);

        /// <summary>
        /// A query that returns an IEnumerable of type T from a BaseQuery and optional Finalizer.
        /// </summary>
        /// <param name="baseQuery">The BaseQuery object.</param>
        /// <param name="multipleFinalizer">The optional MultipleFinalizer object.</param>
        /// <returns>An IEnumerable of type T from the result of a query.</returns>
        IEnumerable<T> EntitiesEnumerable(BaseQuery<T> baseQuery, IMultipleFinalizer<T> multipleFinalizer = default);

        /// <summary>
        /// A query that returns an IEnumerable of type T from a BaseQuery, BaseOrder, and optional Finalizer.
        /// </summary>
        /// <param name="baseQuery">The BaseQuery object.</param>
        /// <param name="baseOrder">The BaseOrder object.</param>
        /// <param name="multipleFinalizer">The optional MultipleFinalizer object.</param>
        /// <returns>An IEnumerable of type T from the result of a query.</returns>
        IEnumerable<T> EntitiesEnumerable(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder, IMultipleFinalizer<T> multipleFinalizer = default);

        /// <summary>
        /// A query that returns an IQueryable of type T from a BaseQuery and optional Finalizer.
        /// </summary>
        /// <param name="baseQuery">The BaseQuery object.</param>
        /// <param name="multipleFinalizer">The optional MultipleFinalizer object.</param>
        /// <returns>An IQueryable of type T from the result of a query.</returns>
        IQueryable<T> EntitiesQueryable(BaseQuery<T> baseQuery, IMultipleFinalizer<T> multipleFinalizer = default);

        /// <summary>
        /// A query that returns an IQueryable of type T from a BaseQuery, BaseOrder, and optional Finalizer.
        /// </summary>
        /// <param name="baseQuery">The BaseQuery object.</param>
        /// <param name="baseOrder">The BaseOrder object.</param>
        /// <param name="multipleFinalizer">The optional MultipleFinalizer object.</param>
        /// <returns>An IQueryable of type T from the result of a query.</returns>
        IQueryable<T> EntitiesQueryable(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder, IMultipleFinalizer<T> multipleFinalizer = default);

        /// <summary>
        /// A query that returns a List of type T from a BaseQuery and optional Finalizer.
        /// </summary>
        /// <param name="baseQuery">A BaseQuery object.</param>
        /// <param name="multipleFinalizer">A MultipleFinalizer object.</param>
        /// <returns>A List of type T from the result of a query.</returns>
        List<T> EntitiesList(BaseQuery<T> baseQuery, IMultipleFinalizer<T> multipleFinalizer = default);

        /// <summary>
        /// A query that returns a List of type T from a BaseQuery, BaseOrder, and optional Finalizer.
        /// </summary>
        /// <param name="baseQuery">A BaseQuery object.</param>
        /// <param name="baseOrder">A BaseOrder object.</param>
        /// <param name="multipleFinalizer">A MultipleFinalizer object.</param>
        /// <returns>A List of type T from the result of a query.</returns>
        List<T> EntitiesList(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder, IMultipleFinalizer<T> multipleFinalizer = default);

        /// <summary>
        /// A query that returns a Task of List of type T from a BaseQuery and optional Finalizer.
        /// </summary>
        /// <param name="baseQuery">A BaseQuery object.</param>
        /// <param name="multipleFinalizer">A MultipleFinalizer object.</param>
        /// <returns>A Task of List of type T from the result of a query.</returns>
        Task<List<T>> EntitiesListAsync(BaseQuery<T> baseQuery, IMultipleFinalizer<T> multipleFinalizer = default);

        /// <summary>
        /// A query that returns a Task of List of type T from a BaseQuery, BaseOrder, and optional Finalizer.
        /// </summary>
        /// <param name="baseQuery">A BaseQuery object.</param>
        /// <param name="baseOrder">A BaseOrder object.</param>
        /// <param name="multipleFinalizer">A MultipleFinalizer object.</param>
        /// <returns>A Task of List of type T from the result of a query.</returns>
        Task<List<T>> EntitiesListAsync(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder, IMultipleFinalizer<T> multipleFinalizer = default);
    }
}
