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
        frmLogin frmLogin = new frmLogin();

        //Instantiate Item class
        Items myItems = new Items();

        double dblTax = 0.0825;
        double dblSubTotal;
        double dblAmountTax;
        double dblTotalAmount;
        double dblDiscountOne = 0.1;
        double dblDiscountTwo = 0.2;
        double dblDiscountThree = 0.3;
        double dblDiscount;


        int intSaleId;


        int intQuantityAvailable;
        int intQuantityNeed;


        public frmMain()
        {
            InitializeComponent();
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();//Get date


            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                Connection.Open();
                //display Last name of user
                SqlCommand command = new SqlCommand("SELECT RandrezaVoharisoaM21Su2332.Person.NameLast FROM RandrezaVoharisoaM21Su2332.Person " +
                    "LEFT JOIN RandrezaVoharisoaM21Su2332.Users ON RandrezaVoharisoaM21Su2332.Person.PersonID = RandrezaVoharisoaM21Su2332.Users.PersonID WHERE UserID = '" + lblUser.Text + "'", Connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                lblNameOfUser.Text = reader["NameLast"].ToString();
                reader.Close();


                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            DisplayAllItems();

        }

        //**************************Method to display table item by category**************************
        public void DisplayAllItems()
        {
            try
            {
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Name, Quantity, RetailPrice ,Description FROM RandrezaVoharisoaM21Su2332.Items", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvAll.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayGiftItems()
        {
            try
            {
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Name, Quantity, RetailPrice,Description   FROM RandrezaVoharisoaM21Su2332.Items WHERE CategoryID = 2 ;", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvAll.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayClothesItems()
        {
            try
            {
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Name, Quantity, RetailPrice,Description  FROM RandrezaVoharisoaM21Su2332.Items WHERE CategoryID = 1 ;", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvAll.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DisplayBagsItems()
        {
            try
            {
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Name, Quantity, RetailPrice,Description  FROM RandrezaVoharisoaM21Su2332.Items WHERE CategoryID = 3 ;", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvAll.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //**************************END Method to display table item by category**************************


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
        //SELECT by Category
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex == 0)
            {
                DisplayAllItems();
            }

            else if (cboCategory.SelectedItem.ToString() == "Bags")
            {
                DisplayBagsItems();
            }

            else if (cboCategory.SelectedItem.ToString() == "Gifts")
            {
                DisplayGiftItems();
            }
            else if (cboCategory.SelectedItem.ToString() == "Clothes")
            {
                DisplayClothesItems();
            }
        }


        //ITEM SELECTION 
        private void dgvAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Connection.Open();

                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvAll.Rows[e.RowIndex];

                    myItems.Name = row.Cells["Name"].Value.ToString();
                    myItems.Description = row.Cells["Description"].Value.ToString();

                    string strQuantityAvailable = row.Cells["Quantity"].Value.ToString();

                    bool intResultTryParse = int.TryParse(strQuantityAvailable, out intQuantityAvailable);
                    if (intResultTryParse == true)
                    {
                        myItems.Quantity = intQuantityAvailable;
                    }

                    string strPrice = row.Cells["RetailPrice"].Value.ToString();
                    double dblPrice;
                    bool dblResultTryParse = double.TryParse(strPrice, out dblPrice);
                    if (dblResultTryParse == true)
                    {
                        myItems.Price = dblPrice;
                    }

                    //Display in the label
                    lblQuantityAvailable.Text = myItems.Quantity.ToString();
                    lblPrice.Text = myItems.Price.ToString("C2");
                    lblName.Text = myItems.Name;
                    tbxDescription.Text = myItems.Description;

                }


                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DisplayImage(myItems.Name, pbxAll);
        }


        //***************************END ITEM SELECTION********************************************


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new frmAdmin().Show();
            this.Hide();
        }

        //***********************ADD LIST*********************************************


        //Method to pass value in DatagridviewList
        private void addCart(string strName, string strDecoration, string strColor, string strSize,
            string strQuantity, string strUnitPrice, string strTotalPrice)
        {
            string[] row = { strName, strDecoration, strColor, strSize, strQuantity, strUnitPrice, strTotalPrice };
            dgvList.Rows.Add(row);
            dgvList.CurrentCell.Selected = false;
        }

        //Add select Item to List
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (lblName.Text != "")
            {
                if (tbxQuantity.Text != "")
                {

                    string strQuantityNeed;
                    strQuantityNeed = tbxQuantity.Text;

                    bool intQuantityTryParse = int.TryParse(strQuantityNeed, out intQuantityNeed);

                    if (intQuantityNeed > 0 && intQuantityNeed < int.MaxValue)
                    {
                        if (intQuantityNeed <= myItems.Quantity)
                        {
                            if (radEmbroidered.Checked == true || radPrinted.Checked == true || radBlank.Checked == true)
                            {
                                if (radSmall.Checked == true || radMedium.Checked == true || radLarge.Checked == true)
                                {
                                    if (cboColor.SelectedItem != null)
                                    {
                                        //Build datagriedviewList 
                                        dgvList.ColumnCount = 7;
                                        dgvList.Columns[0].Name = "Name";
                                        dgvList.Columns[1].Name = "Type of Decoration";
                                        dgvList.Columns[2].Name = "Color";
                                        dgvList.Columns[3].Name = "Size";
                                        dgvList.Columns[4].Name = "Quantity";
                                        dgvList.Columns[5].Name = "Unit Price";
                                        dgvList.Columns[6].Name = "Total Price";



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

                                        double dblTotalPrice = myItems.Price * intQuantityNeed;



                                        //lblMessage.Text =dblTotalPrice.ToString();
                                        string strItemTotalPrice = dblTotalPrice.ToString();

                                        //Call add cart function to display selection in the cart
                                        addCart(myItems.Name, strItemDeco, strItemColor, strItemSize, strQuantityNeed, myItems.Price.ToString(), strItemTotalPrice);


                                        if (myItems.Quantity > 0)
                                        {
                                            //Decrease Quantity Item selected
                                            myItems.Quantity = myItems.Quantity - intQuantityNeed;

                                            lblQuantityAvailable.Text = myItems.Quantity.ToString();
                                            //grab current row index selected
                                            int intIndexRowSelected = dgvAll.CurrentCell.RowIndex;
                                            //Insert quantity updated to current row and Cell "Quantity" index 1
                                            dgvAll.Rows[intIndexRowSelected].Cells[1].Value = myItems.Quantity.ToString();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Sorry, this item is out of stock!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }

                                        //Reset Selection
                                        tbxQuantity.Text = "";
                                        radEmbroidered.Checked = false;
                                        radPrinted.Checked = false;
                                        radBlank.Checked = false;
                                        radLarge.Checked = false;
                                        radMedium.Checked = false;
                                        radSmall.Checked = false;
                                        cboColor.Text = "";
                                        lblQuantityAvailable.Text = "";
                                        tbxDescription.Text = "";
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
                            tbxQuantity.Text = "";
                            tbxQuantity.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter positive number only", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxQuantity.Text = "";
                        tbxQuantity.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please add quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxQuantity.Focus();
                }
                lblDiscountOne.BackColor = Color.Silver;
                lblDiscountTwo.BackColor = Color.Silver;
                lblDiscountThree.BackColor = Color.Silver;

                lblDiscount.Text = "";
                dblDiscount = 0;
                lblTotalAmount.Text = "";

                lblDeliveryOne.BackColor = Color.Silver;
                lblDeliveryTwo.BackColor = Color.Silver;
                lblDeliveryThree.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Please select your product", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(dgvList.Rows.Count > 0)
            {
                btnRemove.Enabled = true;
                btnDisplayAmount.Enabled = true;
            }

            
            
        }

        //Remove Item from list
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0)
            {
                lblSubTotal.Text = "";
                lblTaxAmount.Text = "";
                lblTotalAmount.Text = "";

                foreach (DataGridViewRow row in dgvList.SelectedRows)
                {
                    dgvList.Rows.RemoveAt(row.Index);
                    //Increase Quantity Available
                    myItems.Quantity = myItems.Quantity + intQuantityNeed;

                    lblQuantityAvailable.Text = myItems.Quantity.ToString();
                    //grab current row index selected
                    int intIndexRowSelected = dgvAll.CurrentCell.RowIndex;
                    //Insert quantity updated to current row and Cell "Quantity" index 1
                    dgvAll.Rows[intIndexRowSelected].Cells[1].Value = myItems.Quantity.ToString();
                }
                lblDiscountOne.BackColor = Color.Silver;
                lblDiscountTwo.BackColor = Color.Silver;
                lblDiscountThree.BackColor = Color.Silver;

                lblDiscount.Text = "";
                dblDiscount = 0;
                lblTotalAmount.Text = "";

                lblDeliveryOne.BackColor = Color.Silver;
                lblDeliveryTwo.BackColor = Color.Silver;
                lblDeliveryThree.BackColor = Color.Silver;
            }
            else
            {
                MessageBox.Show("Please select the product you want to remove", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Display detail Amount detail and total to pay from the list of order
        private void btnDisplayAmount_Click(object sender, EventArgs e)
        {
            string strTotalPriceList;
            double dblTotalPriceList = 0;
            double dblTotalList = 0;

            string strQuantityTotal;
            int intQuantityTotal=0;
            int intQuantityTotalList = 0;

            btnCheckout.Enabled = true;

            if (dgvList.Rows.Count > 0)//make sure data list is not empty
            {

                //cumulate Total Price of order from list cart
                for (int i = 0; i < dgvList.Rows.Count; i++)
                {
                    strTotalPriceList = dgvList.Rows[i].Cells[6].Value.ToString();
                    bool dblResultTryParse = double.TryParse(strTotalPriceList, out dblTotalPriceList);

                    dblTotalList = dblTotalList + dblTotalPriceList;
                }

                //Cumulate quantity total for discount
                for (int i = 0; i < dgvList.Rows.Count; i++)
                {
                    strQuantityTotal = dgvList.Rows[i].Cells[4].Value.ToString();
                    bool intResultTryParse = int.TryParse(strQuantityTotal, out intQuantityTotalList);

                    intQuantityTotal = intQuantityTotal + intQuantityTotalList;
                }

                //Discount and delivery condition based on quantities
                if (intQuantityTotal > 10 && intQuantityTotal <= 50)
                {
                    
                    lblDiscountOne.BackColor = Color.OrangeRed;
                    lblDeliveryOne.BackColor = Color.OrangeRed;
                    dblDiscount = dblTotalList * dblDiscountOne;
                    dblTotalList = dblTotalList - dblDiscount;
                }
              else if (intQuantityTotal >50 && intQuantityTotal < 100)
                {

                    lblDiscountTwo.BackColor = Color.OrangeRed;
                    lblDeliveryTwo.BackColor = Color.OrangeRed;
                    dblDiscount = dblTotalList * dblDiscountTwo;
                    dblTotalList = dblTotalList - dblDiscount;
                }
                else if (intQuantityTotal >= 100)
                {

                    lblDiscountThree.BackColor = Color.OrangeRed;
                    lblDeliveryThree.BackColor = Color.OrangeRed;
                    dblDiscount = dblTotalList * dblDiscountThree;
                    dblTotalList = dblTotalList - dblDiscount;
                }

                dblAmountTax = dblTotalList * dblTax;
                dblSubTotal = dblTotalList;
                dblTotalAmount = dblTotalList + dblAmountTax;

                
                lblDiscount.Text = dblDiscount.ToString("C2");
                lblSubTotal.Text = dblTotalList.ToString("C2");
                lblTaxAmount.Text = dblAmountTax.ToString("C2");

                lblTotalAmount.Text = dblTotalAmount.ToString("C2");

            }
           
        }

        //Get UserID value from database and display to the label user when login is valid
        public string LabelUserID
        {

            get { return lblUser.Text; }
            set { lblUser.Text = value; }
        }


        //Store sale in the Database when checked out
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (lblTotalAmount.Text != "")
            {
                int intUserID;
                string strUserID = lblUser.Text;
                bool intResultTryParse = int.TryParse(strUserID, out intUserID);
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
                    commandSalesReport.Parameters.AddWithValue("@UserID", intUserID);
                    commandSalesReport.Parameters.AddWithValue("@CreationDate", strDate);
                   

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
                    foreach (DataGridViewRow row in dgvList.Rows)
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
                    foreach (DataGridViewRow row in dgvAll.Rows)
                    {
                        
                        string strQuantityUpdate= row.Cells["Quantity"].Value.ToString();
                        int intQuantityDgv;
                        bool blnConvert= int.TryParse(strQuantityUpdate, out intQuantityDgv);
                        string strNameItem= row.Cells["Name"].Value.ToString();
                        //UPDATE quantity in the table Items
                        string strUpdateQuery = "UPDATE RandrezaVoharisoaM21Su2332.Items SET Quantity = @Quantity where Name= '" + strNameItem + "'";
                        SqlCommand commandUpQuantity = new SqlCommand(strUpdateQuery, Connection);
                       
                        SqlParameter sqlParams = commandUpQuantity.Parameters.AddWithValue("@Quantity", intQuantityDgv);
                        commandUpQuantity.ExecuteNonQuery();
                        
                    }

                    Connection.Close();
                    if (MessageBox.Show("Do you want your receipt?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PrintReport(GenerateReport());

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
        private StringBuilder GenerateReport()
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

            html.AppendLine($"<h1>{"User Sales Detail Receipt"}</h1>");

            html.Append($"<h5>{"Date: "}{lblDate.Text}</h5>");
            html.Append($"<h5>{"Customer Name: "}{lblNameOfUser.Text}</h5>");
            html.Append($"<h5>{"Sale ID: "}{intSaleId.ToString()}</h5>");

            html.AppendLine("<table>");
            html.AppendLine("<tr><td>Name</td><td>Decoration</td><td>Size</td><td>Color</td><td>Quantity</td><td>Price</td><td>Total Price</td></tr>");
            html.AppendLine("<tr><td colspan=8><hr /></td></tr>");

            //Loop through the data grid view List to display user Order in the receipt
            foreach (DataGridViewRow row in dgvList.Rows)
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

            html.Append("<tr><td colspan=8><hr></hd></td></tr>");
            html.Append("<table>");

            html.AppendLine($"<h5>{"Discount: "}{dblDiscount.ToString("C2")}</h5>");
            html.AppendLine($"<h5>{"Subtotal: "}{dblSubTotal.ToString("C2")}</h5>");
            html.AppendLine($"<h5>{"Tax Sale: "}{dblAmountTax.ToString("C2")}</h5>");
            html.AppendLine($"<h5>{"Total Amount: "}{dblTotalAmount.ToString("C2")}</h5>");
          

            if (lblDeliveryTwo.BackColor == Color.OrangeRed)
            {
                html.AppendLine($"<h5>{"Estimated Delivery: 48h "}</h5>");
            }
            else if (lblDeliveryOne.BackColor == Color.OrangeRed)
            {
                html.AppendLine($"<h5>{"Estimated Delivery: 24h "}</h5>");
            }
            else if (lblDeliveryThree.BackColor == Color.OrangeRed)
            {
                html.AppendLine($"<h5>{"Estimated Delivery: 72h "}</h5>");
            }
            
            html.Append($"<h2>{"Company: Imprint Store  "}</h2>");

            html.Append("</body></html>");//close body

            return html;
        }

        // Write (and overwrite) to the hard drive using the same filename of "Report.html"
        private void PrintReport(StringBuilder html)
        {

            try
            {
                // A "using" statement will automatically close a file after opening it.               
                using (StreamWriter sw = new StreamWriter("Report.html"))
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

        //Close Application
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the application", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        

        //Reset Selection
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            dgvList.Rows.Clear();            
            lblName.Text = "";
            lblPrice.Text = "";
            pbxAll.Image = null;
            lblSubTotal.Text = "";
            lblTaxAmount.Text = "";
            lblTotalAmount.Text = "";
            btnRemove.Enabled = false;
            btnDisplayAmount.Enabled = false;
            lblDiscountOne.BackColor = Color.Silver;
            lblDiscountTwo.BackColor = Color.Silver;
            lblDiscountThree.BackColor = Color.Silver;
            radEmbroidered.Checked = false;
            radPrinted.Checked = false;
            radBlank.Checked = false;
            radMedium.Checked = false;
            radLarge.Checked = false;
            radSmall.Checked = false;
            cboColor.Text = "";
            lblQuantityAvailable.Text = "";
            tbxDescription.Text = "";
            tbxQuantity.Text = "";

            lblDiscount.Text = "";
            dblDiscount = 0;
            lblTotalAmount.Text = "";

            lblDeliveryOne.BackColor = Color.Silver;
            lblDeliveryTwo.BackColor = Color.Silver;
            lblDeliveryThree.BackColor = Color.Silver;

            //Reset Item browser
            try
            {
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Name, Quantity, RetailPrice ,Description FROM RandrezaVoharisoaM21Su2332.Items", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvAll.DataSource = dataTable;

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Back to login form
        private void btnLogout_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
            Reset();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

