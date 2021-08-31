
namespace TrackerUI
{
    partial class TournamentViewer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewer));
            this.lblTournament = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.cmbRound = new System.Windows.Forms.ComboBox();
            this.chkUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.ltbMatchup = new System.Windows.Forms.ListBox();
            this.lblTeamOneName = new System.Windows.Forms.Label();
            this.lblScoreTeamOne = new System.Windows.Forms.Label();
            this.txtTeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.txtTeamTwoScore = new System.Windows.Forms.TextBox();
            this.lblTeamTwoScore = new System.Windows.Forms.Label();
            this.lblTeamTwoName = new System.Windows.Forms.Label();
            this.lblVs = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTournament
            // 
            this.lblTournament.AutoSize = true;
            this.lblTournament.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTournament.Location = new System.Drawing.Point(12, 9);
            this.lblTournament.Name = "lblTournament";
            this.lblTournament.Size = new System.Drawing.Size(224, 50);
            this.lblTournament.TabIndex = 0;
            this.lblTournament.Text = "Tournament :";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTournamentName.Location = new System.Drawing.Point(232, 9);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(150, 50);
            this.lblTournamentName.TabIndex = 1;
            this.lblTournamentName.Text = "<none>";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRound.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblRound.Location = new System.Drawing.Point(18, 74);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(94, 37);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "Round";
            // 
            // cmbRound
            // 
            this.cmbRound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRound.FormattingEnabled = true;
            this.cmbRound.Location = new System.Drawing.Point(127, 73);
            this.cmbRound.Name = "cmbRound";
            this.cmbRound.Size = new System.Drawing.Size(197, 38);
            this.cmbRound.TabIndex = 3;
            this.cmbRound.SelectedIndexChanged += new System.EventHandler(this.cmbRound_SelectedIndexChanged);
            // 
            // chkUnplayedOnly
            // 
            this.chkUnplayedOnly.AutoSize = true;
            this.chkUnplayedOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkUnplayedOnly.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkUnplayedOnly.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chkUnplayedOnly.Location = new System.Drawing.Point(127, 130);
            this.chkUnplayedOnly.Name = "chkUnplayedOnly";
            this.chkUnplayedOnly.Size = new System.Drawing.Size(209, 41);
            this.chkUnplayedOnly.TabIndex = 4;
            this.chkUnplayedOnly.Text = "Unplayed Only";
            this.chkUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // ltbMatchup
            // 
            this.ltbMatchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltbMatchup.FormattingEnabled = true;
            this.ltbMatchup.ItemHeight = 30;
            this.ltbMatchup.Location = new System.Drawing.Point(18, 193);
            this.ltbMatchup.Name = "ltbMatchup";
            this.ltbMatchup.Size = new System.Drawing.Size(306, 242);
            this.ltbMatchup.TabIndex = 5;
            this.ltbMatchup.SelectedIndexChanged += new System.EventHandler(this.ltbMatchup_SelectedIndexChanged);
            // 
            // lblTeamOneName
            // 
            this.lblTeamOneName.AutoSize = true;
            this.lblTeamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTeamOneName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTeamOneName.Location = new System.Drawing.Point(385, 193);
            this.lblTeamOneName.Name = "lblTeamOneName";
            this.lblTeamOneName.Size = new System.Drawing.Size(165, 37);
            this.lblTeamOneName.TabIndex = 6;
            this.lblTeamOneName.Text = "<team one>";
            // 
            // lblScoreTeamOne
            // 
            this.lblScoreTeamOne.AutoSize = true;
            this.lblScoreTeamOne.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScoreTeamOne.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblScoreTeamOne.Location = new System.Drawing.Point(395, 245);
            this.lblScoreTeamOne.Name = "lblScoreTeamOne";
            this.lblScoreTeamOne.Size = new System.Drawing.Size(82, 37);
            this.lblScoreTeamOne.TabIndex = 7;
            this.lblScoreTeamOne.Text = "Score";
            // 
            // txtTeamOneScoreValue
            // 
            this.txtTeamOneScoreValue.Location = new System.Drawing.Point(483, 245);
            this.txtTeamOneScoreValue.Name = "txtTeamOneScoreValue";
            this.txtTeamOneScoreValue.Size = new System.Drawing.Size(99, 35);
            this.txtTeamOneScoreValue.TabIndex = 8;
            // 
            // txtTeamTwoScore
            // 
            this.txtTeamTwoScore.Location = new System.Drawing.Point(483, 391);
            this.txtTeamTwoScore.Name = "txtTeamTwoScore";
            this.txtTeamTwoScore.Size = new System.Drawing.Size(99, 35);
            this.txtTeamTwoScore.TabIndex = 11;
            // 
            // lblTeamTwoScore
            // 
            this.lblTeamTwoScore.AutoSize = true;
            this.lblTeamTwoScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTeamTwoScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTeamTwoScore.Location = new System.Drawing.Point(395, 389);
            this.lblTeamTwoScore.Name = "lblTeamTwoScore";
            this.lblTeamTwoScore.Size = new System.Drawing.Size(82, 37);
            this.lblTeamTwoScore.TabIndex = 10;
            this.lblTeamTwoScore.Text = "Score";
            // 
            // lblTeamTwoName
            // 
            this.lblTeamTwoName.AutoSize = true;
            this.lblTeamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTeamTwoName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTeamTwoName.Location = new System.Drawing.Point(385, 339);
            this.lblTeamTwoName.Name = "lblTeamTwoName";
            this.lblTeamTwoName.Size = new System.Drawing.Size(165, 37);
            this.lblTeamTwoName.TabIndex = 9;
            this.lblTeamTwoName.Text = "<team two>";
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVs.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblVs.Location = new System.Drawing.Point(454, 298);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(84, 37);
            this.lblVs.TabIndex = 12;
            this.lblVs.Text = "- VS -";
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnScore.Location = new System.Drawing.Point(594, 299);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(101, 41);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 470);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.txtTeamTwoScore);
            this.Controls.Add(this.lblTeamTwoScore);
            this.Controls.Add(this.lblTeamTwoName);
            this.Controls.Add(this.txtTeamOneScoreValue);
            this.Controls.Add(this.lblScoreTeamOne);
            this.Controls.Add(this.lblTeamOneName);
            this.Controls.Add(this.ltbMatchup);
            this.Controls.Add(this.chkUnplayedOnly);
            this.Controls.Add(this.cmbRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblTournament);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTournament;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox cmbRound;
        private System.Windows.Forms.CheckBox chkUnplayedOnly;
        private System.Windows.Forms.ListBox ltbMatchup;
        private System.Windows.Forms.Label lblTeamOneName;
        private System.Windows.Forms.Label lblScoreTeamOne;
        private System.Windows.Forms.TextBox txtTeamOneScoreValue;
        private System.Windows.Forms.TextBox txtTeamTwoScore;
        private System.Windows.Forms.Label lblTeamTwoScore;
        private System.Windows.Forms.Label lblTeamTwoName;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.Button btnScore;
    }
}

