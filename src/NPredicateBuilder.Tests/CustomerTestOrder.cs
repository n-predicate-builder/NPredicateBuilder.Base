namespace NPredicateBuilder.Tests
{
    public class CustomerTestOrder : BaseOrder<Customer>
    {
        public CustomerTestOrder ByName()
        {
            OrderBy(x => x.Name);

            return this;
        }

        public CustomerTestOrder ByNameDescending()
        {
            OrderByDescending(x => x.Name);

            return this;
        }

        public CustomerTestOrder ThenByAge()
        {
            ThenBy(x => x.Age);

            return this;
        }

        public CustomerTestOrder ThenByAgeDescending()
        {
            ThenByDescending(x => x.Age);

            return this;
        }
    }
}
