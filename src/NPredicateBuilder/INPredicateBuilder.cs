using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NPredicateBuilder
{
    public interface INPredicateBuilder
    {
        TResult Entity<TSource, TResult>(BaseQuery<TSource> query, ISingleFinalizer<TSource, TResult> finalizer);
        TResult Entity<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, ISingleFinalizer<TSource, TResult> finalizer);

        Task<TResult> EntityAsync<TSource, TResult>(BaseQuery<TSource> query, ISingleFinalizer<TSource, TResult> finalizer);
        Task<TResult> EntityAsync<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, ISingleFinalizer<TSource, TResult> finalizer);

        IEnumerable<TSource> EntitiesEnumerable<TSource>(BaseQuery<TSource> query);
        IEnumerable<TSource> EntitiesEnumerable<TSource>(BaseQuery<TSource> query, BaseOrder<TSource> order);
        IEnumerable<TResult> EntitiesEnumerable<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TResult> finalizer);
        IEnumerable<TResult> EntitiesEnumerable<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, Expression<Func<TSource, TResult>> projection);
        IEnumerable<TResult> EntitiesEnumerable<TSource, TFinalized, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TFinalized> finalizer, Expression<Func<TFinalized, TResult>> projection);
        IEnumerable<TResult> EntitiesEnumerable<TSource, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TResult> finalizer);
        IEnumerable<TResult> EntitiesEnumerable<TSource, TFinalized, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TResult> finalizer, Expression<Func<TFinalized, TResult>> projection);
        IEnumerable<TResult> EntitiesEnumerable<TSource, TResult>(BaseQuery<TSource> query, Expression<Func<TSource, TResult>> projection);

        IQueryable<TSource> EntitiesQueryable<TSource>(BaseQuery<TSource> query);
        IQueryable<TSource> EntitiesQueryable<TSource>(BaseQuery<TSource> query, BaseOrder<TSource> order);
        IQueryable<TResult> EntitiesQueryable<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TResult> finalizer);
        IQueryable<TResult> EntitiesQueryable<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, Expression<Func<TSource, TResult>> projection);
        IQueryable<TResult> EntitiesQueryable<TSource, TFinalized, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TFinalized> finalizer, Expression<Func<TFinalized, TResult>> projection);
        IQueryable<TResult> EntitiesQueryable<TSource, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TResult> finalizer);
        IQueryable<TResult> EntitiesQueryable<TSource, TFinalized, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TResult> finalizer, Expression<Func<TFinalized, TResult>> projection);
        IQueryable<TResult> EntitiesQueryable<TSource, TResult>(BaseQuery<TSource> query, Expression<Func<TSource, TResult>> projection);

        List<TSource> EntitiesList<TSource>(BaseQuery<TSource> query);
        List<TSource> EntitiesList<TSource>(BaseQuery<TSource> query, BaseOrder<TSource> order);
        List<TResult> EntitiesList<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TResult> finalizer);
        List<TResult> EntitiesList<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, Expression<Func<TSource, TResult>> projection);
        List<TResult> EntitiesList<TSource, TFinalized, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TFinalized> finalizer, Expression<Func<TFinalized, TResult>> projection);
        List<TResult> EntitiesList<TSource, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TResult> finalizer);
        List<TResult> EntitiesList<TSource, TFinalized, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TResult> finalizer, Expression<Func<TFinalized, TResult>> projection);
        List<TResult> EntitiesList<TSource, TResult>(BaseQuery<TSource> query, Expression<Func<TSource, TResult>> projection);

        Task<List<TSource>> EntitiesListAsync<TSource>(BaseQuery<TSource> query);
        Task<List<TSource>> EntitiesListAsync<TSource>(BaseQuery<TSource> query, BaseOrder<TSource> order);
        Task<List<TResult>> EntitiesListAsync<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TResult> finalizer);
        Task<List<TResult>> EntitiesListAsync<TSource, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, Expression<Func<TSource, TResult>> projection);
        Task<List<TResult>> EntitiesListAsync<TSource, TFinalized, TResult>(BaseQuery<TSource> query, BaseOrder<TSource> order, IMultipleFinalizer<TSource, TFinalized> finalizer, Expression<Func<TFinalized, TResult>> projection);
        Task<List<TResult>> EntitiesListAsync<TSource, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TResult> finalizer);
        Task<List<TResult>> EntitiesListAsync<TSource, TFinalized, TResult>(BaseQuery<TSource> query, IMultipleFinalizer<TSource, TResult> finalizer, Expression<Func<TFinalized, TResult>> projection);
        Task<List<TResult>> EntitiesListAsync<TSource, TResult>(BaseQuery<TSource> query, Expression<Func<TSource, TResult>> projection);
    }
}
