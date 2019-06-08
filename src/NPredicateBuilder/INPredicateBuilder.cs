using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NPredicateBuilder
{
    public interface INPredicateBuilder
    {
        TResult Entity<TSource, TResult>(BaseQuery<TSource> baseQuery, ISingleFinalizer<TSource, TResult> singleFinalizer);

        TResult Entity<TSource, TResult>(BaseQuery<TSource> baseQuery, BaseOrder<TSource> baseOrder, ISingleFinalizer<TSource, TResult> singleFinalizer);

        Task<TResult> EntityAsync<TSource, TResult>(BaseQuery<TSource> baseQuery, ISingleAsyncFinalizer<TSource, TResult> finalizer);

        Task<TResult> EntityAsync<TSource, TResult>(BaseQuery<TSource> baseQuery, BaseOrder<TSource> baseOrder, ISingleAsyncFinalizer<TSource, TResult> finalizer);

        IEnumerable<TResult> EntitiesEnumerable<TSource, TResult>(BaseQuery<TSource> baseQuery, IMultipleFinalizer<TSource, TResult> multipleFinalizer = default);

        IEnumerable<TResult> EntitiesEnumerable<TSource, TResult>(BaseQuery<TSource> baseQuery, BaseOrder<TSource> baseOrder, IMultipleFinalizer<TSource, TResult> multipleFinalizer = default);

        IQueryable<TResult> EntitiesQueryable<TSource, TResult>(BaseQuery<TSource> baseQuery, IMultipleFinalizer<TSource, TResult> multipleFinalizer = default);

        IQueryable<TResult> EntitiesQueryable<TSource, TResult>(BaseQuery<TSource> baseQuery, BaseOrder<TSource> baseOrder, IMultipleFinalizer<TSource, TResult> multipleFinalizer = default);

        List<TResult> EntitiesList<TSource, TResult>(BaseQuery<TSource> baseQuery, IMultipleFinalizer<TSource, TResult> multipleFinalizer = default);

        List<TResult> EntitiesList<TSource, TResult>(BaseQuery<TSource> baseQuery, BaseOrder<TSource> baseOrder, IMultipleFinalizer<TSource, TResult> multipleFinalizer = default);

        Task<List<TResult>> EntitiesListAsync<TSource, TResult>(BaseQuery<TSource> baseQuery, IMultipleFinalizer<TSource, TResult> multipleFinalizer = default);

        Task<List<TResult>> EntitiesListAsync<TSource, TResult>(BaseQuery<TSource> baseQuery, BaseOrder<TSource> baseOrder, IMultipleFinalizer<TSource, TResult> multipleFinalizer = default);
    }
}
