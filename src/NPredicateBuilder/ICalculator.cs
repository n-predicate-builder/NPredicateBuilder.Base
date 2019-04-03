using System.Linq;

namespace NPredicateBuilder
{
    public interface ICalculator<in T>
    {
        decimal Calculate(IQueryable<T> queryable);
    }
}
