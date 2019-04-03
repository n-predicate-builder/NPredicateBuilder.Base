using System.Linq;

namespace NPredicateBuilder.Organizers
{
    public interface IOrganizer<T>
    {
        IOrderedQueryable<T> Organize(IQueryable<T> queryable);
    }
}
