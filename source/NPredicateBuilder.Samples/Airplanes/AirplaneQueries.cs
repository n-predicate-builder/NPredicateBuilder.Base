namespace NPredicateBuilder.Samples.Airplanes
{
    public class AirplaneQueries : BaseQuery<Airplane>
    {
        public AirplaneQueries IsBoeing()
        {
            AddAndCriteria(airplane => airplane.Manufacturer == "Boeing");

            return this;
        }

        public AirplaneQueries IsAirbus()
        {
            AddAndCriteria(airplane => airplane.Manufacturer == "Airbus");

            return this;
        }
    }
}
