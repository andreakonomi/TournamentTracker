using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents the place for the prize.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Represents the naming convention for the place competed.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// Represents the fixed amount that the place won.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// Represents the percentage from the total price that the place won.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
