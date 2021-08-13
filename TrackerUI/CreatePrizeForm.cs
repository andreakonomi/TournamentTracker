using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void btnCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new(
                    txtPlaceName.Text, 
                    txtPlaceNumber.Text, 
                    txtPrizeAmount.Text, 
                    txtPrizePercentage.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);      //here we get in return a prizeModel but for the moment we have no use for it
                }

                txtPlaceName.Text = "";         //if successful clear controls
                txtPlaceNumber.Text = "";
                txtPrizeAmount.Text = "0";
                txtPrizePercentage.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again!");
            }
        }

        /// <summary>
        /// Validates all controls on the form for proper input.
        /// </summary>
        /// <returns>true if all controls are filled correctly, false if they are not.</returns>
        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(txtPlaceNumber.Text, out placeNumber);

            if (placeNumberValidNumber == false)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (string.IsNullOrWhiteSpace(txtPlaceName.Text))
            {
                output = false;
            }

            decimal prizeAmount;
            double prizePercentage;

            bool prizeAmountValid = decimal.TryParse(txtPrizeAmount.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(txtPrizePercentage.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }

            if ( prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }


    }
}
