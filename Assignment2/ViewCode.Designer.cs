namespace Assignment2
{
    partial class ViewCode
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
            this.fastColoredTextBoxCode = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxCode)).BeginInit();
            this.SuspendLayout();
            // 
            // fastColoredTextBoxCode
            // 
            this.fastColoredTextBoxCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBoxCode.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBoxCode.BackBrush = null;
            this.fastColoredTextBoxCode.CharHeight = 14;
            this.fastColoredTextBoxCode.CharWidth = 8;
            this.fastColoredTextBoxCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBoxCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBoxCode.IsReplaceMode = false;
            this.fastColoredTextBoxCode.Location = new System.Drawing.Point(-2, 1);
            this.fastColoredTextBoxCode.Name = "fastColoredTextBoxCode";
            this.fastColoredTextBoxCode.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBoxCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBoxCode.Size = new System.Drawing.Size(573, 424);
            this.fastColoredTextBoxCode.TabIndex = 0;
            this.fastColoredTextBoxCode.Zoom = 100;
            this.fastColoredTextBoxCode.Load += new System.EventHandler(this.fastColoredTextBoxCode_Load);
            // 
            // ViewCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 426);
            this.Controls.Add(this.fastColoredTextBoxCode);
            this.Name = "ViewCode";
            this.Text = "ViewCode";
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBoxCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBoxCode;
    }
}