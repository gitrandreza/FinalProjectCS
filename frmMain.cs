//ToDo: Change the entries below indicated by {} to your values
//*******************************************
//*******************************************
// Programmer: Ricky Randreza
// Course: INEW 2332.7Z1 (Final Project)
// Program Description: A sale management application of custom gift service that print design on items 
//*******************************************
// Form Purpose: This is the point of sale view or the customer view
//*******************************************
//*******************************************

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
    public partial class frmMain : Form
    {
        //Establish connection to the database       
        private SqlConnection dataConnection;
        string query;

        //connect to database
        

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                //connect to database
                dataConnection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                //open the database
                dataConnection.Open();
                //display message
                lblMessage.Text = dataConnection.State.ToString();
                //close the database
                dataConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
           

            //test query
            SqlCommand Cmd;
            SqlDataAdapter dataAd;
            DataTable dt;

        }
    }
}