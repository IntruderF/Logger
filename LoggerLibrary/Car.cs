using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary
{
    class Car
    {
        /// <summary>
        /// Name of the car.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Year of production.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Actual mileage while entering the car.
        /// </summary>
        public double InitialMileage { get; set; }

        /// <summary>
        /// Type of fuel used by the car.
        /// </summary>
        public string Fuel { get; set; }

        /// <summary>
        /// Fuel consumption in the city.
        /// </summary>
        public double InCityConsumption { get; set; }

        /// <summary>
        /// Fuel consumption outside the city.
        /// </summary>
        public double OutCityConsumption { get; set; }

        /// <summary>
        /// Trips entered for the car.
        /// </summary>
        public List<Trip> Trips { get; set; }

        /// <summary>
        /// Notes entered for the car.
        /// </summary>
        public List<Note> Notes { get; set; }
    }
}
