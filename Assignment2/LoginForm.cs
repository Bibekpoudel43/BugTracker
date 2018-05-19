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
        string user;
        string pass;
        string userRole;
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrackingsys; password=; SslMode=none;");
        MySqlDataAdapter ada;
        DataTable dt;
        public LoginForm()
        {
            InitializeComponent();
        }

       /* private void registerClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.Show();        
        }*/

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

            login();
        }


        //method for login
        public void login() {
             user = txtname.Text;
             pass = txtpassword.Text;
            dt = new DataTable();
            try
            {
                string query = "select u.username, u.password, r.user_type from users u, user_roles ur, roles r  where "+
                    "u.id = ur.user_id  and r.id = ur.role_id and u.username ='" + user + "' and u.password='" + pass + "'";
                ada = new MySqlDataAdapter(query, con);
                ada.Fill(dt);

                IDataReader uRes = dt.CreateDataReader();

                if (dt.Rows.Count == 1)
                {
                    while (uRes.Read())
                    {
                        userRole = uRes.GetString(2);
                    }
                    if (userRole == "admin")
                    {
                        AdminDashboard ad = new AdminDashboard(user, userRole);
                        ad.Show();
                        this.Visible = false;
                    }
                    else {
                        Dashboard d = new Dashboard(user, userRole);
                        d.Show();
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("incorrect username and password", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            
        private void clickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Close(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
