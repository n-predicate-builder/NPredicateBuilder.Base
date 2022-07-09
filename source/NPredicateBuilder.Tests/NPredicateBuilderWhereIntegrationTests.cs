namespace NPredicateBuilder.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EF;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NPredicateBuilderWhereIntegrationTests
    {
        public NPredicateBuilderWhereIntegrationTests()
        {
            using (var context = new TestContext())
            {
                var allCustomers = context.Customers;
                context.Customers.RemoveRange(allCustomers);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void Where_DbSet_FiltersCorrectly()
        {
            var customers = new List<Customer>
            {
                TestHelper.Billy(),
                TestHelper.Bobby(),
            };

            using (var context = new TestContext())
            {
                context.Customers.AddRange(customers);
                context.SaveChanges();
            }

            using (var context = new TestContext())
            {
                var query = new CustomerTestQuery()
                    .AndNameIsBobby();

                var result = context.Customers
                    .NPredicateBuilderEFWhere(query)
                    .ToList();

                Assert.AreEqual("Bobby", result.Single().Name);
            }
        }

        [TestMethod]
        public void MultipleAndFilters_FiltersCorrectly()
        {
            var correctCustomer = new Customer(Guid.NewGuid(), "Billy", 10);

            var customers = new List<Customer>
            {
                correctCustomer, new Customer(Guid.NewGuid(), "Billy", 5), TestHelper.Bobby(),
            };

            using (var context = new TestContext())
            {
                context.Customers.AddRange(customers);
                context.SaveChanges();
            }

            using (var context = new TestContext())
            {
                var query = new CustomerTestQuery()
                    .AndNameIsBilly().AndAgeIsOverSix();

                var result = context.Customers
                    .NPredicateBuilderEFWhere(query)
                    .ToList();

                Assert.AreEqual(correctCustomer.Name, result.Single().Name);
                Assert.AreEqual(correctCustomer.Age, result.Single().Age);
            }
        }

        [TestMethod]
        public void CombinedAndOrFilters_FiltersCorrectly()
        {
            var customers = new List<Customer>
            {
                new Customer(Guid.NewGuid(), "Billy", 5),
                new Customer(Guid.NewGuid(), "Billy", 25),
                new Customer(Guid.NewGuid(), "Bobby", 5),
                new Customer(Guid.NewGuid(), "Bobby", 25),
            };

            using (var context = new TestContext())
            {
                context.Customers.AddRange(customers);
                context.SaveChanges();
            }

            using (var context = new TestContext())
            {
                var query = new CustomerTestQuery()
                    .AndNameIsBilly().OrAgeIsOverTwenty();

                var result = context.Customers
                    .NPredicateBuilderEFWhere(query)
                    .ToList();

                Assert.AreEqual(3, result.Count);
            }
        }

        [TestMethod]
        public void AppendedFilters_FiltersCorrectly()
        {
            var customers = new List<Customer>
            {
                new Customer(Guid.NewGuid(), "Billy", 5),
                new Customer(Guid.NewGuid(), "Billy", 25),
                new Customer(Guid.NewGuid(), "Bobby", 5),
                new Customer(Guid.NewGuid(), "Bobby", 25),
            };

            using (var context = new TestContext())
            {
                context.Customers.AddRange(customers);
                context.SaveChanges();
            }

            using (var context = new TestContext())
            {
                var query = new CustomerTestQuery()
                    .AndNameIsBilly().AndAgeIsOverSix()
                    .Or(new CustomerTestQuery().AndNameIsBobby());

                var result = context.Customers
                    .NPredicateBuilderEFWhere(query)
                    .ToList();

                Assert.AreEqual(3, result.Count);
            }
        }
    }
}