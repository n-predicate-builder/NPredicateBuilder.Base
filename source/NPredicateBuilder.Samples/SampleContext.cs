﻿// <copyright file="SampleContext.cs" company="Michael Bradvica LLC">
// Copyright (c) Michael Bradvica LLC. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using NPredicateBuilder.Samples.Airplanes;
using NPredicateBuilder.Samples.Flights;

namespace NPredicateBuilder.Samples
{
    /// <summary>
    /// Sample EF database context.
    /// </summary>
    public sealed class SampleContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleContext"/> class.
        /// </summary>
        public SampleContext()
        {
            Database.EnsureCreated();
        }

        /// <summary>
        /// Gets or sets the airplanes DbSet.
        /// </summary>
        public DbSet<Airplane> Airplanes { get; set; }

        /// <summary>
        /// Gets or sets the Flights DbSet.
        /// </summary>
        public DbSet<Flight> Flights { get; set; }

        /// <summary>
        /// Initializes the database connection string.
        /// </summary>
        /// <param name="optionsBuilder">Further options to configure the database.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=NPredicateBuilderSamples;Integrated Security=True;MultipleActiveResultSets=true;");
        }
    }
}