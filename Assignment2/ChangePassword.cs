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
    public partial class ChangePassword : Form
    {
        public static string user, email, userRole;
        public static int uId;
        //set connection to mysql database
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrackingsys; password=; SslMode=none;");
        MySqlCommand myCommand;
        //get the password of logged in user
        string pas = LoginForm.userPassword;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            //validation
            if (txtOldPassword.Text == "")
            {
                labelOldPassword.Text = "•Please enter your old password ";
            }
            else if (txtNewPassword.Text == "")
            {
                labelNewPasssword.Text = "•Please enter a new password ";
            }
            else if (!pas.Equals(txtOldPassword.Text))
            {
                MessageBox.Show("Password doesn't match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPassword.Focus();
            }
            else
            {
                //calling method 
                updatePassword();
            }
        }
            
        /// <summary>
        /// update the password of admin user
        /// </summary>
        public void updatePassword()
        {
 
                try
                {
                    string myQuery = "UPDATE users set password='" +txtNewPassword.Text+ "' where id=" + LoginForm.uId;
                    myCommand = new MySqlCommand(myQuery, con);
                    con.Open();
                    if (myCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Sucessfully updated!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myCommand.Connection.Close();
        }
     }
 }
    

