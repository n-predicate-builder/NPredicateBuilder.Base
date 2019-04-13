using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NPredicateBuilder.Ordering
{
    public abstract class BaseOrder<T>
    {
        public IOrder<T> FirstOrder { get; private set; }
        private readonly List<IThenByOrder<T>> _secondaryOrders;
        public IEnumerable<IThenByOrder<T>> SecondaryOrders => _secondaryOrders.AsEnumerable();

        protected BaseOrder() => _secondaryOrders = new List<IThenByOrder<T>>();

        protected void OrderBy<TKey>(Expression<Func<T, TKey>> orderExpression) => FirstOrder = new OrderBy<T, TKey>(orderExpression);
    
        protected void OrderByDescending<TKey>(Expression<Func<T, TKey>> orderExpression) => FirstOrder = new OrderByDescending<T,TKey>(orderExpression);

        protected void ThenBy<TKey>(Expression<Func<T, TKey>> orderExpression) => _secondaryOrders.Add(new ThenBy<T, TKey>(orderExpression));

        protected void ThenByDescending<TKey>(Expression<Func<T, TKey>> orderExpression) => _secondaryOrders.Add(new ThenByDescending<T,TKey>(orderExpression));
    }
}
