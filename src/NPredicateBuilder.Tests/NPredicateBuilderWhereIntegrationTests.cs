namespace NPredicateBuilder.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NPredicateBuilder.EF;

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
                    .NameIsBobby();

                var result = context.Customers
                    .NPredicateBuilderEFWhere(query)
                    .ToList();

                Assert.AreEqual(1, result.Count());
                Assert.AreEqual("Bobby", result.First().Name);
            }
        }
    }
}
