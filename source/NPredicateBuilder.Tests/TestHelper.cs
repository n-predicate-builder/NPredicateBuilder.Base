using System;

namespace NPredicateBuilder.Tests
{
    public static class TestHelper
    {
        public static Customer Billy()
        {
            return new Customer(Guid.NewGuid(), "Billy", 20);
        }

        public static Customer Bobby()
        {
            return new Customer(Guid.NewGuid(), "Bobby", 30);
        }
    }
}