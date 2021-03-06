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
    public partial class Register : Form
    {
        private string name;
        private string email;
        private string uname;
        private string pass;

        //set connection with mysql dabatabase
        MySqlConnection con = new MySqlConnection("datasource=localhost; port=3306; username=root; database=bugtrackingsys; password=; SslMode=none;");
        MySqlCommand myCommand;
        public Register()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clickRegister(object sender, EventArgs e)
        {
            //validation
            if (txtfullname.Text == "")
            {
                labelfullname.Text = "•Please enter your full name ";
            }
            else if (txtemail.Text == "")
            {
                labelemail.Text = " •Please enter your email ";
            }
            else if (txtusername.Text == "")
            {
                labelusername.Text = " •Please enter a username ";
            }
            else if (txtpassword.Text == "")
            {
                labelpassword.Text = "•Please enter a password ";
            }
            else
            {
                //calling method
                addNewUser();
            }
         }

         /// <summary>
         /// adding new user
         /// </summary>
          public void addNewUser()
          { 
                 name = txtfullname.Text;
                 email = txtemail.Text;
                 uname = txtusername.Text;
                 pass = txtpassword.Text;
                try
                {
                    string myInsertQuery = "INSERT INTO users (full_name, email, username, password) "+
                    " Values('" + name + "','" + email + "','" + uname + "', '" + pass + "')";
                    myCommand = new MySqlCommand(myInsertQuery);
                    myCommand.Connection = con;
                    con.Open();
                    //if query affect the row then
                    if (myCommand.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Sucessfully registered!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Error in a database connection", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myCommand.Connection.Close();
            }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
