namespace NPredicateBuilder.Tests
{
#if NET472
    using System.Data.Entity;
#else
    using Microsoft.EntityFrameworkCore;
#endif

    public sealed class TestContext : DbContext
    {
#if NET472
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

#if NET472
#else
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=NPredicateBuilderTest;Integrated Security=True;MultipleActiveResultSets=true;");
        }
#endif
    }
}