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
    public partial class Dashboard : Form
    {
        public Dashboard(string user, string userRole)
        {
            InitializeComponent();
            labelWelcome.Text = "Welcome "+user+ "|" +userRole;
        }

        private void clickHomeMenu(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home hm = new Home();
            hm.MdiParent = this;
            hm.Show();
        }

        private void LogOut(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm l = new LoginForm();
            this.Visible = false;
            l.Visible = true;
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void clickReport(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReportForm r = new ReportForm();
            r.MdiParent = this;
            r.Show();
        }
    }
}
