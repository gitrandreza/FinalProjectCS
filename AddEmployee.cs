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
    public partial class frmAddEmployee : Form
    {
        SqlConnection Connection;

        string strTitle;
        string strFirstName;
        string strLastName;
        string strMiddleName = "";
        string strSuffix;
        string strAddressOne;
        string strAddressTwo = "";
        string strAddressThree = "";
        string strPhoneOne;
        string strPhoneTwo = "";
        string strCity;
        string strState;
        string strZip;
        string strEmail;
        string strRole;
        string strPosition;
        string strSalary;
        string strHiredDate;


        string strCreateUsername;
        string strCreatePassword;
      
      
       
        bool blnDuplicateUsername;

 
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
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
                if (tbxFirstName.Text != "" && tbxLastName.Text != "" && tbxAddressOne.Text != "" && mskPhone.Text != "" && tbxCity.Text != "" && tbxZip.Text != ""
                    && cboState.Text != "" && tbxEmail.Text != ""  && cboRole.Text != "" && cboPosition.Text != "" && tbxSalary.Text != "" && dtpEmployeeHiredDate.Text != "")
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
                            blnDuplicateUsername = true;
                            
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
                        
                        
                        strPhoneOne = mskPhone.Text;
                        strEmail = tbxEmail.Text;
                        strZip = tbxZip.Text;
                        strAddressOne = tbxAddressOne.Text;

                        if (ValidAddress(strAddressOne) == true)
                        {
                            if (ValidZip(strZip) == true)
                            {

                                    if (ValidEmail(strEmail) == true)
                                    {

                                                //INSERT RECORD FOR PERSON INFORMATION
                                                strTitle = "Employee";
                                                strFirstName = tbxFirstName.Text;
                                                strLastName = tbxLastName.Text;
                                                strMiddleName = tbxMiddleName.Text;
                                                strAddressOne = tbxAddressOne.Text;
                                               
                                                strSalary = tbxSalary.Text;

                                                strHiredDate = dtpEmployeeHiredDate.Text;
                                                strCity = tbxCity.Text;
                                                strState = cboState.SelectedItem.ToString();
                                                
                                                strRole= cboRole.SelectedItem.ToString();
                                   
                                                int intRoleID;

                                    if (strRole == "Manager")
                                    {
                                        intRoleID = 1;
                                    }
                                    else
                                    {
                                        intRoleID = 2;
                                    }

                                                strPosition = cboPosition.SelectedItem.ToString();
                                   

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

                                                string strQuestionThree = "N/A";
                                                string strQuestionTwo = "N/A";
                                                string strQuestionOne = "N/A";
                                                string strAnswerOne = "N/A";
                                                string strAnswerTwo = "N/A"; ;
                                                string strAnswerThree = "N/A"; ;
                                                
                                              

                                                //Get the last PersonID using Max to insert as FK to the User table
                                                string queryLastID = "SELECT MAX(PersonID) from RandrezaVoharisoaM21Su2332.Person";
                                                SqlCommand commandLastID = new SqlCommand(queryLastID, Connection);

                                                //gets the results from the sql command
                                                SqlDataReader sr = commandLastID.ExecuteReader();
                                                sr.Read();
                                                int intPersonID = sr.GetInt32(0);
                                                sr.Close();

                                        //generate Username and Password
                                        string strModidfiedLastName = strLastName.Substring(0,strLastName.Length-2);
                                        strCreateUsername = strModidfiedLastName + intPersonID.ToString();

                                        strCreatePassword = intRoleID.ToString() + intPersonID.ToString();

                                                SqlCommand commandUsers = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Users(PersonID,Username,Password,Answer1,Answer2,RoleID,ThirdQuestion,SecondQuestion,FirstQuestion,Answer3) VALUES(@PersonID,@Username,@Password,@Answer1,@Answer2,@RoleID,@ThirdQuestion,@SecondQuestion,@FirstQuestion,@Answer3)", Connection);
                                                commandUsers.Parameters.AddWithValue("@PersonID", intPersonID);
                                                commandUsers.Parameters.AddWithValue("@Username", strCreateUsername);
                                                commandUsers.Parameters.AddWithValue("@Password", strCreatePassword);
                                                commandUsers.Parameters.AddWithValue("@Answer1", strAnswerOne);
                                                commandUsers.Parameters.AddWithValue("@Answer2", strAnswerTwo);
                                                commandUsers.Parameters.AddWithValue("@RoleID", intRoleID);
                                                commandUsers.Parameters.AddWithValue("@ThirdQuestion", strQuestionThree);
                                                commandUsers.Parameters.AddWithValue("@SecondQuestion", strQuestionTwo);
                                                commandUsers.Parameters.AddWithValue("@FirstQuestion", strQuestionOne);
                                                commandUsers.Parameters.AddWithValue("@Answer3", strAnswerThree);

                                                commandUsers.ExecuteNonQuery();
                                               

                                                //Get the last UserID using Max to insert as FK to the Employee table
                                                string queryLastUserID = "SELECT MAX(UserID) from RandrezaVoharisoaM21Su2332.Users";
                                                SqlCommand command = new SqlCommand(queryLastUserID, Connection);

                                                //gets the results from the sql command
                                                SqlDataReader readerUserID = command.ExecuteReader();
                                                readerUserID.Read();
                                                int intUserID = readerUserID.GetInt32(0);
                                                readerUserID.Close();

                                                SqlCommand commandEmployee = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Employees(UserID,Salary,HiredDate,Position) VALUES(@UserID,@Salary,@HiredDate,@Position)", Connection);
                                                commandEmployee.Parameters.AddWithValue("@UserID", intUserID);
                                                commandEmployee.Parameters.AddWithValue("@Salary", strSalary);
                                                commandEmployee.Parameters.AddWithValue("@HiredDate", strHiredDate);
                                                commandEmployee.Parameters.AddWithValue("@Position", strPosition);



                                                commandEmployee.ExecuteNonQuery();
                                                MessageBox.Show("Employee Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                Connection.Close();

                                                new frmAdmin().Show();
                                                this.Hide();
                                           
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
        


        public bool ValidAddress(string strAddress)
        {

            if (strAddress.Length < 4)
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

            if (strValidZip.Length != 5)
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
                bool blnIsValidEmail = regex.IsMatch(strValidEmail);
                if (!blnIsValidEmail)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        //Return to login form
        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmAdmin().Show();
            this.Hide();
        }

    

        //Accept dIGIT OR LETTER ONLY KEYPRESS
        private void tbxZip_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            new frmAdmin().Show();
            this.Hide();
        }

        private void frmAddEmployee_FormClosing(object sender, FormClosingEventArgs e)
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
                        new frmAdmin().Show();
                        this.Hide();
                    }
                    break;
            }
        }

        private void btnHelpAddEmployee_Click(object sender, EventArgs e)
        {
            new frmAddEmployeeHelp().Show();
            this.Visible = false;
        }
    }
}
