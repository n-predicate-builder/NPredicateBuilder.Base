using Microsoft.EntityFrameworkCore;
using NPredicateBuilder.Samples.Airplanes;
using NPredicateBuilder.Samples.Flights;

namespace NPredicateBuilder.Samples
{
    public sealed class SampleContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleContext"/> class.
        /// </summary>
        public SampleContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Airplane> Airplanes { get; set; }

        public DbSet<Flight> Flights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=NPredicateBuilderSamples;Integrated Security=True;MultipleActiveResultSets=true;");
        }
    }
}