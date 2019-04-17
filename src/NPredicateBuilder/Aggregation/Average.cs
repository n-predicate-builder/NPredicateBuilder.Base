using System;
using System.Linq;

namespace NPredicateBuilder.Aggregation
{
    internal class Average<T> : ICalculator
    {
        private readonly Func<T, decimal> _decimalFunc;
        private readonly Func<T, double> _doubleFunc;
        private readonly Func<T, float> _floatFunc;
        private readonly Func<T, long> _longFunc;
        private readonly Func<T, decimal?> _nullableDecimalFunc;
        private readonly Func<T, double?> _nullableDoubleFunc;
        private readonly Func<T, int?> _nullableIntFunc;
        private readonly Func<T, long?> _nullableLongFunc;

        public Average(Func<T, decimal> decimalFunc) => _decimalFunc = decimalFunc;

        public Average(Func<T, double> doubleFunc) => _doubleFunc = doubleFunc;

        public Average(Func<T, float> floatFunc) => _floatFunc = floatFunc;

        public decimal Calculate(IQueryable<decimal> queryable) => queryable.Average();

        public double Calculate(IQueryable<double> queryable) => queryable.Average();

        public double Calculate(IQueryable<int> queryable) => queryable.Average();

        public double Calculate(IQueryable<long> queryable) => queryable.Average();

        public float Calculate(IQueryable<float> queryable) => queryable.Average();

        public decimal? Calculate(IQueryable<decimal?> queryable) => queryable.Average();

        public double? Calculate(IQueryable<double?> queryable) => queryable.Average();

        public double? Calculate(IQueryable<int?> queryable) => queryable.Average();

        public double? Calculate(IQueryable<long?> queryable) => queryable.Average();

        public float? Calculate(IQueryable<float?> queryable) => queryable.Average();
    }
}
