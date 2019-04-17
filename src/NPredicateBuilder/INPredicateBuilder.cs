using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPredicateBuilder.Ordering;

namespace NPredicateBuilder
{
    public interface INPredicateBuilder<T>
    { 
        T Entity(BaseQuery<T> baseQuery, ISingleFinalizer<T> singleFinalizer);+
        T Entity(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder, ISingleFinalizer<T> singleFinalizer);
        Task<T> EntityAsync(BaseQuery<T> baseQuery, IAsyncSingleFinalizer<T> singleFinalizer);
        Task<T> EntityAsync(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder, IAsyncSingleFinalizer<T> singleFinalizer);
        IEnumerable<T> EntitiesEnumerable(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder);
        IEnumerable<T> EntitiesEnumerable(BaseQuery<T> baseQuery, IMultipleFinalizer<T> multipleFinalizer);
        IEnumerable<T> EntitiesEnumerable(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder, IMultipleFinalizer<T> multipleFinalizer);
        IQueryable<T> EntitiesQueryable(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder);
        IQueryable<T> EntitiesQueryable(BaseQuery<T> baseQuery, IMultipleFinalizer<T> multipleFinalizer);
        IQueryable<T> EntitiesQueryable(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder, IMultipleFinalizer<T> multipleFinalizer);
        List<T> EntitiesList(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder);
        List<T> EntitiesList(BaseQuery<T> baseQuery, IMultipleFinalizer<T> multipleFinalizer);
        List<T> EntitiesList(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder, IMultipleFinalizer<T> multipleFinalizer);
        Task<List<T>> EntitiesListAsync(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder);
        Task<List<T>> EntitiesListAsync(BaseQuery<T> baseQuery, IMultipleFinalizer<T> multipleFinalizer);
        Task<List<T>> EntitiesListAsync(BaseQuery<T> baseQuery, BaseOrder<T> baseOrder, IMultipleFinalizer<T> multipleFinalizer);
    }
}
