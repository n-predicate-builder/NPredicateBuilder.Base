using System;
using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class Average<T> : ICalculator<T>
    {
        public decimal Calculate(IQueryable<T> queryable)
        {
            throw new NotImplementedException();
        }
    }
}
