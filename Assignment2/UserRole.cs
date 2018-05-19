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
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrackingsys; password=; SslMode=none;");
        MySqlDataAdapter ada;
        DataSet dt;

        public UserRole()
        {
            InitializeComponent();
            selectRole();
            selectUsers();
        }

        private void clickAdd(object sender, EventArgs e)
        {
            //validation
            if (comboBoxRole.Text == "")
            {
                labelRole.Text = "•Please Select Any Role";
            }
            else if (comboBoxUser.Text == "")
            {
                labelUser.Text = " •Please Select Any  User";
            }
        }

        //fecth data from database and load it into a combo box
        public void selectRole()
        {
            var list = new List<string>();
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
                MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
       }


        //fecth data from database and load it into a combo box
        public void selectUsers()
        {
            var list = new List<string>();
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
                MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
 }

