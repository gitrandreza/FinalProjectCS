﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SU21_Final_Project
{
    public partial class frmLogin : Form
    {
        private SqlConnection Connection;
        private SqlCommand command; //command object
        private SqlDataReader reader; //datareader object
        public frmMain fmain;
        string strUsername;
        string strPassword;
        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(frmMain formMain)
        {
            fmain = formMain;
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            strUsername = tbxUsername.Text;
            strPassword = tbxPassword.Text;
            try
            { 
               
               
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
               
                command = new SqlCommand("SELECT Username, Password FROM RandrezaVoharisoaM21Su2332.Users;", Connection);

                //gets the results from the sql command
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //iterates through the user name column to find a matching value
                    
                    if (reader["Username"].ToString() == strUsername) 
                    {
                        if (reader["Password"].ToString() == strPassword) 
                        {
                            new frmMain().Show();
                            this.Hide();

                        }
                    }

                    else
                    lblMessage.Text = "Pleach verify your username and your password ";
                    tbxPassword.Text = "";
                    tbxPassword.Text = "";
                    tbxPassword.Focus();
                }


                if (reader != null)
                {
                    reader.Close(); //closes the reader
                }
                if (Connection != null)
                {
                    Connection.Close(); //closes connection to database
                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
