
namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.lblCreateTeam = new System.Windows.Forms.Label();
            this.txtTeamN = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.cmbSelectTeamMember = new System.Windows.Forms.ComboBox();
            this.lblSelectTeamMember = new System.Windows.Forms.Label();
            this.boxAddNewMember = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.ltbTeamMembers = new System.Windows.Forms.ListBox();
            this.btnDeleteTeamMember = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.boxAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreateTeam
            // 
            this.lblCreateTeam.AutoSize = true;
            this.lblCreateTeam.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCreateTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCreateTeam.Location = new System.Drawing.Point(12, 9);
            this.lblCreateTeam.Name = "lblCreateTeam";
            this.lblCreateTeam.Size = new System.Drawing.Size(213, 50);
            this.lblCreateTeam.TabIndex = 2;
            this.lblCreateTeam.Text = "Create Team";
            // 
            // txtTeamN
            // 
            this.txtTeamN.Location = new System.Drawing.Point(32, 113);
            this.txtTeamN.Name = "txtTeamN";
            this.txtTeamN.Size = new System.Drawing.Size(327, 35);
            this.txtTeamN.TabIndex = 12;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTeamName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTeamName.Location = new System.Drawing.Point(23, 71);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(157, 37);
            this.lblTeamName.TabIndex = 11;
            this.lblTeamName.Text = "Team Name";
            // 
            // btnAddMember
            // 
            this.btnAddMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddMember.Location = new System.Drawing.Point(102, 264);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(156, 41);
            this.btnAddMember.TabIndex = 19;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // cmbSelectTeamMember
            // 
            this.cmbSelectTeamMember.FormattingEnabled = true;
            this.cmbSelectTeamMember.Location = new System.Drawing.Point(32, 205);
            this.cmbSelectTeamMember.Name = "cmbSelectTeamMember";
            this.cmbSelectTeamMember.Size = new System.Drawing.Size(327, 38);
            this.cmbSelectTeamMember.TabIndex = 18;
            // 
            // lblSelectTeamMember
            // 
            this.lblSelectTeamMember.AutoSize = true;
            this.lblSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelectTeamMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSelectTeamMember.Location = new System.Drawing.Point(28, 163);
            this.lblSelectTeamMember.Name = "lblSelectTeamMember";
            this.lblSelectTeamMember.Size = new System.Drawing.Size(263, 37);
            this.lblSelectTeamMember.TabIndex = 17;
            this.lblSelectTeamMember.Text = "Select Team Member";
            // 
            // boxAddNewMember
            // 
            this.boxAddNewMember.Controls.Add(this.btnCreateMember);
            this.boxAddNewMember.Controls.Add(this.txtCellphone);
            this.boxAddNewMember.Controls.Add(this.lblCellphone);
            this.boxAddNewMember.Controls.Add(this.txtEmail);
            this.boxAddNewMember.Controls.Add(this.lblEmail);
            this.boxAddNewMember.Controls.Add(this.txtLastName);
            this.boxAddNewMember.Controls.Add(this.lblLastName);
            this.boxAddNewMember.Controls.Add(this.lblFirstName);
            this.boxAddNewMember.Controls.Add(this.txtFirstName);
            this.boxAddNewMember.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxAddNewMember.Location = new System.Drawing.Point(31, 321);
            this.boxAddNewMember.Name = "boxAddNewMember";
            this.boxAddNewMember.Size = new System.Drawing.Size(373, 332);
            this.boxAddNewMember.TabIndex = 20;
            this.boxAddNewMember.TabStop = false;
            this.boxAddNewMember.Text = "Add New Member";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(156, 40);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(199, 43);
            this.txtFirstName.TabIndex = 22;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFirstName.Location = new System.Drawing.Point(6, 37);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(144, 37);
            this.lblFirstName.TabIndex = 21;
            this.lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(156, 102);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 43);
            this.txtLastName.TabIndex = 24;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLastName.Location = new System.Drawing.Point(6, 102);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(142, 37);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(156, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 43);
            this.txtEmail.TabIndex = 26;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEmail.Location = new System.Drawing.Point(6, 166);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 37);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(156, 218);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(199, 43);
            this.txtCellphone.TabIndex = 28;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCellphone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCellphone.Location = new System.Drawing.Point(6, 222);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(138, 37);
            this.lblCellphone.TabIndex = 27;
            this.lblCellphone.Text = "Cellphone";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateMember.Location = new System.Drawing.Point(86, 279);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(177, 40);
            this.btnCreateMember.TabIndex = 29;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            // 
            // ltbTeamMembers
            // 
            this.ltbTeamMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ltbTeamMembers.FormattingEnabled = true;
            this.ltbTeamMembers.ItemHeight = 30;
            this.ltbTeamMembers.Location = new System.Drawing.Point(458, 113);
            this.ltbTeamMembers.Name = "ltbTeamMembers";
            this.ltbTeamMembers.Size = new System.Drawing.Size(306, 542);
            this.ltbTeamMembers.TabIndex = 21;
            // 
            // btnDeleteTeamMember
            // 
            this.btnDeleteTeamMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDeleteTeamMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnDeleteTeamMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnDeleteTeamMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeamMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteTeamMember.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteTeamMember.Location = new System.Drawing.Point(775, 333);
            this.btnDeleteTeamMember.Name = "btnDeleteTeamMember";
            this.btnDeleteTeamMember.Size = new System.Drawing.Size(114, 71);
            this.btnDeleteTeamMember.TabIndex = 22;
            this.btnDeleteTeamMember.Text = "Delete Selected";
            this.btnDeleteTeamMember.UseVisualStyleBackColor = true;
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateTeam.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCreateTeam.Location = new System.Drawing.Point(331, 677);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(190, 62);
            this.btnCreateTeam.TabIndex = 25;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 751);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnDeleteTeamMember);
            this.Controls.Add(this.ltbTeamMembers);
            this.Controls.Add(this.boxAddNewMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.cmbSelectTeamMember);
            this.Controls.Add(this.lblSelectTeamMember);
            this.Controls.Add(this.txtTeamN);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblCreateTeam);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.boxAddNewMember.ResumeLayout(false);
            this.boxAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateTeam;
        private System.Windows.Forms.TextBox txtTeamN;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ComboBox cmbSelectTeamMember;
        private System.Windows.Forms.Label lblSelectTeamMember;
        private System.Windows.Forms.GroupBox boxAddNewMember;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ListBox ltbTeamMembers;
        private System.Windows.Forms.Button btnDeleteTeamMember;
        private System.Windows.Forms.Button btnCreateTeam;
    }
}