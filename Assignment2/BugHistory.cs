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
    public partial class BugHistory : Form
    {
        //set connection to mysql database
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrackingsys; password=; SslMode=none;");
        MySqlDataAdapter ada;
        DataSet dt;
        public BugHistory()
        {
            InitializeComponent();
        }

        private void BugHistory_Load(object sender, EventArgs e)
        {
            try
            {
                //if search box contains a text then search according to specified bug 
                //if not then view all bugs
                if (!String.IsNullOrEmpty(Dashboard.searchItem))
                {
                    string query = "select * from bugs where summary like '%"+Dashboard.searchItem+ "%' or project_name like '%" + Dashboard.searchItem + "%' ";
                    ada = new MySqlDataAdapter(query, con);
                    con.Open();
                    dt = new DataSet();
                    ada.Fill(dt, "bugs");
                    //showing data from bugs table into grid table
                    dataGridViewBugs.DataSource = dt.Tables["bugs"]; ;
                    dataGridViewBugs.Columns["image"].Visible = false;
                    con.Close();
                }
                else {
                    string query = "select * from bugs";
                    ada = new MySqlDataAdapter(query, con);
                    con.Open();
                    dt = new DataSet();
                    ada.Fill(dt, "bugs");
                    dataGridViewBugs.DataSource = dt.Tables["bugs"]; ;
                    dataGridViewBugs.Columns["image"].Visible = false;
                    con.Close();
                     }
            }
            catch (Exception)
            {
            }
        }
    }
}
