namespace NPredicateBuilder.Samples
{
    public class AirplaneQueries : BaseQuery<Airplane>
    {
        public AirplaneQueries IsBoeing()
        {
            AddAndCriteria(airplane => airplane.Model == "Boeing");

            return this;
        }

        public AirplaneQueries IsAirbus()
        {
            AddAndCriteria(airplane => airplane.Model == "Airbus");

            return this;
        }
    }
}
