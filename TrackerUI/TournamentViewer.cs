using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewer : Form
    {
        private TournamentModel tournament;
        BindingList<int> rounds = new();
        BindingList<MatchupModel> selectedMatchups = new();

        public TournamentViewer(TournamentModel tournamentModel)
        {
            InitializeComponent();
            tournament = tournamentModel;
            LoadFormData();
            
            WireUpLists();

            LoadRounds();
            LoadMatchups();
        }

        private void LoadFormData()
        {
            lblTournamentName.Text = tournament.TournamentName;
        }

        private void WireUpLists()
        {
            cmbRound.DataSource = rounds;
            ltbMatchup.DataSource = selectedMatchups;
            ltbMatchup.DisplayMember = "DisplayName";
        }

        private void WireUpMatchupsLists()
        {

        }

        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                    currRound++;
                }
            }
        }

        private void cmbRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();

            if (selectedMatchups.Count > 0)
            {
                ltbMatchup.SelectedIndex = 0;
            }
            LoadMatchup();
        }

        private void LoadMatchups()
        {
            int round = (int)cmbRound.SelectedItem;

            foreach (List<MatchupModel> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (MatchupModel m in matchups)
                    {
                        selectedMatchups.Add(m);
                    }
                }
            }
        }

        private void LoadMatchup()
        {
            if (selectedMatchups.Count == 0) return;

            MatchupModel m = (MatchupModel)ltbMatchup.SelectedItem;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        lblTeamOneName.Text = m.Entries[0].TeamCompeting.TeamName;
                        txtTeamOneScoreValue.Text = m.Entries[0].Score.ToString();

                        lblTeamTwoName.Text = "<bye>";
                        txtTeamTwoScore.Text = "0";
                    }
                    else
                    {
                        lblTeamOneName.Text = "Not Yet Set";
                        txtTeamTwoScore.Text = "";
                    }
                }

                if (i == 1)
                {
                    if (m.Entries[1].TeamCompeting != null)
                    {
                        lblTeamTwoName.Text = m.Entries[1].TeamCompeting.TeamName;
                        txtTeamTwoScore.Text = m.Entries[1].Score.ToString();
                    }
                    else
                    {
                        lblTeamTwoName.Text = "Not Yet Set";
                        txtTeamTwoScore.Text = "";
                    }
                }
            }
        }

        private void ltbMatchup_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup();
        }
    }
}
