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
namespace SU21_Final_Project
{
    public partial class frmAdmin : Form
    {
        //Establish connection to the database       
        SqlConnection Connection;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        SqlDataReader reader;
        SqlCommand command;


        string strItemID;
        string strPersonID;
        string strUserID;



        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();//Get date
        }
        public frmAdmin()
        {
            InitializeComponent();

            if (tabManagerFeatures.SelectedTab.Name == "tabInventory")
            {
                DisplayAllItems();
                DisplayLowQuantityItems();
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

        public void DisplayEmployees()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT RandrezaVoharisoaM21Su2332.Person.PersonID, RandrezaVoharisoaM21Su2332.Person.NameFirst, RandrezaVoharisoaM21Su2332.Person.NameLast,RandrezaVoharisoaM21Su2332.Person.Address1,RandrezaVoharisoaM21Su2332.Person.City,RandrezaVoharisoaM21Su2332.Person.State, RandrezaVoharisoaM21Su2332.Person.Zipcode,RandrezaVoharisoaM21Su2332.Person.Email, RandrezaVoharisoaM21Su2332.Person.PhonePrimary  FROM RandrezaVoharisoaM21Su2332.Person FULL JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Users.PersonID = RandrezaVoharisoaM21Su2332.Person.PersonID WHERE RoleID = 1 OR RoleID = 2; ", Connection);
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
                dataAdapter = new SqlDataAdapter("SELECT RandrezaVoharisoaM21Su2332.Person.NameFirst, RandrezaVoharisoaM21Su2332.Person.NameLast,RandrezaVoharisoaM21Su2332.Person.Address1,RandrezaVoharisoaM21Su2332.Person.City,RandrezaVoharisoaM21Su2332.Person.State, RandrezaVoharisoaM21Su2332.Person.Zipcode,RandrezaVoharisoaM21Su2332.Person.PhonePrimary, RandrezaVoharisoaM21Su2332.Person.Email  FROM RandrezaVoharisoaM21Su2332.Person FULL JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Users.PersonID = RandrezaVoharisoaM21Su2332.Person.PersonID WHERE RoleID = 3; ", Connection);
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
                        strItemID = dgvAllProducts.Rows[intIndexRowSelected].Cells[0].Value.ToString();
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


        //Update Selected Item
        private void btnUpdateItem_Click_1(object sender, EventArgs e)
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

                    strAddQuantity = tbxQuantity.Text;
                    blnQuantityConvert = int.TryParse(strAddQuantity, out intAddQuantity);
                    if (blnQuantityConvert == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    intUpdateQuantity = intSelectedQuantity + intAddQuantity;
                    blnInvoice = true;
                }

                if (tbxCost.Text == "")
                {
                    strCost = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[3].Value.ToString();
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
                    strRetailPrice = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[4].Value.ToString();
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

                if (cboSupplierID.Text == "")
                {

                    strSupplierID = dgvAllProducts.Rows[dgvAllProducts.CurrentCell.RowIndex].Cells[7].Value.ToString();
                    intSupplierTryParse = int.TryParse(strSupplierID, out intSupplierID);
                    if (intSupplierTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    strSupplierID = cboSupplierID.SelectedItem.ToString();
                    intSupplierTryParse = int.TryParse(strSupplierID, out intSupplierID);
                    if (intSupplierTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
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
                            Connection.Close();

                            MessageBox.Show("The selected item has been updated successfully?", "Message", MessageBoxButtons.OK);

                            DisplayAllItems();
                            ResetUpdateFields();

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
                    if (MessageBox.Show("Do you want Invoice?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PrintInvoice(GenerateInvoice(strName, intAddQuantity, dblCost));

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
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

            html.AppendLine($"<h1>{" Purchase Detail"}</h1>");

            html.Append($"<h5>{"Date: "}{lblDate.Text}</h5>");
            //html.Append($"<h5>{"Customer Name: "}{lblNameOfUser.Text}</h5>");
            //html.Append($"<h5>{"Sale ID: "}{intSaleId.ToString()}</h5>");

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
            html.AppendLine($"<h5>{"Tax Sale(8.25%): "}{dblTaxValue.ToString("C2")}</h5>");
            html.AppendLine($"<h5>{"Total Amount: "}{dblTotalPay.ToString("C2")}</h5>");


            html.Append($"<h2>{"Company: Supplier  "}</h2>");

            html.Append("</body></html>");//close body

            return html;
        }

       
        private void PrintInvoice(StringBuilder html)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = path + "\\Report.html";
            try
            {
                // A "using" statement will automatically close a file after opening it.               
                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    sw.WriteLine(html);
                }
                System.Diagnostics.Process.Start(@"Report.html"); //Open the report in the default web browser
            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.",
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //unique filename  use for a date and time with part of a name
            DateTime today = DateTime.Now;
            using (StreamWriter sw = new StreamWriter($"{today.ToString("yyyy-MM-dd-HHmmss")} - Report.html"))
            {
                sw.WriteLine(html);
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
                    strPersonId = row.Cells["PersonId"].Value.ToString();


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
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Remove Employee from database tables( Employees, Users, Person)
        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {


            if (dgvEmployee.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you want to remove this Employee?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvEmployee.SelectedRows)
                    {
                        //grab current row index selected
                        int intIndexRowSelected = dgvEmployee.CurrentCell.RowIndex;
                        //grab item name to use in order to delete in the database
                        strItemID = dgvEmployee.Rows[intIndexRowSelected].Cells[0].Value.ToString();
                        dgvEmployee.Rows.RemoveAt(row.Index);

                    }
                    try
                    {
                        //connect to database
                        Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                            "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                        Connection.Open();


                        string strDeleteQueryEmployee = "DELETE FROM RandrezaVoharisoaM21Su2332.Employees where UserID= '" + strUserID + "'";
                        SqlCommand deleteCommandeEmployee = new SqlCommand(strDeleteQueryEmployee, Connection);

                        deleteCommandeEmployee.ExecuteNonQuery();

                        string strDeleteQueryUser = "DELETE FROM RandrezaVoharisoaM21Su2332.Users where PersonID= '" + strPersonID + "'";
                        SqlCommand deleteCommandeUser = new SqlCommand(strDeleteQueryUser, Connection);

                        deleteCommandeUser.ExecuteNonQuery();

                        string strDeleteQueryPerson = "DELETE FROM RandrezaVoharisoaM21Su2332.Person where PersonID= '" + strPersonID + "'";
                        SqlCommand deleteCommandePerson = new SqlCommand(strDeleteQueryPerson, Connection);

                        deleteCommandePerson.ExecuteNonQuery();


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

        //Edit Employee Informatiom
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            string strFirstName= dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string strLastName = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[2].Value.ToString();


            if (dgvEmployee.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you want to edit Employee '"+strFirstName+" " + strLastName + "'?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gbxEdit.Enabled = true;

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
                }

                if (tbxLastName.Text == "")
                {
                    strNameLast = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[2].Value.ToString();

                }
                else
                {
                    strNameLast = tbxLastName.Text;
                }


                if (tbxAddress.Text == "")
                {
                    strAddress = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[3].Value.ToString();
                }
                else
                {
                    strAddress = tbxAddress.Text;
                }

                if (tbxCity.Text == "")
                {
                    strCity = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[4].Value.ToString();
                }
                else
                {
                    strCity = tbxCity.Text;
                }


                if (cboStates.Text == "")
                {
                    strStateEdit = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[5].Value.ToString();

                }
                else
                {
                    strStateEdit = cboStates.SelectedItem.ToString();

                }

        

                if (tbxZip.Text == "")
                {
                    strZip = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[6].Value.ToString();
                }
                else
                {
                    strZip = tbxZip.Text;
                }

                if (tbxEmail.Text == "")
                {
                    strEmail = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[7].Value.ToString();
                }
                else
                {
                    
                    strEmail = tbxEmail.Text;
                    //if (ValidEmail(strEmail)==false)
                    //{
                    //    strEmail = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[7].Value.ToString();
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Sorry, Email format is not valid", "Invalid Email", MessageBoxButtons.OK);
                    //    tbxEmail.Text = "";
                    //    tbxEmail.Focus();
                    //}
                }

                if (mskPhones.Text == "")
                {
                    strPhoneEdit = dgvEmployee.Rows[dgvEmployee.CurrentCell.RowIndex].Cells[8].Value.ToString();
                    
                }
                else
                {
                    strPhoneEdit = mskPhones.Text;
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

                    MessageBox.Show("The selected employee has been updated successfully?", "Message", MessageBoxButtons.OK);

                    DisplayEmployees();
                    ResetEditFields();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }

        }


    //Enable textbox for updating when checkbox checked
   

 
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

        }

        private void dgvEmployee_SelectionChanged_1(object sender, EventArgs e)
        {
            gbxEdit.Enabled = false;
            ResetEditFields();
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

        private void tbxZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public bool ValidEmail(string strValidEmail)
        {

            try
            {
                Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.
                 [0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                RegexOptions.CultureInvariant | RegexOptions.Singleline);
                bool isValidEmail = regex.IsMatch(strValidEmail);
                if (!isValidEmail)
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

        public void DisplayLowQuantityItems()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Name, Quantity FROM RandrezaVoharisoaM21Su2332.Items where Quantity <50;", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvLowItem.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplaySalesReport()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM RandrezaVoharisoaM21Su2332.SalesReport;", Connection);
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
                string strQuery = "SELECT * FROM RandrezaVoharisoaM21Su2332.SalesDetails where SaleID='" + strSaleID + "' ;";
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
            if (e.RowIndex >= 0)
            {
                //instantiate object from Items class and assign value from cell
                DataGridViewRow row = this.dgvSalesReport.Rows[e.RowIndex];
                strSaleId = row.Cells["SaleId"].Value.ToString();

                DisplaySalesDetail(strSaleId);

            }
        }
    }

}
        

