namespace NPredicateBuilder.Samples.Flights
{
    public class FlightOrders : BaseOrder<Flight>
    {
        public FlightOrders ByDeparture()
        {
            OrderBy(flight => flight.Departure);

            return this;
        }
    }
}
