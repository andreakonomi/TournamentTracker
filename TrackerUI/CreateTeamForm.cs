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
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = txtFirstName.Text;
                p.LastName = txtLastName.Text;
                p.EmailAddress = txtEmail.Text;
                p.CellphoneNumber = txtCellphone.Text;

                GlobalConfig.Connection.CreatePerson(p);

                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtCellphone.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill all the fields.");
            }
        }

        private bool ValidateForm()
        {
            if(txtFirstName.Text.Length == 0)
            {
                return false;
            }

            if (txtLastName.Text.Length == 0)
            {
                return false;
            }

            if (txtEmail.Text.Length == 0)
            {
                return false;
            }

            if (txtCellphone.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
