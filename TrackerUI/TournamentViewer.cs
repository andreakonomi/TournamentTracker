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

        private void RefreshControlsData()
        {
            LoadMatchups();

            if (selectedMatchups.Count > 0)
            {
                ltbMatchup.SelectedIndex = 0;
            }
            LoadMatchup();
        }

        private void cmbRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshControlsData();
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
                        if (m.Winner == null || ! chkUnplayedOnly.Checked)
                        {
                            selectedMatchups.Add(m);
                        }
                    }
                }
            }

            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()   //left at 30:00
        {
            bool isVisible = selectedMatchups.Count > 0;

            lblScoreTeamOne.Visible = isVisible;
            lblTeamOneName.Visible = isVisible;
            txtTeamOneScoreValue.Visible = isVisible;
            lblTeamTwoName.Visible = isVisible;
            lblTeamTwoScore.Visible = isVisible;
            txtTeamTwoScore.Visible = isVisible;
            btnScore.Visible = isVisible;
            lblVs.Visible = isVisible;
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

        private void chkUnplayedOnly_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchups();     //same as another event above, opportunity to refactor

            if (selectedMatchups.Count > 0)
            {
                ltbMatchup.SelectedIndex = 0;
            }
            LoadMatchup();
        }

        private string ValidateData()
        {
            string output = "";
            double teamOneScore = 0;
            double teamTwoScore = 0;

            bool scoreOneValid = double.TryParse(txtTeamOneScoreValue.Text, out teamOneScore);
            bool scoreTwoValid = double.TryParse(txtTeamTwoScore.Text, out teamTwoScore);
            
            if (!scoreOneValid)
            {
                output = "The Score One value is not a valid number.";
            }
            else if (!scoreTwoValid)
            {
                output = "The Score Two value is not a valid number.";
            }
            else if (teamOneScore == 0 || teamTwoScore == 0)
            {
                output = "You did not enter a score for either team.";
            }
            else if (teamOneScore == teamTwoScore)
            {
                output = "We do not allow ties for this application.";
            }

            return output;
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            string errorMessage = ValidateData();
            if (errorMessage.Length > 0)
            {
                MessageBox.Show($"Input error: {errorMessage}");
                return;
            }

            double teamOneScore = 0;
            double teamTwoScore = 0;
            if (selectedMatchups.Count == 0) return;

            MatchupModel m = (MatchupModel)ltbMatchup.SelectedItem;

            for (int i = 0; i < m.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if (m.Entries[0].TeamCompeting != null)
                    {
                        bool scoreValid = double.TryParse(txtTeamOneScoreValue.Text, out teamOneScore);
                        if (scoreValid)
                        {
                            m.Entries[0].Score = teamOneScore;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid score for Team One.");
                            return;
                        }
                    }
                }

                if (i == 1)
                {
                    bool scoreValid = double.TryParse(txtTeamTwoScore.Text, out teamTwoScore);
                    if (scoreValid)
                    {
                        m.Entries[1].Score = teamTwoScore;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid score for Team Two.");
                        return;
                    }
                }
            }

            try
            {
                TournamentLogic.UpdateTournamentResults(tournament);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"The application had the following error: {ex.Message} ");
                return;
            }

            RefreshControlsData();

        
        }
    }
}
