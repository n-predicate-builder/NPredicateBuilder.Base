// <copyright file="FlightOrders.cs" company="Michael Bradvica LLC">
// Copyright (c) Michael Bradvica LLC. All rights reserved.
// </copyright>

namespace NPredicateBuilder.Samples.Flights
{
    /// <summary>
    /// Sample order.
    /// </summary>
    public class FlightOrders : BaseOrder<Flight>
    {
        /// <summary>
        /// Sample order.
        /// </summary>
        /// <returns>An instance of <see cref="FlightOrders"/>.</returns>
        public FlightOrders ByDeparture()
        {
            OrderBy(flight => flight.Departure);

            return this;
        }
    }
}