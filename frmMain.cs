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
        frmLogin frmLogin =new frmLogin();

        //Instantiate Item class
        Items myItems = new Items();

        double dblTax = 0.0825;
        double dblSubTotal;
        double dblAmountTax;
        double dblTotalAmount;
        double dblDiscount = 0;
        string strQtyList;
        string strTotalPriceList;
        //global list of item
        private List<Items> product = new List<Items>(); 

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
                //display message
                //lblMessage.Text = Connection.State.ToString();
                
                //close the database
                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DisplayClothesItems();

        }

        //**************************Method to display table item by category**************************
        public void DisplayAllItems()
        {
            try
            {
                Connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT Description, Quantity, RetailPrice  FROM RandrezaVoharisoaM21Su2332.Items", Connection);
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
                dataAdapter = new SqlDataAdapter("SELECT Description, Quantity, RetailPrice  FROM RandrezaVoharisoaM21Su2332.Items WHERE CategoryID = 2 ;", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvGift.DataSource = dataTable;

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
                dataAdapter = new SqlDataAdapter("SELECT Description, Quantity, RetailPrice  FROM RandrezaVoharisoaM21Su2332.Items WHERE CategoryID = 1 ;", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvClothes.DataSource = dataTable;

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
                dataAdapter = new SqlDataAdapter("SELECT Description, Quantity, RetailPrice  FROM RandrezaVoharisoaM21Su2332.Items WHERE CategoryID = 3 ;", Connection);
                dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvBags.DataSource = dataTable;

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
                SqlCommand cmd = new SqlCommand("Select Image From RandrezaVoharisoaM21Su2332.Items where Description = '" + selectedItem + "'", Connection);
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

        //Tab selection
        private void tabItemCategory_Selected(object sender, TabControlEventArgs e)
        {

            if (tabItemCategory.SelectedTab.Name == "tabAll")
            {
                DisplayAllItems();
            }

            if (tabItemCategory.SelectedTab.Name == "tabGifts")
            {
                DisplayGiftItems();
            }

            if (tabItemCategory.SelectedTab.Name == "tabClothes")
            {
                DisplayClothesItems();
            }

            if (tabItemCategory.SelectedTab.Name == "tabBags")
            {

                DisplayBagsItems();


            }
        }



        //*************************ITEM SELECTION****************************************
        private void dgvGift_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Connection.Open();

                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvGift.Rows[e.RowIndex];

                    myItems.Name = row.Cells["Description"].Value.ToString();
                    string strQuantity = row.Cells["Quantity"].Value.ToString();
                    int intQuantity;
                    bool intResultTryParse = int.TryParse(strQuantity, out intQuantity);
                    if (intResultTryParse == true)
                    {
                        myItems.Quantity = intQuantity;
                    }

                    string strPrice = row.Cells["RetailPrice"].Value.ToString();
                    double dblPrice;
                    bool dblResultTryParse = double.TryParse(strPrice, out dblPrice);
                    if (dblResultTryParse == true)
                    {
                        myItems.Price = dblPrice;
                    }



                    lblQuantityAvailable.Text = myItems.Quantity.ToString();
                    lblPrice.Text = myItems.Price.ToString();
                    lblItemName.Text = myItems.Name;

                }

                Connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DisplayImage(myItems.Name, pbxGift);
        }

        private void dgvClothes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Connection.Open();

                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvClothes.Rows[e.RowIndex];

                    myItems.Name = row.Cells["Description"].Value.ToString();
                    string strQuantity = row.Cells["Quantity"].Value.ToString();
                    int intQuantity;
                    bool intResultTryParse = int.TryParse(strQuantity, out intQuantity);
                    if (intResultTryParse == true)
                    {
                        myItems.Quantity = intQuantity;
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
                    lblPrice.Text = myItems.Price.ToString();
                    lblItemName.Text = myItems.Name;

                }

                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DisplayImage(myItems.Name, pbxClothes);
        }

        private void dgvAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Connection.Open();

                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvAll.Rows[e.RowIndex];

                    myItems.Name = row.Cells["Description"].Value.ToString();
                    string strQuantity = row.Cells["Quantity"].Value.ToString();
                    int intQuantity;
                    bool intResultTryParse = int.TryParse(strQuantity, out intQuantity);
                    if (intResultTryParse == true)
                    {
                        myItems.Quantity = intQuantity;
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
                    lblPrice.Text = myItems.Price.ToString();
                    lblItemName.Text = myItems.Name;

                }


                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DisplayImage(myItems.Name, pbxAll);
        }

        private void dgvBags_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Connection.Open();

                if (e.RowIndex >= 0)
                {
                    //instantiate object from Items class and assign value from cell
                    DataGridViewRow row = this.dgvBags.Rows[e.RowIndex];

                    myItems.Name = row.Cells["Description"].Value.ToString();
                    string strQuantity = row.Cells["Quantity"].Value.ToString();
                    int intQuantity;
                    bool intResultTryParse = int.TryParse(strQuantity, out intQuantity);
                    if (intResultTryParse == true)
                    {
                        myItems.Quantity = intQuantity;
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
                    lblPrice.Text = myItems.Price.ToString();
                    lblItemName.Text = myItems.Name;

                }
                Connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex, "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DisplayImage(myItems.Name, pbxBags);
        }
        //***************************END ITEM SELECTION********************************************





        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new frmAdmin().Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        //***********************ADD LIST*********************************************


        //Method to pass value in DatagridviewList
        private void addCart(string strName, string strDecoration, string strColor, string strSize,
            string strQuantity,string strUnitPrice, string strTotalPrice)
        {
            string[] row = { strName, strDecoration, strColor, strSize, strQuantity, strUnitPrice, strTotalPrice };
            dgvList.Rows.Add(row);
            dgvList.CurrentCell.Selected = false;
        }

        private void btnAddToList_Click(object sender, EventArgs e)
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
            string strItemName = lblItemName.Text;

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

            string strItemQuantity = "";
            if (tbxQuantity.Text != "")
            {
                strItemQuantity = tbxQuantity.Text;
            }
            else
            {
                MessageBox.Show("Please add quantity", "Missing Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            string strPrice = lblPrice.Text;
            double dblPrice;
            bool dblPriceTryParse = double.TryParse(strPrice, out dblPrice);

            string strQuantity = tbxQuantity.Text;
            int intQuantity;
            bool intQuantityTryParse = int.TryParse(strQuantity, out intQuantity);

            double dblTotalPrice = dblPrice * intQuantity;
            //lblMessage.Text =dblTotalPrice.ToString();
            string strItemTotalPrice = dblTotalPrice.ToString();

            //Call add cart function to display selection in the cart
            addCart(strItemName, strItemDeco, strItemColor, strItemSize, strItemQuantity, strPrice ,strItemTotalPrice);
            //reset input
            tbxQuantity.Text = "";
            radEmbroidered.Checked = false;
            radPrinted.Checked = false;
            radBlank.Checked = false;
            radLarge.Checked = false;
            radMedium.Checked = false;
            radSmall.Checked = false;
            
            cboColor.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (dgvList.CurrentCell.RowIndex > -1)
            {
                dgvList.Rows.RemoveAt(dgvList.CurrentCell.RowIndex);
                dgvList.Refresh();
            }

        }

        //Display detail Amount detail and total to pay from the list of order
        private void btnDisplayAmount_Click(object sender, EventArgs e)
        {
            string strTotalPriceList;
            double dblTotalPriceList = 0;
            double dblTotalList = 0;           
            

            if (dgvList.Rows.Count > 0)//make sure data list is not empty
            {

                //cumulate Total Price of order from list cart
                for (int i = 0; i < dgvList.Rows.Count; i++)
                {
                    strTotalPriceList = dgvList.Rows[i].Cells[6].Value.ToString();
                    bool dblResultTryParse = double.TryParse(strTotalPriceList, out dblTotalPriceList);

                    dblTotalList = dblTotalList + dblTotalPriceList;
                }




                dblAmountTax = dblTotalList * dblTax;
                dblSubTotal = dblTotalList;
                dblTotalAmount = dblTotalList + dblAmountTax;

                lblSubTotal.Text = dblTotalList.ToString("C2");
                lblTaxAmount.Text = dblAmountTax.ToString("C2");
                lblTotalAmount.Text = dblTotalAmount.ToString("C2");

            }

            // string strTotalPriceList = row.Cells["RetailPrice"].Value.ToString();
            //double dblTotalPriceList;
            // bool dblResultTryParse = double.TryParse(strTotalPriceList, out dblTotalPriceList);
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

                SqlCommand commandSalesReport = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.SalesReport(UserID,CreationDate,SubTotal,DiscountAmount,TaxAmount,TotalAmount) " +
                    "VALUES(@UserID,@CreationDate,@SubTotal,@DiscountAmount,@TaxAmount,@TotalAmount)", Connection);
                commandSalesReport.Parameters.AddWithValue("@UserID", intUserID);
                commandSalesReport.Parameters.AddWithValue("@CreationDate", strDate);
                commandSalesReport.Parameters.AddWithValue("@SubTotal", dblSubTotal);
                commandSalesReport.Parameters.AddWithValue("@DiscountAmount", dblDiscount);
                commandSalesReport.Parameters.AddWithValue("@TaxAmount", dblAmountTax);
                commandSalesReport.Parameters.AddWithValue("@TotalAmount", dblTotalAmount);

                commandSalesReport.ExecuteNonQuery();

              
                MessageBox.Show("Client Successfully added");

                Connection.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
           

            html.AppendLine("<table>");
            html.AppendLine("<tr><td>Item</td><td>Quantity</td><td>Price</td><td>Total Price</td></tr>");
            html.AppendLine("<tr><td colspan=5><hr /></td></tr>");

            //Loop through the datagriview List to display user Order in the receipt
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                html.Append("<tr>");
                html.Append($"<td>{row.Cells["Name"].Value}</td>");
                html.Append($"<td>{row.Cells["Quantity"].Value}</td>");
                html.Append($"<td>{row.Cells["Unit Price"].Value}</td>");
                html.Append($"<td>{row.Cells["Total Price"].Value}</td>");
                html.Append("</tr>");
                html.AppendLine("<tr><td colspan=5><hr /></td></tr>");
            }

            html.Append("<tr><td colspan=5><hr></hd></td></tr>");
            html.Append("<table>");

            html.AppendLine($"<h5>{"Subtotal: "}{dblSubTotal.ToString("C2")}</h5>");
            html.AppendLine($"<h5>{"Tax Sale: "}{dblAmountTax.ToString("C2")}</h5>");
            html.AppendLine($"<h5>{"Total Amount: "}{dblTotalAmount.ToString("C2")}</h5>");

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
                using (StreamWriter writer = new StreamWriter("Report.html"))
                {
                    writer.WriteLine(html);
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
            using (StreamWriter writer = new StreamWriter($"{today.ToString("yyyy-MM-dd-HHmmss")} - Report.html"))
            {
                writer.WriteLine(html);
            }
        }
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            PrintReport(GenerateReport());
        }
    }
    }

