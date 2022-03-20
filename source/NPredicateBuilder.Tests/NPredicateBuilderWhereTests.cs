namespace NPredicateBuilder.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using EF;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class NPredicateBuilderWhereTests
    {
        private IEnumerable<Customer> _customers;

        [TestMethod]
        public void Where_IEnumerable_FiltersCorrectly()
        {
            _customers = new List<Customer>
            {
                TestHelper.Billy(),
                TestHelper.Bobby(),
            };

            var query = new CustomerTestQuery().NameIsBobby();

            var result = _customers.NPredicateBuilderWhere(query);

            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("Bobby", result.First().Name);
        }

        [TestMethod]
        public void Where_Queryable_FiltersCorrectly()
        {
            _customers = new List<Customer>
            {
                TestHelper.Billy(),
                TestHelper.Bobby(),
            };

            var query = new CustomerTestQuery().NameIsBobby();

            var result = _customers.AsQueryable().NPredicateBuilderEFWhere(query);

            Assert.AreEqual(1, result.Count());
            Assert.AreEqual("Bobby", result.First().Name);
        }
    }
}
