#if NETFRAMEWORK
using System.Data.Entity;

namespace NPredicateBuilder.Tests
{
#else
using Microsoft.EntityFrameworkCore;

namespace NPredicateBuilder.Tests
{
#endif

    public sealed class TestContext : DbContext
    {
#if NETFRAMEWORK
        /// <summary>
        /// Initializes a new instance of the <see cref="TestContext"/> class.
        /// </summary>
        public TestContext()
            : base("TestContext")
        {
        }
#else
        /// <summary>
        /// Initializes a new instance of the <see cref="TestContext"/> class.
        /// </summary>
        public TestContext()
        {
            Database.EnsureCreated();
        }
#endif

        public DbSet<Customer> Customers { get; set; }

#if NETFRAMEWORK
#else
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=NPredicateBuilderTest;Integrated Security=True;MultipleActiveResultSets=true;");
        }
#endif
    }
}