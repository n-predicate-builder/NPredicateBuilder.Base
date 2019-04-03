using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NPredicateBuilder.Organizers;

namespace NPredicateBuilder
{
    public interface INPredicateBuilder<T>
    {
        T Entity(BaseQuery<T> query, IFinalizer<T> finalizer, BaseOrganizer<T> order);
        Task<T> EntityAsync(BaseQuery<T> query, IFinalizer<T> finalizer, BaseOrganizer<T> order);
        IEnumerable<T> EntitiesEnumerable(BaseQuery<T> query, BaseOrganizer<T> order);
        IQueryable<T> EntitiesQueryable(BaseQuery<T> query, BaseOrganizer<T> order);
        List<T> EntitiesList(BaseQuery<T> query, BaseOrganizer<T> order);
        Task<List<T>> EntitiesListAsync(BaseQuery<T> query, BaseOrganizer<T> order);
        decimal EntitiesCalculation(BaseQuery<T> query, ICalculation calculator);
        Task<decimal> EntitiesCalculationAsync(BaseQuery<T> query, ICalculation calculator);
    }
}
