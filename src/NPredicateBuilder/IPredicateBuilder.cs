using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NPredicateBuilder
{
    public interface IPredicateBuilder
    {
        TResult Entity<TSource, TResult>(BaseQuery<TSource> query, ISingleFinalizer<TSource, TResult> finalizer) where TSource : class;
        TResult Entity<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, ISingleFinalizer<TSource, TResult> finalizer) where TSource : class;

        Task<TResult> EntityAsync<TSource, TResult>(BaseQuery<TSource> query, ISingleAsyncFinalizer<TSource, TResult> finalizer) where TSource : class;
        Task<TResult> EntityAsync<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, ISingleAsyncFinalizer<TSource, TResult> finalizer) where TSource : class;

        IEnumerable<TSource> EntitiesEnumerable<TSource>(BaseQuery<TSource> query) where TSource : class;
        IEnumerable<TSource> EntitiesEnumerable<TSource>(BaseQuery<TSource> query, BaseOrder<TSource> order) where TSource : class;
        IEnumerable<TResult> EntitiesEnumerable<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TResult> finalizer) where TSource : class;
        IEnumerable<TResult> EntitiesEnumerable<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, Expression<Func<TSource, TResult>> projection) where TSource : class;
        IEnumerable<TResult> EntitiesEnumerable<TSource, TFinalized, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TFinalized> finalizer, Expression<Func<TFinalized, TResult>> projection) where TSource : class;
        IEnumerable<TResult> EntitiesEnumerable<TSource, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TResult> finalizer) where TSource : class;
        IEnumerable<TResult> EntitiesEnumerable<TSource, TFinalized, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TFinalized> finalizer, Expression<Func<TFinalized, TResult>> projection) where TSource : class;
        IEnumerable<TResult> EntitiesEnumerable<TSource, TResult>(BaseQuery<TSource> query, Expression<Func<TSource, TResult>> projection) where TSource : class;

        IQueryable<TSource> EntitiesQueryable<TSource>(BaseQuery<TSource> query) where TSource : class;
        IQueryable<TSource> EntitiesQueryable<TSource>(BaseQuery<TSource> query, BaseOrder<TSource> order) where TSource : class;
        IQueryable<TResult> EntitiesQueryable<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TResult> finalizer) where TSource : class;
        IQueryable<TResult> EntitiesQueryable<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, Expression<Func<TSource, TResult>> projection) where TSource : class;
        IQueryable<TResult> EntitiesQueryable<TSource, TFinalized, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TFinalized> finalizer, Expression<Func<TFinalized, TResult>> projection) where TSource : class;
        IQueryable<TResult> EntitiesQueryable<TSource, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TResult> finalizer) where TSource : class;
        IQueryable<TResult> EntitiesQueryable<TSource, TFinalized, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TFinalized> finalizer, Expression<Func<TFinalized, TResult>> projection) where TSource : class;
        IQueryable<TResult> EntitiesQueryable<TSource, TResult>(BaseQuery<TSource> query, Expression<Func<TSource, TResult>> projection) where TSource : class;

        List<TSource> EntitiesList<TSource>(BaseQuery<TSource> query) where TSource : class;
        List<TSource> EntitiesList<TSource>(BaseQuery<TSource> query, BaseOrder<TSource> order) where TSource : class;
        List<TResult> EntitiesList<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TResult> finalizer) where TSource : class;
        List<TResult> EntitiesList<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, Expression<Func<TSource, TResult>> projection) where TSource : class;
        List<TResult> EntitiesList<TSource, TFinalized, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TFinalized> finalizer, Expression<Func<TFinalized, TResult>> projection) where TSource : class;
        List<TResult> EntitiesList<TSource, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TResult> finalizer) where TSource : class;
        List<TResult> EntitiesList<TSource, TFinalized, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TFinalized> finalizer, Expression<Func<TFinalized, TResult>> projection) where TSource : class;
        List<TResult> EntitiesList<TSource, TResult>(BaseQuery<TSource> query, Expression<Func<TSource, TResult>> projection) where TSource : class;

        Task<List<TSource>> EntitiesListAsync<TSource>(BaseQuery<TSource> query) where TSource : class;
        Task<List<TSource>> EntitiesListAsync<TSource>(BaseQuery<TSource> query, BaseOrder<TSource> order) where TSource : class;
        Task<List<TResult>> EntitiesListAsync<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TResult> finalizer) where TSource : class;
        Task<List<TResult>> EntitiesListAsync<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, Expression<Func<TSource, TResult>> projection) where TSource : class;
        Task<List<TResult>> EntitiesListAsync<TSource, TFinalized, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TFinalized> finalizer, Expression<Func<TFinalized, TResult>> projection) where TSource : class;
        Task<List<TResult>> EntitiesListAsync<TSource, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TResult> finalizer) where TSource : class;
        Task<List<TResult>> EntitiesListAsync<TSource, TFinalized, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TFinalized> finalizer, Expression<Func<TFinalized, TResult>> projection) where TSource : class;
        Task<List<TResult>> EntitiesListAsync<TSource, TResult>(BaseQuery<TSource> query, Expression<Func<TSource, TResult>> projection) where TSource : class;
    }
}
