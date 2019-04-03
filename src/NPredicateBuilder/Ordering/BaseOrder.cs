using System.Collections.Generic;

namespace NPredicateBuilder.Ordering
{
    public abstract class BaseOrder<T>
    {
        private IOrder<T> _firstOrder;
        private readonly List<IOrder<T>> _secondaryOrder;
        public IEnumerable<IOrder<T>> OrderExpressions => CombineOrder();

        protected BaseOrder()
        {
            _secondaryOrder = new List<IOrder<T>>();
        }

        protected void AddOrderer(IOrder<T> order)
        {
            if (_firstOrder == null)
            {
                _firstOrder = order;
            }
            else
            {
                _secondaryOrder.Add(order);
            }
        }

        private IEnumerable<IOrder<T>> CombineOrder()
        {
            var orders = new List<IOrder<T>> { _firstOrder };
            orders.AddRange(_secondaryOrder);

            return orders;
        }
    }
}
