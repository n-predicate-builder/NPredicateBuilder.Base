// <copyright file="OrderBy.cs" company="Michael Bradvica LLC">
// Copyright (c) Michael Bradvica LLC. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder
{
    /// <inheritdoc />
    internal class OrderBy<T, TKey> : IOrder<T>
    {
        private readonly Expression<Func<T, TKey>> _orderExpression;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderBy{T, TKey}"/> class.
        /// </summary>
        /// <param name="orderExpression">A func that describes how an entity should be ordered by.</param>
        public OrderBy(Expression<Func<T, TKey>> orderExpression)
        {
            _orderExpression = orderExpression;
        }

        /// <inheritdoc/>
        public IOrderedQueryable<T> Order(IQueryable<T> queryable)
        {
            return queryable.OrderBy(_orderExpression);
        }

        /// <inheritdoc/>
        public IOrderedEnumerable<T> Order(IEnumerable<T> enumerable)
        {
            return enumerable.OrderBy(_orderExpression.Compile());
        }
    }
}