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
    public partial class UserRole : Form
    {
        //set connection to mysql database
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrackingsys; password=; SslMode=none;");
        MySqlDataAdapter ada;
        DataSet dt;
        DataTable d;
        MySqlCommand myCommand;
        private int userId, roleID = -1;
        public UserRole()
        {
            InitializeComponent();
            selectRole();
            selectUsers();
        }

        private void clickAdd(object sender, EventArgs e)
        {
            //validation
            if (comboBoxUser.Text == "")
            {
                labelUser.Text = " •Please Select Any  User";
            }
            else if (comboBoxRole.Text == "")
            {
                labelRole.Text = "•Please Select Any Role";
            }
            else
            {
                getUser();
                getRole();
                //calling method
                addUserRole();
            }
        }

        /// <summary>
        /// fecth data from database and load it into a combo box
        /// </summary>
        public void selectRole()
        {
            dt = new DataSet();
            try
            {
                string query = "select id, user_type from roles";
                MySqlCommand cmd = new MySqlCommand(query, con);
                ada = new MySqlDataAdapter(query, con);
                ada.Fill(dt);
                comboBoxRole.DataSource = dt.Tables[0];
                comboBoxRole.DisplayMember = "user_type";
                comboBoxRole.ValueMember = "id";
                comboBoxRole.Enabled = true;
                comboBoxRole.SelectedIndex = -1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// fecth data from database and load it into a combo box
        /// </summary>
        public void selectUsers()
        {
            dt = new DataSet();
            try
            {
                string query = "select id, username from users";
                MySqlCommand cmd = new MySqlCommand(query, con);
                ada = new MySqlDataAdapter(query, con);
                ada.Fill(dt);
                comboBoxUser.DataSource = dt.Tables[0];
                comboBoxUser.DisplayMember = "username";
                comboBoxUser.ValueMember = "id";
                comboBoxUser.Enabled = true;
                comboBoxUser.SelectedIndex = -1;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// inserting data based on the selected value
        /// </summary>
        public void addUserRole()
        {
            try
            {
                string myInsertQuery = "INSERT INTO user_roles(user_id, role_id) values("+userId+","+roleID+")";
                myCommand = new MySqlCommand(myInsertQuery, con);
                con.Open();
                if (myCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Added Sucessfully!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            myCommand.Connection.Close();
        }
        /// <summary>
        /// get the specific user
        /// </summary>
        public void getUser()
        {
            d = new DataTable();
            try
            {
                string query = "select id from users where username='"+comboBoxUser.Text+"'";
                ada = new MySqlDataAdapter(query, con);
                ada.Fill(d);

                IDataReader uRes = d.CreateDataReader();

                while (uRes.Read())
                {
                    userId = uRes.GetInt32(0);
                }
                
            }
            catch (Exception)
            {
                //MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// get the specific role for user
        /// </summary>
        public void getRole()
        {

            d = new DataTable();
            try
            {
                string query = "select id from roles where user_type='"+comboBoxRole.Text+"'";
                ada = new MySqlDataAdapter(query, con);
                ada.Fill(d);

                IDataReader uRes = d.CreateDataReader();

                if (d.Rows.Count == 1)
                {
                    while (uRes.Read())
                    {
                        roleID = uRes.GetInt32(0);
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
    }
 }

