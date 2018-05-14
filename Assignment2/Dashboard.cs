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
        public Dashboard()
        {
            InitializeComponent();
        }

        private void clickRegister(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.MdiParent = this;
            r.Show();
        }

        private void loginClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm l = new LoginForm();
            l.MdiParent = this;
            l.Show();
        }

        private void clickHome(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home hm = new Home();
            hm.MdiParent = this;
            hm.Show();
        }
    }
}
