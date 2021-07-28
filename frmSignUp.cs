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
using System.Text.RegularExpressions;

namespace SU21_Final_Project
{
    public partial class frmSignUp : Form
    {


        SqlConnection Connection;
        
        

        string strTitle;
        string strFirstName ;
        string strLastName ;
        string strMiddleName="";
        string strSuffix ;
        string strAddressOne;
        string strAddressTwo="" ;
        string strAddressThree="" ;
        string strPhoneOne ;
        string strPhoneTwo="" ;
        string strCity ;
        string strState ;
        string strZip ;
        string strEmail ;


        
        string strCreateUsername ;
        string strCreatePassword ;
        string strAnswerOne ;
        string strAnswerTwo ;
        string strAnswerThree ;
        int intRoleId ;
        string strQuestionOne;
        string strQuestionTwo ;
        string strQuestionThree ;
        bool blnDuplicateUsername;

        public static bool blnSignUpPicture=false;
       

        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            strCreateUsername = tbxCreateUsername.Text;
            try
            {

                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            try
            {

                Connection.Open();
                if (tbxFirstName.Text != "" && tbxLastName.Text != "" && tbxAddressOne.Text != "" && mskPhone1.Text != "" && tbxCity.Text != "" && tbxZip.Text != ""
                    && cboState.Text != "" && tbxEmail.Text != "" && tbxCreateUsername.Text != "" && tbxCreatePassword.Text != "" && tbxAnswerOne.Text != ""
                    && tbxAnswerTwo.Text != "" && tbxAnswerThree.Text != "")
                {
                    SqlCommand commandCheckUsername = new SqlCommand("SELECT Username FROM RandrezaVoharisoaM21Su2332.Users;", Connection);

                    //gets the results from the sql command
                   SqlDataReader reader = commandCheckUsername.ExecuteReader();

                    while (reader.Read())
                    {
                        //check through the user table column to find a matching value
                        if (reader["Username"].ToString() == strCreateUsername)
                        {
                            MessageBox.Show("Username is already taken", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            blnDuplicateUsername=true;                           
                            tbxCreateUsername.Text="";
                            tbxCreateUsername.Focus();
                            break;
                        }
                        else
                        {
                            blnDuplicateUsername = false;
                            
                        }

                    }



                    if (blnDuplicateUsername == false)
                    {
                        reader.Close();
                        strCreatePassword = tbxCreatePassword.Text;
                        strPhoneOne = mskPhone1.Text;
                        strEmail = tbxEmail.Text;
                        strZip = tbxZip.Text;
                        strAddressOne = tbxAddressOne.Text;

                        if (ValidAddress(strAddressOne) == true)
                        {
                            if (ValidZip(strZip) == true)
                            {

                              
                                    if (ValidEmail(strEmail) == true)
                                    {

                                        if (ValidUsername(strCreateUsername) == true)
                                        {

                                            if (ValidPassword(strCreatePassword) == true)
                                            {


                                                //INSERT RECORD FOR PERSON INFORMATION
                                                strTitle = "Customer";
                                                strFirstName = tbxFirstName.Text;
                                                strLastName = tbxLastName.Text;
                                                strMiddleName = tbxMiddleName.Text;
                                                strAddressOne = tbxAddressOne.Text;
                                                strAddressTwo = tbxAddressTwo.Text;
                                                strAddressThree = tbxAddressThree.Text;

                                                strPhoneTwo = mskPhone2.Text;
                                                strCity = tbxCity.Text;
                                                strState = cboState.SelectedItem.ToString();



                                                if (cboSuffix.SelectedItem == null)
                                                {
                                                    strSuffix = "N/A";
                                                }
                                                else
                                                {
                                                    strSuffix = cboSuffix.SelectedItem.ToString();
                                                }


                                                SqlCommand commandPerson = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Person(Title,NameFirst,NameMiddle,NameLast,Suffix,Address1,Address2,Address3,City,Zipcode" +
                                                    ",State,Email,PhonePrimary,PhoneSecondary,Image) " +
                                                    "VALUES(@Title,@NameFirst,@NameMiddle,@NameLast,@Suffix,@Address1,@Address2,@Address3,@City,@Zipcode" +
                                                    ",@State,@Email,@PhonePrimary,@PhoneSecondary,NULL)", Connection);
                                                commandPerson.Parameters.AddWithValue("@Title", strTitle);
                                                commandPerson.Parameters.AddWithValue("@NameFirst", strFirstName);
                                                commandPerson.Parameters.AddWithValue("@NameMiddle", strMiddleName);
                                                commandPerson.Parameters.AddWithValue("@NameLast", strLastName);
                                                commandPerson.Parameters.AddWithValue("@Suffix", strSuffix);
                                                commandPerson.Parameters.AddWithValue("@Address1", strAddressOne);
                                                commandPerson.Parameters.AddWithValue("@Address2", strAddressTwo);
                                                commandPerson.Parameters.AddWithValue("@Address3", strAddressThree);
                                                commandPerson.Parameters.AddWithValue("@City", strCity);
                                                commandPerson.Parameters.AddWithValue("@Zipcode", strZip);
                                                commandPerson.Parameters.AddWithValue("@State", strState);
                                                commandPerson.Parameters.AddWithValue("@Email", strEmail);
                                                commandPerson.Parameters.AddWithValue("@PhonePrimary", strPhoneOne);
                                                commandPerson.Parameters.AddWithValue("@PhoneSecondary", strPhoneTwo);

                                                commandPerson.ExecuteNonQuery();


                                                //INSERT RECORD FOR USERS LOGON SECURITY ACCESS


                                                strAnswerOne = tbxAnswerOne.Text;
                                                strAnswerTwo = tbxAnswerTwo.Text;
                                                strAnswerThree = tbxAnswerThree.Text;
                                                intRoleId = 3;
                                                strQuestionOne = "What is your favorite drink?";
                                                strQuestionTwo = "What is your favorite type of dog?";
                                                strQuestionThree = "Who is your idol?";

                                                //Get the last PersonID using Max to insert as FK to the User table
                                                string queryLastID = "SELECT MAX(PersonID) from RandrezaVoharisoaM21Su2332.Person";
                                                SqlCommand commandLastID = new SqlCommand(queryLastID, Connection);

                                                //gets the results from the sql command
                                                SqlDataReader sr = commandLastID.ExecuteReader();
                                                sr.Read();
                                                int intPersonID = sr.GetInt32(0);
                                                sr.Close();


                                                SqlCommand commandUsers = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Users(PersonID,Username,Password,Answer1,Answer2,RoleID,ThirdQuestion,SecondQuestion,FirstQuestion,Answer3) VALUES(@PersonID,@Username,@Password,@Answer1,@Answer2,@RoleID,@ThirdQuestion,@SecondQuestion,@FirstQuestion,@Answer3)", Connection);
                                                commandUsers.Parameters.AddWithValue("@PersonID", intPersonID);
                                                commandUsers.Parameters.AddWithValue("@Username", strCreateUsername);
                                                commandUsers.Parameters.AddWithValue("@Password", strCreatePassword);
                                                commandUsers.Parameters.AddWithValue("@Answer1", strAnswerOne);
                                                commandUsers.Parameters.AddWithValue("@Answer2", strAnswerTwo);
                                                commandUsers.Parameters.AddWithValue("@RoleID", intRoleId);
                                                commandUsers.Parameters.AddWithValue("@ThirdQuestion", strQuestionThree);
                                                commandUsers.Parameters.AddWithValue("@SecondQuestion", strQuestionTwo);
                                                commandUsers.Parameters.AddWithValue("@FirstQuestion", strQuestionOne);
                                                commandUsers.Parameters.AddWithValue("@Answer3", strAnswerThree);

                                                commandUsers.ExecuteNonQuery();
                                                MessageBox.Show("Client Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                Connection.Close();

                                                new frmLogin().Show();
                                                this.Hide();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Password format is not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                tbxCreatePassword.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Username format is not valid, must more than 4 characters", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            tbxCreateUsername.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Email format is not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        tbxEmail.Focus();
                                    }
                          
                            }
                            else
                            {
                                MessageBox.Show("Zip format is not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tbxZip.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Address format is not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxZip.Focus();
                        }
                    }

                   
                }
                else
                {
                    MessageBox.Show("Please make sure to fill up the required fields with(*)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        //Check for password Validation
        public bool ValidPassword(string strPassword)
        {

            if (strPassword.Length < 8 && strPassword.Length > 20)
                return false;

            else if (!strPassword.Any(char.IsLetter))
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

       

        public bool ValidAddress(string strAddress)
        {

            if (strAddress.Length < 4 )
                return false;

            else if (!strAddress.Any(char.IsLetter))
            {
                return false;
            }

            else if (!strAddress.Any(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        public bool ValidZip(string strValidZip)
        {

            if (strValidZip.Length !=5)
            {
                return false;
            }
            return true;
        }


        public bool ValidUsername(string strUsername)
        {

            if (strUsername.Length < 4)
            {
                return false;
            }
            return true;
        }

        public bool ValidEmail(string strValidEmail)
        {

            try
            {
                Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.
                 [0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                RegexOptions.CultureInvariant | RegexOptions.Singleline);
                bool blnValidEmail = regex.IsMatch(strValidEmail);
                if (!blnValidEmail)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Return to login form
        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        //Handling Form Closing event
        private void frmSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show("Do you want to close this form?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        new frmLogin().Show();
                        this.Hide();
                    }
                    break;
            }
        }

        //Accept digit only for zip
        private void tbxZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        //Accept digit only for Phone
        private void tbxPhoneOne_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tbxDateOfBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxPhoneTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
   (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void btnBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBack.PerformClick();
            }
        }

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }

        private void btnHelpSignUp_Click(object sender, EventArgs e)
        {
            new frmHelp().Show();
            blnSignUpPicture = true;
            this.Hide();
        }
    }

}
