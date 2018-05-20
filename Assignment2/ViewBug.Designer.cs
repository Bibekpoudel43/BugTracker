namespace Assignment2
{
    partial class ViewBug
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBug = new System.Windows.Forms.DataGridView();
            this.btnShowBugs = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblPname = new System.Windows.Forms.Label();
            this.lblclass = new System.Windows.Forms.Label();
            this.lblmethod = new System.Windows.Forms.Label();
            this.lblLineNo = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblAssignedto = new System.Windows.Forms.Label();
            this.lblassignedby = new System.Windows.Forms.Label();
            this.lblsummary = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAddedDAte = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnViewCode = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBug)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assigned bug for you";
            // 
            // dataGridViewBug
            // 
            this.dataGridViewBug.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBug.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewBug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBug.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewBug.Name = "dataGridViewBug";
            this.dataGridViewBug.Size = new System.Drawing.Size(645, 228);
            this.dataGridViewBug.TabIndex = 2;
            this.dataGridViewBug.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBug_CellClick);
            // 
            // btnShowBugs
            // 
            this.btnShowBugs.BackColor = System.Drawing.Color.Tomato;
            this.btnShowBugs.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnShowBugs.FlatAppearance.BorderSize = 0;
            this.btnShowBugs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnShowBugs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnShowBugs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowBugs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowBugs.ForeColor = System.Drawing.Color.White;
            this.btnShowBugs.Location = new System.Drawing.Point(549, 30);
            this.btnShowBugs.Name = "btnShowBugs";
            this.btnShowBugs.Size = new System.Drawing.Size(94, 24);
            this.btnShowBugs.TabIndex = 10;
            this.btnShowBugs.Text = "Show Bugs";
            this.btnShowBugs.UseVisualStyleBackColor = false;
            this.btnShowBugs.Click += new System.EventHandler(this.btnShowBugs_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Tomato;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(803, 562);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 33);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Tomato;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label14.Location = new System.Drawing.Point(664, 326);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 21);
            this.label14.TabIndex = 49;
            this.label14.Text = "Assigned To";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Tomato;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label15.Location = new System.Drawing.Point(666, 518);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 21);
            this.label15.TabIndex = 48;
            this.label15.Text = "Summary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(663, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 47;
            this.label8.Text = "Code Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(663, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 46;
            this.label6.Text = "Line No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(663, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(664, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(663, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Project Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Tomato;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label13.Location = new System.Drawing.Point(666, 467);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 21);
            this.label13.TabIndex = 50;
            this.label13.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(664, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Assigned by";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(665, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "Language";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Tomato;
            this.label9.Location = new System.Drawing.Point(831, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(831, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Tomato;
            this.label11.Location = new System.Drawing.Point(831, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 17);
            this.label11.TabIndex = 57;
            this.label11.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Tomato;
            this.label12.Location = new System.Drawing.Point(831, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 17);
            this.label12.TabIndex = 56;
            this.label12.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Tomato;
            this.label16.Location = new System.Drawing.Point(831, 281);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 17);
            this.label16.TabIndex = 59;
            this.label16.Text = ":";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Tomato;
            this.label17.Location = new System.Drawing.Point(831, 231);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 17);
            this.label17.TabIndex = 58;
            this.label17.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Tomato;
            this.label18.Location = new System.Drawing.Point(831, 373);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(12, 17);
            this.label18.TabIndex = 61;
            this.label18.Text = ":";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Tomato;
            this.label19.Location = new System.Drawing.Point(831, 323);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(12, 17);
            this.label19.TabIndex = 60;
            this.label19.Text = ":";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Tomato;
            this.label20.Location = new System.Drawing.Point(832, 471);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(12, 17);
            this.label20.TabIndex = 63;
            this.label20.Text = ":";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Tomato;
            this.label21.Location = new System.Drawing.Point(832, 522);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(12, 17);
            this.label21.TabIndex = 62;
            this.label21.Text = ":";
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPname.ForeColor = System.Drawing.Color.Tomato;
            this.lblPname.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPname.Location = new System.Drawing.Point(883, 27);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(20, 21);
            this.lblPname.TabIndex = 64;
            this.lblPname.Text = "--";
            // 
            // lblclass
            // 
            this.lblclass.AutoSize = true;
            this.lblclass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclass.ForeColor = System.Drawing.Color.Tomato;
            this.lblclass.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblclass.Location = new System.Drawing.Point(883, 77);
            this.lblclass.Name = "lblclass";
            this.lblclass.Size = new System.Drawing.Size(20, 21);
            this.lblclass.TabIndex = 65;
            this.lblclass.Text = "--";
            // 
            // lblmethod
            // 
            this.lblmethod.AutoSize = true;
            this.lblmethod.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmethod.ForeColor = System.Drawing.Color.Tomato;
            this.lblmethod.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblmethod.Location = new System.Drawing.Point(883, 128);
            this.lblmethod.Name = "lblmethod";
            this.lblmethod.Size = new System.Drawing.Size(20, 21);
            this.lblmethod.TabIndex = 66;
            this.lblmethod.Text = "--";
            // 
            // lblLineNo
            // 
            this.lblLineNo.AutoSize = true;
            this.lblLineNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineNo.ForeColor = System.Drawing.Color.Tomato;
            this.lblLineNo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblLineNo.Location = new System.Drawing.Point(883, 180);
            this.lblLineNo.Name = "lblLineNo";
            this.lblLineNo.Size = new System.Drawing.Size(20, 21);
            this.lblLineNo.TabIndex = 67;
            this.lblLineNo.Text = "--";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Tomato;
            this.lblAuthor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAuthor.Location = new System.Drawing.Point(883, 231);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(20, 21);
            this.lblAuthor.TabIndex = 68;
            this.lblAuthor.Text = "--";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.ForeColor = System.Drawing.Color.Tomato;
            this.lblLanguage.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblLanguage.Location = new System.Drawing.Point(883, 281);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(20, 21);
            this.lblLanguage.TabIndex = 69;
            this.lblLanguage.Text = "--";
            // 
            // lblAssignedto
            // 
            this.lblAssignedto.AutoSize = true;
            this.lblAssignedto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedto.ForeColor = System.Drawing.Color.Tomato;
            this.lblAssignedto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAssignedto.Location = new System.Drawing.Point(883, 326);
            this.lblAssignedto.Name = "lblAssignedto";
            this.lblAssignedto.Size = new System.Drawing.Size(20, 21);
            this.lblAssignedto.TabIndex = 70;
            this.lblAssignedto.Text = "--";
            // 
            // lblassignedby
            // 
            this.lblassignedby.AutoSize = true;
            this.lblassignedby.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblassignedby.ForeColor = System.Drawing.Color.Tomato;
            this.lblassignedby.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblassignedby.Location = new System.Drawing.Point(883, 373);
            this.lblassignedby.Name = "lblassignedby";
            this.lblassignedby.Size = new System.Drawing.Size(20, 21);
            this.lblassignedby.TabIndex = 71;
            this.lblassignedby.Text = "--";
            // 
            // lblsummary
            // 
            this.lblsummary.AutoSize = true;
            this.lblsummary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsummary.ForeColor = System.Drawing.Color.Tomato;
            this.lblsummary.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblsummary.Location = new System.Drawing.Point(884, 522);
            this.lblsummary.Name = "lblsummary";
            this.lblsummary.Size = new System.Drawing.Size(20, 21);
            this.lblsummary.TabIndex = 72;
            this.lblsummary.Text = "--";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Un-Fixed",
            "Fixed"});
            this.comboBox1.Location = new System.Drawing.Point(888, 471);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 73;
            // 
            // lblAddedDAte
            // 
            this.lblAddedDAte.AutoSize = true;
            this.lblAddedDAte.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddedDAte.ForeColor = System.Drawing.Color.Tomato;
            this.lblAddedDAte.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAddedDAte.Location = new System.Drawing.Point(883, 424);
            this.lblAddedDAte.Name = "lblAddedDAte";
            this.lblAddedDAte.Size = new System.Drawing.Size(20, 21);
            this.lblAddedDAte.TabIndex = 76;
            this.lblAddedDAte.Text = "--";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Tomato;
            this.label23.Location = new System.Drawing.Point(831, 424);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(12, 17);
            this.label23.TabIndex = 75;
            this.label23.Text = ":";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Tomato;
            this.label24.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label24.Location = new System.Drawing.Point(665, 420);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(110, 21);
            this.label24.TabIndex = 74;
            this.label24.Text = "Added Date";
            // 
            // btnViewCode
            // 
            this.btnViewCode.BackColor = System.Drawing.Color.Tomato;
            this.btnViewCode.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btnViewCode.FlatAppearance.BorderSize = 0;
            this.btnViewCode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btnViewCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnViewCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCode.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCode.ForeColor = System.Drawing.Color.White;
            this.btnViewCode.Location = new System.Drawing.Point(549, 366);
            this.btnViewCode.Name = "btnViewCode";
            this.btnViewCode.Size = new System.Drawing.Size(94, 24);
            this.btnViewCode.TabIndex = 78;
            this.btnViewCode.Text = "View Code";
            this.btnViewCode.UseVisualStyleBackColor = false;
            this.btnViewCode.Click += new System.EventHandler(this.clickViewCode);
            // 
            // ViewBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1121, 620);
            this.Controls.Add(this.btnViewCode);
            this.Controls.Add(this.lblAddedDAte);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblsummary);
            this.Controls.Add(this.lblassignedby);
            this.Controls.Add(this.lblAssignedto);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblLineNo);
            this.Controls.Add(this.lblmethod);
            this.Controls.Add(this.lblclass);
            this.Controls.Add(this.lblPname);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowBugs);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridViewBug);
            this.Controls.Add(this.label1);
            this.Name = "ViewBug";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewBug";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBug;
        private System.Windows.Forms.Button btnShowBugs;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblPname;
        private System.Windows.Forms.Label lblclass;
        private System.Windows.Forms.Label lblmethod;
        private System.Windows.Forms.Label lblLineNo;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblAssignedto;
        private System.Windows.Forms.Label lblassignedby;
        private System.Windows.Forms.Label lblsummary;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAddedDAte;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnViewCode;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}