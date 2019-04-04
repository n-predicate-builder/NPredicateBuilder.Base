using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPredicateBuilder.Ordering;

namespace NPredicateBuilder
{
    public interface INPredicateBuilder<T>
    { 
        T Entity(BaseQuery<T> query, ISingleFinalizer<T> singleFinalizer);
        T Entity(BaseQuery<T> query, BaseOrder<T> order, ISingleFinalizer<T> singleFinalizer);
        Task<T> EntityAsync(BaseQuery<T> query, IAsyncSingleFinalizer<T> singleFinalizer);
        Task<T> EntityAsync(BaseQuery<T> query, BaseOrder<T> order, IAsyncSingleFinalizer<T> singleFinalizer);
        IEnumerable<T> EntitiesEnumerable(BaseQuery<T> query, BaseOrder<T> order);
        IEnumerable<T> EntitiesEnumerable(BaseQuery<T> query, IMultipleFinalizer<T> multipleFinalizer);
        IEnumerable<T> EntitiesEnumerable(BaseQuery<T> query, BaseOrder<T> order, IMultipleFinalizer<T> multipleFinalizer);
        IQueryable<T> EntitiesQueryable(BaseQuery<T> query, BaseOrder<T> order);
        IQueryable<T> EntitiesQueryable(BaseQuery<T> query, IMultipleFinalizer<T> multipleFinalizer);
        IQueryable<T> EntitiesQueryable(BaseQuery<T> query, BaseOrder<T> order, IMultipleFinalizer<T> multipleFinalizer);
        List<T> EntitiesList(BaseQuery<T> query, BaseOrder<T> order);
        List<T> EntitiesList(BaseQuery<T> query, IMultipleFinalizer<T> multipleFinalizer);
        List<T> EntitiesList(BaseQuery<T> query, BaseOrder<T> order, IMultipleFinalizer<T> multipleFinalizer);
        Task<List<T>> EntitiesListAsync(BaseQuery<T> query, BaseOrder<T> order);
        Task<List<T>> EntitiesListAsync(BaseQuery<T> query, IMultipleFinalizer<T> multipleFinalizer);
        Task<List<T>> EntitiesListAsync(BaseQuery<T> query, BaseOrder<T> order, IMultipleFinalizer<T> multipleFinalizer);
    }
}
