using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerLibrary
{
    class Trip
    {
        /// <summary>
        /// Car used for the trip.
        /// </summary>
        public Car Car { get; set; }

        /// <summary>
        /// Distance traveled.
        /// </summary>
        public double Distance { get; set; }

        /// <summary>
        /// Driving around the city.
        /// </summary>
        public bool InCity { get; set; }

        /// <summary>
        /// Date of the trip.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Additional information (200 characters).
        /// </summary>
        public string AdditionalInfo { get; set; }
    }
}
