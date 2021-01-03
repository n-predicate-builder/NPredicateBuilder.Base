namespace NPredicateBuilder.Tests
{
    public class CustomerTestQuery : BaseQuery<Customer>
    {
        public CustomerTestQuery NameIsBobby()
        {
            AddAndCriteria(x => x.Name == "Bobby");

            return this;
        }
    }
}
