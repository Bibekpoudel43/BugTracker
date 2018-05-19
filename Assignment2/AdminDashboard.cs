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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard(int uid, string user, string uRole)
        {
            InitializeComponent();
            labelWelcome.Text = "Welcome " + user + "|" + uRole;
        }

        private void clickAddUsers(object sender, EventArgs e)
        {
            Register r = new Register();
            r.MdiParent = this;
            r.Show();
        }

        private void clickAddRole(object sender, EventArgs e)
        {
            UserRole u = new UserRole();
            u.MdiParent = this;
            u.Show();
        }

        private void clickLogout(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            LoginForm l = new LoginForm();
            l.Visible = true;
        }

        private void clickUpdateProfile(object sender, EventArgs e)
        {
            UpdateAdminProfile up = new UpdateAdminProfile();
            up.MdiParent = this;
            up.Show();
        }

        private void clickViewUser(object sender, EventArgs e)
        {
           ViewUsers v = new ViewUsers();
            v.MdiParent = this;
            v.Show();
        }
    }
}
