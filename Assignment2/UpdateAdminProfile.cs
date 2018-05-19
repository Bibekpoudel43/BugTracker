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
    public partial class UpdateAdminProfile : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrackingsys; password=; SslMode=none;");
        MySqlDataAdapter ada;
        DataTable dt;
        MySqlCommand myCommand;
        public UpdateAdminProfile()
        {
            InitializeComponent();
            labelID.Text = Convert.ToString(LoginForm.uId);
            viewProfile();
        }

        private void clickUpdate(object sender, EventArgs e)
        {
            //validation
            if (txtfname.Text == "")
            {
                labelfname.Text = "•Please enter your full name ";
            }
            else if (txtemail.Text == "")
            {
                labelemail.Text = " •Please enter your email ";
            }
            else if (txtuname.Text == "")
            {
                labeluname.Text = " •Please enter a username ";
            }
            else if (txtOldPassword.Text == "")
            {
                labelOldPassword.Text = "•Please enter your old password ";
            }
            else if (txtNewPassword.Text == "")
            {
                labelNewPassword.Text = "•Please enter a new password ";
            }
            else
            {
                updateProfile();
            }
        }

        //load admin profile on the textbox
        public void viewProfile() {
            try
            {
                string query = "select * from users where id =" + labelID.Text;
                dt = new DataTable();
                ada = new MySqlDataAdapter(query, con);
                ada.Fill(dt);

                IDataReader uRes = dt.CreateDataReader();

                if (dt.Rows.Count == 1)
                {
                    //Read the data and store them in the list
                    while (uRes.Read())
                    {
                        txtfname.Text = uRes.GetString(1);
                        txtemail.Text = uRes.GetString(2);
                        txtuname.Text = uRes.GetString(3);
                        txtOldPassword.Text = uRes.GetString(4);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void updateProfile()
        {
            try
            {
                string myQuery = "UPDATE users set full_name='"+txtfname.Text+"', email='"+txtemail.Text+"', username='"+txtuname.Text+"', password='"+txtNewPassword.Text+"' WHERE id="+labelID.Text ;
                myCommand = new MySqlCommand(myQuery, con);
                con.Open();
                if (myCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sucessfully updated!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
