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
    public partial class frmEmployee : Form
    {

        //Establish connection to the database       
        SqlConnection Connection;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;


        string strItemSelectedName;
        string strQuantityAvailable;
        int intQuantityAvailable;
        int intQuantitySelected;
        string strPrice;
        double dblPrice;
        double dblPriceItemSelected;

        string strQuantityNeeded;
        int intQuantityNeeded;
        double dblTotalList;
        int intQuantityTotal;

        double dblAmountTax ;
         
        double dblSubTotal;
             double dblTotalAmount;
        double dblTax = 0.0825;
        double dblDiscount = 0;
        double dblDiscountOne = 0.1;
        double dblDiscountTwo = 0.2;
        double dblDiscountThree = 0.3;

        int intSaleId;



        private void frmEmployee_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();//Get date
         
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
            //string x= dgvItemList.Rows[0].Cells[6].Value.ToString();
            //tbxCoupon.Text=x;
            string strTotalPriceList;
            double dblTotalPriceList;


            string strQuantityTotal;
            int intQuantityTotalList;


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

                //delivery condition based on quantities
                if (intQuantityTotal > 10 && intQuantityTotal <= 50)
                {
                    radQuantityDiscount.Checked = true;
                    tbxDelivery.Text = "24h";
                }
                else if (intQuantityTotal > 50 && intQuantityTotal < 100)
                {
                    radQuantityDiscount.Checked = true;
                    tbxDelivery.Text = "48h";
                }
                else if (intQuantityTotal >= 100)
                {
                    radQuantityDiscount.Checked = true;
                    tbxDelivery.Text = "72h";
                }

                else
                {
                    radNoDiscount.Checked = true;
                    CalculateAmount(dblDiscount);
                }
                

            }
        }

        void CalculateAmount(double dblDiscountApply )
        {
            
           
            dblDiscount = dblTotalList * dblDiscountApply;
            dblSubTotal = dblTotalList;
            dblAmountTax = dblTotalList * dblTax;
            dblTotalAmount = dblTotalList + dblAmountTax;

            tbxDiscountCustomer.Text = dblDiscount.ToString("C2");
            tbxSubTotalCustomer.Text = dblTotalList.ToString("C2");
            tbxTaxCustomer.Text = dblAmountTax.ToString("C2");
            tbxTotalToPay.Text = dblTotalAmount.ToString("C2");

        }

        //Apply discount based 
        private void radQuantityDiscount_CheckedChanged(object sender, EventArgs e)
        {
            //Discount and delivery condition based on quantities
            if (intQuantityTotal > 10 && intQuantityTotal <= 50)
            {

                CalculateAmount(dblDiscountOne);
                lblDisplayDiscountQuantity.Text = "10% Discount";
            }
            else if (intQuantityTotal > 50 && intQuantityTotal < 100)
            {

                CalculateAmount(dblDiscountTwo);
                lblDisplayDiscountQuantity.Text = "20% Discount";
            }
            else if (intQuantityTotal >= 100)
            {
                CalculateAmount(dblDiscountThree);
                lblDisplayDiscountQuantity.Text = "30% Discount";
            }
        }

        //No discount apply
        private void radNoDiscount_CheckedChanged(object sender, EventArgs e)
        {
            CalculateAmount(dblDiscount);
        }
      
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (tbxTotalToPay.Text != "")
            {
                int intUserID;
                string strUserID = "2069";
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
                    commandSalesReport.Parameters.AddWithValue("@TotalSale", dblTotalAmount.ToString());


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
                    if (MessageBox.Show("Do you want your receipt?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            html.Append($"<h5>{"Customer Name: "}{lblNameEmployee.Text}</h5>");
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

            html.AppendLine($"<h5>{"Discount: "}{dblDiscount.ToString("C2")}</h5>");
            html.AppendLine($"<h5>{"Subtotal: "}{dblSubTotal.ToString("C2")}</h5>");
            html.AppendLine($"<h5>{"Tax Sale: "}{dblAmountTax.ToString("C2")}</h5>");
            html.AppendLine($"<h5>{"Total Amount: "}{dblTotalAmount.ToString("C2")}</h5>");

                html.AppendLine($"<h5>{"Estimated Delivery: "}{tbxDelivery.Text}</h5>");

            html.Append($"<h2>{"Company: Imprint Store  "}</h2>");

            html.Append("</body></html>");//close body

            return html;
        }

        // Print the HTML report on the desktop
        private void PrintReportEmployeeView(StringBuilder html)
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
                System.Diagnostics.Process.Start(filepath);

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
            dblDiscount = 0;
            tbxDelivery.Text = "";

            radNoDiscount.Checked = true;

            DisplayEmployeeViewItems();
           

        }

       
    }
}



