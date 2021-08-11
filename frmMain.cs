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
using System.Reflection;

namespace SU21_Final_Project
{

    public partial class frmMain : Form
    {


        //Establish connection to the database       
        SqlConnection Connection;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        

        //Instantiate Item class
        Items myItems = new Items();

     
        
        double dblDiscount;
   
        int intSaleId;


        int intQuantityAvailable;
        int intQuantityNeed;
        string strInvoiceCustomer;
        string strLastSaleReportCustomer;

        public static string strUserNumberID;

        string strCreditCardNumber;
        string strCreditCardName;
        string strCreditCardDate;
        string strCreditCardCVV;
        bool blnPaid = false;


        string strDiscountIndex;
        double dblDiscountCouponOne = 0.25;
        double dblDiscountCouponTwo = 100;
        double dblDiscountCouponThree = 500;
        double dblDiscountCouponPercentage;

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
                dataAdapter = new SqlDataAdapter("SELECT Name, Quantity, CategoryID, RetailPrice ,Description FROM RandrezaVoharisoaM21Su2332.Items where Status='Available'", Connection);
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
                    myItems.Category = row.Cells["CategoryID"].Value.ToString();

                    string strQuantityAvailable = row.Cells["Quantity"].Value.ToString();

                    bool intResultTryParse = int.TryParse(strQuantityAvailable, out intQuantityAvailable);
                    if (intResultTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                    myItems.Quantity = intQuantityAvailable;

                    string strPrice = row.Cells["RetailPrice"].Value.ToString();
                    double dblPrice;
                    bool dblResultTryParse = double.TryParse(strPrice, out dblPrice);
                    if (dblResultTryParse == false)
                    {
                        MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    myItems.Price = dblPrice;
                    //Display in the label
                    lblQuantityAvailable.Text = myItems.Quantity.ToString();
                    lblPrice.Text = myItems.Price.ToString("C2");
                    lblName.Text = myItems.Name;
                    tbxDescription.Text = myItems.Description;

                    //Disable features depends on category and Items
                    if(myItems.Category=="2")
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

            DisplayImage(myItems.Name, pbxAll);
        }


        //***************************END ITEM SELECTION********************************************


        private void btnAdmin_Click(object sender, EventArgs e)
        {
            SqlCommand scRoleID;
            SqlDataReader srRoleID;
            strUserNumberID = lblUser.Text;
            try
            {


                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                //gets Role Id from based on UserID
                scRoleID = new SqlCommand("SELECT RandrezaVoharisoaM21Su2332.Users.RoleID from RandrezaVoharisoaM21Su2332.Users where UserID='" + strUserNumberID + "';", Connection);

                srRoleID = scRoleID.ExecuteReader();

                srRoleID.Read();
                int intRoleId = srRoleID.GetInt32(0);
                srRoleID.Close();

                //Check role of user id to open the Employee view or Manager View
                if (intRoleId == 2)
                {
                    new frmEmployee().Show();
                    this.Hide();
                }
                else if (intRoleId == 1)
                {
                    new frmAdmin().Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Access denied. Admnistrator use only ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                Connection.Close(); //closes connection to database

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


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
            try
            {
                if (lblName.Text != "")
                {
                    if (tbxQuantity.Text != "")
                    {

                        string strQuantityNeed;
                        strQuantityNeed = tbxQuantity.Text;

                        if (int.TryParse(strQuantityNeed, out intQuantityNeed) == false)

                        {
                            MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

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




                                            string strItemTotalPrice = dblTotalPrice.ToString("C2");

                                            string strItemPrice = myItems.Price.ToString("C2");

                                            //Call add cart function to display selection in the cart
                                            addCart(myItems.Name, strItemDeco, strItemColor, strItemSize, strQuantityNeed, strItemPrice, strItemTotalPrice);


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
                if (dgvList.Rows.Count > 0)
                {
                    btnRemove.Enabled = true;
                    btnDisplayAmount.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Remove Item from list
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
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
                    lblTotalList.Text = "";
                    lblDeliveryOne.BackColor = Color.Silver;
                    lblDeliveryTwo.BackColor = Color.Silver;
                    lblDeliveryThree.BackColor = Color.Silver;
                    lblQuantityAvailable.Text = "";
                    cboColor.Text = "";

                    DisplayAllItems();
                    if (dgvList.SelectedRows.Count == 0)
                    {
                        btnDisplayAmount.Enabled = false;
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

        //Display detail Amount detail and total to pay from the list of order
        private void btnDisplayAmount_Click(object sender, EventArgs e)
        {
            CalculateAmount();
            AddListCoupon();
            btnApplyCoupon.Enabled = true;
            btnCancelCoupon.Enabled = true;
        }


        //Function to calculate amount in the list
        void CalculateAmount(double dblCoupounPercentage=0,double dblCouponOFF=0, double dblDiscountOne = 0.1,
        double dblDiscountTwo = 0.2,
        double dblDiscountThree = 0.3)
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


            btnCheckout.Enabled = true;

            try
            {
                if (dgvList.Rows.Count > 0)//make sure data list is not empty
                {

                    //cumulate Total Price of order from list cart
                    for (int i = 0; i < dgvList.Rows.Count; i++)
                    {
                        strTotalPriceList = dgvList.Rows[i].Cells[6].Value.ToString().Substring(1);

                        bool dblResultTryParse = double.TryParse(strTotalPriceList, out dblTotalPriceList);

                        if (dblResultTryParse == false)
                        {
                            MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }


                        dblTotalList = dblTotalList + dblTotalPriceList;
                    }


                    //Cumulate quantity total for discount
                    for (int i = 0; i < dgvList.Rows.Count; i++)
                    {
                        strQuantityTotal = dgvList.Rows[i].Cells[4].Value.ToString();
                        bool intResultTryParse = int.TryParse(strQuantityTotal, out intQuantityTotalList);
                        if (intResultTryParse == false)
                        {
                            MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                        intQuantityTotal = intQuantityTotal + intQuantityTotalList;
                    }


                }

                dblDiscountCouponPercentage = dblTotalList * dblCoupounPercentage;



                //Discount and delivery condition based on quantities
                if (intQuantityTotal > 10 && intQuantityTotal <= 50)
                {

                    lblDiscountOne.BackColor = Color.OrangeRed;
                    lblDeliveryOne.BackColor = Color.OrangeRed;
                    dblDiscount = dblTotalList * dblDiscountOne;
                    dblSubTotal = dblTotalList - dblDiscount - dblCouponOFF - dblDiscountCouponPercentage;
                }
                else if (intQuantityTotal > 50 && intQuantityTotal < 100)
                {

                    lblDiscountTwo.BackColor = Color.OrangeRed;
                    lblDeliveryTwo.BackColor = Color.OrangeRed;
                    dblDiscount = dblTotalList * dblDiscountTwo;
                    dblSubTotal = dblTotalList - dblDiscount - dblCouponOFF - dblDiscountCouponPercentage; ;
                }
                else if (intQuantityTotal >= 100)
                {

                    lblDiscountThree.BackColor = Color.OrangeRed;
                    lblDeliveryThree.BackColor = Color.OrangeRed;
                    dblDiscount = dblTotalList * dblDiscountThree;
                    dblSubTotal = dblTotalList - dblDiscount - dblCouponOFF - dblDiscountCouponPercentage; ;
                }
                else
                {
                    dblSubTotal = dblTotalList - dblCouponOFF - dblDiscountCouponPercentage; ;
                }


                dblAmountTax = dblSubTotal * dblTax;
                dblTotalAmount = dblSubTotal + dblAmountTax;

                lblTotalList.Text = dblTotalList.ToString("C2");
                lblDiscount.Text = dblDiscount.ToString("C2");
                lblSubTotal.Text = dblSubTotal.ToString("C2");
                lblTaxAmount.Text = dblAmountTax.ToString("C2");
                lblTotalAmount.Text = dblTotalAmount.ToString("C2");
            }
            catch (ArithmeticException ex)
            {
                MessageBox.Show(ex.Message, "Error Arithmetic", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
            
        }


        //Get UserID value from database and use it to access admin views, lblUser is not visible in running, it's just for the program use
        public string LabelUserID
        {
         
            get { return lblUser.Text; }
            set { lblUser.Text = value; }
        }


        //Store sale in the Database when checked out
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblTotalAmount.Text != "")
                {
                    strCreditCardCVV = mskCVV.Text;
                    strCreditCardDate = dtpCreditCard.Text;
                    strCreditCardName = tbxNameCredit.Text;
                    strCreditCardNumber = tbxCardNumber.Text;

                    if (ValidCVV(strCreditCardCVV) == true && ValidCreditCardNumber(strCreditCardNumber) == true && tbxNameCredit.Text != "" && dtpCreditCard.Text != "")
                    {
                        int intUserID;
                        string strUserID = lblUser.Text;
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

                            SqlCommand commandSalesReport = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.SalesReport(UserID,CreationDate) " +
                                "VALUES(@UserID,@CreationDate)", Connection);
                            commandSalesReport.Parameters.AddWithValue("@UserID", intUserID);
                            commandSalesReport.Parameters.AddWithValue("@CreationDate", strDate);

                            string strTotalAmount = lblTotalAmount.Text.Substring(1);
                            double dblTotalAmount;

                            if (!double.TryParse(strTotalAmount, out dblTotalAmount))
                            {
                                MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                           

                            btnViewReceipt.Enabled = true;
                            blnPaid = true;

                            commandSalesReport.ExecuteNonQuery();

                            //Get the last SaleID using Max to insert as FK to the Sales Report table and as Id of Invoice 
                            string strQuerySaleID = "SELECT MAX(SaleId) from RandrezaVoharisoaM21Su2332.SalesReport";
                            SqlCommand commandSalesID = new SqlCommand(strQuerySaleID, Connection);

                            //gets Sale Id from insert sale report in the table sales report
                            SqlDataReader srSaleID = commandSalesID.ExecuteReader();
                            srSaleID.Read();
                            intSaleId = srSaleID.GetInt32(0);

                            strInvoiceCustomer = intSaleId.ToString() + ".html";
                            strLastSaleReportCustomer = intSaleId.ToString();
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


                            MessageBox.Show("Your Order has been successfully placed, here is your invoice", "Transaction Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            PrintReport(GenerateReport());

                            Reset();

                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message, "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please verify your credit card Information", "Invalid Credit Card", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
                else
                {
                    MessageBox.Show("Please  Display Amount before checking out", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

        //Display receipt in HTML
        private StringBuilder GenerateReport()
        {
            StringBuilder html = new StringBuilder();
            StringBuilder css = new StringBuilder();
            css.AppendLine("<style>");            
            css.AppendLine("td {padding: 5px; text-align:center; font-weight: bold; text-align: center;}");
            css.AppendLine("h1 {color: brown;}");           
            css.AppendLine("h2 {color: blue;}");
            css.AppendLine("</style>");

            html.AppendLine("<html>");
            html.AppendLine($"<head>{css}<title>{"Imprint Store Report"}</title></head>");
            html.AppendLine("<body>");

            html.AppendLine($"<h1>{"Imprint Store"}</h1>");
            html.Append($"<h5>{"Abilene, TX"}</h5>");
            html.Append($"<h5>{"79602"}</h5>");

            html.Append($"<h5>{"Customer Name: "}{lblNameOfUser.Text}</h5>");
            html.Append($"<h5>{"Date: "}{lblDate.Text}</h5>");
           
            html.Append($"<h5>{"Invoice Number: "}{strLastSaleReportCustomer}</h5>");

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

            html.AppendLine($"<h5>{"Total Price: "}{lblTotalList.Text}</h5>");
            html.AppendLine($"<h5>{"Discount: "}{lblDiscount.Text}</h5>");
            html.AppendLine($"<h5>{"Subtotal: "}{lblSubTotal.Text}</h5>");
            html.AppendLine($"<h5>{"Sales Tax: "}{lblTaxAmount.Text}</h5>");

            html.AppendLine($"<h5>{"Total Amount: "}{lblTotalAmount.Text}</h5>");
            if (blnPaid == true)
            {
                html.AppendLine($"<h5>{"Paid with credit card ##### : "}{strCreditCardNumber.Substring(strCreditCardNumber.Length - 4)}</h5>");
            }

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
            else
            {
                html.AppendLine($"<h5>{"Estimated Delivery: 2h "}</h5>");
            }
            
            html.Append($"<h2>{"Thank you for shopping with us "}</h2>");

            html.Append("</body></html>");//close body

            return html;
        }

        // Print the HTML report on the desktop
        private void PrintReport(StringBuilder html)
        {
            string strPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string strFilepath = strPath + "\\"+strInvoiceCustomer;
         
            try
            {
                // A "using" statement will automatically close a file after opening it.               
                using (StreamWriter swInvoice = new StreamWriter(strFilepath))
                {
                    swInvoice.WriteLine(html);
                }
                System.Diagnostics.Process.Start(strFilepath); //Open the report in the default web browser

            }
            catch (IOException )
            {
                MessageBox.Show("You currently do not have write permissions for this feature.",
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Call Reset Selection
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //Method for reset all 
        public void Reset()
        {
            dgvList.Rows.Clear();            
            lblName.Text = "";
            lblPrice.Text = "";
            pbxAll.Image = null;
            lblSubTotal.Text = "";
            lblTaxAmount.Text = "";
            lblTotalAmount.Text = "";
            lblTotalList.Text = "";
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
            cboColor.SelectedIndex=-1;
            lblQuantityAvailable.Text = "";
            tbxDescription.Text = "";
            tbxQuantity.Text = "";
            lblTotalList.Text = "";
            lblDiscount.Text = "";
            dblDiscount = 0;
            cboCoupon.Text = "";
            tbxDescription.Text = "";
            btnApplyCoupon.Enabled = false;
            btnCancelCoupon.Enabled = false;
            tbxNameCredit.Text = "";
            tbxCardNumber.Text = "";
            mskCVV.Text = "";

            lblCouponDescription.Text = "";
            lblDeliveryOne.BackColor = Color.Silver;
            lblDeliveryTwo.BackColor = Color.Silver;
            lblDeliveryThree.BackColor = Color.Silver;

            //Reset Item browser
            DisplayAllItems();
          

        }
        //Back to login form
        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to log out?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new frmLogin().Show();
                    this.Hide();
                    Reset();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        //Handling closing form
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
                        new frmLogin().Show();
                        this.Hide();
                        Reset();
                    }
                    break;
            }
        }

        //---------------------------------Key press Enter for buttons-------------------------------------

        private void btnAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdmin.PerformClick();
            }
        }

        private void btnLogout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogout.PerformClick();
            }
        }

        private void btnRemove_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRemove.PerformClick();
            }
        }

        private void btnAddToList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddToList.PerformClick();
            }
        }

        private void btnCheckout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheckout.PerformClick();
            }
        }

        private void btnReset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnReset.PerformClick();
            }
        }

        private void btnViewReceipt_Click(object sender, EventArgs e)
        {

            try
            {

                string strExecutableLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string strLocation = Path.Combine(strExecutableLocation, strLastSaleReportCustomer + ".html");
                    System.Diagnostics.Process.Start(strLocation);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot find Report associate with this.",
                    "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //CREDIT CARD
        public bool ValidCreditCardNumber(string strCreditCard)
        {

            if (strCreditCard.Length !=16)
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

        private void tbxCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mskCVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //FUNCTION TO CHECK COUPON IN DATABASE
        public void SearchValidCoupon()
        {
            string strSearchCoupon = cboCoupon.Text;

            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");

                Connection.Open();
                string strQuery = "SELECT CouponID, Description, Expiration,DiscountIndex FROM RandrezaVoharisoaM21Su2332.Coupon where CouponID='" + strSearchCoupon + "' and Expiration > '" + lblDate.Text + "' ;";
                SqlCommand command = new SqlCommand(strQuery, Connection);

                //gets the results from the sql command
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();


                var Expiration = reader.GetDateTime(2);
                lblCouponDescription.Text = reader["Description"].ToString();
                

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
            catch (Exception ex)
            {
                MessageBox.Show("Coupon Expired", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCoupon.Text = "";
                cboCoupon.Focus();
                lblCouponDescription.Text = "Coupon Expired";
                Connection.Close();
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


        //Apply Coupon
        private void btnApplyCoupon_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboCoupon.Text != "")
                {
                    if (MessageBox.Show("Are you sure you want to Apply this coupon, your other discount won't be applied?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        SearchValidCoupon();

                        string strTotalListForCoupon = lblTotalList.Text.Substring(1);

                        double dblTotalListForCoupon;
                        if (!double.TryParse(strTotalListForCoupon, out dblTotalListForCoupon))
                        {
                            MessageBox.Show("You did not enter a value to convert", "Conversion Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        if (strDiscountIndex == "1")
                        {
                            CalculateAmount(dblDiscountCouponOne, 0, 0, 0, 0);
                            lblDiscountOne.BackColor = Color.Silver;
                            lblDiscountTwo.BackColor = Color.Silver;
                            lblDiscountThree.BackColor = Color.Silver;
                            lblDiscount.Text = dblDiscountCouponPercentage.ToString("C2");
                        }
                        if (strDiscountIndex == "2")
                        {
                            if (dblTotalListForCoupon > 500 && dblTotalListForCoupon < 2000)
                            {
                                CalculateAmount(0, dblDiscountCouponTwo, 0, 0, 0);
                                lblDiscountOne.BackColor = Color.Silver;
                                lblDiscountTwo.BackColor = Color.Silver;
                                lblDiscountThree.BackColor = Color.Silver;
                                lblDiscount.Text = "$100";
                            }
                            else
                            {
                                MessageBox.Show("Available only for a total purchase $500 and plus", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        if (strDiscountIndex == "3")
                        {
                            if (dblTotalListForCoupon > 2000)
                            {
                                CalculateAmount(0, dblDiscountCouponThree, 0, 0, 0);
                                lblDiscountOne.BackColor = Color.Silver;
                                lblDiscountTwo.BackColor = Color.Silver;
                                lblDiscountThree.BackColor = Color.Silver;
                                lblDiscount.Text = "$500";
                            }
                            else
                            {
                                MessageBox.Show("Available only for a total purchase $2000 and plus", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Enter your coupon number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
        //Cancel Coupon
        private void btnCancelCoupon_Click(object sender, EventArgs e)
        {
            CalculateAmount();
            cboCoupon.Text = "";
            lblCouponDescription.Text = "";
        }
        //Acces to help content
        private void btnHelpEmployeeView_Click(object sender, EventArgs e)
        {
            new frmHelpMain().Show();
          
        }
        //Make sure to not enter anything than number 
        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //Make sure to not enter anything than letter 
        private void tbxNameCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
      
    }
}

