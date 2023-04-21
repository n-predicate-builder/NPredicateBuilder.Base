namespace NPredicateBuilder.Samples
{
    public class AirplaneOrders : BaseOrder<Airplane>
    {
        public AirplaneOrders OrderByManufacturer()
        {
            OrderBy(airplane => airplane.Manufacturer);

            return this;
        }

        public AirplaneOrders ThenByModel()
        {
            ThenBy(airplane => airplane.Model);

            return this;
        }
    }
}
