using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Assignment2
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrackingsys; password=; SslMode=none;");
        MySqlDataAdapter ada;
        DataTable dt;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void labelexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.Show();        
        }

        private void click_login(object sender, EventArgs e)
        {
            //validation
            if (txtname.Text == "")
            {
                lblusername.Text = "•Please enter username ";
            }
            else if (txtpassword.Text == "")
            {
                lblpassword.Text = " •Please enter password ";
            }

            string user = txtname.Text;
            string pass = txtpassword.Text;
            dt = new DataTable();
            try
            {
                string query = "select * from admin where username ='" + user + "' and password='" + pass + "'";
                ada = new MySqlDataAdapter(query, con);
                ada.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("incorrect username and password", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clickExit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
