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
using System.Text.RegularExpressions;
using System.Reflection;
namespace SU21_Final_Project
{
    public partial class frmAdmin : Form
    {
        //Establish connection to the database       
        SqlConnection Connection;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        DataTable dt;


        string strItemID;
        string strPersonID;
        string strUserID;

        string strPersonIdCustomerView;
        string strInvoiceReport;
        string strSupplierId;

        string strPurchaseID;
        string strPurchaseInvoice;
        string strPurchaseInvoiceFile;
        int intPurchaseID;
        string strPurchaseNumber;
        string strSupplierInvoice;

        private void frmAdmin_Load(object sender, EventArgs e)
        {
             
            string strGetDate = DateTime.Now.ToShortDateString();//Get date
            lblDate.Text = strGetDate;
        }
        public frmAdmin()
        {
            InitializeComponent();

            if (tabManagerFeatures.SelectedTab.Name == "tabInventory")
            {
                DisplayAllItems();
                DisplayLowQuantityItems();
                DisplayLowItems();
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

                dataAdapter = new SqlDataAdapter("SELECT ItemID as [Item ID], Name, Quantity," +
                    "FORMAT(Cost, 'c', 'en-US') AS 'Cost' , " +
                    "FORMAT(retailPrice, 'c', 'en-US') AS 'Retail Price' ,Description,CategoryID as [Category ID] ,SupplierID as [Supplier ID] FROM RandrezaVoharisoaM21Su2332.Items where Status='Available'", Connection);

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

        public void DisplayEmployees()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT RandrezaVoharisoaM21Su2332.Person.PersonID as [Employee ID], RandrezaVoharisoaM21Su2332.Person.NameFirst as [First Name], RandrezaVoharisoaM21Su2332.Person.NameLast as [Last Name],RandrezaVoharisoaM21Su2332.Person.Address1 as [Address],RandrezaVoharisoaM21Su2332.Person.City,RandrezaVoharisoaM21Su2332.Person.State, RandrezaVoharisoaM21Su2332.Person.Zipcode,RandrezaVoharisoaM21Su2332.Person.Email, RandrezaVoharisoaM21Su2332.Person.PhonePrimary as [Phone]  FROM RandrezaVoharisoaM21Su2332.Person FULL JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Users.PersonID = RandrezaVoharisoaM21Su2332.Person.PersonID  WHERE Status ='Active' and RoleID = 1 OR RoleID = 2; ", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvEmployee.DataSource = dataTable;


                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayCustomers()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();

                dataAdapter = new SqlDataAdapter("SELECT RandrezaVoharisoaM21Su2332.Person.PersonID  as [Person ID],RandrezaVoharisoaM21Su2332.Person.NameFirst  as [First Name], RandrezaVoharisoaM21Su2332.Person.NameLast as [Last Name],RandrezaVoharisoaM21Su2332.Person.Address1  as [Address],RandrezaVoharisoaM21Su2332.Person.City,RandrezaVoharisoaM21Su2332.Person.State, RandrezaVoharisoaM21Su2332.Person.Zipcode,RandrezaVoharisoaM21Su2332.Person.PhonePrimary as [Phone] , RandrezaVoharisoaM21Su2332.Person.Email  FROM RandrezaVoharisoaM21Su2332.Person FULL JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Users.PersonID = RandrezaVoharisoaM21Su2332.Person.PersonID WHERE RoleID = 3  and Status= 'Active'; ", Connection);

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvCustomer.DataSource = dataTable;


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

            if (tabManagerFeatures.SelectedTab.Name == "tabEmployee")
            {
                DisplayEmployees();
            }
            if (tabManagerFeatures.SelectedTab.Name == "tabCustomer")
            {
                DisplayCustomers();
            }
            if (tabManagerFeatures.SelectedTab.Name == "tabSalesReport")
            {
                DisplaySalesReport();
                radAllReport.Checked = true;
            }
            if (tabManagerFeatures.SelectedTab.Name == "tabSupplier")
            {
                DisplaySupplierList();
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
            try
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
                            strItemID = dgvAllProducts.Rows[intIndexRowSelected].Cells[0].Value.ToString();
                            dgvAllProducts.Rows.RemoveAt(row.Index);

                        }
                        try
                        {
                            //connect to database
                            Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                                "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                            Connection.Open();

                            //get userID from personID in USers
                            SqlCommand commandRemove = new SqlCommand("UPDATE RandrezaVoharisoaM21Su2332.Items SET Status ='Unavailable' where ItemID = '" + strItemID + "'", Connection);
  
                            commandRemove.ExecuteNonQuery();

                            Connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please select the product you want to remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }


        //Update Selected Item
        private void btnUpdateItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string strItemNameSelected = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[1].Value.ToString();

                if (dgvAllProducts.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Do you want to edit '" + strItemNameSelected + "'?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }


        //Save Edited Fields
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {

            string strName;

            string strSelectedQuantity;
            strSelectedQuantity = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[2].Value.ToString();
            int intSelectedQuantity;
            bool blnResultTryParse = int.TryParse(strSelectedQuantity, out intSelectedQuantity);

            string strAddQuantity;
            int intAddQuantity = 0;
            bool blnQuantityConvert;
            bool blnInvoice;

            int intUpdateQuantity;

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

                    intUpdateQuantity = intSelectedQuantity;
                    blnInvoice = false;
                }
                else
                {
                    if(!tbxQuantity.Text.Contains("."))
                    {
                        strAddQuantity = tbxQuantity.Text;
                        blnQuantityConvert = int.TryParse(strAddQuantity, out intAddQuantity);
                        if (blnQuantityConvert == false)
                        {
                            MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbxQuantity.Focus();
                        }

                        
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid quantity number", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    intUpdateQuantity = intSelectedQuantity + intAddQuantity;
                    blnInvoice = true;

                }

                if (tbxCost.Text == "")
                {
                    strCost = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[3].Value.ToString().Substring(1);
                    blnCostConvert = double.TryParse(strCost, out dblCost);
                    if (blnCostConvert == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    strCost = tbxCost.Text;
                    blnCostConvert = double.TryParse(strCost, out dblCost);
                    if (blnCostConvert == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }


                if (tbxRetailPrice.Text == "")
                {
                    strRetailPrice = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[4].Value.ToString().Substring(1);
                    blnRetailPriceConvert = double.TryParse(strRetailPrice, out dblRetailPrice);
                    if (blnRetailPriceConvert == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    strRetailPrice = tbxRetailPrice.Text;
                    blnRetailPriceConvert = double.TryParse(strRetailPrice, out dblRetailPrice);
                    if (blnRetailPriceConvert == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
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
                    if (intCategoryTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    strCategory = cboCategory.SelectedItem.ToString();
                    intCategoryTryParse = int.TryParse(strCategory, out intCategory);
                    if (intCategoryTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

             

                    strSupplierID = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[7].Value.ToString();
                    intSupplierTryParse = int.TryParse(strSupplierID, out intSupplierID);
                    if (intSupplierTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    strSupplierInvoice = strSupplierID;
              


                if (intSelectedQuantity >= 0 && intSelectedQuantity < int.MaxValue)
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
                            SqlParameter sqlpmQuantity = updateCommande.Parameters.AddWithValue("@Quantity", intUpdateQuantity);
                            SqlParameter sqlpmCost = updateCommande.Parameters.AddWithValue("@Cost", dblCost);
                            SqlParameter sqlpmRetailPrice = updateCommande.Parameters.AddWithValue("@RetailPrice", dblRetailPrice);
                            SqlParameter sqlpmDescription = updateCommande.Parameters.AddWithValue("@Description", strDescription);
                            SqlParameter sqlpmCategory = updateCommande.Parameters.AddWithValue("@CategoryID", intCategory);
                            SqlParameter sqlpmSupplier = updateCommande.Parameters.AddWithValue("@SupplierID", intSupplierID);
                            updateCommande.ExecuteNonQuery();
                            btnSaveUpdate.Enabled = true;
                           

                            MessageBox.Show("The selected item has been updated successfully?", "Message", MessageBoxButtons.OK);


                            //Store in Purchase table
                            SqlCommand commandPurchaseReport = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Purchase(SupplierID,PurchaseDate, ItemName) VALUES (@SupplierID,@PurchaseDate,@ItemName)", Connection);
                            commandPurchaseReport.Parameters.AddWithValue("@SupplierID", intSupplierID.ToString());
                            commandPurchaseReport.Parameters.AddWithValue("@PurchaseDate", lblDate.Text);
                            commandPurchaseReport.Parameters.AddWithValue("@ItemName", strName);

                            commandPurchaseReport.ExecuteNonQuery();

                            //Get the last PurchaseID using Max to use as Purchase Invoice number
                            string strQueryPurchaseID = "SELECT MAX(PurchaseId) from RandrezaVoharisoaM21Su2332.Purchase";
                            SqlCommand commandPurchaseID = new SqlCommand(strQueryPurchaseID, Connection);

                            //gets Sale Id from insert sale report in the table sales report
                            SqlDataReader srPurchaseID = commandPurchaseID.ExecuteReader();
                            srPurchaseID.Read();
                            intPurchaseID = srPurchaseID.GetInt32(0);

                            strPurchaseInvoice = intPurchaseID.ToString() + ".html";
                            strPurchaseInvoiceFile = intPurchaseID.ToString();
                            srPurchaseID.Close();

                           



                            DisplayAllItems();
                            ResetUpdateFields();
                            DisplayLowQuantityItems();
                            DisplayLowItems();
                            Connection.Close();
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

                if (blnInvoice == true)
                {
                   
                        PrintInvoice(GenerateInvoice(strName, intAddQuantity, dblCost));
                    MessageBox.Show("Your purchase has been saved, Invoice ID is " + strPurchaseInvoiceFile + " ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //Function for creating Invoice after adding Item
        private StringBuilder GenerateInvoice(string strItemName, int intItemQuantity, double dblCost)
        {
            double dblTax = 0.0825;
            double dblTotalCost = dblCost * intItemQuantity;
            double dblTaxValue = dblTotalCost * dblTax;
            double dblTotalPay = dblTotalCost + dblTaxValue;

            StringBuilder html = new StringBuilder();
            StringBuilder css = new StringBuilder();

            css.AppendLine("<style>");
            css.AppendLine("td {padding: 5px; text-align:center; font-weight: bold; text-align: center;}");
            css.AppendLine("h1 {color: blue;}");
            css.AppendLine("h2 {color: red;}");
            css.AppendLine("</style>");

            html.AppendLine("<html>");
            html.AppendLine($"<head>{css}<title>{"Invoice"}</title></head>");
            html.AppendLine("<body>");

            html.AppendLine($"<h1>{" Purchase Invoice"}</h1>");

            html.Append($"<h5>{"Date: "}{lblDate.Text}</h5>");
            html.Append($"<h5>{"Purchase Invoice #: "}{strPurchaseInvoiceFile}</h5>");

            html.AppendLine("<table>");
            html.AppendLine("<tr><td>Name</td><td>Quantity</td><td>Cost</td><td>TotalCost</td>");
            html.AppendLine("<tr><td colspan=4><hr /></td></tr>");

            html.Append("<tr>");
            html.Append($"<td>{strItemName}</td>");
            html.Append($"<td>{intItemQuantity.ToString()}</td>");
            html.Append($"<td>{dblCost.ToString("C2")}</td>");
            html.Append($"<td>{dblTotalCost.ToString("C2")}</td>");
            html.Append("</tr>");
            html.AppendLine("<tr><td colspan=4><hr /></td></tr>");


            html.Append("<tr><td colspan=4><hr></hd></td></tr>");
            html.Append("<table>");


            html.AppendLine($"<h5>{"Subtotal: "}{dblTotalCost.ToString("C2")}</h5>");
            html.AppendLine($"<h5>{"Tax (8.25%): "}{dblTaxValue.ToString("C2")}</h5>");
            html.AppendLine($"<h5>{"Total Amount: "}{dblTotalPay.ToString("C2")}</h5>");


            html.Append($"<h2>{"Supplier ID: "}{strSupplierInvoice}</h2>");

            html.Append("</body></html>");//close body

            return html;
        }

       
        private void PrintInvoice(StringBuilder html)
        {
            string strPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string strFilepath = strPath + "\\" + strPurchaseInvoice + " ";
            try
            {
                // A "using" statement will automatically close a file after opening it.               
                using (StreamWriter swPurchase = new StreamWriter(strFilepath))
                {
                    swPurchase.WriteLine(html);
                }
                System.Diagnostics.Process.Start(strFilepath); //Open the report in the default web browser
            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.",
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show("Are you sure you want to log out?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
                tbxCost.Text = "";
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



        public void ResetUpdateFields()
        {
            cbxName.Checked = false; tbxName.Text = "";
            cbxQuantity.Checked = false; tbxQuantity.Text = "";
            cbxCost.Checked = false; tbxCost.Text = "";
            cbxRetailPrice.Checked = false; tbxRetailPrice.Text = "";
            cbxDescription.Checked = false; tbxDescription.Text = "";
            cboCategory.Text = "";
            cbxCategoryID.Checked = false;
          
            cbxStates.Checked = false;
        }
        private void dgvAllProducts_SelectionChanged(object sender, EventArgs e)
        {
            gbxUpdateField.Enabled = false;
            ResetUpdateFields();
        }


        private void btnAddItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddItems.PerformClick();
            }
        }

        private void btnUpdateItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdateItem.PerformClick();
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }



        //-------------------------------------Employee--------------------------------

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            new frmAddEmployee().Show();
            this.Hide();
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strPersonId;
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                Connection.Open();

                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvEmployee.Rows[e.RowIndex];
                    strPersonId = row.Cells["Employee ID"].Value.ToString();


                    //get salary, hired date and Position from Employees Table
                    string strQuery = "SELECT RandrezaVoharisoaM21Su2332.Employees.Salary,RandrezaVoharisoaM21Su2332.Employees.HiredDate, RandrezaVoharisoaM21Su2332.Employees.Position,RandrezaVoharisoaM21Su2332.Employees.UserID FROM RandrezaVoharisoaM21Su2332.Employees FULL JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Users.UserID= RandrezaVoharisoaM21Su2332.Employees.UserID WHERE RandrezaVoharisoaM21Su2332.Users.PersonID='" + strPersonId + "'";
                    SqlCommand command = new SqlCommand(strQuery, Connection);

                    //gets the results from the sql command
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    decimal decSalary = reader.GetDecimal(0);
                    var HiredDate = reader.GetDateTime(1);
                    lblSalary.Text = decSalary.ToString("C2");
                    lblPosition.Text = reader["Position"].ToString();
                    lblHiredDate.Text = HiredDate.ToString("d");

                    int intUserId = reader.GetInt32(3);//use to acces User table
                    strUserID = intUserId.ToString();
                    

                    if (reader != null)
                    {
                        reader.Close();
                    }

                }

                if (Connection != null)
                {
                    Connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Employee is no longer active" , "Status Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblSalary.Text ="No longer available" ;
                lblPosition.Text = "No longer available";
                lblHiredDate.Text = "No longer available";

            }

        }

        //Remove Employee from database tables( Employees, Users, Person)
        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployee.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Do you want to remove this Employee?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvEmployee.SelectedRows)
                        {
                            //grab current row index selected
                            int intIndexRowSelected = dgvEmployee.CurrentCell.RowIndex;
                            //grab Employee name to use in order to delete in the database
                            strPersonID = dgvEmployee.Rows[intIndexRowSelected].Cells[0].Value.ToString();
                            dgvEmployee.Rows.RemoveAt(row.Index);

                        }
                        try
                        {
                            //connect to database
                            Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                                "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                            Connection.Open();

                            //get userID from personID in USers
                            SqlCommand commandRemove = new SqlCommand("UPDATE RandrezaVoharisoaM21Su2332.Users SET Status ='Inactive' where PersonID = '" + strPersonID + "'", Connection);
                            //SqlParameter sqlpmPhone = commandRemove.Parameters.AddWithValue("@Phone", strPhoneEdit);
                            commandRemove.ExecuteNonQuery();

                            Connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please select the Employee you want to remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          


        }

        //Edit Employee Informatiom
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                string strFirstName = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string strLastName = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[2].Value.ToString();


                if (dgvEmployee.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Do you want to edit Employee '" + strFirstName + " " + strLastName + "'?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gbxEdit.Enabled = true;
                        cbxEditPhone.Enabled = true;
                        cbxStates.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Please select the Employee you want to edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please make a selection", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            string strNameFirst;
            string strNameLast;
            string strAddress;
            string strCity;
            string strEmail;
            string strZip;
            string strStateEdit;
            string strPhoneEdit;
            string strPersonID;
            bool blnUpdated = false;
            try
            {
                //Connection.Open();
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
               strPersonID = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[0].Value.ToString();

                if (tbxFirstName.Text == "")
                {
                    strNameFirst = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    strNameFirst = tbxFirstName.Text;
                    blnUpdated = true;
                }

                if (tbxLastName.Text == "")
                {
                    strNameLast = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[2].Value.ToString();

                }
                else
                {
                    strNameLast = tbxLastName.Text;
                    blnUpdated = true;
                }


                if (tbxAddress.Text == "")
                {
                    strAddress = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    strAddress = tbxAddress.Text;
                    blnUpdated = true;
                }

                if (tbxCity.Text == "")
                {
                    strCity = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[4].Value.ToString();
                   
                }
                else
                {
                    strCity = tbxCity.Text;
                    blnUpdated = true;
                }


                if (cboStates.Text == "")
                {
                    strStateEdit = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[5].Value.ToString();

                }
                else
                {
                    strStateEdit = cboStates.SelectedItem.ToString();
                    blnUpdated = true;

                }

        

                if (tbxZip.Text == "")
                {
                    strZip = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[6].Value.ToString();
                }
                else
                {
                    strZip = tbxZip.Text;
                    blnUpdated = true;
                }

                if (ValidEmail(tbxEmail.Text)==false)
                {
                    strEmail = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[7].Value.ToString();
                    if (cbxEmail.Checked == true)
                    {
                        MessageBox.Show("This Email format can't be updated?", "Message", MessageBoxButtons.OK);
                    }                   
                    
                }
                else
                {
                    
                    strEmail = tbxEmail.Text;
                    blnUpdated = true;

                }

                if (ValidPhone(mskPhones.Text)==false)
                {
                    strPhoneEdit = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[8].Value.ToString();

                }
                else
                {
                    strPhoneEdit = mskPhones.Text;
                    blnUpdated = true;
                }

                Connection.Open();
               
                    string strQuery = "UPDATE RandrezaVoharisoaM21Su2332.Person SET NameFirst = @NameFirst,NameLast = @NameLast,Address1 = @Address,City = @City,State=@State, Zipcode = @Zip, Email= @Email, PhonePrimary = @Phone" +
                    " where PersonID= '" + strPersonID + "'";
                    SqlCommand editCommande = new SqlCommand(strQuery, Connection);
                SqlParameter sqlpmNameFirst = editCommande.Parameters.AddWithValue("@NameFirst", strNameFirst);
                SqlParameter sqlpmNameLast = editCommande.Parameters.AddWithValue("@NameLast", strNameLast);
                SqlParameter sqlpmAddress = editCommande.Parameters.AddWithValue("@Address", strAddress);
                SqlParameter sqlpmCity = editCommande.Parameters.AddWithValue("@City", strCity);
                SqlParameter sqlpmState = editCommande.Parameters.AddWithValue("@State", strStateEdit);
                SqlParameter sqlpmZip = editCommande.Parameters.AddWithValue("@Zip", strZip);
                SqlParameter sqlpmEmail = editCommande.Parameters.AddWithValue("@Email", strEmail);
                SqlParameter sqlpmPhone = editCommande.Parameters.AddWithValue("@Phone", strPhoneEdit);
                    editCommande.ExecuteNonQuery();

                    Connection.Close();
                if (blnUpdated == true)
                {
                    MessageBox.Show("The selected employee has been updated?", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No fields to update", "Message", MessageBoxButtons.OK);
                }
                    DisplayEmployees();
                    ResetEditFields();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK);
            }

        }


    //------------------Enable textbox for updating when checkbox checked-------------------------------------
        private void cbxFirstName_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxFirstName.Checked == true)
            {
                tbxFirstName.Enabled = true;
            }
            else
            {
                tbxFirstName.Enabled = false;
            }
        }

        private void cbxLastName_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxLastName.Checked == true)
            {
                tbxLastName.Enabled = true;
            }
            else
            {
                tbxLastName.Enabled = false;
            }
        }

        private void cbxAddress_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxAddress.Checked == true)
            {
                tbxAddress.Enabled = true;
            }
            else
            {
                tbxAddress.Enabled = false;
            }
        }

        private void cbxCity_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCity.Checked == true)
            {
                tbxCity.Enabled = true;
            }
            else
            {
                tbxCity.Enabled = false;
            }
        }


        private void cbxZip_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxZip.Checked == true)
            {
               tbxZip.Enabled = true;
            }
            else
            {
                tbxZip.Enabled = false;
            }
        }

        private void cbxEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEmail.Checked == true)
            {
                tbxEmail.Enabled = true;
            }
            else
            {
                tbxEmail.Enabled = false;
            }
        }
    //-----------------------------------------------------------------------

        //Reset all fildes edited
        public void ResetEditFields()
        {
            cbxFirstName.Checked = false; tbxFirstName.Text = "";
            cbxLastName.Checked = false; tbxLastName.Text = "";
            cbxAddress.Checked = false; tbxAddress.Text = "";
            cbxZip.Checked = false; tbxZip.Text = "";
            cbxCity.Checked = false; tbxCity.Text = "";
            cbxEditPhone.Enabled = false; mskPhones.Text = "";
            cbxStates.Enabled = false; cboStates.Text = "";
            cbxEmail.Checked = false; tbxEmail.Text = "";
            cbxEditPhone.Checked = false;
            cbxStates.Checked = false;
        }

        //Reset if user change selection in the datagrid
        private void dgvEmployee_SelectionChanged_1(object sender, EventArgs e)
        {
            gbxEdit.Enabled = false;
            ResetEditFields();
        }

        //---------------Using digit keys only------------------
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

        private void tbxZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }
        }
//--------------------------------------------------------------------------------------------------
    
        //Validation email and Phone
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

        public bool ValidPhone(string strValidPhone)
        {
           if (mskPhones.Text.Length <12)

                    return false;

            return true;
        }
//--------------------------------------------------------------------------------------------------------------------

        //Enable text boxes for edit 
        private void cbxEditPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEditPhone.Checked == true)
            {
                mskPhones.Enabled = true;
            }
            else
            {
                mskPhones.Enabled = false;
            }
        }

        private void cbxStates_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxStates.Checked == true)
            {
                cboStates.Enabled = true;
            }
            else
            {
                cboStates.Enabled = false;
            }
        }
        //Display items less than 50
        public void DisplayLowQuantityItems()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Name, Quantity FROM RandrezaVoharisoaM21Su2332.Items where Quantity <50 and Status='Available';", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvLowItem50.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method to display items less than 100
        public void DisplayLowItems()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Name, Quantity FROM RandrezaVoharisoaM21Su2332.Items where Status='Available' and Quantity between 50 and 99;", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvLowItem100.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method to display Sales reports
        public void DisplaySalesReport()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT SaleId as [Sale ID], UserID as [User ID], CreationDate as [Date of Sale]  FROM RandrezaVoharisoaM21Su2332.SalesReport;", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvSalesReport.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplaySalesDetail(string strSaleID)
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                string strQuery = "SELECT SaleID as [Sale ID],ItemID as [Item ID], QuantitySold as [Quantity], Decoration, Size, Color FROM RandrezaVoharisoaM21Su2332.SalesDetails where SaleID='" + strSaleID + "' ;";
                dataAdapter = new SqlDataAdapter(strQuery, Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvSalesDetails.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvSalesReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strSaleId;
            try
            {
                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvSalesReport.Rows[e.RowIndex];
                    strSaleId = row.Cells["Sale ID"].Value.ToString();
                    strInvoiceReport = row.Cells["Sale ID"].Value.ToString();
                    DisplaySalesDetail(strSaleId);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }
        
        //Creating coupon
        private void btnCreateCoupon_Click(object sender, EventArgs e)
        {
            string strCouponDescription = cboCouponDescription.Text;
            string strIndex = "0";
           
            string strCouponID;

            try
            {

                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                if (cboCouponDescription.Text != "" && dtpStartCoupon.Text != "" && dtpEndCoupon.Text != "")
                {


                    if (cboCouponDescription.SelectedIndex == 0)
                    {
                        strIndex = "1";
                        
                    }
                    else if (cboCouponDescription.SelectedIndex == 1)
                    {
                        strIndex = "2";
                        
                    }

                    else if (cboCouponDescription.SelectedIndex == 2)
                    {
                        strIndex = "3";
                        
                    }


                    SqlCommand commandPerson = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Coupon(Description,CreationDate,Expiration,DiscountIndex) VALUES (@Description,@StartDate,@EndDate,@Index)", Connection);
                    commandPerson.Parameters.AddWithValue("@Description", strCouponDescription);
                    commandPerson.Parameters.AddWithValue("@StartDate", dtpStartCoupon.Value.Date);
                    commandPerson.Parameters.AddWithValue("@EndDate", dtpEndCoupon.Value.Date);
                    commandPerson.Parameters.AddWithValue("@Index", strIndex);

                    commandPerson.ExecuteNonQuery();

                    //Get the CouponID 
                    string queryLastID = "SELECT MAX(CouponID) from RandrezaVoharisoaM21Su2332.Coupon";
                    SqlCommand commandLastID = new SqlCommand(queryLastID, Connection);

                    //gets the results from the sql command
                    SqlDataReader sr = commandLastID.ExecuteReader();
                    sr.Read();
                    strCouponID = sr.GetInt32(0).ToString();
                    sr.Close();

                    MessageBox.Show("Coupon number:" + strCouponID + " added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Connection.Close();

                }
                else
                {
                    MessageBox.Show("Please make sure to fill up the required fields with(*)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Refresh lists
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayAllItems();
            DisplayLowQuantityItems();
            DisplayLowItems();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            gbxAddNewCustomer.Enabled = true;
            dgvCustomer.Enabled = false;
            btnAddNewCustomer.Enabled = true;
        }

        //-------------------Method for Valid  Phone and Valid Address-------------
        public bool ValidPhone()
        {
            if (mskPhoneCustomer.Text.Length < 12 && mskPhoneCustomer.Text.Contains(" "))
            {
                return false;
            }
            return true;
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

//-------------------------------------------------------------------------

        //Button to add customer
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            string strFirstName = tbxFirstNameCustomer.Text;
            string strLastName = tbxLastNameCustomer.Text;
            string strAddress = tbxAddressCustomer.Text;
            string strPhone = mskPhoneCustomer.Text;
            string strCity = tbxCustomerCity.Text;
            string strState = cboStatesCustomer.Text;
            string strZip = tbxZipCustomer.Text;
            string strEmail = tbxEmailCustomer.Text;
            string strTitle = "Customer";
            int intRoleId = 3;

            try
            {

                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                if (tbxFirstNameCustomer.Text != "" && tbxLastNameCustomer.Text != "" && tbxAddressCustomer.Text != "" && mskPhoneCustomer.Text != "" && tbxCustomerCity.Text != "" && cboStatesCustomer.Text != ""
                    && tbxZipCustomer.Text != "" && tbxEmailCustomer.Text != "")
                {


                    if (ValidAddress(strAddress) == true)
                    {

                        if (ValidEmail(strEmail) == true)
                        {
                            if (ValidPhone() == true)
                            {
                                SqlCommand commandPerson = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Person(Title,NameFirst,NameLast,Address1,City,Zipcode,State,Email,PhonePrimary) VALUES (@Title,@NameFirst,@NameLast,@Address,@City,@Zipcode,@State,@Email,@Phone)", Connection);
                                commandPerson.Parameters.AddWithValue("@Title", strTitle);
                                commandPerson.Parameters.AddWithValue("@NameFirst", strFirstName);
                                commandPerson.Parameters.AddWithValue("@NameLast", strLastName);
                                commandPerson.Parameters.AddWithValue("@Address", strAddress);
                                commandPerson.Parameters.AddWithValue("@City", strCity);
                                commandPerson.Parameters.AddWithValue("@Zipcode", strZip);
                                commandPerson.Parameters.AddWithValue("@State", strState);
                                commandPerson.Parameters.AddWithValue("@Email", strEmail);
                                commandPerson.Parameters.AddWithValue("@Phone", strPhone);
                                commandPerson.ExecuteNonQuery();

                                //INSERT RECORD FOR USERS LOGON SECURITY ACCESS
                                string strAnswerOne = "Not Available";
                                string strAnswerTwo = "Not Available";
                                string strAnswerThree = "Not Available";
                                intRoleId = 3;
                                string strQuestionOne = "Not Available";
                                string strQuestionTwo = "Not Available";
                                string strQuestionThree = "Not Available";



                                //Get the last PersonID using Max to insert as FK to the User table
                                string queryLastID = "SELECT MAX(PersonID) from RandrezaVoharisoaM21Su2332.Person";
                                SqlCommand commandLastID = new SqlCommand(queryLastID, Connection);

                                //gets the results from the sql command
                                SqlDataReader sr = commandLastID.ExecuteReader();
                                sr.Read();
                                int intPersonID = sr.GetInt32(0);
                                sr.Close();
                                //generate Username and Password
                                string strModidfiedLastName = strLastName.Substring(0, strLastName.Length - 2);
                                string strCreateUsername = strModidfiedLastName + intPersonID.ToString()+"Cust";

                                string strCreatePassword = intRoleId.ToString() + intPersonID.ToString()+"@Cust";

                                SqlCommand commandUsers = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Users(PersonID,Username,Password,Answer1,Answer2,RoleID,ThirdQuestion,SecondQuestion,FirstQuestion,Answer3,Status) VALUES(@PersonID,@Username,@Password,@Answer1,@Answer2,@RoleID,@ThirdQuestion,@SecondQuestion,@FirstQuestion,@Answer3,@Status)", Connection);
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
                                commandUsers.Parameters.AddWithValue("@Status", "Active");

                                commandUsers.ExecuteNonQuery();
                                MessageBox.Show("Customer Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvCustomer.Enabled = true;
                                gbxAddNewCustomer.Enabled = false;
                                DisplayCustomers();
                                Reset();
                                Connection.Close();
                            }

                            else
                            {
                                MessageBox.Show("Phone is not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                mskPhoneCustomer.Focus();
                            }


                        }

                        else
                        {
                            MessageBox.Show("Email format is not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxEmailCustomer.Focus();
                        }

                    }

                    else
                    {
                        MessageBox.Show("Address format is not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxAddressCustomer.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Please make sure to fill up the required fields with(*)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Method to reset customer fields
        public void Reset()
        {
            tbxFirstNameCustomer.Text = "";
            tbxLastNameCustomer.Text = "";
            tbxZipCustomer.Text = "";
            tbxEmailCustomer.Text = "";
            tbxAddressCustomer.Text = "";
            mskPhoneCustomer.Text = "";
            cboStatesCustomer.Text = "";
            tbxCustomerCity.Text = "";
        }

        //Method to reset Supplier fields
        public void ResetSupplierEntry()
        {
            tbxSupplierName.Text = "";
            tbxSupplierContactName.Text = "";
            tbxSupplierZip.Text = "";
            tbxEmailSupplier.Text = "";
            tbxSupplierAddress.Text = "";
            mskSupplierPhone.Text = "";
            cboSupplierState.Text = "";
           tbxSupplierCity.Text = "";
        }


        //Activate update customer features
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string strFirstName = dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string strLastName = dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[2].Value.ToString();


                if (dgvCustomer.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Do you want to edit Customer '" + strFirstName + " " + strLastName + "'?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gbxAddNewCustomer.Enabled = true;
                        btnAddCustomer.Enabled = false;
                        btnEditCustomer.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Please select the Customer you want to edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please make a selection", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK);
            }
           
        }

   
        //Save Edited customer fields(text boxes)
        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            string strNameFirst;
            string strNameLast;
            string strAddress;
            string strCity;
            string strEmail;
            string strZip;
            string strStateEdit;
            string strPhoneEdit;
            bool blnUpdateEmail = false;
          
            try
            {
                //Connection.Open();
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                strPersonIdCustomerView = dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[0].Value.ToString();

                if (tbxFirstNameCustomer.Text == "")
                {
                    strNameFirst = dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    strNameFirst = tbxFirstNameCustomer.Text;
                    blnUpdateEmail = true;
                }

                if (tbxLastNameCustomer.Text == "")
                {
                    strNameLast = dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[2].Value.ToString();

                }
                else
                {
                    strNameLast = tbxLastNameCustomer.Text;
                    blnUpdateEmail = true;
                }


                if (tbxAddressCustomer.Text == "")
                {
                    strAddress = dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    strAddress = tbxAddressCustomer.Text;
                    blnUpdateEmail = true;
                }

                if (tbxCustomerCity.Text == "")
                {
                    strCity = dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[4].Value.ToString();
                }
                else
                {
                    strCity = tbxCustomerCity.Text;
                    blnUpdateEmail = true;
                }


                if (cboStatesCustomer.Text == "")
                {
                    strStateEdit = dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[5].Value.ToString();

                }
                else
                {
                    strStateEdit = cboStatesCustomer.SelectedItem.ToString();
                    blnUpdateEmail = true;
                }



                if (tbxZipCustomer.Text == "")
                {
                    strZip = dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[6].Value.ToString();
                }
                else
                {
                    strZip = tbxZipCustomer.Text;
                    blnUpdateEmail = true;
                }


                if (ValidEmail(tbxEmailCustomer.Text) == false)
                {
                    strEmail = dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[8].Value.ToString();


                }
                else
                {

                    strEmail = tbxEmailCustomer.Text;
                    blnUpdateEmail = true;
                }
                


                if (ValidPhone(mskPhoneCustomer.Text)==false)
                {
                    strPhoneEdit = dgvCustomer.Rows[dgvCustomer.CurrentCell.RowIndex].Cells[7].Value.ToString();

                }
                else
                {
                    strPhoneEdit = mskPhoneCustomer.Text;
                    blnUpdateEmail = true;
                }




                
                    Connection.Open();

                    string strQuery = "UPDATE RandrezaVoharisoaM21Su2332.Person SET NameFirst = @NameFirst,NameLast = @NameLast,Address1 = @Address,City = @City,State=@State, Zipcode = @Zip, Email= @Email, PhonePrimary = @Phone" +
                    " where PersonID= '" + strPersonIdCustomerView + "'";
                    SqlCommand editCommande = new SqlCommand(strQuery, Connection);
                    SqlParameter sqlpmNameFirst = editCommande.Parameters.AddWithValue("@NameFirst", strNameFirst);
                    SqlParameter sqlpmNameLast = editCommande.Parameters.AddWithValue("@NameLast", strNameLast);
                    SqlParameter sqlpmAddress = editCommande.Parameters.AddWithValue("@Address", strAddress);
                    SqlParameter sqlpmCity = editCommande.Parameters.AddWithValue("@City", strCity);
                    SqlParameter sqlpmState = editCommande.Parameters.AddWithValue("@State", strStateEdit);
                    SqlParameter sqlpmZip = editCommande.Parameters.AddWithValue("@Zip", strZip);
               
                    SqlParameter sqlpmEmail = editCommande.Parameters.AddWithValue("@Email", strEmail);
                
             
                    
                    SqlParameter sqlpmPhone = editCommande.Parameters.AddWithValue("@Phone", strPhoneEdit);
                    editCommande.ExecuteNonQuery();



                    Connection.Close();
                if(blnUpdateEmail == true)
                {
                    MessageBox.Show("The selected Customer Information has been updated?", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("No fields has been changed?", "Message", MessageBoxButtons.OK);
                }   

                    DisplayCustomers();
                    Reset();
                    btnAddCustomer.Enabled = true;
                    btnEditCustomer.Enabled = false;
                
             
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Message", MessageBoxButtons.OK);
            }

        
    }
        //Removing customer by changing their status to Inactive
        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
           // string strCustomerUserID;
            try
            {
                if (dgvCustomer.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Do you want to remove this Customer?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvCustomer.SelectedRows)
                        {
                            //grab current row index selected
                            int intIndexRowSelected = dgvCustomer.CurrentCell.RowIndex;
                            //grab person ID to use in order to delete in the database
                            strPersonIdCustomerView = dgvCustomer.Rows[intIndexRowSelected].Cells[0].Value.ToString();
                            dgvCustomer.Rows.RemoveAt(row.Index);

                        }
                        try
                        {
                            //connect to database
                            Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                                "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                            Connection.Open();
                            //get userID from personID in USers
                            SqlCommand commandRemove = new SqlCommand("UPDATE RandrezaVoharisoaM21Su2332.Users SET Status ='Inactive' where PersonID = '" + strPersonIdCustomerView + "'", Connection);
                            //SqlParameter sqlpmPhone = commandRemove.Parameters.AddWithValue("@Phone", strPhoneEdit);
                            commandRemove.ExecuteNonQuery();


                            Connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please select the Customer you want to remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :" + ex, "Message", MessageBoxButtons.OK);
            }
          

        }

        //Manager Access to POS
        private void btnAccessPOS_Click(object sender, EventArgs e)
        {
            new frmEmployee().Show();
            this.Hide();
        }

        //Select monthly report
        private void radMonthly_CheckedChanged(object sender, EventArgs e)
        {
            string strChooseDateReportWeekly = dtpReport.Text;
            try
            {

                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                if (radDaily.Checked == true)
                {
                    string strQuery = "SELECT *from RandrezaVoharisoaM21Su2332.SalesReport  where CreationDate between '" + strChooseDateReportWeekly + "' And DATEADD(DAY, 31, '" + strChooseDateReportWeekly + "')";
                    dataAdapter = new SqlDataAdapter(strQuery, Connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvSalesReport.DataSource = dataTable;

                    Connection.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        //Display daily, weekly, monthly report
        private void btnDisplayReport_Click(object sender, EventArgs e)
        {
          if(radDaily.Checked==true)
            {
                DisplayDaily();
            }
         else if(radWeekly.Checked==true)
            {
                DisplayWeekly();
               
            }
           else if (radMonthly.Checked == true)
            {
                DisplayMonthly();
            }

            else if (radAllReport.Checked == true)
            {
                DisplaySalesReport();
            }
        }

        //Method  to Display daily report 
        public void DisplayDaily()
        {
            string strChooseDateReportDaily = dtpReport.Text;
            try
            {

                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
              
                    string strQuery = "SELECT SaleId as [Sale ID], UserID as [User ID], CreationDate as [Date of Sale] from RandrezaVoharisoaM21Su2332.SalesReport  where CreationDate = '" + strChooseDateReportDaily + "'";
                    dataAdapter = new SqlDataAdapter(strQuery, Connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvSalesReport.DataSource = dataTable;

                    Connection.Close();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method  to Display weekly report 
        public void DisplayWeekly()
        {
            string strChooseDateReportWeekly = dtpReport.Text;
            try
            {

                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
               
                    string strQuery = "SELECT SaleId as [Sale ID], UserID as [User ID], CreationDate as [Date of Sale] from RandrezaVoharisoaM21Su2332.SalesReport  where CreationDate between '" + strChooseDateReportWeekly + "' And DATEADD(DAY, 7, '" + strChooseDateReportWeekly + "')";
                    dataAdapter = new SqlDataAdapter(strQuery, Connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvSalesReport.DataSource = dataTable;

                    Connection.Close();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Method  to Display monthly report 
        public void DisplayMonthly()
        {
            string strChooseDateReportMonthly = dtpReport.Text;
            try
            {

                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
              
                    string strQuery = "SELECT SaleId as [Sale ID], UserID as [User ID], CreationDate as [Date of Sale] from RandrezaVoharisoaM21Su2332.SalesReport  where CreationDate between '" + strChooseDateReportMonthly + "' And DATEADD(DAY, 31, '" + strChooseDateReportMonthly + "')";
                    dataAdapter = new SqlDataAdapter(strQuery, Connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvSalesReport.DataSource = dataTable;

                    Connection.Close();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Function for printing an html file
        private void btnPrintSelectedSalesReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalesReport.SelectedRows.Count > 0)
                {

                    try
                    {
                        if (strInvoiceReport == "")
                        {
                            MessageBox.Show("This Sales doesn't have invoice yet",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string strExecutableLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                            string strLocation = Path.Combine(strExecutableLocation, strInvoiceReport + ".html");
                            System.Diagnostics.Process.Start(strLocation);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot find Report associate with this.",
                            "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please select report",
                       "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        //Display supplier from database
        public void DisplaySupplierList()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();

                dataAdapter = new SqlDataAdapter("SELECT RandrezaVoharisoaM21Su2332.Suppliers.SupplierID  as [Supplier ID],RandrezaVoharisoaM21Su2332.Suppliers.Name  as [Company Name], RandrezaVoharisoaM21Su2332.Suppliers.Contact as [Contact Name],RandrezaVoharisoaM21Su2332.Suppliers.Address,RandrezaVoharisoaM21Su2332.Suppliers.City,RandrezaVoharisoaM21Su2332.Suppliers.State, RandrezaVoharisoaM21Su2332.Suppliers.Zip,RandrezaVoharisoaM21Su2332.Suppliers.Phone , RandrezaVoharisoaM21Su2332.Suppliers.Email  FROM RandrezaVoharisoaM21Su2332.Suppliers where Status='Active'; ", Connection);

                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvSupplierView.DataSource = dataTable;


                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            gbxAddEditSupplier.Enabled = true;
            DisplaySupplierList();
            btnSaveEditSupplier.Enabled = false;
            btnSaveAddSupplier.Enabled = true;
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                string strCompanyName = dgvSupplierView.Rows[dgvSupplierView.CurrentCell.RowIndex].Cells[1].Value.ToString();



                if (dgvSupplierView.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Do you want to edit Supplier '" + strCompanyName + "'?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gbxAddEditSupplier.Enabled = true;
                        btnSaveAddSupplier.Enabled = false;
                        btnSaveEditSupplier.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Please select the Supplier you want to edit", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please make a selection", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnSaveEditSupplier_Click(object sender, EventArgs e)
        {
            string strCompanyName;
            string strContactName;
            string strSupplierAddress;
            string strSupplierCity;
            string strSupplierState;
            string strSupplierEmail;
            string strSupplierZip;
            string strSupplierPhone;

            try
            {
                //Connection.Open();
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                strSupplierId= dgvSupplierView.Rows[dgvSupplierView.CurrentCell.RowIndex].Cells[0].Value.ToString();

                if (tbxSupplierName.Text == "")
                {
                    strCompanyName = dgvSupplierView.Rows[dgvSupplierView.CurrentCell.RowIndex].Cells[1].Value.ToString();
                }
                else
                {
                    strCompanyName = tbxSupplierName.Text;
                }

                if (tbxSupplierContactName.Text == "")
                {
                    strContactName = dgvSupplierView.Rows[dgvSupplierView.CurrentCell.RowIndex].Cells[2].Value.ToString();

                }
                else
                {
                    strContactName = tbxSupplierContactName.Text;
                }


                if (tbxSupplierAddress.Text == "")
                {
                    strSupplierAddress = dgvSupplierView.Rows[dgvSupplierView.CurrentCell.RowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    strSupplierAddress = tbxSupplierAddress.Text;
                }

                if (tbxSupplierCity.Text == "")
                {
                    strSupplierCity = dgvSupplierView.Rows[dgvSupplierView.CurrentCell.RowIndex].Cells[4].Value.ToString();
                }
                else
                {
                    strSupplierCity = tbxSupplierCity.Text;
                }


                if (cboSupplierState.Text == "")
                {
                    strSupplierState = dgvSupplierView.Rows[dgvSupplierView.CurrentCell.RowIndex].Cells[5].Value.ToString();

                }
                else
                {
                    strSupplierState = cboSupplierState.SelectedItem.ToString();

                }



                if (tbxSupplierZip.Text == "")
                {
                    strSupplierZip = dgvSupplierView.Rows[dgvSupplierView.CurrentCell.RowIndex].Cells[6].Value.ToString();
                }
                else
                {
                    strSupplierZip = tbxSupplierZip.Text;
                }

                if (ValidEmail(tbxEmailSupplier.Text) == true)
                {

                    strSupplierEmail = tbxEmailSupplier.Text;
                }
                else
                {

                    strSupplierEmail = dgvSupplierView.Rows[dgvSupplierView.CurrentCell.RowIndex].Cells[8].Value.ToString();
                }

                if (ValidPhone(mskSupplierPhone.Text) == false)
                {
                    strSupplierPhone = dgvSupplierView.Rows[dgvSupplierView.CurrentCell.RowIndex].Cells[7].Value.ToString();

                }
                else
                {
                    strSupplierPhone = mskSupplierPhone.Text;
                }

                Connection.Open();

                string strQuery = "UPDATE RandrezaVoharisoaM21Su2332.Suppliers SET Name = @Name,Contact = @Contact,Address = @Address,City = @City,State=@State, Zip = @Zip, Email= @Email, Phone = @Phone" +
                " where SupplierID= '" + strSupplierId+ "'";
                SqlCommand editCommande = new SqlCommand(strQuery, Connection);
                SqlParameter sqlpmNameFirst = editCommande.Parameters.AddWithValue("@Name", strCompanyName);
                SqlParameter sqlpmNameLast = editCommande.Parameters.AddWithValue("@Contact", strContactName);
                SqlParameter sqlpmAddress = editCommande.Parameters.AddWithValue("@Address", strSupplierAddress);
                SqlParameter sqlpmCity = editCommande.Parameters.AddWithValue("@City", strSupplierCity);
                SqlParameter sqlpmState = editCommande.Parameters.AddWithValue("@State", strSupplierState);
                SqlParameter sqlpmZip = editCommande.Parameters.AddWithValue("@Zip", strSupplierZip);
                SqlParameter sqlpmEmail = editCommande.Parameters.AddWithValue("@Email", strSupplierEmail);
                SqlParameter sqlpmPhone = editCommande.Parameters.AddWithValue("@Phone", strSupplierPhone);
                editCommande.ExecuteNonQuery();



                Connection.Close();

                MessageBox.Show("The selected Supplier Information has been updated?", "Message", MessageBoxButtons.OK);

                DisplaySupplierList();
                ResetSupplierEntry();
                btnSaveEditSupplier.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Message", MessageBoxButtons.OK);
            }
        }

        private void btnSaveAddSupplier_Click(object sender, EventArgs e)
        {
            string strCompanyName=tbxSupplierName.Text;
            string strContactName = tbxSupplierContactName.Text;
            string strSupplierAddress = tbxSupplierAddress.Text;
            string strSupplierCity = tbxSupplierCity.Text;
            string strSupplierState = cboSupplierState.Text;
            string strSupplierEmail = tbxEmailSupplier.Text;
            string strSupplierZip = tbxSupplierZip.Text;
            string strSupplierPhone = mskSupplierPhone.Text;
       

            try
            {

                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                if (tbxSupplierName.Text != "" && tbxSupplierContactName.Text != "" && tbxSupplierAddress.Text != "" && tbxSupplierCity.Text != "" && cboSupplierState.Text != "" && tbxEmailSupplier.Text != ""
                    && tbxSupplierZip.Text != "" && mskSupplierPhone.Text != "")
                {


                    if (ValidAddress(strSupplierAddress) == true)
                    {

                        if (ValidEmail(strSupplierEmail) == true)
                        {
                          
                                SqlCommand commandSupplier = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Suppliers(Name,Contact,Address,City,Zip,State,Email,Phone) VALUES (@Name,@Contact,@Address,@City,@Zip,@State,@Email,@Phone)", Connection);

                                commandSupplier.Parameters.AddWithValue("@Name", strCompanyName);
                                commandSupplier.Parameters.AddWithValue("@Contact", strContactName);
                                commandSupplier.Parameters.AddWithValue("@Address", strSupplierAddress);
                                commandSupplier.Parameters.AddWithValue("@City", strSupplierCity);
                                commandSupplier.Parameters.AddWithValue("@Zip", strSupplierZip);
                                commandSupplier.Parameters.AddWithValue("@State", strSupplierState);
                                commandSupplier.Parameters.AddWithValue("@Email", strSupplierEmail);
                                commandSupplier.Parameters.AddWithValue("@Phone", strSupplierPhone);
                                commandSupplier.ExecuteNonQuery();

                                
                              
                                DisplaySupplierList();
                                ResetSupplierEntry();
                            btnSaveAddSupplier.Enabled = false;
                            MessageBox.Show("New Supplier was successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Connection.Close();
                           


                        }

                        else
                        {
                            MessageBox.Show("Email format is not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbxEmailCustomer.Focus();
                        }

                    }

                    else
                    {
                        MessageBox.Show("Address format is not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxAddressCustomer.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Please make sure to fill up the required fields with(*)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSupplierView.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Do you want to remove this Supplier?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvSupplierView.SelectedRows)
                        {

                            int intIndexRowSelected = dgvSupplierView.CurrentCell.RowIndex;

                            strSupplierId = dgvSupplierView.Rows[intIndexRowSelected].Cells[0].Value.ToString();
                            dgvSupplierView.Rows.RemoveAt(row.Index);

                        }
                        try
                        {
                            //connect to database
                            Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                                "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                            Connection.Open();

                            //get userID from personID in USers
                            SqlCommand commandRemove = new SqlCommand("UPDATE RandrezaVoharisoaM21Su2332.Suppliers SET Status ='Inactive' where SupplierID= '" + strSupplierId + "'", Connection);
                          
                            commandRemove.ExecuteNonQuery();



                            MessageBox.Show("Supplier has been removed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DisplaySupplierList();

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
                    MessageBox.Show("Please select the Customer you want to remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        //Method to Display all purchase history
        public void DisplayAllPurchaseHistory()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT PurchaseID as [Purchase ID],SupplierID as [Supplier ID], PurchaseDate as [Date of Purchase], ItemName as [Product Purchased] FROM RandrezaVoharisoaM21Su2332.Purchase;", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvPurchaseRecord.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method to Display weekly purchase history
        public void DisplayPurchaseWeekly()
        {
            string strChooseDateReportWeekly = dtpPurchaseDate.Text;
            try
            {

                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
               
                    string strQuery = "SELECT PurchaseID as [Purchase ID],SupplierID as [Supplier ID], PurchaseDate as [Date of Purchase], ItemName as [Product Purchased] from RandrezaVoharisoaM21Su2332.Purchase  where PurchaseDate between '" + strChooseDateReportWeekly + "' And DATEADD(DAY, 7, '" + strChooseDateReportWeekly + "')";
                    dataAdapter = new SqlDataAdapter(strQuery, Connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvPurchaseRecord.DataSource = dataTable;

                    Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method to Display daily purchase history
        public void DisplayPurchaseDaily()
        {
            string strChooseDateReportDaily = dtpPurchaseDate.Text;
            try
            {

                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                
                    string strQuery = "SELECT PurchaseID as [Purchase ID],SupplierID as [Supplier ID], PurchaseDate as [Date of Purchase], ItemName as [Product Purchased] from RandrezaVoharisoaM21Su2332.Purchase  where PurchaseDate = '" + strChooseDateReportDaily + "'";
                    dataAdapter = new SqlDataAdapter(strQuery, Connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvPurchaseRecord.DataSource = dataTable;

                    Connection.Close();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayPurchaseMonthly()
        {
            string strChooseDateReportMonthly = dtpPurchaseDate.Text;
            try
            {

                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
             
                    string strQuery = "SELECT PurchaseID as [Purchase ID],SupplierID as [Supplier ID], PurchaseDate as [Date of Purchase], ItemName as [Product Purchased] from RandrezaVoharisoaM21Su2332.Purchase  where PurchaseDate between '" + strChooseDateReportMonthly + "' And DATEADD(DAY, 31, '" + strChooseDateReportMonthly + "')";
                    dataAdapter = new SqlDataAdapter(strQuery, Connection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dgvPurchaseRecord.DataSource = dataTable;

                    Connection.Close();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Display daily or weekly or monthly purchase history 
        private void btnDisplayPurchase_Click(object sender, EventArgs e)
        {
            if(radPurchaseAll.Checked==true)
            {
                DisplayAllPurchaseHistory();
            }
            else if (radPurchaseDaily.Checked == true)
            {
                DisplayPurchaseDaily();
            }
            else if (radPurchaseWeekly.Checked == true)
            {
                DisplayPurchaseWeekly();
            }
            else if (radPurchaseMonthly.Checked == true)
            {
                DisplayPurchaseMonthly();
            }
        }
        private void dgvPurchaseRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvPurchaseRecord.Rows[e.RowIndex];
                    strPurchaseNumber = row.Cells["Purchase ID"].Value.ToString();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void btnPrintPurchaseReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPurchaseRecord.SelectedRows.Count > 0)
                {

                    try
                    {

                        string strExecutableLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                        string strLocation = Path.Combine(strExecutableLocation, strPurchaseNumber + ".html");
                        System.Diagnostics.Process.Start(strLocation);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot find Report associate with this.",
                            "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please select report",
                       "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        //Access to help form
        private void btnHelpAdmin_Click(object sender, EventArgs e)
        {
            new frmManagerViewHelp().Show();
            this.Hide();
        }
        //---------------Accept only number with the text boxes events below
        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxRetailPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxZipCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Display Coupon List
        private void btnViewCouponList_Click(object sender, EventArgs e)
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM RandrezaVoharisoaM21Su2332.Coupon", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvCouponList.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Delete coupon
        private void btnRemoveCoupon_Click(object sender, EventArgs e)
        {
            string strCouponID="";
            try
            {
                if (dgvCouponList.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Do you want to remove this coupon?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvCouponList.SelectedRows)
                        {
                            //grab current row index selected
                            int intIndexRowSelected = dgvCouponList.CurrentCell.RowIndex;
                            //grab item name to use in order to delete in the database
                            strCouponID = dgvCouponList.Rows[intIndexRowSelected].Cells[0].Value.ToString();
                            dgvCouponList.Rows.RemoveAt(row.Index);

                        }
                        try
                        {
                            //connect to database
                            Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                                "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                            Connection.Open();

                            string strDeleteQuery = "DELETE FROM RandrezaVoharisoaM21Su2332.Coupon where CouponID= '" + strCouponID + "'";
                            SqlCommand deleteCommande = new SqlCommand(strDeleteQuery, Connection);

                            deleteCommande.ExecuteNonQuery();

                            Connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please select the Coupon you want to remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


        

