namespace NPredicateBuilder.Tests
{
    using System;

    public class Customer
    {
        public Customer(Guid id, string name, int age)
            : this()
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public Customer()
        {
        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }
    }
}
