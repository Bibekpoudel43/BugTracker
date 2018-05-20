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
    public partial class ViewUsers : Form
    {
        //set connection to the mysql database
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrackingsys; password=; SslMode=none;");
        MySqlDataAdapter ada;
        DataSet dt;
        public ViewUsers()
        {
            InitializeComponent();
        }

        private void clickView(object sender, EventArgs e)
        {
            try
            {
                string query = "select * from users u, roles r, user_roles ur where u.id = ur.user_id and r.id = ur.role_id";
                ada = new MySqlDataAdapter(query, con);
                con.Open();
                dt = new DataSet();
                ada.Fill(dt, "users");
                //retrive data from database's table and show them to grid table
                dataGridViewUsers.DataSource = dt.Tables["users"];
                dataGridViewUsers.Columns["password"].Visible = false;
                dataGridViewUsers.Columns["id1"].Visible = false;
                dataGridViewUsers.Columns["id2"].Visible = false;
                dataGridViewUsers.Columns["user_id"].Visible = false;
                dataGridViewUsers.Columns["role_id"].Visible = false;
                con.Close();

            }
            catch (Exception)
            {
            }
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {

        }

        private void clickDelete(object sender, EventArgs e)
        {
          try {
                string selected_uid = dataGridViewUsers.CurrentRow.Cells["id"].Value.ToString();
                string query = "DELETE from users where id=" +int.Parse(selected_uid);
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sucessfully deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Something's wrong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
               }
            catch(Exception x)
            {
                MessageBox.Show("Error in db connection" + x.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
   
        }
    }
}
