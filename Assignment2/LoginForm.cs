﻿using System;
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
   public partial class LoginForm : Form
    {
        public static string user, email, userRole, userPassword;
        private string pass;
        public static int uId;
        //set connection to mysql database
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrackingsys; password=; SslMode=none;");

        public LoginForm()
        {
            InitializeComponent();
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
            //calling login method
            login();
        }


        /// <summary>
        /// check the user login
        /// </summary>
        public void login()
        {
           user = txtname.Text;
           pass = txtpassword.Text;
            DataTable dt = new DataTable();
            try
            {
                string query = "select u.id, u.email, u.username, u.password, r.user_type from users u, user_roles ur, roles r  where "+
                    "u.id = ur.user_id  and r.id = ur.role_id and u.username ='" + user + "' and u.password='" + pass + "'";
                MySqlDataAdapter ada = new MySqlDataAdapter(query, con);
                ada.Fill(dt);
                IDataReader uRes = dt.CreateDataReader();

                if (dt.Rows.Count == 1)
                {
                    while (uRes.Read())
                    {
                       
                        uId = uRes.GetInt32(0);
                        email = uRes.GetString(1);
                        userRole = uRes.GetString(4);
                        userPassword = uRes.GetString(3);

                    }
                    //if user is a admin
                    if (userRole == "admin")
                    {
                        AdminDashboard ad = new AdminDashboard(uId, user, userRole);
                        ad.Show();
                        this.Visible = false;
                    }
                    //if user is either developer or tester
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
