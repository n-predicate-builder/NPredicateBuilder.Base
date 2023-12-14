// <copyright file="BaseQuery.cs" company="Michael Bradvica LLC">
// Copyright (c) Michael Bradvica LLC. All rights reserved.
// </copyright>

using System;
using System.Linq.Expressions;

namespace NPredicateBuilder
{
    /// <summary>
    /// A base class used to build Where clause queries against an entity.
    /// </summary>
    /// <typeparam name="T">The entity to be queried against.</typeparam>
    public abstract class BaseQuery<T>
    {
        /// <summary>
        /// Gets the current Expression that will be used to query a collection.
        /// </summary>
        public Expression<Func<T, bool>> SearchExpression { get; private set; }

        /// <summary>
        /// Appends an additional search expression on an already existing search expression using the And comparison.
        /// </summary>
        /// <param name="currentQuery">The search expression that you are appending to the end of an already existing expression.</param>
        /// <returns>A new search expression that contains all previous expressions.</returns>
        public BaseQuery<T> And(BaseQuery<T> currentQuery)
        {
            SearchExpression = And(currentQuery.SearchExpression);

            return this;
        }

        /// <summary>
        /// Appends an additional search expression on an already existing search expressing using the Or comparison.
        /// </summary>
        /// <param name="currentQuery">The search expression that you are appending to the end of an already existing expression.</param>
        /// <returns>A new search expression that contains all previous expressions.</returns>
        public BaseQuery<T> Or(BaseQuery<T> currentQuery)
        {
            SearchExpression = Or(currentQuery.SearchExpression);

            return this;
        }

        /// <summary>
        /// Adds an And expression to the current search expression list.
        /// </summary>
        /// <param name="nextExpression">The expression that you wish to add with the And comparison.</param>
        protected void AddAndCriteria(Expression<Func<T, bool>> nextExpression)
        {
            SearchExpression = SearchExpression == null ? nextExpression : And(nextExpression);
        }

        /// <summary>
        /// Adds an Or expression to the current search expression list.
        /// </summary>
        /// <param name="nextExpression">The expression that you wish to add with the Or comparison.</param>
        protected void AddOrCriteria(Expression<Func<T, bool>> nextExpression)
        {
            SearchExpression = SearchExpression == null ? nextExpression : Or(nextExpression);
        }

        private Expression<Func<T, bool>> Or(Expression<Func<T, bool>> nextExpression)
        {
            var invokedExpression = Expression.Invoke(nextExpression, SearchExpression.Parameters);

            return Expression.Lambda<Func<T, bool>>(Expression.OrElse(SearchExpression.Body, invokedExpression), SearchExpression.Parameters);
        }

        private Expression<Func<T, bool>> And(Expression<Func<T, bool>> nextExpression)
        {
            var invokedExpression = Expression.Invoke(nextExpression, SearchExpression.Parameters);

            return Expression.Lambda<Func<T, bool>>(Expression.AndAlso(SearchExpression.Body, invokedExpression), SearchExpression.Parameters);
        }
    }
}