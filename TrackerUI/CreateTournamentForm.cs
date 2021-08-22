using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequestor
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new();
        List<PrizeModel> selectedPrizes = new();

        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        private void WireUpLists()
        {
            cmbSelectTeam.DataSource = null;
            cmbSelectTeam.DataSource = availableTeams;
            cmbSelectTeam.DisplayMember = "TeamName";

            ltbTournamentTeams.DataSource = null;
            ltbTournamentTeams.DataSource = selectedTeams;
            ltbTournamentTeams.DisplayMember = "TeamName";

            ltbPrizes.DataSource = null;
            ltbPrizes.DataSource = selectedPrizes;
            ltbPrizes.DisplayMember = "PlaceName";
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (cmbSelectTeam.SelectedIndex == -1) return;
            TeamModel p = (TeamModel)cmbSelectTeam.SelectedItem;

            availableTeams.Remove(p);
            selectedTeams.Add(p);

            WireUpLists();
        }

        private void btnCreatePrize_Click(object sender, EventArgs e)
        {
            // Call the create prize form
            CreatePrizeForm frm = new(this);
            frm.Show();


        }

        public void PrizeComplete(PrizeModel model)
        {
            //Get back from the form a PrizeModel
            //Take the PrizeModel and put into our list of selected prizes

            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void llblCreateNewTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new(this);
            frm.Show();
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            if (ltbTournamentTeams.SelectedIndex == -1) return;
            TeamModel t = (TeamModel)ltbTournamentTeams.SelectedItem;

            selectedTeams.Remove(t);
            availableTeams.Add(t);

            WireUpLists();
        }

        private void btnRemovePrize_Click(object sender, EventArgs e)
        {
            if (ltbPrizes.SelectedIndex == -1) return;
            PrizeModel p = (PrizeModel)ltbPrizes.SelectedItem;

            selectedPrizes.Remove(p);
            WireUpLists();
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            // Validate data
            bool feeAcceptable = decimal.TryParse(txtEntryFee.Text, out decimal fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee.", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create our tournament model
            TournamentModel tm = new();

            tm.TournamentName = txtTournamentNameValue.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            //TODO - Wire our matchups

            // Create the tournament record
            // Create all of the prizes entries
            // Create all of team entries
            GlobalConfig.Connection.CreateTournament(tm);
        }
    }
}
