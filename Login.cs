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
        public SqlConnection Connection;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.Open();
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
               //check for password and username

               
               
                 lblMessage.Text = Connection.State.ToString();
              
                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }
    }
}
