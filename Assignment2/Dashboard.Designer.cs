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
            this.lbllogout = new System.Windows.Forms.LinkLabel();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lbllogin = new System.Windows.Forms.LinkLabel();
            this.lblregister = new System.Windows.Forms.LinkLabel();
            this.lblhome = new System.Windows.Forms.LinkLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.lbllogout);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.lbllogin);
            this.panel1.Controls.Add(this.lblregister);
            this.panel1.Controls.Add(this.lblhome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 42);
            this.panel1.TabIndex = 0;
            // 
            // lbllogout
            // 
            this.lbllogout.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.lbllogout.AutoSize = true;
            this.lbllogout.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.lbllogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbllogout.LinkColor = System.Drawing.Color.White;
            this.lbllogout.Location = new System.Drawing.Point(834, 11);
            this.lbllogout.Name = "lbllogout";
            this.lbllogout.Size = new System.Drawing.Size(67, 20);
            this.lbllogout.TabIndex = 4;
            this.lbllogout.TabStop = true;
            this.lbllogout.Text = "Log Out";
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(392, 8);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(239, 11);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(136, 20);
            this.txtsearch.TabIndex = 0;
            // 
            // lbllogin
            // 
            this.lbllogin.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.lbllogin.AutoSize = true;
            this.lbllogin.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.lbllogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllogin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lbllogin.LinkColor = System.Drawing.Color.White;
            this.lbllogin.Location = new System.Drawing.Point(168, 9);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(54, 20);
            this.lbllogin.TabIndex = 2;
            this.lbllogin.TabStop = true;
            this.lbllogin.Text = "Log In";
            this.lbllogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginClick);
            // 
            // lblregister
            // 
            this.lblregister.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.lblregister.AutoSize = true;
            this.lblregister.DisabledLinkColor = System.Drawing.Color.DarkRed;
            this.lblregister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregister.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblregister.LinkColor = System.Drawing.Color.White;
            this.lblregister.Location = new System.Drawing.Point(84, 9);
            this.lblregister.Name = "lblregister";
            this.lblregister.Size = new System.Drawing.Size(67, 20);
            this.lblregister.TabIndex = 1;
            this.lblregister.TabStop = true;
            this.lblregister.Text = "Register";
            this.lblregister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clickRegister);
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
            this.lblhome.Location = new System.Drawing.Point(12, 9);
            this.lblhome.Name = "lblhome";
            this.lblhome.Size = new System.Drawing.Size(52, 20);
            this.lblhome.TabIndex = 0;
            this.lblhome.TabStop = true;
            this.lblhome.Text = "Home";
            this.lblhome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clickHome);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(913, 545);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblregister;
        private System.Windows.Forms.LinkLabel lblhome;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.LinkLabel lbllogin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.LinkLabel lbllogout;
        private System.Windows.Forms.Button btnsearch;
    }
}