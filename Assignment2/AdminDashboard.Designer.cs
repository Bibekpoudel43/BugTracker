namespace Assignment2
{
    partial class AdminDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.labelhome = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnViewUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelWelcome);
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.labelhome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 39);
            this.panel1.TabIndex = 0;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(380, 8);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(0, 20);
            this.labelWelcome.TabIndex = 3;
            // 
            // lblLogout
            // 
            this.lblLogout.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.lblLogout.AutoSize = true;
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.lblLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLogout.LinkColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(915, 8);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(67, 20);
            this.lblLogout.TabIndex = 2;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Log Out";
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clickLogout);
            // 
            // labelhome
            // 
            this.labelhome.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.labelhome.AutoSize = true;
            this.labelhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelhome.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.labelhome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhome.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.labelhome.LinkColor = System.Drawing.Color.White;
            this.labelhome.Location = new System.Drawing.Point(11, 8);
            this.labelhome.Name = "labelhome";
            this.labelhome.Size = new System.Drawing.Size(52, 20);
            this.labelhome.TabIndex = 1;
            this.labelhome.TabStop = true;
            this.labelhome.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Controls.Add(this.btnViewUser);
            this.panel2.Controls.Add(this.btnUpdateProfile);
            this.panel2.Controls.Add(this.btnRole);
            this.panel2.Controls.Add(this.btnAddUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 505);
            this.panel2.TabIndex = 1;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.Olive;
            this.btnUpdateProfile.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnUpdateProfile.FlatAppearance.BorderSize = 0;
            this.btnUpdateProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnUpdateProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProfile.Location = new System.Drawing.Point(12, 250);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(166, 32);
            this.btnUpdateProfile.TabIndex = 13;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.clickUpdateProfile);
            // 
            // btnRole
            // 
            this.btnRole.BackColor = System.Drawing.Color.Olive;
            this.btnRole.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnRole.FlatAppearance.BorderSize = 0;
            this.btnRole.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnRole.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRole.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRole.ForeColor = System.Drawing.Color.White;
            this.btnRole.Location = new System.Drawing.Point(12, 116);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(166, 32);
            this.btnRole.TabIndex = 12;
            this.btnRole.Text = "Assign Role";
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.clickAddRole);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Olive;
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(12, 50);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(166, 32);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.clickAddUsers);
            // 
            // btnViewUser
            // 
            this.btnViewUser.BackColor = System.Drawing.Color.Olive;
            this.btnViewUser.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnViewUser.FlatAppearance.BorderSize = 0;
            this.btnViewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btnViewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnViewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUser.ForeColor = System.Drawing.Color.White;
            this.btnViewUser.Location = new System.Drawing.Point(12, 180);
            this.btnViewUser.Name = "btnViewUser";
            this.btnViewUser.Size = new System.Drawing.Size(166, 32);
            this.btnViewUser.TabIndex = 14;
            this.btnViewUser.Text = "View User";
            this.btnViewUser.UseVisualStyleBackColor = true;
            this.btnViewUser.Click += new System.EventHandler(this.clickViewUser);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel labelhome;
        private System.Windows.Forms.LinkLabel lblLogout;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnViewUser;
    }
}