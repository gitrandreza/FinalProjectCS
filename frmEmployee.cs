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
using System.Reflection;
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
        string strDescription;
        string strCategory;
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
        double dblDiscountReturning = 0.05;
        double dblDiscountCouponOne = 0.25;
        double dblDiscountCouponTwo = 100;
        double dblDiscountCouponThree = 500;


        int intSaleId;

        string strCustomerID;
        bool blnReturningCustomer = false;
        bool blnExpirationCoupon = false;

        string strDiscountIndex;
        int intCustomerUserID;
        string strInvoiceReference;
        string strLastSaleReport;

        string strCreditCardNumber;
        string strCreditCardName;
        string strCreditCardDate;
        string strCreditCardCVV;
        bool blnPaid = false;
       

        int intQuantityDiscount;
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
                dataAdapter = new SqlDataAdapter("SELECT ItemID as [Item ID] , Name, Quantity,CategoryID as [Category ID], FORMAT(RetailPrice, 'c', 'en-US') AS 'Retail Price', Description,SupplierID as [Supplier ID] FROM RandrezaVoharisoaM21Su2332.Items", Connection);
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
        //Display Items List in the Employee view
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
                    strDescription = row.Cells["Description"].Value.ToString();
                    strCategory= row.Cells["Category ID"].Value.ToString();

                    bool intResultTryParse = int.TryParse(strQuantityAvailable, out intQuantityAvailable);
                    if (intResultTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    intQuantitySelected = intQuantityAvailable;

                    strPrice = row.Cells["Retail Price"].Value.ToString().Substring(1);                   
                    bool dblResultTryParse = double.TryParse(strPrice, out dblPrice);
                    if (dblResultTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //Display in the label
                    lblQuantityRemain.Text = strQuantityAvailable;
                    dblPriceItemSelected = dblPrice;
                    tbxDescription.Text = strDescription;



                    //Disable features depends on category and Items
                    if (strCategory == "2")
                    {
                        radEmbroidered.Enabled = false;
                        radSmall.Enabled = false;
                        radLarge.Enabled = false;
                        radMedium.Checked = true;
                        cboColor.SelectedIndex = 8;
                    }
                    else
                    {
                        radEmbroidered.Enabled = true;
                        radSmall.Enabled = true;
                        radLarge.Enabled = true;
                        radMedium.Checked = false;
                    }

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
            try
            {
                if (tbxQuantityNeeded.Text != "" && !tbxQuantityNeeded.Text.Contains("."))
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

                                    double dblTotalPrice = dblPriceItemSelected * intQuantityNeeded;
                                    string strTotalPrice = dblTotalPrice.ToString("C2");


                                    string[] row = { strItemSelectedName, strItemDeco, strItemColor, strItemSize, strQuantityNeeded, dblPriceItemSelected.ToString("C2"), strTotalPrice };
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
                    MessageBox.Show("Please add quantity or a valid Quantity number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxQuantityNeeded.Focus();
                }


                if (dgvItemList.Rows.Count > 0)
                {
                    btnRemoveCart.Enabled = true;
                    btnDisplayPrice.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }

        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItemList.SelectedRows.Count > 0)
                {
                    tbxTotalPrice.Text = "";
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
                        int intIndexRowSelected = dgvEmployeeViewItem.CurrentCell.RowIndex;
                        //Insert quantity updated to current row and Cell "Quantity" index 1
                        dgvEmployeeViewItem.Rows[intIndexRowSelected].Cells[2].Value = intQuantitySelected.ToString();
                    }
                    DisplayEmployeeViewItems();

                    if (dgvItemList.SelectedRows.Count == 0)
                    {
                        btnPlaceOrder.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Please select the product you want to remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
       

        //Display Amount in the list without discount
        private void btnDisplayPrice_Click(object sender, EventArgs e)
        {
            CalculateAmount(0, 0);
            btnPlaceOrder.Enabled = true;
        }

        //Function to calculate amount in the list
        void CalculateAmount(double dblDiscountPercentage, double dblDiscountOff)
        {
            try
            {
                int intQuantityTotal = 0;
                double dblTotalList = 0;
                double dblAmountTax;
                double dblDiscount = 0;
                double dblSubTotal = 0;
                double dblTotalAmount = 0;
                double dblTax = 0.0825;

                string strTotalPriceList;
                double dblTotalPriceList = 0;


                string strQuantityTotal;
                int intQuantityTotalList = 0;




                if (dgvItemList.Rows.Count > 0)//make sure data list is not empty
                {

                    //cumulate Total Price of order from list cart
                    for (int i = 0; i < dgvItemList.Rows.Count; i++)
                    {
                        strTotalPriceList = dgvItemList.Rows[i].Cells[6].Value.ToString().Substring(1);

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
                        intQuantityDiscount = intQuantityTotal;
                    }


                }


                dblDiscount = dblTotalList * dblDiscountPercentage;
                dblSubTotal = dblTotalList - dblDiscount - dblDiscountOff;
                dblAmountTax = dblSubTotal * dblTax;
                dblTotalAmount = dblSubTotal + dblAmountTax;

                tbxDiscountCustomer.Text = dblDiscount.ToString("C2");
                tbxSubTotalCustomer.Text = dblSubTotal.ToString("C2");
                tbxTaxCustomer.Text = dblAmountTax.ToString("C2");
                tbxTotalToPay.Text = dblTotalAmount.ToString("C2");
                tbxQuantityTotal.Text = intQuantityTotal.ToString();

                if (intQuantityTotal > 10)
                {
                    tbxDelivery.Text = "24h";
                }
                else if (intQuantityTotal > 50)
                {
                    tbxDelivery.Text = "48h";
                }
                else if (intQuantityTotal > 100)
                {
                    tbxDelivery.Text = "72h";
                }
                else
                {
                    tbxDelivery.Text = "On call";
                }
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message, "Error Arithmetic", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxTotalToPay.Text != "")
                {
                    strCreditCardCVV = mskCVV.Text;
                    strCreditCardDate = dtpCreditCard.Text;
                    strCreditCardName = tbxNameCredit.Text;
                    strCreditCardNumber = tbxCardNumber.Text;

                    if (ValidCVV(strCreditCardCVV) == true && ValidCreditCardNumber(strCreditCardNumber) == true && tbxNameCredit.Text != "" && dtpCreditCard.Text != "")
                    {
                        if (tbxCustomerName.Text == "")
                        {
                            MessageBox.Show("Need Customer information, please", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gbxAddCustomer.Focus();
                        }
                        else
                        {

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



                                SqlCommand commandSalesReport = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.SalesReport(UserID,CreationDate) " +
                                    "VALUES(@UserID,@CreationDate)", Connection);
                                commandSalesReport.Parameters.AddWithValue("@UserID", intCustomerUserID);
                                commandSalesReport.Parameters.AddWithValue("@CreationDate", strDate);

                                string strConvertTotalToPay = tbxTotalToPay.Text.Substring(1);
                                double dblConvertTotalToPay;
                                if (!double.TryParse(strConvertTotalToPay, out dblConvertTotalToPay))
                                {
                                    MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                               



                                btnViewInvoice.Enabled = true;
                                blnPaid = true;
                                commandSalesReport.ExecuteNonQuery();



                                //Get the last SaleID using Max to insert as FK to the Sales Report table
                                string strQuerySaleID = "SELECT MAX(SaleId) from RandrezaVoharisoaM21Su2332.SalesReport";
                                SqlCommand commandSalesID = new SqlCommand(strQuerySaleID, Connection);

                                //gets Sale Id from insert sale report in the table sales report
                                SqlDataReader srSaleID = commandSalesID.ExecuteReader();
                                srSaleID.Read();
                                intSaleId = srSaleID.GetInt32(0);

                                strInvoiceReference = intSaleId.ToString();
                                strLastSaleReport = intSaleId.ToString() + ".html";
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

                                MessageBox.Show("The  Order has been successfully placed, here is the invoice", "Transaction Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                
                                PrintReportEmployeeView(GenerateReportEmployeeView());
                               

                                Reset();
                                ResetCustomerInformation();

                                btnViewInvoice.Enabled = true;
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.Message, "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }


                        }
                    }
                    else
                    {
                        MessageBox.Show("Please verify your credit card Information", "Invalid Credit Card", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("Please  Display Amount before checking out", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            html.Append($"<h5>{"Customer Name: "}{tbxCustomerName.Text}</h5>");
           html.Append($"<h5>{"Invoice: "}{strInvoiceReference}</h5>");

            html.AppendLine("<table>");
            html.AppendLine("<tr><td>Name</td><td>Decoration</td><td>Size</td><td>Color</td><td>Quantity</td><td>Price</td><td>Total Price</td></tr>");
            html.AppendLine("<tr><td colspan=8><hr /></td></tr>");
            try
            {
                //Loop through the data grid view List to display user Order in the receipt
                foreach (DataGridViewRow row in dgvItemList.Rows)
                {
                    html.Append("<tr>");
                    html.Append($"<td>{row.Cells["Name"].Value}</td>");
                    html.Append($"<td>{row.Cells["Type of Decoration"].Value}</td>");
                    html.Append($"<td>{row.Cells["Size"].Value}</td>");
                    html.Append($"<td>{row.Cells["Color"].Value}</td>");
                    html.Append($"<td>{row.Cells["Quantity"].Value}</td>");
                    html.Append($"<td>{row.Cells["Unit Price"].Value}</td>");
                    html.Append($"<td>{row.Cells["Total Price"].Value}</td>");
                    html.Append("</tr>");
                    html.AppendLine("<tr><td colspan=8><hr /></td></tr>");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            html.Append("<tr><td colspan=8><hr></hd></td></tr>");
            html.Append("<table>");
            html.AppendLine($"<h5>{"Totale Price: "}{tbxTotalPrice.Text}</h5>");
            html.AppendLine($"<h5>{"Discount: "}{tbxDiscountCustomer.Text}</h5>");
            html.AppendLine($"<h5>{"Subtotal: "}{tbxSubTotalCustomer.Text}</h5>");
            html.AppendLine($"<h5>{"Sales Tax: "}{tbxTaxCustomer.Text}</h5>");
            html.AppendLine($"<h5>{"Total Amount: "}{tbxTotalToPay.Text}</h5>");

                html.AppendLine($"<h5>{"Estimated Delivery: "}{tbxDelivery.Text}</h5>");

            if (blnPaid == true)
            {
                html.AppendLine($"<h5>{"Paid with credit card ##### : "}{strCreditCardNumber.Substring(strCreditCardNumber.Length - 4)}</h5>");
            }

            html.Append($"<h5>{"Cashier Name: "}{lblNameEmployee.Text}</h5>");
            html.Append($"<h2>{"Imprint Store "}</h2>");

            html.Append("</body></html>");//close body

            return html;
        }

        // Print the HTML report on the desktop
        private void PrintReportEmployeeView(StringBuilder html)
        {
            try
            {
                string strPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string strFilepath = strPath + "\\" + strLastSaleReport + "";


                // A "using" statement will automatically close a file after opening it.               
                using (StreamWriter swHistory = new StreamWriter(strFilepath))
                {
                    swHistory.WriteLine(html);
                }
                System.Diagnostics.Process.Start(strFilepath); //Open the report in the default web browser

               
            }
            catch (Exception)
            {
                MessageBox.Show("You currently do not have write permissions for this feature.",
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        //getting the invoice and display in html based o Invoice value in salesReport
        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomerPurchase.SelectedRows.Count > 0)
                {
                    try
                    {
                        if (strInvoiceReference == "")
                        {
                            MessageBox.Show("This Sales doesn't have invoice yet",
                            "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string strExecutableLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                            string strLocation = Path.Combine(strExecutableLocation, strInvoiceReference + ".html");
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
                       "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            tbxTotalPrice.Text = "";
            tbxCardNumber.Text = "";
            tbxNameCredit.Text = "";
            dtpCreditCard.Text = "";
            mskCVV.Text = "";
            tbxCustomerName.Text = "";
            btnAddCustomer.Enabled = false;
            btnPlaceOrder.Enabled = false;
            btnViewInvoice.Enabled = false;
            tbxDescription.Text = "";

            DisplayEmployeeViewItems();
           

        }

        //Reset Customer Information
        public void ResetCustomerInformation()
        {


            tbxFirstNameCustomer.Text="";
            tbxLastNameCustomer.Text = "";
            tbxAddressCustomer.Text = "";
            mskPhoneCustomer.Text = "";
            tbxCustomerCity.Text = "";
             cboStatesCustomer.Text = "";
            tbxZipCustomer.Text = "";
            tbxEmailCustomer.Text = "";
            radYes.Checked = false;
            radNo.Checked = false;
            tbxIDSearch.Text = "";
            btnAddCustomer.Enabled = false;
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
                MessageBox.Show("Ask for customer ID and Enter ID, or Go to Additional Information tab and search for Customer",
                      "Message Customer ID information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxIDSearch.Enabled = true;
                lblIDLabel.Enabled = true;
                lblIDLabel.Enabled = true;
                btnSearchCustomerID.Enabled = true;
                btnAddCustomer.Enabled = false;
                tbxIDSearch.Focus();

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
                MessageBox.Show("Enter an ID number or for more search option, please go to 'Additional Information Tab'", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string strQueryPersonID = "SELECT * FROM RandrezaVoharisoaM21Su2332.Person where PersonID='" + strIdCustomer + "' ;";
                SqlCommand commandPersonID = new SqlCommand(strQueryPersonID, Connection);

                //gets the results from the sql command
                SqlDataReader readerPersonID = commandPersonID.ExecuteReader();
                readerPersonID.Read();


                tbxFirstNameCustomer.Text = readerPersonID["NameFirst"].ToString();
                tbxLastNameCustomer.Text = readerPersonID["NameLast"].ToString();
                tbxEmailCustomer.Text = readerPersonID["Email"].ToString();
                tbxAddressCustomer.Text = readerPersonID["Address1"].ToString();
                tbxCustomerCity.Text = readerPersonID["City"].ToString();
                tbxZipCustomer.Text = readerPersonID["Zipcode"].ToString();              
                tbxCustomerState.Text = readerPersonID["State"].ToString();
                mskPhoneCustomer.Text = readerPersonID["PhonePrimary"].ToString();


                tbxCustomerName.Text = tbxFirstNameCustomer.Text.ToString() + " " + tbxLastNameCustomer.Text.ToString();
                btnPlaceOrder.Enabled = true;
                lblDisplayDiscountReturn.Text = "5% off";
                blnReturningCustomer = true;

                if (readerPersonID != null)
                {
                    readerPersonID.Close();
                }

                //get userId from table for sales report

                string queryUserID = "SELECT UserID from RandrezaVoharisoaM21Su2332.Users where PersonID= '" + strIdCustomer + "' and Status='Active';";
                SqlCommand commandUserID = new SqlCommand(queryUserID, Connection);

                //gets the results from the sql command
                SqlDataReader srUserID = commandUserID.ExecuteReader();
                srUserID.Read();
                intCustomerUserID = srUserID.GetInt32(0);
                srUserID.Close();

                if (srUserID != null)
                {
                    srUserID.Close();
                }

                if (Connection != null)
                {
                    Connection.Close();
                }


            
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot find Customer ID, please go to Additional Information Tab and Search in Customer List " , "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please enter new customer information ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblDisplayDiscountReturn.Text = "Don't Apply for new Customer";
                tbxFirstNameCustomer.Focus();
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
                tbxQuantityTotal.Text = "";
                tbxIDSearch.Text = "";
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

        public bool ValidPhone()
        {
            if ( mskPhoneCustomer.Text.Length<12 && mskPhoneCustomer.Text.Contains(" "))
            {
                return false;
            }
            return true;
        }


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
                            if (ValidPhone() == true)
                            {
                                if (!tbxZipCustomer.Text.Contains(".") && tbxZipCustomer.Text.Length > 4)
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
                                    SqlDataReader srOne = commandLastID.ExecuteReader();
                                    srOne.Read();
                                    int intPersonID = srOne.GetInt32(0);
                                    srOne.Close();
                                    //generate Username and Password
                                    string strModidfiedLastName = strLastName.Substring(0, strLastName.Length - 2);
                                    string strCreateUsername = strModidfiedLastName + intPersonID.ToString();

                                    string strCreatePassword = intRoleId.ToString() + intPersonID.ToString();

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

                                    MessageBox.Show("New Customer has been added successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    tbxCustomerName.Text = strFirstName + " " + strLastName;
                                    blnReturningCustomer = false;

                                    //Get the last PersonID using Max to insert as FK to the User table
                                    string queryLastUserID = "SELECT MAX(UserID) from RandrezaVoharisoaM21Su2332.Users";
                                    SqlCommand commandLastUserID = new SqlCommand(queryLastUserID, Connection);

                                    //gets the results from the sql command
                                    SqlDataReader srUserID = commandLastUserID.ExecuteReader();
                                    srUserID.Read();
                                    intCustomerUserID = srUserID.GetInt32(0);
                                    srUserID.Close();
                                    Connection.Close();
                                    btnPlaceOrder.Enabled = true;
                                    ResetCustomerInformation();

                                }
                                else
                                {
                                    MessageBox.Show("Zip is not valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    tbxZipCustomer.Text = "";
                                    tbxZipCustomer.Focus();
                                }

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

        //FUNCTION TO CHECK COUPON IN DATABASE
        public void SearchValidCoupon()
        {
            string strSearchCoupon = cboCoupon.Text;
            string strExpirationDate="";
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
               
                strExpirationDate= Expiration.ToString("d");
                lblExpiration.Text = strExpirationDate;

                int intCouponId = reader.GetInt32(0);
                strDiscountIndex = reader["DiscountIndex"].ToString();

               

                if (reader != null)
                {
                    reader.Close();
                }
               
                

                if (Connection != null)
            {
                Connection.Close();
            }


            }
            catch (Exception )
            {
                MessageBox.Show("Coupon already used or expired ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCoupon.Text = "";
                cboCoupon.Focus();
                lblCouponDescription.Text = "";
                lblExpiration.Text = strExpirationDate;
                Connection.Close();
            }
        }

        //Check and apply coupon if existed
        private void btnCheckCoupon_Click(object sender, EventArgs e)
        {
            if(cboCoupon.Text!="")
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
            try
            {
                if (tbxTotalPrice.Text != "")
                {
                    if (cboCoupon.Text == "" && radCoupon.Checked == true)
                    {
                        MessageBox.Show("Enter Coupon Number please", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string strTotalListForCoupon = tbxTotalPrice.Text.Substring(1);

                        double dblTotalListForCoupon;
                        if (!double.TryParse(strTotalListForCoupon, out dblTotalListForCoupon))
                        {
                            MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        if (radCoupon.Checked == true)
                        {

                            if (strDiscountIndex == "1")
                            {
                                CalculateAmount(dblDiscountCouponOne, 0);
                            }
                            if (strDiscountIndex == "2")
                            {
                                if (dblTotalListForCoupon > 500 && dblTotalListForCoupon < 2000)
                                {
                                    CalculateAmount(0, dblDiscountCouponTwo);
                                    tbxDiscountCustomer.Text = "$100";
                                }
                                else
                                {
                                    MessageBox.Show("Available only for a total purchase $500 and plus", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            if (strDiscountIndex == "3")
                            {
                                if (dblTotalListForCoupon > 2000)
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

                        if (radReturningDiscount.Checked == true && tbxFirstNameCustomer.Text!="")
                        {

                            CalculateAmount(dblDiscountReturning, 0);
                            lblDisplayDiscountReturn.Text = "5% off";
                        }

                        if (radQuantityDiscount.Checked == true)
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

                                CalculateAmount(dblDiscountOne, 0);
                                lblDisplayDiscountQuantity.Text = "10% Discount";
                            }
                            else if (intQuantityTotalDelivery > 50 && intQuantityTotalDelivery < 100)
                            {

                                CalculateAmount(dblDiscountTwo, 0);
                                lblDisplayDiscountQuantity.Text = "20% Discount";
                            }
                            else if (intQuantityTotalDelivery >= 100)
                            {
                                CalculateAmount(dblDiscountThree, 0);
                                lblDisplayDiscountQuantity.Text = "30% Discount";
                            }
                        }
                        if (radNoDiscount.Checked == true)
                        {
                            CalculateAmount(0, 0);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please display price by clicking on 'Display' Button", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        //Adding coupon ID from database in the drop down list
        public void AddListCoupon()
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT CouponID FROM RandrezaVoharisoaM21Su2332.Coupon", Connection);
                dataTable = new DataTable();
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "Coupon");

                cboCoupon.ValueMember = "CouponID";
                cboCoupon.DataSource = ds.Tables["Coupon"];

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Activate Coupon
        private void radCoupon_CheckedChanged(object sender, EventArgs e)
        {
            if(radCoupon.Checked==true)
            {
                cboCoupon.Enabled = true;
                lblExpiration.Enabled = true;
                lblExpirationLabel.Enabled = true;
                lblCouponDescription.Enabled = true;
                lblCouponDescription.Enabled = true;
                btnCheckCoupon.Enabled = true;
                lblCouponDescriptionLabel.Enabled = true;
                AddListCoupon();
            }
            else
            {
                cboCoupon.Text = "";
                lblCouponDescription.Text = "";
                lblExpiration.Text = "";

                cboCoupon.Enabled =false;
                lblExpiration.Enabled = false;
                lblExpirationLabel.Enabled = false;
                lblCouponDescription.Enabled = false;
                lblCouponDescription.Enabled = false;
                btnCheckCoupon.Enabled = false;
            }
        }


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
            try
            {
                string strEmployeeUserID = lblUserEmployee.Text;
                if (tabEmployeeView.SelectedTab.Name == "tabInformation")
                {
                    DisplayEmployeeInfo(strEmployeeUserID);
                    btnResetAll.Enabled = false;
                }
                if (tabEmployeeView.SelectedTab.Name == "tabPOS")
                {

                    btnResetAll.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Message: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            radEmail.Checked = false;
            radPhone.Checked = false;
            btnSearchEmail.Enabled = false;
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT RandrezaVoharisoaM21Su2332.Person.PersonID  as [Person ID], RandrezaVoharisoaM21Su2332.Person.NameFirst  as [First Name], RandrezaVoharisoaM21Su2332.Person.NameLast as [Last Name],RandrezaVoharisoaM21Su2332.Person.Address1  as [Address],RandrezaVoharisoaM21Su2332.Person.City,RandrezaVoharisoaM21Su2332.Person.State, RandrezaVoharisoaM21Su2332.Person.Zipcode,RandrezaVoharisoaM21Su2332.Person.PhonePrimary as [Phone] , RandrezaVoharisoaM21Su2332.Person.Email  FROM RandrezaVoharisoaM21Su2332.Person FULL JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Users.PersonID = RandrezaVoharisoaM21Su2332.Person.PersonID WHERE RoleID = 3 and Status='Active'; ", Connection);
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



                dataAdapter = new SqlDataAdapter("SELECT SaleId as[Sale ID], UserID as [User ID], CreationDate as [Transaction Date] FROM RandrezaVoharisoaM21Su2332.SalesReport where UserID = '" + strUserIDSelectedCustomer + "'", Connection);
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
            try
            {
                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvCustomerPurchase.Rows[e.RowIndex];
                    strSaleId = row.Cells["Sale ID"].Value.ToString();
                    strInvoiceReference = row.Cells["Sale ID"].Value.ToString();

                    DisplaySalesDetail(strSaleId);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string strQuery = "SELECT SalesDetailID as [Transaction Detail ID], SaleID as [Sale ID], ItemID as [Item ID], QuantitySold as [Quantity Sold], Decoration, Size, Color FROM RandrezaVoharisoaM21Su2332.SalesDetails where SaleID='" + strSaleID + "' ;";
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
            try
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
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btnClearCoupon_Click(object sender, EventArgs e)
        {
            try
            {
                while (dgvCouponList.Rows.Count > 0)
                {
                    dgvCouponList.Rows.RemoveAt(0);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                string strExecutableLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string strLocation = Path.Combine(strExecutableLocation, strLastSaleReport);
                System.Diagnostics.Process.Start(strLocation);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

     


        //CREDIT CARD
        public bool ValidCreditCardNumber(string strCreditCard)
        {

            if (strCreditCard.Length != 16)
            {
                return false;
            }


            return true;
        }

        public bool ValidCVV(string strValidCVV)
        {

            if (strValidCVV.Length <3)
            {
                return false;
            }
            return true;
        }

        private void tbxCardNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void mskCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            ResetCustomerInformation();
            Reset();
            radNoDiscount.Checked = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();


        }
         
        //Reset discount Information
        private void radNoDiscount_CheckedChanged(object sender, EventArgs e)
        {
            radCoupon.Checked = false;
            cboCoupon.Text = "";
            lblCouponDescription.Text = "";
            lblExpiration.Text = "";
            radQuantityDiscount.Checked = false;
            lblDisplayDiscountQuantity.Text = "";
            tbxQuantityTotal.Text = "";
            radReturningDiscount.Checked = false;
            lblDisplayDiscountReturn.Text = "";
            btnCheckCoupon.Enabled = false;
        }


        private void radQuantityDiscount_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                string strQuantityTotal;
                int intQuantityTotalList;
                int intQuantityTotal=0;
                if (radQuantityDiscount.Checked == true)
                {
                    if (dgvItemList.Rows.Count > 0)//make sure data list is not empty
                    {

                        MessageBox.Show("+10 items= 10% off\n +50 items= 20% off\n +100 items= 30% off",
                      "Discount Quantity Description", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                        tbxQuantityTotal.Text = intQuantityTotal.ToString();

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnHelpEmployeeView_Click(object sender, EventArgs e)
        {

            new frmHelpEmployeeView().Show();
            this.Visible = false;
        }

        //Display if customer received dscount based on loyalty
        private void radReturningDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (radReturningDiscount.Checked == true)
            {
                if (blnReturningCustomer==true)
                {
                    lblDisplayDiscountReturn.Text = "5% off";
                }
                else
                {
                    lblDisplayDiscountReturn.Text = "Don't apply on new customer";
                }
            }
        }

        //Method to Search Customer by email
        public void DisplayCustomerEmailOnly(string strByEmail)
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT RandrezaVoharisoaM21Su2332.Person.PersonID  as [Person ID], RandrezaVoharisoaM21Su2332.Person.NameFirst  as [First Name], RandrezaVoharisoaM21Su2332.Person.NameLast as [Last Name],RandrezaVoharisoaM21Su2332.Person.Address1  as [Address],RandrezaVoharisoaM21Su2332.Person.City,RandrezaVoharisoaM21Su2332.Person.State, RandrezaVoharisoaM21Su2332.Person.Zipcode,RandrezaVoharisoaM21Su2332.Person.PhonePrimary as [Phone] , RandrezaVoharisoaM21Su2332.Person.Email  FROM RandrezaVoharisoaM21Su2332.Person  FULL JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Users.PersonID = RandrezaVoharisoaM21Su2332.Person.PersonID WHERE RoleID = 3 and RandrezaVoharisoaM21Su2332.Person.Email='" + strByEmail + "' ; ", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvCustomerList.DataSource = dataTable;


                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot find this customer email ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxSearchEmail.Text = "";
            }
        }

        //Method to Search Customer by Phone
        public void DisplayCustomerPhoneOnly(string strByPhone)
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT RandrezaVoharisoaM21Su2332.Person.PersonID  as [Person ID], RandrezaVoharisoaM21Su2332.Person.NameFirst  as [First Name], RandrezaVoharisoaM21Su2332.Person.NameLast as [Last Name],RandrezaVoharisoaM21Su2332.Person.Address1  as [Address],RandrezaVoharisoaM21Su2332.Person.City,RandrezaVoharisoaM21Su2332.Person.State, RandrezaVoharisoaM21Su2332.Person.Zipcode,RandrezaVoharisoaM21Su2332.Person.PhonePrimary as [Phone] , RandrezaVoharisoaM21Su2332.Person.Email  FROM RandrezaVoharisoaM21Su2332.Person  FULL JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Users.PersonID = RandrezaVoharisoaM21Su2332.Person.PersonID WHERE RoleID = 3 and RandrezaVoharisoaM21Su2332.Person.PhonePrimary='" + strByPhone + "' ; ", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvCustomerList.DataSource = dataTable;


                Connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot find this customer email ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskSearchPhone.Text = "";
            }
        }

        //Search customer by phone or by email
        private void btnSearchEmail_Click(object sender, EventArgs e)
        {
            
            string strCustomerEmail = tbxSearchEmail.Text;
            string strSearchPhone = mskSearchPhone.Text;

            if (radEmail.Checked==true&& tbxSearchEmail.Text!=""&& ValidEmail(strCustomerEmail))
            {
                DisplayCustomerEmailOnly(strCustomerEmail);
            }
            else if (radPhone.Checked == true && mskSearchPhone.Text != "")
            {
                DisplayCustomerPhoneOnly(strSearchPhone);
            }
            else
            {
                MessageBox.Show("Please enter customer phone or email to search", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxSearchEmail.Text = "";
                mskSearchPhone.Text = "";
            }
        }

        //Activate search customer email
        private void radEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (radEmail.Checked == true)
            {
                tbxSearchEmail.Enabled = true;
                btnSearchEmail.Enabled = true;
            }
            else
            {
                tbxSearchEmail.Enabled = false;
            }
        }

        //Activate search customer phone
        private void radPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (radPhone.Checked == true)
            {
                mskSearchPhone.Enabled = true;
                btnSearchEmail.Enabled = true;
            }
            else
            {
                mskSearchPhone.Enabled = false;
                mskSearchPhone.Text = "";
            }
        }

        private void dgvCouponList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



