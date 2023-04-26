namespace NPredicateBuilder.Samples.Flights
{
    using Airplanes;

    public class Flight
    {
        public Flight(Airplane airplane)
            : this()
        {
            Id = Guid.NewGuid();
            Airplane = airplane;
            Departure = DateTime.UtcNow;
        }

        public Flight()
        {
        }

        public Guid Id { get; private set; }

        public Airplane Airplane { get; private set; }

        public DateTime Departure { get; private set; }
    }
}
