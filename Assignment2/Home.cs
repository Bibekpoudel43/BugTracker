using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            ReportForm rp = new ReportForm();
            this.Visible = false;
            rp.Show();
        }
    }
}
