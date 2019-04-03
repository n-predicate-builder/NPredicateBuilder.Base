using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPredicateBuilder.Ordering;

namespace NPredicateBuilder
{
    public interface INPredicateBuilder<T>
    {
        T Entity(BaseQuery<T> query, ISingleFinalizer<T> singleFinalizer, BaseOrder<T> order);
        Task<T> EntityAsync(BaseQuery<T> query, IAsyncSingleFinalizer<T> singleFinalizer, BaseOrder<T> order);
        IEnumerable<T> EntitiesEnumerable(BaseQuery<T> query, IMultipleFinalizer<T> multipleFinalizer, BaseOrder<T> order);
        IQueryable<T> EntitiesQueryable(BaseQuery<T> query, IMultipleFinalizer<T> multipleFinalizer, BaseOrder<T> order);
        List<T> EntitiesList(BaseQuery<T> query, IMultipleFinalizer<T> multipleFinalizer, BaseOrder<T> order);
        Task<List<T>> EntitiesListAsync(BaseQuery<T> query, IAsyncMultipleFinalizer<T> multipleFinalizer, BaseOrder<T> order);

        //decimal EntitiesCalculation(BaseQuery<T> query, ICalculator<T> calculator);
        //Task<decimal> EntitiesCalculationAsync(BaseQuery<T> query, IAsyncCalculator<T> calculator);
    }
}
