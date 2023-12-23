// <copyright file="NPredicateBuilderEFExtensions.cs" company="Michael Bradvica LLC">
// Copyright (c) Michael Bradvica LLC. All rights reserved.
// </copyright>

using LinqKit;
using System;
using System.Linq;

namespace NPredicateBuilder.EF
{
    /// <summary>
    /// A series of extension methods for applying Queries and Orders against a <see cref="IQueryable"/> interface.
    /// </summary>
    public static class NPredicateBuilderEFExtensions
    {
        /// <summary>
        /// Applies a series of predicates as filters on an IQueryable.
        /// </summary>
        /// <typeparam name="T">The entity that you are querying.</typeparam>
        /// <param name="queryable">An IQueryable of type T entity.</param>
        /// <param name="baseQuery">A query object that will apply a series of filters.</param>
        /// <returns>A filtered IQueryable of type T.</returns>
        public static IQueryable<T> NPredicateBuilderEFWhere<T>(this IQueryable<T> queryable, BaseQuery<T> baseQuery)
        {
            if (baseQuery.SearchExpression == null)
            {
                throw new ArgumentNullException(nameof(queryable));
            }

            return queryable.AsExpandable().Where(baseQuery.SearchExpression);
        }

        /// <summary>
        /// Applies a series of orders on an IQueryable.
        /// </summary>
        /// <typeparam name="T">The entity that you are ordering.</typeparam>
        /// <param name="queryable">An IQueryable of type T entity.</param>
        /// <param name="baseOrder">An order object that will apply a series of orders.</param>
        /// <returns>An IOrderedQueryable of type T.</returns>
        public static IOrderedQueryable<T> NPredicateBuilderEFOrder<T>(this IQueryable<T> queryable, BaseOrder<T> baseOrder)
        {
            if (baseOrder.FirstOrder == null)
            {
                throw new ArgumentNullException(nameof(queryable));
            }

            var orderedEntities = baseOrder.FirstOrder.Order(queryable);

            foreach (var orderer in baseOrder.SecondaryOrders)
            {
                orderedEntities = orderer.Order(orderedEntities);
            }

            return orderedEntities;
        }
    }
}