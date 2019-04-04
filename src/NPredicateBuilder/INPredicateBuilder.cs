using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPredicateBuilder.Ordering;

namespace NPredicateBuilder
{
    public interface INPredicateBuilder<T>
    {
        T Entity(BaseQuery<T> query, BaseOrder<T> order, ISingleFinalizer<T> singleFinalizer);
        Task<T> EntityAsync(BaseQuery<T> query, BaseOrder<T> order, IAsyncSingleFinalizer<T> singleFinalizer);
        IEnumerable<T> EntitiesEnumerable(BaseQuery<T> query, BaseOrder<T> order, IMultipleFinalizer<T> multipleFinalizer);
        IQueryable<T> EntitiesQueryable(BaseQuery<T> query, BaseOrder<T> order, IMultipleFinalizer<T> multipleFinalizer);
        List<T> EntitiesList(BaseQuery<T> query, BaseOrder<T> order, IMultipleFinalizer<T> multipleFinalizer);
        Task<List<T>> EntitiesListAsync(BaseQuery<T> query, BaseOrder<T> order, IMultipleFinalizer<T> multipleFinalizer);
    }
}
