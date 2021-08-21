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
    public partial class CreateTournamentForm : Form
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
    }
}
