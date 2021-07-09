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
                if (tbxFirstName.Text != "" && tbxLastName.Text != "" && tbxAddressOne.Text != "" && tbxPhoneOne.Text != "" && tbxCity.Text != "" && tbxZip.Text != ""
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
                            MessageBox.Show("Username is existed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            strPhoneOne = tbxPhoneOne.Text;
                            strPhoneTwo = tbxPhoneTwo.Text;
                            strCity = tbxCity.Text;
                            strState = cboState.SelectedItem.ToString();
                            strEmail = tbxEmail.Text;
                            strZip = tbxZip.Text;

                            if (cboSuffix.SelectedItem == null)
                            {
                                strSuffix = "N/A";
                            }
                            else
                            {
                                strSuffix = cboSuffix.SelectedItem.ToString();
                            }


                            SqlCommand commandPerson = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Person(Title,NameFirst,NameMiddle,NameLast,Suffix,Address1,Address2,Address3,City,Zipcode" +
                                ",State,Email,PhonePrimary,PhoneSecondary,Image) VALUES(@Title,@NameFirst,@NameMiddle,@NameLast,@Suffix,@Address1,@Address2,@Address3,@City,@Zipcode" +
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

        //Handling Form Closing event
        private void frmSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        Application.Exit();
                    }
                    break;
            }
        }
    }

}
