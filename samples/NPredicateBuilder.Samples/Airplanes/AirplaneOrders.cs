// <copyright file="AirplaneOrders.cs" company="Michael Bradvica LLC">
// Copyright (c) Michael Bradvica LLC. All rights reserved.
// </copyright>

namespace NPredicateBuilder.Samples.Airplanes
{
    /// <summary>
    /// Sample order for an <see cref="Airplane"/>.
    /// </summary>
    public class AirplaneOrders : BaseOrder<Airplane>
    {
        /// <summary>
        /// Sample order.
        /// </summary>
        /// <returns>An instance of <see cref="AirplaneOrders"/>.</returns>
        public AirplaneOrders OrderByManufacturer()
        {
            OrderBy(airplane => airplane.Manufacturer);

            return this;
        }

        /// <summary>
        /// Sample order.
        /// </summary>
        /// <returns>An instance of <see cref="AirplaneOrders"/>.</returns>
        public AirplaneOrders ThenByModel()
        {
            ThenBy(airplane => airplane.Model);

            return this;
        }

        /// <summary>
        /// Sample order.
        /// </summary>
        /// <returns>An instance of <see cref="AirplaneOrders"/>.</returns>
        public AirplaneOrders ByModelDescending()
        {
            OrderByDescending(x => x.Model);

            return this;
        }

        /// <summary>
        /// Sample order.
        /// </summary>
        /// <returns>An instance of <see cref="AirplaneOrders"/>.</returns>
        public AirplaneOrders ThenByManufacturerDescending()
        {
            ThenByDescending(x => x.Manufacturer);

            return this;
        }
    }
}