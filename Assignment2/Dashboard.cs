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
        public static string searchItem;
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

        private void clickViewBugs(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if user is a tester then enabling the view Bug link
            //if not then opening view bug link
            if (LoginForm.userRole == "tester") {
                linkLabelViewBug.Enabled = false;
            }
            else
            {
                ViewBug vb = new ViewBug();
                vb.MdiParent = this;
                vb.Show();
            }
        }

        private void linkLabelBugHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BugHistory bh = new BugHistory();
            bh.MdiParent = this;
            bh.Show();
        }

        private void linkLabelChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.MdiParent = this;
            cp.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            BugHistory bh = new BugHistory();
            bh.MdiParent = this;
            bh.Show();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //retriving text from search textbar and storing in an variable
            //later use for searching from bug history
            searchItem = txtsearch.Text;
        }
    }
}
