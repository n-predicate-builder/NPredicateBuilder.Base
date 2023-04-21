namespace NPredicateBuilder.Samples
{
    public class Airplane
    {
        public Airplane(string manufacturer, string model, int range)
            : this()
        {
            Id = Guid.NewGuid();
            Manufacturer = manufacturer;
            Model = model;
            Range = range;
        }

        private Airplane()
        {
        }

        public Guid Id { get; set; }

        public string Manufacturer { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public int Range { get; set; }
    }
}
