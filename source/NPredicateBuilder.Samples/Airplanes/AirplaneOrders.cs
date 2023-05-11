namespace NPredicateBuilder.Samples.Airplanes
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

        public AirplaneOrders ByModelDescending()
        {
            OrderByDescending(x => x.Model);

            return this;
        }

        public AirplaneOrders ThenByManufacturerDescending()
        {
            ThenByDescending(x => x.Manufacturer);

            return this;
        }
    }
}
