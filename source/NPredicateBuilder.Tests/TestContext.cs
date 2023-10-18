// <copyright file="TestContext.cs" company="Michael Bradvica LLC">
// Copyright (c) Michael Bradvica LLC. All rights reserved.
// </copyright>

#if NETFRAMEWORK
using System.Data.Entity;

namespace NPredicateBuilder.Tests
{
#else
using Microsoft.EntityFrameworkCore;

namespace NPredicateBuilder.Tests
{
#endif

    /// <summary>
    /// EF Context for testing.
    /// </summary>
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

        /// <summary>
        /// Gets or sets a DbSet for a Customer table.
        /// </summary>
        public DbSet<Customer> Customers { get; set; }

#if NETFRAMEWORK
#else
        /// <summary>
        /// Configures the database connection.
        /// </summary>
        /// <param name="optionsBuilder">Allow further options for database configuration.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=NPredicateBuilderTest;Integrated Security=True;MultipleActiveResultSets=true;");
        }
#endif
    }
}