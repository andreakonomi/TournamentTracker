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
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new();
        private ITeamRequestor callingForm;

        public CreateTeamForm(ITeamRequestor caller)
        {
            InitializeComponent();

            callingForm = caller;
            //CreateSampleData();
            WireUpLists();
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Andrea", LastName = "Konomi" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Lebron", LastName = "James" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Kevin", LastName = "Durant" });
        }

        //there are better ways to refresh the controls but for the moment its ok
        private void WireUpLists()
        {
            cmbSelectTeamMember.DataSource = null;
            cmbSelectTeamMember.DataSource = availableTeamMembers;
            cmbSelectTeamMember.DisplayMember = "FullName";

            ltbTeamMembers.DataSource = null;
            ltbTeamMembers.DataSource = selectedTeamMembers;
            ltbTeamMembers.DisplayMember = "FullName";
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

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                WireUpLists();

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

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (cmbSelectTeamMember.SelectedIndex == -1) return;
            PersonModel p = (PersonModel)cmbSelectTeamMember.SelectedItem;

            availableTeamMembers.Remove(p);
            selectedTeamMembers.Add(p);

            WireUpLists();
        }

        private void btnRemoveTeamMember_Click(object sender, EventArgs e)
        {
            if (ltbTeamMembers.SelectedIndex == -1) return; //fixes bug of removing when no item is selected
            PersonModel p = (PersonModel)ltbTeamMembers.SelectedItem;

            selectedTeamMembers.Remove(p);
            availableTeamMembers.Add(p);

            WireUpLists();
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            TeamModel t = new();

            t.TeamName = txtTeamName.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);
            callingForm.TeamComplete(t);

            this.Close();
        }
    }
}
