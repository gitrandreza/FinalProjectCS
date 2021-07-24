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
    public partial class frmEmployee : Form
    {

        //Establish connection to the database       
        SqlConnection Connection;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        SqlCommand command;
        SqlDataReader reader;

        string strGetDate = DateTime.Now.ToShortDateString();//Get date

        string strItemSelectedName;
        string strQuantityAvailable;
        int intQuantityAvailable;
        int intQuantitySelected;
        string strPrice;
        double dblPrice;
        double dblPriceItemSelected;
       

        string strQuantityNeeded;
        int intQuantityNeeded;

        
       
        double dblDiscountOne = 0.1;
        double dblDiscountTwo = 0.2;
        double dblDiscountThree = 0.3;
        double dblDiscountReturning = 0.1;
        double dblDiscountCouponOne = 0.25;
        double dblDiscountCouponTwo = 100;
        double dblDiscountCouponThree = 500;


        int intSaleId;

        string strCustomerID;
        bool blnReturningCustomer = false;
        bool blnExpirationCoupon = false;
<<<<<<< HEAD

        string strDiscountIndex;

       
=======

        string strDiscountIndex;
>>>>>>> 7f1d16a54332546517698c8f5f06a539561b9f79
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            
            lblDate.Text = strGetDate;

            lblUserEmployee.Text = frmMain.strUserNumberID;
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                Connection.Open();
                //display Last name of user
                SqlCommand command = new SqlCommand("SELECT RandrezaVoharisoaM21Su2332.Person.NameLast FROM RandrezaVoharisoaM21Su2332.Person " +
                    "LEFT JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Person.PersonID = RandrezaVoharisoaM21Su2332.Users.PersonID WHERE UserID = '" + lblUserEmployee.Text + "'", Connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                lblNameEmployee.Text = reader["NameLast"].ToString();
                reader.Close();


                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public frmEmployee()
        {
            InitializeComponent();
            DisplayEmployeeViewItems();
        }

        public void DisplayEmployeeViewItems()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT ItemID, Name, Quantity,CategoryID, RetailPrice ,SupplierID Description FROM RandrezaVoharisoaM21Su2332.Items", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvEmployeeViewItem.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Method to display Item Picture
        void DisplayImage(string selectedItem, PictureBox pictureBox)
        {
            try
            {
                Connection.Open();
                byte[] imgData;
                SqlCommand cmd = new SqlCommand("Select Image From RandrezaVoharisoaM21Su2332.Items where Name = '" + selectedItem + "'", Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                long bufLength = reader.GetBytes(0, 0, null, 0, 0);
                imgData = new byte[bufLength];
                reader.GetBytes(0, 0, imgData, 0, (int)bufLength);
                MemoryStream ms = new MemoryStream(imgData);
                ms.Position = 0;
                pictureBox.Image = Image.FromStream(ms);
                reader.Close();
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvEmployeeViewItem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Connection.Open();

                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvEmployeeViewItem.Rows[e.RowIndex];

                     strItemSelectedName= row.Cells["Name"].Value.ToString();
                    strQuantityAvailable = row.Cells["Quantity"].Value.ToString();

                    bool intResultTryParse = int.TryParse(strQuantityAvailable, out intQuantityAvailable);
                    if (intResultTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    intQuantitySelected = intQuantityAvailable;

                    strPrice = row.Cells["RetailPrice"].Value.ToString();                   
                    bool dblResultTryParse = double.TryParse(strPrice, out dblPrice);
                    if (dblResultTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Display in the label
                    lblQuantityRemain.Text = strQuantityAvailable;
                    dblPriceItemSelected = dblPrice;
                    

                }


                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DisplayImage(strItemSelectedName, pbxItemPicture);
        }

        //Add selected list with features in the list
        private void btnAddSelection_Click(object sender, EventArgs e)
        {
            if (tbxQuantityNeeded.Text != "")
            {

               
                strQuantityNeeded = tbxQuantityNeeded.Text;
                bool intQuantityTryParse = int.TryParse(strQuantityNeeded, out intQuantityNeeded);
                if (intQuantityTryParse == false)
                {
                    MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


                if (intQuantityNeeded <= intQuantityAvailable)
                {
                    if (radEmbroidered.Checked == true || radPrinted.Checked == true || radBlank.Checked == true)
                    {
                        if (radSmall.Checked == true || radMedium.Checked == true || radLarge.Checked == true)
                        {
                            if (cboColor.SelectedItem != null)
                            {
                                //Build datagriedviewList 
                                dgvItemList.ColumnCount = 7;
                                dgvItemList.Columns[0].Name = "Name";
                                dgvItemList.Columns[1].Name = "Type of Decoration";
                                dgvItemList.Columns[2].Name = "Color";
                                dgvItemList.Columns[3].Name = "Size";
                                dgvItemList.Columns[4].Name = "Quantity";
                                dgvItemList.Columns[5].Name = "Unit Price";
                                dgvItemList.Columns[6].Name = "Total Price";



                                //Get selection information from input 


                                string strItemDeco = "N/A";
                                if (radEmbroidered.Checked == true)
                                {
                                    strItemDeco = "Embroidered";
                                }
                                else if (radPrinted.Checked == true)
                                {
                                    strItemDeco = "Printed";
                                }

                                else if (radBlank.Checked == true)
                                {
                                    strItemDeco = "Blank";
                                }

                                string strItemColor;
                                if (cboColor.SelectedItem == null)
                                {
                                    strItemColor = "N/A";

                                }
                                else
                                {
                                    strItemColor = cboColor.SelectedItem.ToString();
                                }


                                string strItemSize = "N/A";
                                if (radSmall.Checked == true)
                                {
                                    strItemSize = "Small";
                                }
                                else if (radMedium.Checked == true)
                                {
                                    strItemSize = "Medium";
                                }

                                else if (radLarge.Checked == true)
                                {
                                    strItemSize = "Large";
                                }

                                double dblTotalPrice =dblPriceItemSelected * intQuantityNeeded;
                                string strTotalPrice = dblTotalPrice.ToString();


                                string[] row = { strItemSelectedName, strItemDeco, strItemColor, strItemSize, strQuantityNeeded,dblPriceItemSelected.ToString(), strTotalPrice };
                                dgvItemList.Rows.Add(row);
                                dgvItemList.CurrentCell.Selected = false;


                                if (intQuantitySelected > 0)
                                {
                                    //Decrease Quantity Item selected
                                    intQuantitySelected = intQuantitySelected - intQuantityNeeded;

                                    lblQuantityRemain.Text = intQuantitySelected.ToString();

                                    //grab current row index selected
                                    int intIndexRowSelected = dgvEmployeeViewItem.CurrentCell.RowIndex;
                                    //Insert quantity updated to current row and Cell "Quantity" index 1
                                    dgvEmployeeViewItem.Rows[intIndexRowSelected].Cells[2].Value = intQuantitySelected.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Sorry, this item is out of stock!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                //Reset Selection
                                tbxQuantityNeeded.Text = "";
                                radEmbroidered.Checked = false;
                                radPrinted.Checked = false;
                                radBlank.Checked = false;
                                radLarge.Checked = false;
                                radMedium.Checked = false;
                                radSmall.Checked = false;
                                cboColor.Text = "";
                                lblQuantityRemain.Text = "";
                                
                            }
                            else
                            {
                                MessageBox.Show("Please choose Color", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Please choose size", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please choose decoration", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Quantity Unavailable", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxQuantityNeeded.Text = "";
                    tbxQuantityNeeded.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please add quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxQuantityNeeded.Focus();
            }
            
       
            if(dgvItemList.Rows.Count > 0)
            {
                btnRemoveCart.Enabled = true;
                btnDisplayPrice.Enabled = true;
            }

            
        }

        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            if (dgvItemList.SelectedRows.Count > 0)
            {
                tbxDiscountCustomer.Text = "";
                tbxSubTotalCustomer.Text = "";
                tbxTotalToPay.Text = "";
                tbxTaxCustomer.Text = "";

                foreach (DataGridViewRow row in dgvItemList.SelectedRows)
                {
                    dgvItemList.Rows.RemoveAt(row.Index);

                    //Increase Quantity Available
                    intQuantitySelected = intQuantitySelected + intQuantityNeeded;

                    lblQuantityRemain.Text = intQuantitySelected.ToString();
                    //grab current row index selected
                    int intIndexRowSelected = dgvItemList.CurrentCell.RowIndex;
                    //Insert quantity updated to current row and Cell "Quantity" index 1
                    dgvItemList.Rows[intIndexRowSelected].Cells[2].Value = intQuantitySelected.ToString();
                }
                DisplayEmployeeViewItems();
            }
            else
            {
                MessageBox.Show("Please select the product you want to remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       

        //Display Amount in the list without discount
        private void btnDisplayPrice_Click(object sender, EventArgs e)
        {
            CalculateAmount(0, 0);

        }

        //Function to calculate amount in the list
        void CalculateAmount(double dblDiscountPercentage, double dblDiscountOff)
        {
            int intQuantityTotal = 0;
            double dblTotalList=0;
            double dblAmountTax;
            double dblDiscount = 0;
            double dblSubTotal=0;
            double dblTotalAmount=0;
            double dblTax = 0.0825;

            string strTotalPriceList;
            double dblTotalPriceList=0;


            string strQuantityTotal;
            int intQuantityTotalList=0;


            btnPlaceOrder.Enabled = true;

            if (dgvItemList.Rows.Count > 0)//make sure data list is not empty
            {

                //cumulate Total Price of order from list cart
                for (int i = 0; i < dgvItemList.Rows.Count; i++)
                {
                    strTotalPriceList = dgvItemList.Rows[i].Cells[6].Value.ToString();

                    bool dblResultTryParse = double.TryParse(strTotalPriceList, out dblTotalPriceList);

                    if (dblResultTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                    dblTotalList = dblTotalList + dblTotalPriceList;
                }
                tbxTotalPrice.Text = dblTotalList.ToString("C2");

                //Cumulate quantity total for discount
                for (int i = 0; i < dgvItemList.Rows.Count; i++)
                {
                    strQuantityTotal = dgvItemList.Rows[i].Cells[4].Value.ToString();
                    bool intResultTryParse = int.TryParse(strQuantityTotal, out intQuantityTotalList);
                    if (intResultTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    intQuantityTotal = intQuantityTotal + intQuantityTotalList;
                }


            }


            dblDiscount = dblTotalList * dblDiscountPercentage;
            dblSubTotal = dblTotalList- dblDiscount-dblDiscountOff;
            dblAmountTax = dblTotalList * dblTax;
            dblTotalAmount = dblSubTotal + dblAmountTax;

            tbxDiscountCustomer.Text = dblDiscount.ToString("C2");
            tbxSubTotalCustomer.Text = dblSubTotal.ToString("C2");
            tbxTaxCustomer.Text = dblAmountTax.ToString("C2");
            tbxTotalToPay.Text = dblTotalAmount.ToString("C2");
            tbxQuantityTotal.Text = intQuantityTotal.ToString();
        }

      
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (tbxTotalToPay.Text != "")
            {
                int intUserID;
                string strUserID = lblUserEmployee.Text;
                bool intResultTryParse = int.TryParse(strUserID, out intUserID);
                if (intResultTryParse == false)
                {
                    MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string strDate = lblDate.Text;

                try
                {

                    Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                        "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {

                    Connection.Open();
                    //Store Sales Report
                    SqlCommand commandSalesReport = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.SalesReport(UserID,CreationDate, TotalSale) " +
                        "VALUES(@UserID,@CreationDate,@TotalSale)", Connection);
                    commandSalesReport.Parameters.AddWithValue("@UserID", intUserID);
                    commandSalesReport.Parameters.AddWithValue("@CreationDate", strDate);
                  

                    commandSalesReport.Parameters.AddWithValue("@TotalSale", tbxTotalToPay.Text);


                    commandSalesReport.ExecuteNonQuery();



                    //Get the last SaleID using Max to insert as FK to the Sales Report table
                    string strQuerySaleID = "SELECT MAX(SaleId) from RandrezaVoharisoaM21Su2332.SalesReport";
                    SqlCommand commandSalesID = new SqlCommand(strQuerySaleID, Connection);

                    //gets Sale Id from insert sale report in the table sales report
                    SqlDataReader srSaleID = commandSalesID.ExecuteReader();
                    srSaleID.Read();
                    intSaleId = srSaleID.GetInt32(0);
                    srSaleID.Close();

                    //Loop through the data grid view List to store sales details in database table
                    foreach (DataGridViewRow row in dgvItemList.Rows)
                    {
                        //Store List in the table Sales Details
                        SqlCommand commandSalesDetails = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.SalesDetails(SaleID,ItemID,QuantitySold,Decoration,Size,Color) " +
                          "VALUES(@SaleID,@ItemID,@QuantitySold,@Decoration,@Size,@Color)", Connection);
                        //Select item ID of each Item Name in the data grid view list
                        string strItemID;
                        string strNameItem = row.Cells["Name"].Value.ToString();
                        SqlCommand commandItemID = new SqlCommand("SELECT RandrezaVoharisoaM21Su2332.Items.ItemID FROM RandrezaVoharisoaM21Su2332.Items " +
                            "FULL JOIN RandrezaVoharisoaM21Su2332.SalesDetails " +
                            "ON RandrezaVoharisoaM21Su2332.SalesDetails.ItemID = RandrezaVoharisoaM21Su2332.Items.ItemID WHERE Name = '" + strNameItem + "'", Connection);
                        SqlDataReader srItemID = commandItemID.ExecuteReader();
                        srItemID.Read();
                        strItemID = srItemID["ItemID"].ToString();
                        srItemID.Close();

                        string strQuantitySold = row.Cells["Quantity"].Value.ToString();
                        string strDecoration = row.Cells["Type of Decoration"].Value.ToString();
                        string strSize = row.Cells["Size"].Value.ToString();
                        string strColor = row.Cells["Color"].Value.ToString();

                        commandSalesDetails.Parameters.AddWithValue("@SaleID", intSaleId);
                        commandSalesDetails.Parameters.AddWithValue("@ItemID", strItemID);
                        commandSalesDetails.Parameters.AddWithValue("@QuantitySold", strQuantitySold);
                        commandSalesDetails.Parameters.AddWithValue("@Decoration", strDecoration);
                        commandSalesDetails.Parameters.AddWithValue("@Size", strSize);
                        commandSalesDetails.Parameters.AddWithValue("@Color", strColor);


                        commandSalesDetails.ExecuteNonQuery();

                    }

                    //Loop through the data grid view All column quantity to UPDATE QUANTITY in database table
                    foreach (DataGridViewRow row in dgvEmployeeViewItem.Rows)
                    {

                        string strQuantityUpdate = row.Cells["Quantity"].Value.ToString();
                        int intQuantityDgv;
                        bool blnConvert = int.TryParse(strQuantityUpdate, out intQuantityDgv);
                        if (blnConvert == false)
                        {
                            MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        string strNameItem = row.Cells["Name"].Value.ToString();
                        //UPDATE quantity in the table Items
                        string strUpdateQuery = "UPDATE RandrezaVoharisoaM21Su2332.Items SET Quantity = @Quantity where Name= '" + strNameItem + "'";
                        SqlCommand commandUpQuantity = new SqlCommand(strUpdateQuery, Connection);

                        SqlParameter sqlParams = commandUpQuantity.Parameters.AddWithValue("@Quantity", intQuantityDgv);
                        commandUpQuantity.ExecuteNonQuery();

                    }

                    Connection.Close();
                    if (MessageBox.Show("Do you want to print your Invoice?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PrintReportEmployeeView(GenerateReportEmployeeView());

                    }
                    Reset();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please  Display Amount before checking out", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //Display receipt in HTML
        private StringBuilder GenerateReportEmployeeView()
        {
            StringBuilder html = new StringBuilder();
            StringBuilder css = new StringBuilder();
            css.AppendLine("<style>");
            css.AppendLine("td {padding: 5px; text-align:center; font-weight: bold; text-align: center;}");
            css.AppendLine("h1 {color: blue;}");
            css.AppendLine("h2 {color: red;}");
            css.AppendLine("</style>");

            html.AppendLine("<html>");
            html.AppendLine($"<head>{css}<title>{"Imprint Store Report"}</title></head>");
            html.AppendLine("<body>");

            html.AppendLine($"<h1>{"Sales Invoice"}</h1>");

            html.Append($"<h5>{"Date: "}{lblDate.Text}</h5>");
            html.Append($"<h5>{"Employee Name: "}{lblNameEmployee.Text}</h5>");
           html.Append($"<h5>{"Sale ID: "}{intSaleId.ToString()}</h5>");

            html.AppendLine("<table>");
            html.AppendLine("<tr><td>Name</td><td>Decoration</td><td>Size</td><td>Color</td><td>Quantity</td><td>Price</td><td>Total Price</td></tr>");
            html.AppendLine("<tr><td colspan=8><hr /></td></tr>");

            //Loop through the data grid view List to display user Order in the receipt
            foreach (DataGridViewRow row in dgvItemList.Rows)
            {
                html.Append("<tr>");
                html.Append($"<td>{row.Cells["Name"].Value}</td>");
                html.Append($"<td>{row.Cells["Type of Decoration"].Value}</td>");
                html.Append($"<td>{row.Cells["Size"].Value}</td>");
                html.Append($"<td>{row.Cells["Color"].Value}</td>");
                html.Append($"<td>{row.Cells["Quantity"].Value}</td>");
                html.Append($"<td>${row.Cells["Unit Price"].Value}</td>");
                html.Append($"<td>${row.Cells["Total Price"].Value}</td>");
                html.Append("</tr>");
                html.AppendLine("<tr><td colspan=8><hr /></td></tr>");
            }

            html.Append("<tr><td colspan=8><hr></hd></td></tr>");
            html.Append("<table>");

            html.AppendLine($"<h5>{"Discount: "}{tbxDiscountCustomer.Text}</h5>");
            html.AppendLine($"<h5>{"Subtotal: "}{tbxSubTotalCustomer.Text}</h5>");
            html.AppendLine($"<h5>{"Tax Sale: "}{tbxTaxCustomer.Text}</h5>");
            html.AppendLine($"<h5>{"Total Amount: "}{tbxTotalToPay.Text}</h5>");

                html.AppendLine($"<h5>{"Estimated Delivery: "}{tbxDelivery.Text}</h5>");

            html.Append($"<h2>{"Company: Imprint Store  "}</h2>");

            html.Append("</body></html>");//close body

            return html;
        }

        // Print the HTML report on the desktop
        private void PrintReportEmployeeView(StringBuilder html)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = path + "\\Invoice.html";

            try
            {
                // A "using" statement will automatically close a file after opening it.               
                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    sw.WriteLine(html);
                }
                System.Diagnostics.Process.Start(filepath);

            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.",
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //unique filename  use for a date and time with part of a name
            DateTime today = DateTime.Now;
            using (StreamWriter sw = new StreamWriter($"{today.ToString("yyyy-MM-dd-HHmmss")} - Invoice.html"))
            {
                sw.WriteLine(html);
            }
        }

        private void tbxQuantityNeeded_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        public void Reset()
        {
            dgvItemList.Rows.Clear();
          
           
            pbxItemPicture.Image = null;
           tbxSubTotalCustomer.Text = "";
            tbxTaxCustomer.Text = "";
            tbxTotalToPay.Text = "";
            btnRemoveCart.Enabled = false;
           btnDisplayPrice.Enabled = false;
           
            radEmbroidered.Checked = false;
            radPrinted.Checked = false;
            radBlank.Checked = false;
            radMedium.Checked = false;
            radLarge.Checked = false;
            radSmall.Checked = false;
            cboColor.Text = "";
            lblQuantityRemain.Text = "";            
            tbxQuantityNeeded.Text = "";

            tbxDiscountCustomer.Text = "";
            
            tbxDelivery.Text = "";

            radNoDiscount.Checked = true;

            DisplayEmployeeViewItems();
           

        }
        //Print Invoice
        private void btnPrint_Click(object sender, EventArgs e)
        {

            PrintReportEmployeeView(GenerateReportEmployeeView());
        }

        //Enable features if checked
        private void radYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radYes.Checked == true)
            {
                tbxIDSearch.Enabled = true;
                lblIDLabel.Enabled = true;
                btnSearchCustomerID.Enabled = true;
                btnAddCustomer.Enabled = false;
               

                tbxFirstNameCustomer.ReadOnly = true;               
                tbxLastNameCustomer.ReadOnly = true;
                tbxEmailCustomer.ReadOnly = true;
                tbxAddressCustomer.ReadOnly = true;
                tbxCustomerCity.ReadOnly = true;
                tbxZipCustomer.ReadOnly = true;              
                mskPhoneCustomer.ReadOnly = true;

                tbxCustomerState.Visible = true;
                cboStatesCustomer.Visible = false;
                tbxCustomerState.ReadOnly = true;
            }
            else
            {
                tbxIDSearch.Enabled = false;
                lblIDLabel.Enabled = false;
                btnSearchCustomerID.Enabled = false;
                tbxCustomerState.Visible = false;
                cboStatesCustomer.Visible = true;

            }
        }

        private void btnSearchCustomerID_Click(object sender, EventArgs e)
        {
            strCustomerID = tbxIDSearch.Text;
            if (tbxIDSearch.Text!="")
            {
                DisplayCustomerInfo(strCustomerID);
            }
            else
            {
                MessageBox.Show("Please enter an ID number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxIDSearch.Focus();
            }
           
        }

        //function to display customer from search ID
        public void DisplayCustomerInfo(string strIdCustomer)
        {
           
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                string strQuery = "SELECT * FROM RandrezaVoharisoaM21Su2332.Person where PersonID='" + strIdCustomer + "' ;";
                SqlCommand command = new SqlCommand(strQuery, Connection);

                //gets the results from the sql command
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();


                tbxFirstNameCustomer.Text = reader["NameFirst"].ToString();
                tbxLastNameCustomer.Text = reader["NameLast"].ToString();
                tbxEmailCustomer.Text = reader["Email"].ToString();
                tbxAddressCustomer.Text = reader["Address1"].ToString();
                tbxCustomerCity.Text = reader["City"].ToString();
                tbxZipCustomer.Text= reader["Zipcode"].ToString();              
                tbxCustomerState.Text = reader["State"].ToString();
                mskPhoneCustomer.Text= reader["PhonePrimary"].ToString();

                


                if (reader != null)
                {
                    reader.Close();
                }



                if (Connection != null)
                {
                    Connection.Close();
                }


            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot find this ID ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxIDSearch.Text = "";
                tbxIDSearch.Focus();
            }
        }

        //Digit only 
        private void tbxIDSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbxZipCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }


        //Enable features to Enter customer information
        private void radNo_CheckedChanged(object sender, EventArgs e)
        {
            if(radNo.Checked==true)
            {
                
                tbxFirstNameCustomer.ReadOnly = false;
                tbxLastNameCustomer.ReadOnly = false;
                tbxEmailCustomer.ReadOnly = false;
                tbxAddressCustomer.ReadOnly = false;
                tbxCustomerCity.ReadOnly = false;
                tbxZipCustomer.ReadOnly = false;
                mskPhoneCustomer.ReadOnly = false;
                btnAddCustomer.Enabled = true;
                tbxCustomerState.Visible = false;
                cboStatesCustomer.Visible = true;
                tbxCustomerState.ReadOnly = false;

                tbxFirstNameCustomer.Text = "";
                tbxLastNameCustomer.Text = "";
                tbxEmailCustomer.Text = "";
                tbxAddressCustomer.Text = "";
                tbxCustomerCity.Text = "";
                tbxZipCustomer.Text = "";
                tbxCustomerState.Text = "";
                mskPhoneCustomer.Text = "";
            }
           

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

        public bool ValidEmail(string strValidEmail)
        {

            try
            {
                Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.
                 [0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                RegexOptions.CultureInvariant | RegexOptions.Singleline);
                bool blnValidEmail = regex.IsMatch(strValidEmail);
                if (!blnValidEmail)
                {
                    return false;
                }
              
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
<<<<<<< HEAD
        public bool ValidPhone()
        {
            if ( mskPhoneCustomer.Text.Length<12 && mskPhoneCustomer.Text.Contains(" "))
            {
                return false;
            }
            return true;
        }

=======
   
>>>>>>> 7f1d16a54332546517698c8f5f06a539561b9f79
        private void btnAddCustomer_Click(object sender, EventArgs e)
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
                            if(ValidPhone()==true)
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
                                string strCreateUsername = strModidfiedLastName + intPersonID.ToString();

                                string strCreatePassword = intRoleId.ToString() + intPersonID.ToString();

                                SqlCommand commandUsers = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Users(PersonID,Username,Password,Answer1,Answer2,RoleID,ThirdQuestion,SecondQuestion,FirstQuestion,Answer3) VALUES(@PersonID,@Username,@Password,@Answer1,@Answer2,@RoleID,@ThirdQuestion,@SecondQuestion,@FirstQuestion,@Answer3)", Connection);
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

                                commandUsers.ExecuteNonQuery();
                                MessageBox.Show("Client Successfully added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public void SearchValidCoupon()
        {
            string strSearchCoupon = tbxCoupon.Text;
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                string strQuery = "SELECT CouponID, Description, Expiration,DiscountIndex FROM RandrezaVoharisoaM21Su2332.Coupon where CouponID='" + strSearchCoupon + "' and Expiration > '" + strGetDate + "' ;";
                SqlCommand command = new SqlCommand(strQuery, Connection);

                //gets the results from the sql command
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                
                var Expiration = reader.GetDateTime(2);              
                lblCouponDescription.Text = reader["Description"].ToString();
                lblExpiration.Text =Expiration.ToString("d");

                int intCouponId = reader.GetInt32(0);
                strDiscountIndex= reader["DiscountIndex"].ToString();

               

                if (reader != null)
                {
                    reader.Close();
                }
               
                

                if (Connection != null)
            {
                Connection.Close();
            }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot find coupon ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCoupon.Text = "";
                tbxCoupon.Focus();
            }
        }

        //Check and apply coupon if existed
        private void btnCheckCoupon_Click(object sender, EventArgs e)
        {
            if(tbxCoupon.Text!="")
            {
                SearchValidCoupon();
            }
            else
            {
                MessageBox.Show("Enter Coupon Number please", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            string strTotalListForCoupon = tbxTotalPrice.Text.Substring(1);

            double dblTotalListForCoupon;
            
            if (!double.TryParse(strTotalListForCoupon, out dblTotalListForCoupon))
            {
                MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
            if(radCoupon.Checked==true )
            {
                
                if(strDiscountIndex == "1")
                {
                    CalculateAmount(dblDiscountCouponOne,0);
                }
                if (strDiscountIndex == "2" )
                {
                    if(dblTotalListForCoupon > 500 && dblTotalListForCoupon < 2000)
                    {
                        CalculateAmount(0, dblDiscountCouponTwo);
                        tbxDiscountCustomer.Text = "$100";
                    }
                    else
                    {
                        MessageBox.Show("Available only for a total purchase $500 and plus", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (strDiscountIndex == "3" )
                {
                    if(dblTotalListForCoupon > 2000)
                    {
                        CalculateAmount(0, dblDiscountCouponThree);
                        tbxDiscountCustomer.Text = "$500";
                    }
                    else
                    {
                        MessageBox.Show("Available only for a total purchase $2000 and plus", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }

            if(radReturningDiscount.Checked==true)
            {
                CalculateAmount(dblDiscountReturning,0);
            }

            if(radQuantityDiscount.Checked == true)
            {
                //Discount and delivery condition based on quantities
                string strQuantityTotal = tbxQuantityTotal.Text;

               int intQuantityTotalDelivery;

                if (!int.TryParse(strQuantityTotal, out intQuantityTotalDelivery))
                {
                    MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                if (intQuantityTotalDelivery > 10 && intQuantityTotalDelivery <= 50)
                {

                    CalculateAmount(dblDiscountOne,0);
                    lblDisplayDiscountQuantity.Text = "10% Discount";
                }
                else if (intQuantityTotalDelivery > 50 && intQuantityTotalDelivery < 100)
                {

                    CalculateAmount(dblDiscountTwo,0);
                    lblDisplayDiscountQuantity.Text = "20% Discount";
                }
                else if (intQuantityTotalDelivery >= 100)
                {
                    CalculateAmount(dblDiscountThree,0);
                    lblDisplayDiscountQuantity.Text = "30% Discount";
                }
            }
            if(radNoDiscount.Checked==true)
            {
                CalculateAmount(0,0);
            }

        }

        //Handling form closing
        private void frmEmployee_FormClosing(object sender, FormClosingEventArgs e)
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

        private void radCoupon_CheckedChanged(object sender, EventArgs e)
        {
            if(radCoupon.Checked==true)
            {
                tbxCoupon.Enabled = true;
                lblExpiration.Enabled = true;
                lblExpirationLabel.Enabled = true;
                lblCouponDescription.Enabled = true;
                lblCouponDescription.Enabled = true;
                btnCheckCoupon.Enabled = true;
            }
            else
            {
                tbxCoupon.Text = "";
                lblCouponDescription.Text = "";
                lblExpiration.Text = "";

                tbxCoupon.Enabled =false;
                lblExpiration.Enabled = false;
                lblExpirationLabel.Enabled = false;
                lblCouponDescription.Enabled = false;
                lblCouponDescription.Enabled = false;
                btnCheckCoupon.Enabled = false;
            }
        }
<<<<<<< HEAD

        //function to display customer from search ID
        public void DisplayEmployeeInfo(string strIdEmployee)
        {

            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                string strQueryPerson = "SELECT RandrezaVoharisoaM21Su2332.Person.PersonID, RandrezaVoharisoaM21Su2332.Person.NameFirst,RandrezaVoharisoaM21Su2332.Person.NameLast,RandrezaVoharisoaM21Su2332.Person.Email," +
                    "RandrezaVoharisoaM21Su2332.Person.Address1,RandrezaVoharisoaM21Su2332.Person.City,RandrezaVoharisoaM21Su2332.Person.State,RandrezaVoharisoaM21Su2332.Person.Zipcode,RandrezaVoharisoaM21Su2332.Person.PhonePrimary FROM RandrezaVoharisoaM21Su2332.Person FULL JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Users.PersonID = RandrezaVoharisoaM21Su2332.Person.PersonID WHERE UserID = '" + strIdEmployee + "' ; ";
                SqlCommand commandPerson = new SqlCommand(strQueryPerson, Connection);

                //gets the results from the sql command
                SqlDataReader reader = commandPerson.ExecuteReader();


                reader.Read();

                lblEmployeeID.Text = reader["PersonID"].ToString();
                lblEmployeeFirstName.Text = reader["NameFirst"].ToString();
                lblEmployeeFirstName.Text = reader["NameFirst"].ToString();
                lblEmployeeLastName.Text = reader["NameLast"].ToString();
                tbxEmployeeEmail.Text = reader["Email"].ToString();
                lblEmployeeAddress.Text = reader["Address1"].ToString();
                lblEmployeeCity.Text = reader["City"].ToString();
                lblEmployeeZip.Text = reader["Zipcode"].ToString();
                lblEmployeeState.Text = reader["State"].ToString();
                mskEmployeePhone.Text = reader["PhonePrimary"].ToString();

                if (reader != null)
                {
                    reader.Close();
                }

                string strQueryEmployee = "SELECT RandrezaVoharisoaM21Su2332.Employees.Salary,RandrezaVoharisoaM21Su2332.Employees.HiredDate,RandrezaVoharisoaM21Su2332.Employees.Position FROM RandrezaVoharisoaM21Su2332.Employees FULL JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Users.UserID = RandrezaVoharisoaM21Su2332.Employees.UserID WHERE RandrezaVoharisoaM21Su2332.Users.UserID = '" + strIdEmployee + "' ; ";
                SqlCommand commandEmployee = new SqlCommand(strQueryEmployee, Connection);

                //gets the results from the sql command
                SqlDataReader readerEmployee = commandEmployee.ExecuteReader();

                readerEmployee.Read();

                decimal decSalary = readerEmployee.GetDecimal(0);
                var HiredDate = readerEmployee.GetDateTime(1);
                lblEmployeePosition.Text = readerEmployee["Position"].ToString();
                lblHiredDate.Text = HiredDate.ToString("d");
                lblEmployeeSalary.Text = decSalary.ToString("C2");




                if (readerEmployee != null)
                {
                    readerEmployee.Close();
                }

                if (Connection != null)
                {
                    Connection.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Message: "+ ex , "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxIDSearch.Text = "";
                tbxIDSearch.Focus();
            }
        }

        private void tabEmployeeView_Selected(object sender, TabControlEventArgs e)
        {

            string strEmployeeUserID = lblUserEmployee.Text;
            if (tabEmployeeView.SelectedTab.Name == "tabInformation")
            {
                DisplayEmployeeInfo(strEmployeeUserID);
            }
        }

        private void cbxEmployeePhone_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxEmployeePhone.Checked==true)
            {
               
                mskEmployeePhone.ReadOnly = false;
                btnSaveEmployeeEdit.Enabled = true;

            }
            else
            {
               
                mskEmployeePhone.ReadOnly = true;
                btnSaveEmployeeEdit.Enabled = false;
            }
        }

        private void cbxEmployeeEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEmployeeEmail.Checked == true)
            {
                
                tbxEmployeeEmail.ReadOnly = false;
                btnSaveEmployeeEdit.Enabled = true;

            }
            else
            {
               
                tbxEmployeeEmail.ReadOnly = true;
                btnSaveEmployeeEdit.Enabled = false;
            }
        }

        private void btnSaveEmployeeEdit_Click(object sender, EventArgs e)
        {

            try
            {
                if(mskEmployeePhone.Text!="")
                {
                    if (tbxEmployeeEmail.Text != ""&& ValidEmail(tbxEmployeeEmail.Text) )
                    {

                        //Connection.Open();
                        Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                            "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                        string strPersonID = lblEmployeeID.Text;

                        Connection.Open();

                        string strQuery = "UPDATE RandrezaVoharisoaM21Su2332.Person SET PhonePrimary = @Phone, Email = @Email where PersonID= '" + strPersonID + "'";
                        SqlCommand editCommande = new SqlCommand(strQuery, Connection);
                        SqlParameter sqlpmPhone = editCommande.Parameters.AddWithValue("@Phone", mskEmployeePhone.Text);
                        SqlParameter sqlpmEmail = editCommande.Parameters.AddWithValue("@Email", tbxEmployeeEmail.Text);
                        editCommande.ExecuteNonQuery();



                        Connection.Close();

                        MessageBox.Show("The selected employee has been updated successfully?", "Message", MessageBoxButtons.OK);
                       
                        cbxEmployeePhone.Checked = false;
                        cbxEmployeeEmail.Checked = false;
                        btnSaveEmployeeEdit.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Please check Email", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       tbxEmployeeEmail.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a phone number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mskEmployeePhone.Focus();
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Message", MessageBoxButtons.OK);
            }
           
            
        }

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

        private void btnDisplayCustomerList_Click(object sender, EventArgs e)
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT RandrezaVoharisoaM21Su2332.Person.PersonID  as [Person ID], RandrezaVoharisoaM21Su2332.Person.NameFirst  as [First Name], RandrezaVoharisoaM21Su2332.Person.NameLast as [Last Name],RandrezaVoharisoaM21Su2332.Person.Address1  as [Address],RandrezaVoharisoaM21Su2332.Person.City,RandrezaVoharisoaM21Su2332.Person.State, RandrezaVoharisoaM21Su2332.Person.Zipcode,RandrezaVoharisoaM21Su2332.Person.PhonePrimary as [Phone] , RandrezaVoharisoaM21Su2332.Person.Email  FROM RandrezaVoharisoaM21Su2332.Person FULL JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Users.PersonID = RandrezaVoharisoaM21Su2332.Person.PersonID WHERE RoleID = 3; ", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvCustomerList.DataSource = dataTable;


                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strUserIDSelectedCustomer="";
            string strPersonIDSelectedCustomer = "";

            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();

                if (e.RowIndex >= 0)
            {
                //Get PersonID
                DataGridViewRow row = this.dgvCustomerList.Rows[e.RowIndex];
                strPersonIDSelectedCustomer = row.Cells["Person ID"].Value.ToString();


                //get UserID from UserTable based on PersonID
                string strQuery = "SELECT RandrezaVoharisoaM21Su2332.Users.UserID FROM RandrezaVoharisoaM21Su2332.Users  WHERE RandrezaVoharisoaM21Su2332.Users.PersonID='" + strPersonIDSelectedCustomer + "'";
                SqlCommand command = new SqlCommand(strQuery, Connection);

                //gets the results from the sql command
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                int intUserId = reader.GetInt32(0);//use to acces User table
                strUserIDSelectedCustomer = intUserId.ToString();

                if (reader != null)
                {
                    reader.Close();
                }

            }



                dataAdapter = new SqlDataAdapter("SELECT * FROM RandrezaVoharisoaM21Su2332.SalesReport where UserID = '" + strUserIDSelectedCustomer + "'", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvCustomerPurchase.DataSource = dataTable;

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

        private void dgvCustomerPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strSaleId;
            if (e.RowIndex >= 0)
            {
                //instantiate object from Items class and assign value from cell
                DataGridViewRow row = this.dgvCustomerPurchase.Rows[e.RowIndex];
                strSaleId = row.Cells["SaleId"].Value.ToString();

                DisplaySalesDetail(strSaleId);

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
                dgvPurchaseDetails.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCustomerList_SelectionChanged(object sender, EventArgs e)
        {
            while (dgvCustomerPurchase.Rows.Count > 0)
            {
                dgvCustomerPurchase.Rows.RemoveAt(0);
            }
            while (dgvPurchaseDetails.Rows.Count > 0)
            {
                dgvPurchaseDetails.Rows.RemoveAt(0);
            }
        }

        private void btnClearCoupon_Click(object sender, EventArgs e)
        {
            while (dgvCouponList.Rows.Count > 0)
            {
                dgvCouponList.Rows.RemoveAt(0);
            }
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
           
            while (dgvCustomerList.Rows.Count > 0)
            {
                dgvCustomerList.Rows.RemoveAt(0);
            }

            while (dgvCustomerPurchase.Rows.Count > 0)
            {
                dgvCustomerPurchase.Rows.RemoveAt(0);
            }
            while (dgvPurchaseDetails.Rows.Count > 0)
            {
                dgvPurchaseDetails.Rows.RemoveAt(0);
            }
        }
=======
>>>>>>> 7f1d16a54332546517698c8f5f06a539561b9f79
    }
}



