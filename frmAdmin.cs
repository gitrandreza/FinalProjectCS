﻿using System;
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
    public partial class frmAdmin : Form
    {
        //Establish connection to the database       
        SqlConnection Connection;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        string strItemName;


        public frmAdmin()
        {
            InitializeComponent();

            if (tabManagerFeatures.SelectedTab.Name == "tabInventory")
            {
                DisplayAllItems();
            }
        }





        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            //strItemName = cboItemName.SelectedItem.ToString();
            try
            {

                Connection.Open();
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
            try
            {

                //insert image

                byte[] image = File.ReadAllBytes("C:\\Grocery.png");

                Connection.Open();

                string insertQuery = "UPDATE RandrezaVoharisoaM21Su2332.Items set Image = @Image where Name= '" + strItemName + "'"; // @Image is a parameter we will fill in later
                SqlCommand insertCmd = new SqlCommand(insertQuery, Connection);
                SqlParameter sqlParams = insertCmd.Parameters.AddWithValue("@Image", image); // The parameter will be the image as a byte array
                sqlParams.DbType = System.Data.DbType.Binary; // The type of data we are sending to the server will be a binary file
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("File was successfully added to the database.", "File Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT Image FROM RandrezaVoharisoaM21Su2332.Items WHERE CategoryId = 2", Connection));
                //DataSet dataSet = new DataSet();
                //dataAdapter.Fill(dataSet);

                //Display Image
                byte[] imgData;
                SqlCommand cmd = new SqlCommand("Select Image From RandrezaVoharisoaM21Su2332.Items where Name = '" + strItemName + "'", Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                long bufLength = reader.GetBytes(0, 0, null, 0, 0);
                imgData = new byte[bufLength];
                reader.GetBytes(0, 0, imgData, 0, (int)bufLength);
                MemoryStream ms = new MemoryStream(imgData);
                ms.Position = 0;
                pbxItemPicture.Image = Image.FromStream(ms);
                reader.Close();

                Connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error During Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void DisplayAllItems()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Name, Quantity,Cost, RetailPrice ,Description,CategoryID,SupplierID FROM RandrezaVoharisoaM21Su2332.Items", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvAllProducts.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayEmployee()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Name, Quantity,Cost, RetailPrice ,Description,CategoryID,SupplierID FROM RandrezaVoharisoaM21Su2332.Items", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvAllProducts.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Display inventory
        private void tabManagerFeatures_Selected(object sender, TabControlEventArgs e)
        {
            if (tabManagerFeatures.SelectedTab.Name == "tabInventory")
            {
                DisplayAllItems();              
            }
        }

        //Open Add Item form
        private void btnAddItems_Click(object sender, EventArgs e)
        {
            new frmAddItems().Show();
            this.Hide();
        }


        //Remove selected Item from Data grid and Database
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            
            if (dgvAllProducts.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you want to remove this item?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvAllProducts.SelectedRows)
                    {                       
                        //grab current row index selected
                        int intIndexRowSelected = dgvAllProducts.CurrentCell.RowIndex;
                        //grab item name to use in order to delete in the database
                        strItemName= dgvAllProducts.Rows[intIndexRowSelected].Cells[0].Value.ToString();
                        dgvAllProducts.Rows.RemoveAt(row.Index);

                    }
                    try
                    {
                        //connect to database
                        Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                            "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                        Connection.Open();

                        string strDeleteQuery = "DELETE FROM RandrezaVoharisoaM21Su2332.Items where Name= '" + strItemName + "'";
                        SqlCommand deleteCommande = new SqlCommand(strDeleteQuery, Connection);
                        
                        deleteCommande.ExecuteNonQuery();
                       
                        Connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex);
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select the product you want to remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }



        private void btnUpdateItem_Click_1(object sender, EventArgs e)
        {
       
            try
            {
                //Connection.Open();
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                strItemName = cboItemName.SelectedItem.ToString();
                string strDescription = tbxUpDescrption.Text;
                Connection.Open();

                string strUpdateQuery = "UPDATE RandrezaVoharisoaM21Su2332.Items SET Description = @Description where Name= '" + strItemName + "'";
                SqlCommand updateCommande = new SqlCommand(strUpdateQuery, Connection);
                SqlParameter sqlParams = updateCommande.Parameters.AddWithValue("@Description", strDescription);
                updateCommande.ExecuteNonQuery();
                tbxUpDescrption.Text = "";
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show("Are you sure you want to exit the program?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
        

