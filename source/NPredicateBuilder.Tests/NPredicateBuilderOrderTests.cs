namespace NPredicateBuilder.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NPredicateBuilder.EF;

    [TestClass]
    public class NPredicateBuilderOrderTests
    {
        private IEnumerable<Customer> _customers;

        [TestMethod]
        public void OrderBy_IEnumerable_OrdersCorrectly()
        {
            _customers = new List<Customer>
            {
                TestHelper.Bobby(),
                TestHelper.Billy(),
                TestHelper.Bobby(),
            };

            var order = new CustomerTestOrder().ByName();

            var result = _customers.NPredicateBuilderOrder(order);

            Assert.AreEqual("Billy", result.First().Name);
        }

        [TestMethod]
        public void OrderBy_IQueryable_OrdersCorrectly()
        {
            _customers = new List<Customer>
            {
                TestHelper.Bobby(),
                TestHelper.Billy(),
                TestHelper.Bobby(),
            };

            var order = new CustomerTestOrder().ByName();

            var result = _customers.AsQueryable().NPredicateBuilderEFOrder(order);

            Assert.AreEqual("Billy", result.First().Name);
        }

        [TestMethod]
        public void ThenBy_IEnumerable_OrdersCorrectly()
        {
            _customers = new List<Customer>
            {
                new Customer(Guid.NewGuid(), "Bobby", 30),
                new Customer(Guid.NewGuid(), "Billy", 30),
                new Customer(Guid.NewGuid(), "Billy", 20),
            };

            var order = new CustomerTestOrder()
                .ByName()
                .ThenByAge();

            var result = _customers.NPredicateBuilderOrder(order);

            Assert.AreEqual("Billy", result.First().Name);
            Assert.AreEqual(20, result.First().Age);
        }

        [TestMethod]
        public void ThenBy_IQueryable_OrdersCorrectly()
        {
            _customers = new List<Customer>
            {
                new Customer(Guid.NewGuid(), "Bobby", 30),
                new Customer(Guid.NewGuid(), "Billy", 30),
                new Customer(Guid.NewGuid(), "Billy", 20),
            };

            var order = new CustomerTestOrder()
                .ByName()
                .ThenByAge();

            var result = _customers.AsQueryable().NPredicateBuilderEFOrder(order);

            Assert.AreEqual("Billy", result.First().Name);
            Assert.AreEqual(20, result.First().Age);
        }

        [TestMethod]
        public void OrderByDescending_IEnumerable_OrdersCorrectly()
        {
            _customers = new List<Customer>
            {
                TestHelper.Bobby(),
                TestHelper.Billy(),
                TestHelper.Bobby(),
            };

            var order = new CustomerTestOrder().ByNameDescending();

            var result = _customers.NPredicateBuilderOrder(order);

            Assert.AreEqual("Billy", result.Last().Name);
        }

        [TestMethod]
        public void OrderByDescending_IQueryable_OrdersCorrectly()
        {
            _customers = new List<Customer>
            {
                TestHelper.Bobby(),
                TestHelper.Billy(),
                TestHelper.Bobby(),
            };

            var order = new CustomerTestOrder().ByNameDescending();

            var result = _customers.AsQueryable().NPredicateBuilderEFOrder(order);

            Assert.AreEqual("Billy", result.Last().Name);
        }

        [TestMethod]
        public void ThenByDescending_IEnumerable_OrdersCorrectly()
        {
            _customers = new List<Customer>
            {
                new Customer(Guid.NewGuid(), "Bobby", 30),
                new Customer(Guid.NewGuid(), "Billy", 30),
                new Customer(Guid.NewGuid(), "Billy", 20),
            };

            var order = new CustomerTestOrder()
                .ByName()
                .ThenByAgeDescending();

            var result = _customers.NPredicateBuilderOrder(order);

            Assert.AreEqual("Billy", result.First().Name);
            Assert.AreEqual(30, result.First().Age);
        }

        [TestMethod]
        public void ThenByDescending_IQueryable_OrdersCorrectly()
        {
            _customers = new List<Customer>
            {
                new Customer(Guid.NewGuid(), "Bobby", 30),
                new Customer(Guid.NewGuid(), "Billy", 30),
                new Customer(Guid.NewGuid(), "Billy", 20),
            };

            var order = new CustomerTestOrder()
                .ByName()
                .ThenByAgeDescending();

            var result = _customers.AsQueryable().NPredicateBuilderEFOrder(order);

            Assert.AreEqual("Billy", result.First().Name);
            Assert.AreEqual(30, result.First().Age);
        }
    }
}
