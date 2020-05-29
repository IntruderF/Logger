using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary
{
    class Refueling
    {
        /// <summary>
        /// Car refueled.
        /// </summary>
        public Car Car { get; set; }

        /// <summary>
        /// Price of the fuel.
        /// </summary>
        public double FuelPrice { get; set; }

        /// <summary>
        /// Amount of the fuel.
        /// </summary>
        public double FuelAmount { get; set; }
    }
}
