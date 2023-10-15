using System.Linq;

namespace NPredicateBuilder
{
    /// <summary>
    /// An interface for defining a continued order against an entity.
    /// </summary>
    /// <typeparam name="T">The type of the Entity that is being further ordered.</typeparam>
    public interface IThenByOrder<T>
    {
        /// <summary>
        /// An interface for further ordering an <see cref="IOrderedQueryable"/> entity.
        /// </summary>
        /// <param name="orderedQueryable">A list of entities to be further ordered.</param>
        /// <returns>A further ordered list of entities.</returns>
        IOrderedQueryable<T> Order(IOrderedQueryable<T> orderedQueryable);

        /// <summary>
        /// An interface for further ordering an <see cref="IOrderedEnumerable{TElement}"/> entity.
        /// </summary>
        /// <param name="orderedEnumerable">A list of entity to be further ordered.</param>
        /// <returns>A further ordered list of entities.</returns>
        IOrderedEnumerable<T> Order(IOrderedEnumerable<T> orderedEnumerable);
    }
}