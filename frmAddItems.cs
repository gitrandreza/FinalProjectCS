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
    public partial class frmAddItems : Form
    {
       
        //Establish connection to the database       
        SqlConnection Connection;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        SqlCommand command;
        SqlDataReader reader;
        DataTable dt;


        string strItemName;
        string strSupplierName;
        string strSupplierID;

        string strDate= DateTime.Now.ToShortDateString();//Get date

        int intQuantityPurchased;
        double dblItemCost;
        int intCategory;
        double dblRetailPrice;
        string strDescription;
        string strfileName;

        int intSupplierID;
        int intPurchaseID;
        string strPurchaseInvoice;
        string strPurchaseInvoiceFile;

      
        bool blnDuplicateItemName;
        public frmAddItems()
        {
            InitializeComponent();
        }

        //Add New Item
        private void btnSaveItems_Click(object sender, EventArgs e)
        {
            strItemName = tbxItemName.Text;
            try
            {

                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                if (tbxItemName.Text != "" && tbxQuantity.Text != "" && tbxItemCost.Text != "" && tbxRetailPrice.Text != "" 
                    && cboCategory.Text != "" && tbxDescription.Text != "" && tbxSupplier.Text != "")
                {
                    SqlCommand commandCheckItemName = new SqlCommand("SELECT Name FROM RandrezaVoharisoaM21Su2332.Items;", Connection);

                    //gets the results from the sql command
                    SqlDataReader reader = commandCheckItemName.ExecuteReader();

                    while (reader.Read())
                    {
                        //check through the user table column to find a matching value
                        if (reader["Name"].ToString() == strItemName)
                        {
                            MessageBox.Show("Duplicate Item, please use 'Add quantity' using  'Update Item function'", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            blnDuplicateItemName = true;
                            tbxItemName.Text = "";
                            tbxItemName.Focus();
                            break;
                        }
                        else
                        {
                            blnDuplicateItemName = false;

                        }

                    }

                    if (!tbxQuantity.Text.Contains("."))
                    {
                        if (blnDuplicateItemName == false)
                        {
                            reader.Close();

                            //INSERT RECORD FOR NEW INPUT

                            string strQuantityPurchased = tbxQuantity.Text;

                            if (!int.TryParse(strQuantityPurchased, out intQuantityPurchased))
                            {
                                MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }



                            string strItemCost = tbxItemCost.Text;

                            if (!double.TryParse(strItemCost, out dblItemCost))
                            {
                                MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            string strCategory = cboCategory.SelectedItem.ToString();

                            if (!int.TryParse(strCategory, out intCategory))
                            {
                                MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            string strRetailPrice = tbxRetailPrice.Text;

                            if (!double.TryParse(strRetailPrice, out dblRetailPrice))
                            {
                                MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            strDescription = tbxDescription.Text;





                            if (intQuantityPurchased > 0 && intQuantityPurchased < int.MaxValue)
                            {
                                if (dblItemCost > 0 && dblItemCost < double.MaxValue)
                                {
                                    if (dblRetailPrice > 0 && dblRetailPrice < double.MaxValue)
                                    {

                                        SqlCommand commandItem = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Items(Name,Quantity,Cost,Image,CategoryID,RetailPrice,Description,SupplierID)" +
                                    "VALUES(@Name,@Quantity,@Cost,@Image,@CategoryID,@RetailPrice,@Description,@SupplierID)", Connection);
                                        commandItem.Parameters.AddWithValue("@Name", strItemName);
                                        commandItem.Parameters.AddWithValue("@Quantity", intQuantityPurchased);
                                        commandItem.Parameters.AddWithValue("@Cost", dblItemCost);

                                        string strPath = strfileName;
                                        byte[] image = File.ReadAllBytes(@strPath);


                                        SqlParameter sqlParams = commandItem.Parameters.AddWithValue("@Image", image); // The parameter will be the image as a byte array
                                        sqlParams.DbType = System.Data.DbType.Binary; // The type of data we are sending to the server will be a binary file

                                        commandItem.Parameters.AddWithValue("@CategoryID", intCategory);
                                        commandItem.Parameters.AddWithValue("@RetailPrice", dblRetailPrice);
                                        commandItem.Parameters.AddWithValue("@Description", strDescription);
                                        commandItem.Parameters.AddWithValue("@SupplierID", intSupplierID);


                                        commandItem.ExecuteNonQuery();
                                        MessageBox.Show("New Item added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                        SqlCommand commandPurchaseReport = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Purchase(SupplierID,PurchaseDate, ItemName) VALUES (@SupplierID,@PurchaseDate,@ItemName)", Connection);
                                        commandPurchaseReport.Parameters.AddWithValue("@SupplierID", intSupplierID.ToString());
                                        commandPurchaseReport.Parameters.AddWithValue("@PurchaseDate", strDate);
                                        commandPurchaseReport.Parameters.AddWithValue("@ItemName", strItemName);

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



                                        PrintInvoice(GenerateInvoice(strItemName, intQuantityPurchased, dblItemCost));
                                        MessageBox.Show("Your purchase has been saved, Invoice ID is " + strPurchaseInvoiceFile + " ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                        Connection.Close();

                                        new frmAdmin().Show();
                                        this.Hide();

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
                                    tbxItemCost.Text = "";
                                    tbxItemCost.Focus();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Please enter positive number only for Quantity", "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                tbxQuantity.Text = "";
                                tbxQuantity.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid quantity number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxQuantity.Text = "";
                        tbxQuantity.Focus();
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

            html.Append($"<h5>{"Date: "}{strDate}</h5>");
            html.Append($"<h5>{"Invoice Number: "}{strPurchaseInvoiceFile}</h5>");

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
            html.AppendLine($"<h5>{"Purchase Tax(8.25%): "}{dblTaxValue.ToString("C2")}</h5>");
            html.AppendLine($"<h5>{"Total Amount: "}{dblTotalPay.ToString("C2")}</h5>");




            html.Append($"<h2>{"Supplier: "}{tbxSupplier.Text}</h2>");

            html.Append("</body></html>");//close body

            return html;
        }

        // Write (and overwrite) to the hard drive using the same filename of "Report.html"
        private void PrintInvoice(StringBuilder html)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filepath = path + "\\" + strPurchaseInvoice + " ";

            try
            {
                // A "using" statement will automatically close a file after opening it.               
                using (StreamWriter swNewItem = new StreamWriter(filepath))
                {
                    swNewItem.WriteLine(html);
                }
                System.Diagnostics.Process.Start(filepath); //Open the report in the default web browser
            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.",
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
            using (StreamWriter swNewItem = new StreamWriter($"{strPurchaseInvoice}"))
            {
                swNewItem.WriteLine(html);
            }
        }

        private void btnSaveItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSaveItems.PerformClick();
            }
        }

        private void frmAddItems_FormClosing(object sender, FormClosingEventArgs e)
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
        //Import Image
        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG| * .jpg; *.png", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        strfileName = ofd.FileName;
                        pbxDisplayItemImage.Image = Image.FromFile(strfileName);
                        btnSaveItems.Enabled = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmAdmin().Show();
            this.Hide();
        }

        //Make sure to enter digit only
        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnHelpAddItem_Click(object sender, EventArgs e)
        {
            new frmHelpAddItem().Show();
            this.Visible = false;
            
        }

        //Display Supplier list
        void DisplaySupplier()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT SupplierID as [Supplier ID], Name FROM RandrezaVoharisoaM21Su2332.Suppliers", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvSupplierList.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmAddItems_Load(object sender, EventArgs e)
        {
            DisplaySupplier();
        }

        //Get supplier ID and supplier name from List
        private void dgvSupplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Connection.Open();

                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvSupplierList.Rows[e.RowIndex];

                   strSupplierName = row.Cells["Name"].Value.ToString();
                    strSupplierID = row.Cells["Supplier ID"].Value.ToString();

                    bool intResultTryParse = int.TryParse(strSupplierID, out intSupplierID);
                    if (intResultTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    tbxSupplier.Text = strSupplierName;

                }


                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----------------Make to enter number only---------------
        private void tbxItemCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxRetailPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    
}
