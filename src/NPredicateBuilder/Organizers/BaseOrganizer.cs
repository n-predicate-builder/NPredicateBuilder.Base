using System.Collections.Generic;

namespace NPredicateBuilder.Organizers
{
    public abstract class BaseOrganizer<T>
    {
        private IOrganizer<T> _firstOrganizer;
        private readonly List<IOrganizer<T>> _secondaryOrganizers;
        public IEnumerable<IOrganizer<T>> OrganizerExpressions => CombineOrder();

        protected BaseOrganizer()
        {
            _secondaryOrganizers = new List<IOrganizer<T>>();
        }

        protected void AddOrderer(IOrganizer<T> organizer)
        {
            if (_firstOrganizer == null)
            {
                _firstOrganizer = organizer;
            }
            else
            {
                _secondaryOrganizers.Add(organizer);
            }
        }

        private IEnumerable<IOrganizer<T>> CombineOrder()
        {
            var orders = new List<IOrganizer<T>> { _firstOrganizer };
            orders.AddRange(_secondaryOrganizers);

            return orders;
        }
    }
}
