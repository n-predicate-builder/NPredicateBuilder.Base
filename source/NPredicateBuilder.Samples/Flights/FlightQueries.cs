namespace NPredicateBuilder.Samples.Flights
{
    using Airplanes;

    public class FlightQueries : BaseQuery<Flight>
    {
        public FlightQueries DepartsToday()
        {
            AddAndCriteria(flight => flight.Departure.DayOfYear == DateTime.UtcNow.DayOfYear);

            return this;
        }

        public FlightQueries HasAirplane(Airplane airplane)
        {
            AddAndCriteria(flight => flight.Airplane.Id == airplane.Id);

            return this;
        }
    }
}
