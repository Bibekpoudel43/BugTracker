namespace Assignment2
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelChangePassword = new System.Windows.Forms.LinkLabel();
            this.linkLabelBugHistory = new System.Windows.Forms.LinkLabel();
            this.linkLabelViewBug = new System.Windows.Forms.LinkLabel();
            this.linkReport = new System.Windows.Forms.LinkLabel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.lbllogout = new System.Windows.Forms.LinkLabel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblhome = new System.Windows.Forms.LinkLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.linkLabelChangePassword);
            this.panel1.Controls.Add(this.linkLabelBugHistory);
            this.panel1.Controls.Add(this.linkLabelViewBug);
            this.panel1.Controls.Add(this.linkReport);
            this.panel1.Controls.Add(this.labelWelcome);
            this.panel1.Controls.Add(this.lbllogout);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.lblhome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 49);
            this.panel1.TabIndex = 0;
            // 
            // linkLabelChangePassword
            // 
            this.linkLabelChangePassword.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelChangePassword.AutoSize = true;
            this.linkLabelChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelChangePassword.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelChangePassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelChangePassword.ForeColor = System.Drawing.Color.White;
            this.linkLabelChangePassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelChangePassword.LinkColor = System.Drawing.Color.White;
            this.linkLabelChangePassword.Location = new System.Drawing.Point(1036, 13);
            this.linkLabelChangePassword.Name = "linkLabelChangePassword";
            this.linkLabelChangePassword.Size = new System.Drawing.Size(54, 20);
            this.linkLabelChangePassword.TabIndex = 9;
            this.linkLabelChangePassword.TabStop = true;
            this.linkLabelChangePassword.Text = "Profile";
            this.linkLabelChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelChangePassword_LinkClicked);
            // 
            // linkLabelBugHistory
            // 
            this.linkLabelBugHistory.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelBugHistory.AutoSize = true;
            this.linkLabelBugHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelBugHistory.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelBugHistory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelBugHistory.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelBugHistory.LinkColor = System.Drawing.Color.White;
            this.linkLabelBugHistory.Location = new System.Drawing.Point(283, 13);
            this.linkLabelBugHistory.Name = "linkLabelBugHistory";
            this.linkLabelBugHistory.Size = new System.Drawing.Size(88, 20);
            this.linkLabelBugHistory.TabIndex = 8;
            this.linkLabelBugHistory.TabStop = true;
            this.linkLabelBugHistory.Text = "Bug History";
            this.linkLabelBugHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBugHistory_LinkClicked);
            // 
            // linkLabelViewBug
            // 
            this.linkLabelViewBug.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelViewBug.AutoSize = true;
            this.linkLabelViewBug.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelViewBug.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabelViewBug.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelViewBug.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelViewBug.LinkColor = System.Drawing.Color.White;
            this.linkLabelViewBug.Location = new System.Drawing.Point(185, 13);
            this.linkLabelViewBug.Name = "linkLabelViewBug";
            this.linkLabelViewBug.Size = new System.Drawing.Size(79, 20);
            this.linkLabelViewBug.TabIndex = 7;
            this.linkLabelViewBug.TabStop = true;
            this.linkLabelViewBug.Text = "View Bug";
            this.linkLabelViewBug.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clickViewBugs);
            // 
            // linkReport
            // 
            this.linkReport.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkReport.AutoSize = true;
            this.linkReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkReport.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.linkReport.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkReport.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkReport.LinkColor = System.Drawing.Color.White;
            this.linkReport.Location = new System.Drawing.Point(86, 13);
            this.linkReport.Name = "linkReport";
            this.linkReport.Size = new System.Drawing.Size(78, 20);
            this.linkReport.TabIndex = 6;
            this.linkReport.TabStop = true;
            this.linkReport.Text = "File a Bug";
            this.linkReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clickReport);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(691, 13);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(0, 20);
            this.labelWelcome.TabIndex = 5;
            // 
            // lbllogout
            // 
            this.lbllogout.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.lbllogout.AutoSize = true;
            this.lbllogout.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.lbllogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbllogout.LinkColor = System.Drawing.Color.White;
            this.lbllogout.Location = new System.Drawing.Point(1123, 13);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(67, 20);
            this.lbllogout.TabIndex = 4;
            this.lbllogout.TabStop = true;
            this.lbllogout.Text = "Log Out";
            this.lbllogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(541, 15);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(384, 16);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(136, 20);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblhome
            // 
            this.lblhome.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.lblhome.AutoSize = true;
            this.lblhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblhome.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.lblhome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhome.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblhome.LinkColor = System.Drawing.Color.White;
            this.lblhome.Location = new System.Drawing.Point(12, 13);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(52, 20);
            this.lblhome.TabIndex = 0;
            this.lblhome.TabStop = true;
            this.lblhome.Text = "Home";
            this.lblhome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clickHomeMenu);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1202, 628);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblhome;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.LinkLabel lbllogout;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.LinkLabel linkReport;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.LinkLabel linkLabelViewBug;
        private System.Windows.Forms.LinkLabel linkLabelBugHistory;
        private System.Windows.Forms.LinkLabel linkLabelChangePassword;
    }
}