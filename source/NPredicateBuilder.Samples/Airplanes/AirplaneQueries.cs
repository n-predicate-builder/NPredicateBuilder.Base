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

        public AirplaneQueries AndIsWideBody()
        {
            AddAndCriteria(airplane => airplane.Model == "787-9" || airplane.Model == "A330-9");

            return this;
        }

        public AirplaneQueries AndIsNarrowBody()
        {
            AddAndCriteria(airplane => airplane.Model == "737-8" || airplane.Model == "A320");

            return this;
        }
    }
}
