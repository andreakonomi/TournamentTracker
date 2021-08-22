
namespace TrackerUI
{
    partial class CreateTournamentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.lblCreateTournament = new System.Windows.Forms.Label();
            this.txtTournamentNameValue = new System.Windows.Forms.TextBox();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.txtEntryFee = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.cmbSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.llblCreateNewTeam = new System.Windows.Forms.LinkLabel();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.ltbTournamentTeams = new System.Windows.Forms.ListBox();
            this.lblTournamentPlayers = new System.Windows.Forms.Label();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnRemovePrize = new System.Windows.Forms.Button();
            this.lblPrizes = new System.Windows.Forms.Label();
            this.ltbPrizes = new System.Windows.Forms.ListBox();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreateTournament
            // 
            this.lblCreateTournament.AutoSize = true;
            this.lblCreateTournament.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCreateTournament.Location = new System.Drawing.Point(12, 7);
            this.lblCreateTournament.Name = "lblCreateTournament";
            this.lblCreateTournament.Size = new System.Drawing.Size(317, 50);
            this.lblCreateTournament.TabIndex = 1;
            this.lblCreateTournament.Text = "Create Tournament";
            // 
            // txtTournamentNameValue
            // 
            this.txtTournamentNameValue.Location = new System.Drawing.Point(21, 113);
            this.txtTournamentNameValue.Name = "txtTournamentNameValue";
            this.txtTournamentNameValue.Size = new System.Drawing.Size(327, 35);
            this.txtTournamentNameValue.TabIndex = 10;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTournamentName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTournamentName.Location = new System.Drawing.Point(12, 71);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(236, 37);
            this.lblTournamentName.TabIndex = 9;
            this.lblTournamentName.Text = "Tournament Name";
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.Location = new System.Drawing.Point(152, 169);
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.Size = new System.Drawing.Size(108, 35);
            this.txtEntryFee.TabIndex = 12;
            this.txtEntryFee.Text = "0";
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEntryFee.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEntryFee.Location = new System.Drawing.Point(21, 166);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(125, 37);
            this.lblEntryFee.TabIndex = 11;
            this.lblEntryFee.Text = "Entry Fee";
            // 
            // cmbSelectTeam
            // 
            this.cmbSelectTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectTeam.FormattingEnabled = true;
            this.cmbSelectTeam.Location = new System.Drawing.Point(21, 295);
            this.cmbSelectTeam.Name = "cmbSelectTeam";
            this.cmbSelectTeam.Size = new System.Drawing.Size(327, 38);
            this.cmbSelectTeam.TabIndex = 14;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSelectTeam.Location = new System.Drawing.Point(21, 253);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(156, 37);
            this.lblSelectTeam.TabIndex = 13;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // llblCreateNewTeam
            // 
            this.llblCreateNewTeam.AutoSize = true;
            this.llblCreateNewTeam.Location = new System.Drawing.Point(234, 259);
            this.llblCreateNewTeam.Name = "llblCreateNewTeam";
            this.llblCreateNewTeam.Size = new System.Drawing.Size(114, 30);
            this.llblCreateNewTeam.TabIndex = 15;
            this.llblCreateNewTeam.TabStop = true;
            this.llblCreateNewTeam.Text = "create new";
            this.llblCreateNewTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblCreateNewTeam_LinkClicked);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddTeam.Location = new System.Drawing.Point(92, 356);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(156, 41);
            this.btnAddTeam.TabIndex = 16;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreatePrize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreatePrize.Location = new System.Drawing.Point(92, 431);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(156, 41);
            this.btnCreatePrize.TabIndex = 17;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            this.btnCreatePrize.Click += new System.EventHandler(this.btnCreatePrize_Click);
            // 
            // ltbTournamentTeams
            // 
            this.ltbTournamentTeams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltbTournamentTeams.FormattingEnabled = true;
            this.ltbTournamentTeams.ItemHeight = 30;
            this.ltbTournamentTeams.Location = new System.Drawing.Point(436, 113);
            this.ltbTournamentTeams.Name = "ltbTournamentTeams";
            this.ltbTournamentTeams.Size = new System.Drawing.Size(306, 182);
            this.ltbTournamentTeams.TabIndex = 18;
            // 
            // lblTournamentPlayers
            // 
            this.lblTournamentPlayers.AutoSize = true;
            this.lblTournamentPlayers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTournamentPlayers.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTournamentPlayers.Location = new System.Drawing.Point(436, 71);
            this.lblTournamentPlayers.Name = "lblTournamentPlayers";
            this.lblTournamentPlayers.Size = new System.Drawing.Size(198, 37);
            this.lblTournamentPlayers.TabIndex = 19;
            this.lblTournamentPlayers.Text = "Teams / Players";
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemovePlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemovePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRemovePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemovePlayer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemovePlayer.Location = new System.Drawing.Point(768, 179);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(114, 71);
            this.btnRemovePlayer.TabIndex = 20;
            this.btnRemovePlayer.Text = "Remove Selected";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // btnRemovePrize
            // 
            this.btnRemovePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemovePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemovePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRemovePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemovePrize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemovePrize.Location = new System.Drawing.Point(768, 414);
            this.btnRemovePrize.Name = "btnRemovePrize";
            this.btnRemovePrize.Size = new System.Drawing.Size(114, 70);
            this.btnRemovePrize.TabIndex = 23;
            this.btnRemovePrize.Text = "Remove Selected";
            this.btnRemovePrize.UseVisualStyleBackColor = true;
            this.btnRemovePrize.Click += new System.EventHandler(this.btnRemovePrize_Click);
            // 
            // lblPrizes
            // 
            this.lblPrizes.AutoSize = true;
            this.lblPrizes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrizes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPrizes.Location = new System.Drawing.Point(436, 309);
            this.lblPrizes.Name = "lblPrizes";
            this.lblPrizes.Size = new System.Drawing.Size(85, 37);
            this.lblPrizes.TabIndex = 22;
            this.lblPrizes.Text = "Prizes";
            // 
            // ltbPrizes
            // 
            this.ltbPrizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltbPrizes.FormattingEnabled = true;
            this.ltbPrizes.ItemHeight = 30;
            this.ltbPrizes.Location = new System.Drawing.Point(436, 351);
            this.ltbPrizes.Name = "ltbPrizes";
            this.ltbPrizes.Size = new System.Drawing.Size(306, 182);
            this.ltbPrizes.TabIndex = 21;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateTournament.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateTournament.Location = new System.Drawing.Point(347, 549);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(240, 62);
            this.btnCreateTournament.TabIndex = 24;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 623);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnRemovePrize);
            this.Controls.Add(this.lblPrizes);
            this.Controls.Add(this.ltbPrizes);
            this.Controls.Add(this.btnRemovePlayer);
            this.Controls.Add(this.lblTournamentPlayers);
            this.Controls.Add(this.ltbTournamentTeams);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.llblCreateNewTeam);
            this.Controls.Add(this.cmbSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.txtTournamentNameValue);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblCreateTournament);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateTournament;
        private System.Windows.Forms.TextBox txtTournamentNameValue;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.TextBox txtEntryFee;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.ComboBox cmbSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.LinkLabel llblCreateNewTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.ListBox ltbTournamentTeams;
        private System.Windows.Forms.Label lblTournamentPlayers;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Button btnRemovePrize;
        private System.Windows.Forms.Label lblPrizes;
        private System.Windows.Forms.ListBox ltbPrizes;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}