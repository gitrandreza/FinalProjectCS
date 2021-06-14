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
using System.IO;

namespace SU21_Final_Project
{

    public partial class frmMain : Form
    {
        //Establish connection to the database       
        SqlConnection Connection;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;

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

        //Method to display table item by category
        public void DisplayAllItems()
        {
            try
            {
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Description, Quantity, RetailPrice  FROM RandrezaVoharisoaM21Su2332.Items", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvAll.DataSource = dataTable;
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }

        public void DisplayGiftItems()
        {
            try
            {
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Description, Quantity, RetailPrice  FROM RandrezaVoharisoaM21Su2332.Items WHERE CategoryID = 2 ;", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvGift.DataSource = dataTable;
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }

        public void DisplayClothesItems()
        {
            try
            {
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Description, Quantity, RetailPrice  FROM RandrezaVoharisoaM21Su2332.Items WHERE CategoryID = 1 ;", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvClothes.DataSource = dataTable;
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }

        public void DisplayBagsItems()
        {
            try
            {
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Description, Quantity, RetailPrice  FROM RandrezaVoharisoaM21Su2332.Items WHERE CategoryID = 3 ;", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvBags.DataSource = dataTable;
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }



        //Tab selection
        private void tabItemCategory_Selected(object sender, TabControlEventArgs e)
        {
            if (tabItemCategory.SelectedTab.Name == "tabAll")
            {
                DisplayAllItems();
            }

            if (tabItemCategory.SelectedTab.Name == "tabGifts")
            {
                DisplayGiftItems();
            }

            if (tabItemCategory.SelectedTab.Name == "tabClothes")
            {
                DisplayClothesItems();
            }

            if (tabItemCategory.SelectedTab.Name == "tabBags")
            {
                DisplayBagsItems();
            }
        }





        private void dgvGift_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Connection.Open();

                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvGift.Rows[e.RowIndex];

                    myItems.Name = row.Cells["Description"].Value.ToString();
                    myItems.Quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                    myItems.Price = Convert.ToDouble(row.Cells["RetailPrice"].Value.ToString());


                    lblAvailable.Text = Convert.ToString(myItems.Quantity);
                    lblPrice.Text = Convert.ToString(myItems.Price);
                    lblItemName.Text = Convert.ToString(myItems.Name);

                }

                //Display Image

                byte[] imgData;
                SqlCommand cmd = new SqlCommand("Select Image From RandrezaVoharisoaM21Su2332.Items where Description = '" + lblItemName.Text + "'", Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                long bufLength = reader.GetBytes(0, 0, null, 0, 0);
                imgData = new byte[bufLength];
                reader.GetBytes(0, 0, imgData, 0, (int)bufLength);
                MemoryStream ms = new MemoryStream(imgData);
                ms.Position = 0;
                pbxGift.Image = Image.FromStream(ms);
                reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }
    


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new frmAdmin().Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            new frmLogin().ShowDialog();
        }


        private void dgvClothes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Connection.Open();

                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvClothes.Rows[e.RowIndex];

                    myItems.Name = row.Cells["Description"].Value.ToString();
                    myItems.Quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                    myItems.Price = Convert.ToDouble(row.Cells["RetailPrice"].Value.ToString());


                    lblAvailable.Text = Convert.ToString(myItems.Quantity);
                    lblPrice.Text = Convert.ToString(myItems.Price);
                    lblItemName.Text = myItems.Name;

                }

                //Display Image

                byte[] imgData;
                SqlCommand cmd = new SqlCommand("Select Image From RandrezaVoharisoaM21Su2332.Items where Description = '" + lblItemName.Text + "'", Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                long bufLength = reader.GetBytes(0, 0, null, 0, 0);
                imgData = new byte[bufLength];
                reader.GetBytes(0, 0, imgData, 0, (int)bufLength);
                MemoryStream ms = new MemoryStream(imgData);
                ms.Position = 0;
                pbxClothes.Image = Image.FromStream(ms);
                reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }

        private void dgvAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Connection.Open();

                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvAll.Rows[e.RowIndex];

                    myItems.Name = row.Cells["Description"].Value.ToString();
                    myItems.Quantity = int.Parse(row.Cells["Quantity"].Value.ToString());
                    myItems.Price = Convert.ToDouble(row.Cells["RetailPrice"].Value.ToString());


                    lblAvailable.Text = Convert.ToString(myItems.Quantity);
                    lblPrice.Text = Convert.ToString(myItems.Price);
                    lblItemName.Text = myItems.Name;

                }

                //Display Image

                byte[] imgData;
                SqlCommand cmd = new SqlCommand("Select Image From RandrezaVoharisoaM21Su2332.Items where Description = '" + lblItemName.Text + "'", Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                long bufLength = reader.GetBytes(0, 0, null, 0, 0);
                imgData = new byte[bufLength];
                reader.GetBytes(0, 0, imgData, 0, (int)bufLength);
                MemoryStream ms = new MemoryStream(imgData);
                ms.Position = 0;
                pbxAll.Image = Image.FromStream(ms);
                reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }

        private void dgvBags_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Connection.Open();

                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvBags.Rows[e.RowIndex];

                    myItems.Name = row.Cells["Description"].Value.ToString();                    
                    string strQuantity = row.Cells["Quantity"].Value.ToString();
                    int intQuantity; 
                    bool intResultTryParse = int.TryParse(strQuantity, out intQuantity);
                    if (intResultTryParse == true)
                    {
                        myItems.Quantity= intQuantity;
                    }

                    string strPrice = row.Cells["RetailPrice"].Value.ToString();
                    double dblPrice;
                    bool dblResultTryParse = double.TryParse(strPrice, out dblPrice);
                    if (dblResultTryParse == true)
                    {
                        myItems.Price = dblPrice;
                    }


                    //Display in the label
                    lblAvailable.Text = myItems.Quantity.ToString();
                    lblPrice.Text = myItems.Price.ToString();
                    lblItemName.Text = myItems.Name;

                }

                //Display Image

                byte[] imgData;
                SqlCommand cmd = new SqlCommand("Select Image From RandrezaVoharisoaM21Su2332.Items where Description = '" + lblItemName.Text + "'", Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                long bufLength = reader.GetBytes(0, 0, null, 0, 0);
                imgData = new byte[bufLength];
                reader.GetBytes(0, 0, imgData, 0, (int)bufLength);
                MemoryStream ms = new MemoryStream(imgData);
                ms.Position = 0;
                pbxBags.Image = Image.FromStream(ms);
                reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }
    }
}
