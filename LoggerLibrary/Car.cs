using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary
{
    class Car
    {
        /// <summary>
        /// Unique Id of the car.
        /// </summary>
        public int CarId { get; set; }

        /// <summary>
        /// Name of the car.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Year of production.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Metric or imperial type of units.
        /// </summary>
        public bool Metric { get; set; }

        /// <summary>
        /// Actual mileage while entering the car.
        /// </summary>
        public double Mileage { get; set; }

        /// <summary>
        /// Fuel consumption in the city.
        /// </summary>
        public double EfficiencyCity { get; set; }

        /// <summary>
        /// Fuel consumption on the highway.
        /// </summary>
        public double EfficiencyHighway { get; set; }

        /// <summary>
        /// Average fuel consumption combined with EfficiencyCity and EfficiencyHighway.
        /// </summary>
        public double EfficiencyCombined { get; set; }

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
