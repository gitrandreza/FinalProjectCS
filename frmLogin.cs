using System;
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
        SqlConnection Connection;
        SqlCommand command;
        SqlDataReader reader;
        
        string strUsername;
        string strPassword;

        public frmLogin()
        {
            InitializeComponent();

        }


       
            
        //Connect to database and check for username and password
        private void btnLogin_Click(object sender, EventArgs e)
        {
            strUsername = tbxUsername.Text;
            strPassword = tbxPassword.Text;

            try
            {


                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();

                command = new SqlCommand("SELECT UserID, Username, Password FROM RandrezaVoharisoaM21Su2332.Users;", Connection);

                //gets the results from the sql command
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //iterates through the user name column to find a matching value
                   

                    if (reader["Username"].ToString() == strUsername)
                    {
                        if (reader["Password"].ToString() == strPassword)
                        {

                            frmMain mainForm = new frmMain();
                            mainForm.LabelUserID = reader["UserID"].ToString();
                            mainForm.Show();
                            this.Hide();
                        }
                    }

                    else
                    lblLoginFailed.Text = "Please verify  your login entry ";
                    tbxUsername.Text = "";
                    tbxPassword.Text = "";
                    tbxUsername.Focus();
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

        //Sign up Form
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            new frmSignUp().Show();
            this.Hide();
        }


        //Exit Application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Reset password form
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            new frmResetPassword().Show();
            this.Hide();
        }
    }
}
