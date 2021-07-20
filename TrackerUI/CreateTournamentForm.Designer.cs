
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
            this.ltbTournamentPlayers = new System.Windows.Forms.ListBox();
            this.lblTournamentPlayers = new System.Windows.Forms.Label();
            this.btnDeletePlayer = new System.Windows.Forms.Button();
            this.btnDeletePrize = new System.Windows.Forms.Button();
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
            this.cmbSelectTeam.FormattingEnabled = true;
            this.cmbSelectTeam.Location = new System.Drawing.Point(21, 260);
            this.cmbSelectTeam.Name = "cmbSelectTeam";
            this.cmbSelectTeam.Size = new System.Drawing.Size(327, 38);
            this.cmbSelectTeam.TabIndex = 14;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSelectTeam.Location = new System.Drawing.Point(21, 218);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(156, 37);
            this.lblSelectTeam.TabIndex = 13;
            this.lblSelectTeam.Text = "Select Team";
            // 
            // llblCreateNewTeam
            // 
            this.llblCreateNewTeam.AutoSize = true;
            this.llblCreateNewTeam.Location = new System.Drawing.Point(234, 224);
            this.llblCreateNewTeam.Name = "llblCreateNewTeam";
            this.llblCreateNewTeam.Size = new System.Drawing.Size(114, 30);
            this.llblCreateNewTeam.TabIndex = 15;
            this.llblCreateNewTeam.TabStop = true;
            this.llblCreateNewTeam.Text = "create new";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddTeam.Location = new System.Drawing.Point(92, 321);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(156, 41);
            this.btnAddTeam.TabIndex = 16;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreatePrize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreatePrize.Location = new System.Drawing.Point(92, 396);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(156, 41);
            this.btnCreatePrize.TabIndex = 17;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            // 
            // ltbTournamentPlayers
            // 
            this.ltbTournamentPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltbTournamentPlayers.FormattingEnabled = true;
            this.ltbTournamentPlayers.ItemHeight = 30;
            this.ltbTournamentPlayers.Location = new System.Drawing.Point(436, 113);
            this.ltbTournamentPlayers.Name = "ltbTournamentPlayers";
            this.ltbTournamentPlayers.Size = new System.Drawing.Size(306, 182);
            this.ltbTournamentPlayers.TabIndex = 18;
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
            // btnDeletePlayer
            // 
            this.btnDeletePlayer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeletePlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeletePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeletePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletePlayer.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeletePlayer.Location = new System.Drawing.Point(768, 179);
            this.btnDeletePlayer.Name = "btnDeletePlayer";
            this.btnDeletePlayer.Size = new System.Drawing.Size(114, 71);
            this.btnDeletePlayer.TabIndex = 20;
            this.btnDeletePlayer.Text = "Delete Selected";
            this.btnDeletePlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeletePrize
            // 
            this.btnDeletePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeletePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeletePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeletePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeletePrize.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeletePrize.Location = new System.Drawing.Point(768, 414);
            this.btnDeletePrize.Name = "btnDeletePrize";
            this.btnDeletePrize.Size = new System.Drawing.Size(114, 70);
            this.btnDeletePrize.TabIndex = 23;
            this.btnDeletePrize.Text = "Delete Selected";
            this.btnDeletePrize.UseVisualStyleBackColor = true;
            // 
            // lblPrizes
            // 
            this.lblPrizes.AutoSize = true;
            this.lblPrizes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrizes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPrizes.Location = new System.Drawing.Point(436, 309);
            this.lblPrizes.Name = "lblPrizes";
            this.lblPrizes.Size = new System.Drawing.Size(198, 37);
            this.lblPrizes.TabIndex = 22;
            this.lblPrizes.Text = "Teams / Players";
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
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 623);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnDeletePrize);
            this.Controls.Add(this.lblPrizes);
            this.Controls.Add(this.ltbPrizes);
            this.Controls.Add(this.btnDeletePlayer);
            this.Controls.Add(this.lblTournamentPlayers);
            this.Controls.Add(this.ltbTournamentPlayers);
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
        private System.Windows.Forms.ListBox ltbTournamentPlayers;
        private System.Windows.Forms.Label lblTournamentPlayers;
        private System.Windows.Forms.Button btnDeletePlayer;
        private System.Windows.Forms.Button btnDeletePrize;
        private System.Windows.Forms.Label lblPrizes;
        private System.Windows.Forms.ListBox ltbPrizes;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}