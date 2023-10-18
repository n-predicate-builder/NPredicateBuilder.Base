// <copyright file="OrderByDescending.cs" company="Michael Bradvica LLC">
// Copyright (c) Michael Bradvica LLC. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder
{
    /// <inheritdoc />
    internal class OrderByDescending<T, TKey> : IOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderByDescending{T, TKey}"/> class.
        /// </summary>
        /// <param name="orderExpression">A func to describe how and entity should be ordered.</param>
        public OrderByDescending(Expression<Func<T, TKey>> orderExpression)
        {
            _orderExpression = orderExpression;
        }

        /// <inheritdoc/>
        public IOrderedQueryable<T> Order(IQueryable<T> queryable)
        {
            return queryable.OrderByDescending(_orderExpression);
        }

        /// <inheritdoc/>
        public IOrderedEnumerable<T> Order(IEnumerable<T> enumerable)
        {
            return enumerable.OrderByDescending(_orderExpression.Compile());
        }
    }
}