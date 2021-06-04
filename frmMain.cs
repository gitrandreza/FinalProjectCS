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
        private SqlConnection Connection;
        string query;
        //test query
        SqlCommand Cmd;
        SqlDataAdapter dataAd;
        DataTable dt;

        Items myItems = new Items();


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {


            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                //open the database
                Connection.Open();
                //display message
                lblMessage.Text = Connection.State.ToString();
                //close the database
                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }





        }



        //Method to display table item
        public void displayAllItems()
        {
            try
            {
                Connection.Open();
                dataAd = new SqlDataAdapter("SELECT Description  FROM RandrezaVoharisoaM21Su2332.Items", Connection);
                dt = new DataTable();
                dataAd.Fill(dt);
                dgvAll.DataSource = dt;
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }

        private void tabItemCategory_Selected(object sender, TabControlEventArgs e)
        {
            if (tabItemCategory.SelectedTab.Name == "tabAll")
            {
                displayAllItems();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    //instantiate object from product class and assign value from cell
                    DataGridViewRow row = this.dgvAll.Rows[e.RowIndex];

                    myItems.name = row.Cells["Description"].Value.ToString();
                    myItems.quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                    myItems.price = Convert.ToDouble(row.Cells["RetailPrice"].Value.ToString());


                    lblAvailable.Text = Convert.ToString(myItems.quantity);
                    lblPrice.Text = Convert.ToString(myItems.price);
                    lblItemName.Text = Convert.ToString(myItems.name);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }

        }
    }
}
