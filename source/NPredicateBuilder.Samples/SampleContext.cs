namespace NPredicateBuilder.Samples
{
    using Microsoft.EntityFrameworkCore;

    public sealed class SampleContext : DbContext
    {
        public SampleContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Airplane> Airplanes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=NPredicateBuilderSamples;Integrated Security=True;MultipleActiveResultSets=true;");
        }
    }
}
