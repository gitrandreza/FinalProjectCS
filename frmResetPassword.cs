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
        string strAnswerOne;
        string strAnswerTwo;
        string strAnswerThree;
        
        
        string strEnterUsername;
        string strNewPassword;
        string strConfirmPassword;
        bool blnMatch=false;

        public frmResetPassword()
        {
            InitializeComponent();

          
        }

        //Check for username and security question
        private void btnCheck_Click(object sender, EventArgs e)
        {

            strAnswerOne = tbxDrink.Text;
            strAnswerTwo = tbxDog.Text;
            strAnswerThree = tbxIdol.Text;
            strEnterUsername = tbxEnterUsername.Text;
            strNewPassword = tbxNewPassword.Text;
            

            try
            {
                if (tbxEnterUsername.Text != "")
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
                            if ( reader["Answer1"].ToString().Equals(strAnswerOne, StringComparison.CurrentCultureIgnoreCase)
                                && reader["Answer2"].ToString().Equals(strAnswerTwo, StringComparison.CurrentCultureIgnoreCase)
                                && reader["Answer3"].ToString().Equals(strAnswerThree, StringComparison.CurrentCultureIgnoreCase))
                            {
                                lblInvalidAnswers.Visible = false;
                                lblValidAnswers.Visible = true;
                                tbxNewPassword.Enabled = true;
                                tbxConfirmPassword.Enabled = true;
                                btnNewPassword.Enabled = true;
                                blnMatch = true;

                            }


                        }

                    }

                    if (blnMatch == false)
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
                else
                {
                    MessageBox.Show("Please enter your username" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxEnterUsername.Focus();
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
            strNewPassword = tbxNewPassword.Text;
            strConfirmPassword = tbxConfirmPassword.Text;

            if (ValidPassword(strNewPassword) == true)
            {
                if (strNewPassword == strConfirmPassword)
                {

                if (MessageBox.Show("Are you sure you want to change your password", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)

                {

                    Connection.Open();

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
                else
                {
                    MessageBox.Show("Please check password ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxNewPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Password format is not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxNewPassword.Focus();
            }
        }
      
        //Check for password Validation
        public bool ValidPassword(string strPassword)
        {

            if (strPassword.Length < 8 || strPassword.Length > 14)
                return false;

            else if (!strPassword.Any(char.IsUpper))
            {
                return false;
            }
            else if (!strPassword.Any(char.IsLower))
            {
                return false;
            }
            else if (!strPassword.Any(char.IsDigit))
            {
                return false;
            }

            else if (strPassword.Contains(" "))
            {
                return false;
            }

            if (!((strPassword.Contains("@")) ||
                  (strPassword.Contains("#")) ||
                  (strPassword.Contains("!")) ||
                  (strPassword.Contains("~")) ||
                  (strPassword.Contains("$")) ||
                  (strPassword.Contains("%")) ||
                  (strPassword.Contains("^")) ||
                  (strPassword.Contains("&")) ||
                  (strPassword.Contains("*")) ||
                  (strPassword.Contains("(")) ||
                  (strPassword.Contains(")")) ||
                  (strPassword.Contains("-")) ||
                  (strPassword.Contains("+")) ||
                  (strPassword.Contains("/")) ||
                  (strPassword.Contains(":")) ||
                  (strPassword.Contains(".")) ||
                  (strPassword.Contains(",")) ||
                  (strPassword.Contains("<")) ||
                  (strPassword.Contains(">")) ||
                  (strPassword.Contains("?")) ||
                  (strPassword.Contains("|"))))
            {
                return false;
            }
            return true;
        }

        //Return to login form
        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
