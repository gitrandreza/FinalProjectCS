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
    public partial class frmAdmin : Form
    {
        //Establish connection to the database       
        SqlConnection Connection;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
       
        
        

        string strItemID;

       
        string strNameFirst;
        string strNameLast;
        string strAddress;
        string strCity;
        string strZip;
        string strState;
        string strPhone;
        string strEmail;
         string strEmployeeID;
        string strEmployeeSalary;
        string strEmployeeHiredDate;

        public frmAdmin()
        {
            InitializeComponent();

            if (tabManagerFeatures.SelectedTab.Name == "tabInventory")
            {
                DisplayAllItems();
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
                dataAdapter = new SqlDataAdapter("SELECT ItemID, Name, Quantity,Cost, RetailPrice ,Description,CategoryID,SupplierID FROM RandrezaVoharisoaM21Su2332.Items", Connection);
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

            else if (tabManagerFeatures.SelectedTab.Name == "tabEmployee")
            {
                DisplayEmployee();
            }
        }

        public void DisplayEmployee()
        {
            SqlCommand commandPerson;
            SqlDataReader readerPerson;

            SqlCommand commandEmployee;
            SqlDataReader readerEmployee;

            //Build data grid view Employee 
            dgvEmployee.ColumnCount = 8;
            dgvEmployee.Columns[0].Name = "First Name";
            dgvEmployee.Columns[1].Name = "Last Name";
            dgvEmployee.Columns[2].Name = "Address";
            dgvEmployee.Columns[3].Name = "City";
            dgvEmployee.Columns[4].Name = "State";
            dgvEmployee.Columns[5].Name = "Zip";
            dgvEmployee.Columns[6].Name = "Phone";
            dgvEmployee.Columns[7].Name = "email";


            //grab fields from database

            try
            {


                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();

              

                //--get first name last name address from Person Table based on RoleID from table Users
                commandPerson = new SqlCommand("SELECT RandrezaVoharisoaM21Su2332.Person.NameFirst, RandrezaVoharisoaM21Su2332.Person.NameLast,RandrezaVoharisoaM21Su2332.Person.Address1,RandrezaVoharisoaM21Su2332.Person.City,RandrezaVoharisoaM21Su2332.Person.State, RandrezaVoharisoaM21Su2332.Person.Zipcode,RandrezaVoharisoaM21Su2332.Person.PhonePrimary, RandrezaVoharisoaM21Su2332.Person.Email  FROM RandrezaVoharisoaM21Su2332.Person FULL JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Users.PersonID = RandrezaVoharisoaM21Su2332.Person.PersonID WHERE RoleID = 1 OR RoleID = 2; ", Connection);
                //gets the results from the sql command Person table
                readerPerson = commandPerson.ExecuteReader();

                while (readerPerson.Read())
                {

                    //iterates through the employee id  column to find a matching value
                    strNameFirst = readerPerson["NameFirst"].ToString();
                    strNameLast = readerPerson["NameLast"].ToString();
                    strAddress = readerPerson["Address1"].ToString(); 
                    strCity = readerPerson["City"].ToString(); 
                     strZip = readerPerson["Zipcode"].ToString(); 
                   strState = readerPerson["State"].ToString(); 
                     strPhone = readerPerson["PhonePrimary"].ToString(); 
                    strEmail = readerPerson["Email"].ToString(); 
                   
                    string[] row1 = {strNameFirst, strNameLast, strAddress, strCity , strState, strZip , strPhone, strEmail };
                    dgvEmployee.Rows.Add(row1);
                                 
                }

                //while(readePersonTable.Read())
                //{
                //    strNameFirst = readePersonTable["NameFirst"].ToString();
                //    strNameLast = readePersonTable["NameLast"].ToString();

                //    string[] row2 = { strNameFirst, strNameLast };
                //    dgvEmployee.Rows.Add(row2);
                //}


                if (readerPerson != null)
                {
                    readerPerson.Close(); //closes the reader
                }

                //else if (readePersonTable != null)
                //{
                //    readePersonTable.Close();
                //}

                //--get Salary,Date of hire from Employee Table based on RoleID from Table Users
                commandEmployee = new SqlCommand("SELECT RandrezaVoharisoaM21Su2332.Employees.Salary,RandrezaVoharisoaM21Su2332.Employees.HiredDate,RandrezaVoharisoaM21Su2332.Employees.EmployeeID " +
                    "FROM RandrezaVoharisoaM21Su2332.Employees FULL JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Users.UserID = RandrezaVoharisoaM21Su2332.Employees.UserID WHERE RandrezaVoharisoaM21Su2332.Users.RoleID = 1 OR RoleID = 2; ", Connection);
                //gets the results from the sql command Employee table
                readerEmployee = commandEmployee.ExecuteReader();

                //strEmployeeID = reader["EmployeeID"].ToString();
                //strEmployeeSalary = reader["Salary"].ToString();
                //strEmployeeHiredDate = reader["HiredDate"].ToString();

                if (Connection != null)
                {
                    Connection.Close(); //closes connection to database
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        strItemID= dgvAllProducts.Rows[intIndexRowSelected].Cells[0].Value.ToString();
                        dgvAllProducts.Rows.RemoveAt(row.Index);

                    }
                    try
                    {
                        //connect to database
                        Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                            "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                        Connection.Open();

                        string strDeleteQuery = "DELETE FROM RandrezaVoharisoaM21Su2332.Items where ItemID= '" + strItemID + "'";
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
            string itemNameSelected=  dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[1].Value.ToString();

            if (dgvAllProducts.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you want to edit '"+ itemNameSelected + "'?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gbxUpdateField.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Please select the product you want to edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select the product you want to update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }



        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
          
                string strName;

                string strQuantity;
                int intQuantity;
                bool blnQuantityConvert;

                string strCost;
                double dblCost;
                bool blnCostConvert;

                string strRetailPrice;
                double dblRetailPrice;
                bool blnRetailPriceConvert;

                string strDescription;

                string strCategory;
                int intCategory;
                bool intCategoryTryParse;


                string strSupplierID;
                int intSupplierID;
                bool intSupplierTryParse;
            try
            {
                //Connection.Open();
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                //Get the Name of the selected Item 
                strItemID = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[0].Value.ToString();

                if (tbxName.Text == "")
                {
                    strName = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    strName = tbxName.Text;
                }

                if (tbxQuantity.Text == "")
                {
                    strQuantity = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[2].Value.ToString();
                    blnQuantityConvert = int.TryParse(strQuantity, out intQuantity);
                }
                else
                {

                    strQuantity = tbxQuantity.Text;
                    blnQuantityConvert = int.TryParse(strQuantity, out intQuantity);
                }

                if (tbxCost.Text == "")
                {
                    strCost = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[3].Value.ToString();
                    blnCostConvert = double.TryParse(strCost, out dblCost);
                }
                else
                {
                    strCost = tbxCost.Text;
                    blnCostConvert = double.TryParse(strCost, out dblCost);
                }


                if (tbxRetailPrice.Text == "")
                {
                    strRetailPrice = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[4].Value.ToString();
                    blnRetailPriceConvert = double.TryParse(strRetailPrice, out dblRetailPrice);
                }
                else
                {
                    strRetailPrice = tbxRetailPrice.Text;
                    blnRetailPriceConvert = double.TryParse(strRetailPrice, out dblRetailPrice);
                }

                if (tbxDescription.Text == "")
                {
                    strDescription = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[5].Value.ToString();
                }
                else
                {
                    strDescription = tbxDescription.Text;
                }




                if (cboCategory.Text == "")
                {
                    strCategory = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[6].Value.ToString();
                    intCategoryTryParse = int.TryParse(strCategory, out intCategory);

                }
                else
                {
                    strCategory = cboCategory.SelectedItem.ToString();
                    intCategoryTryParse = int.TryParse(strCategory, out intCategory);
                }

                if (cboSupplierID.Text == "")
                {

                    strSupplierID = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[7].Value.ToString();
                    intSupplierTryParse = int.TryParse(strSupplierID, out intSupplierID);

                }
                else
                {
                    strSupplierID = cboSupplierID.SelectedItem.ToString();
                    intSupplierTryParse = int.TryParse(strSupplierID, out intSupplierID);
                }
                if (intQuantity > 0 && intQuantity < int.MaxValue )
                {
                    if (dblCost > 0 && dblCost < double.MaxValue)
                    {
                        if (dblRetailPrice > 0 && dblRetailPrice < double.MaxValue)
                        {
                            Connection.Open();

                            string strUpdateQuery = "UPDATE RandrezaVoharisoaM21Su2332.Items SET Name = @Name, Quantity = @Quantity, Cost = @Cost, RetailPrice = @RetailPrice, Description = @Description, CategoryID = @CategoryID, SupplierID = @SupplierID" +
                                " where ItemID= '" + strItemID + "'";
                            SqlCommand updateCommande = new SqlCommand(strUpdateQuery, Connection);
                            SqlParameter sqlpmName = updateCommande.Parameters.AddWithValue("@Name", strName);
                            SqlParameter sqlpmQuantity = updateCommande.Parameters.AddWithValue("@Quantity", intQuantity);
                            SqlParameter sqlpmCost = updateCommande.Parameters.AddWithValue("@Cost", dblCost);
                            SqlParameter sqlpmRetailPrice = updateCommande.Parameters.AddWithValue("@RetailPrice", dblRetailPrice);
                            SqlParameter sqlpmDescription = updateCommande.Parameters.AddWithValue("@Description", strDescription);
                            SqlParameter sqlpmCategory = updateCommande.Parameters.AddWithValue("@CategoryID", intCategory);
                            SqlParameter sqlpmSupplier = updateCommande.Parameters.AddWithValue("@SupplierID", intSupplierID);
                            updateCommande.ExecuteNonQuery();
                            btnSaveUpdate.Enabled = true;
                            Connection.Close();

                            MessageBox.Show("The selected item has been updated successfully?", "Exit Application", MessageBoxButtons.OK);

                            DisplayAllItems();

                        }

                        else
                        {
                            MessageBox.Show("Please enter positive value only for Retail Price", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxRetailPrice.Text = "";
                            tbxRetailPrice.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter positive value only for Cost", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxCost.Text = "";
                        tbxCost.Focus();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please enter positive number only for Quantity", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxQuantity.Text = "";
                    tbxQuantity.Focus();
                }
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

        //Enable textbox for updating when checkbox checked
        private void cbxName_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxName.Checked == true)
            {
                tbxName.Enabled = true;
            }
            else
            {
                tbxName.Enabled = false;
            }

        }

        private void cbxQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxQuantity.Checked == true)
            {
                tbxQuantity.Enabled = true;
            }
            else
            {
                tbxQuantity.Enabled = false;
            }
        }

        private void cbxCost_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCost.Checked == true)
            {
                tbxCost.Enabled = true;
            }
            else
            {
                tbxCost.Enabled = false;
            }
        }


        private void cbxRetailPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxRetailPrice.Checked == true)
            {
                tbxRetailPrice.Enabled = true;
            }
            else
            {
                tbxRetailPrice.Enabled = false;
            }
        }

        private void cbxDescription_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDescription.Checked == true)
            {
                tbxDescription.Enabled = true;
            }
            else
            {
                tbxDescription.Enabled = false;
            }
        }

        private void cbxCategoryID_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCategoryID.Checked == true)
            {
                cboCategory.Enabled = true;
            }
            else
            {
                cboCategory.Enabled = false;
            }
        }

        private void cbxSupplierID_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSupplierID.Checked == true)
            {
                cboSupplierID.Enabled = true;
            }
            else
            {
                cboSupplierID.Enabled = false;
            }
        }

        public void ResetUpdateFields()
        {
            cbxName.Checked = false; tbxName.Text = "";
            cbxQuantity.Checked = false; tbxQuantity.Text = "";
            cbxCost.Checked = false; tbxCost.Text = "";
            cbxRetailPrice.Checked = false; tbxRetailPrice.Text = "";
            cbxDescription.Checked = false; tbxDescription.Text = "";
             cboCategory.Text = "";
            cbxCategoryID.Checked = false;
             cboSupplierID.Text = "";
            cbxSupplierID.Checked = false;

        }
        private void dgvAllProducts_SelectionChanged(object sender, EventArgs e)
        {
            gbxUpdateField.Enabled = false;
            ResetUpdateFields();
        }

        //-----------------------------------------
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

                string insertQuery = "UPDATE RandrezaVoharisoaM21Su2332.Items set Image = @Image where ItemID= '" + strItemID + "'"; // @Image is a parameter we will fill in later
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
                SqlCommand cmd = new SqlCommand("Select Image From RandrezaVoharisoaM21Su2332.Items where ItemID = '" + strItemID + "'", Connection);
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

    }

}
        

