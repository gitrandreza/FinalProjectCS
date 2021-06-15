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
        private SqlConnection Connection;
        private SqlCommand command; //command object
        private SqlDataReader reader; //datareader object
        public frmMain fmain;
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
            try
            { //connect to database
               
               
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                //check for password and username
                command = new SqlCommand("SELECT Username, Password FROM RandrezaVoharisoaM21Su2332.Users;", Connection);

                //gets the results from the sql command
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    //iterates through the username column to find a matching value
                    //after it finds a matching user name it then moves to the password column for that row.
                    if (reader["Username"].ToString() == tbxUsername.Text) //compares curent username on the current row
                    {
                        if (reader["Password"].ToString() == tbxPassword.Text ) //compares the password of the current row
                        {
                            lblMessage.Text = Connection.State.ToString();
                           
                           
                          
                        }
                    }
                }
             
                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }
    }
}
