namespace NPredicateBuilder.Tests
{
#if NETFRAMEWORK
    using System.Data.Entity;
#else
    using Microsoft.EntityFrameworkCore;
#endif

    public sealed class TestContext : DbContext
    {
#if NETFRAMEWORK
        public TestContext()
            : base("TestContext")
        {
        }
#else
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