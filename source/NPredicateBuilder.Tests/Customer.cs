﻿// <copyright file="Customer.cs" company="Michael Bradvica LLC">
// Copyright (c) Michael Bradvica LLC. All rights reserved.
// </copyright>

using System;

namespace NPredicateBuilder.Tests
{
    /// <summary>
    /// Sample entity.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="id">Id of the customer.</param>
        /// <param name="name">Name of the customer.</param>
        /// <param name="age">Age of the customer.</param>
        public Customer(Guid id, string name, int age)
            : this()
        {
            Id = id;
            Name = name;
            Age = age;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// Gets the Id.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Gets the Name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the Age.
        /// </summary>
        public int Age { get; private set; }
    }
}