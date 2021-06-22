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
    public partial class frmResetPassword : Form
    {

        SqlConnection Connection;
        SqlCommand command; 
        SqlDataReader reader;
        string strDrink;
        string strDog;
        string strIdol;
        string strEnterUsername;
        string strNewPassword;
        bool blnMatch=false;

        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            strDrink = tbxDrink.Text;
            strDog = tbxDog.Text;
            strIdol = tbxIdol.Text;
            strEnterUsername = tbxEnterUsername.Text;
            strNewPassword = tbxNewPassword.Text;

            try
            {

                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();

                command = new SqlCommand("SELECT Username, Answer1, Answer2, Answer3 FROM RandrezaVoharisoaM21Su2332.Users;", Connection);

                //gets the results from the sql command
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //check through the user table column to find a matching value
                    if (reader["Username"].ToString() == strEnterUsername)
                    {
                        if (reader["Answer1"].ToString() == strDrink && reader["Answer2"].ToString() == strDog && reader["Answer3"].ToString() == strIdol)
                        {
                            lblValidAnswers.Visible = true;
                            tbxNewPassword.Enabled = true;
                            btnNewPassword.Enabled = true;
                            blnMatch = true;
                           
                        }
                       
                        
                    }

                }

                if(blnMatch==false)
                {               
                    lblInvalidAnswers.Visible = true;
                    tbxDrink.Text = "";
                    tbxDog.Text = "";
                    tbxIdol.Text = "";
                    tbxEnterUsername.Text = "";
                    tbxEnterUsername.Focus();
                }

                if (reader != null)
                {
                    reader.Close(); 
                }
                if (Connection != null)
                {
                    Connection.Close(); 
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //UPDATE AND SAVE THE NEW PASSWORD  
        private void btnNewPassword_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Your password will be changed", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                Connection.Open();
                strNewPassword = tbxNewPassword.Text;
                string updateQuery = "UPDATE RandrezaVoharisoaM21Su2332.Users set Password = @Password where Username ='" + strEnterUsername + "' ";
                SqlCommand updateCommand = new SqlCommand(updateQuery, Connection);
                SqlParameter sqlParams = updateCommand.Parameters.AddWithValue("@Password", strNewPassword);
                updateCommand.ExecuteNonQuery();
                MessageBox.Show("New Password saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connection.Close();
                this.Hide();
                new frmLogin().Show();

            }

          
        }
    }
}
