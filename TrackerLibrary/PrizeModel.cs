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

        public PrizeModel()
        {

        }

        /// <summary>
        /// Sets a PrizeModel object with all it's properties. Sets PrizeAmount 
        /// and PrizePercentage to 0 if input not correct.
        /// </summary>
        /// <param name="placeName">The name of the place for the prize.</param>
        /// <param name="placeNumber">The number indicating the place ranked.</param>
        /// <param name="prizeAmount">The amount of money the prize will receive</param>
        /// <param name="prizePercentage">The percentage of the Total Amount the place will receive.</param>
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
