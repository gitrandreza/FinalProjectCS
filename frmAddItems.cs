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
        SqlConnection Connection;



        string strItemName;

        string strDate= DateTime.Now.ToShortDateString();//Get date

        int intQuantityPurchased;
        double dblItemCost;
        int intCategory;
        double dblRetailPrice;
        string strDescription;
        int intSupplierID;
        
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
                    && cboCategory.Text != "" && tbxDescription.Text != "" && cboSupplier.Text != "")
                {
                    SqlCommand commandCheckItemName = new SqlCommand("SELECT Name FROM RandrezaVoharisoaM21Su2332.Items;", Connection);

                    //gets the results from the sql command
                    SqlDataReader reader = commandCheckItemName.ExecuteReader();

                    while (reader.Read())
                    {
                        //check through the user table column to find a matching value
                        if (reader["Name"].ToString() == strItemName)
                        {
                            MessageBox.Show("Duplicate Item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


                    if (blnDuplicateItemName == false)
                    {
                        reader.Close();

                        //INSERT RECORD FOR NEW INPUT
                         string strQuantityPurchased=tbxQuantity.Text;
                         bool intQuantityTryParse = int.TryParse(strQuantityPurchased, out intQuantityPurchased);

                        string strItemCost = tbxItemCost.Text;
                        bool dblResultTryParse = double.TryParse(strItemCost, out dblItemCost);
                        

                        string strCategory=cboCategory.SelectedItem.ToString();
                        bool intCategoryTryParse = int.TryParse(strCategory, out intCategory);


                        string strRetailPrice = tbxRetailPrice.Text;
                        bool dblRetailPriceTryParse = double.TryParse(strRetailPrice, out dblRetailPrice);

                        strDescription=tbxDescription.Text;

                        string strSupplierID = cboSupplier.SelectedItem.ToString();
                        bool intSupplierTryParse = int.TryParse(strSupplierID, out intSupplierID);

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

                                    byte[] image = File.ReadAllBytes("C:\\defaultPic.png");

                                    SqlParameter sqlParams = commandItem.Parameters.AddWithValue("@Image", image); // The parameter will be the image as a byte array
                                    sqlParams.DbType = System.Data.DbType.Binary; // The type of data we are sending to the server will be a binary file

                                    commandItem.Parameters.AddWithValue("@CategoryID", intCategory);
                            commandItem.Parameters.AddWithValue("@RetailPrice", dblRetailPrice);
                            commandItem.Parameters.AddWithValue("@Description", strDescription);
                            commandItem.Parameters.AddWithValue("@SupplierID", intSupplierID);


                            commandItem.ExecuteNonQuery();
                            MessageBox.Show("New Item added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (MessageBox.Show("Do you want Invoice?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                    {
                                        PrintInvoice(GenerateInvoice(strItemName, intQuantityPurchased, dblItemCost));

                                    }

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

            html.AppendLine($"<h1>{" Purchase Detail"}</h1>");

            html.Append($"<h5>{"Date: "}{strDate}</h5>");
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

        // Write (and overwrite) to the hard drive using the same filename of "Report.html"
        private void PrintInvoice(StringBuilder html)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filepath = path + "\\NewItemInvoice.html";

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

            //unique filename  use for a date and time with part of a name
            DateTime today = DateTime.Now;
            using (StreamWriter swNewItem = new StreamWriter($"{today.ToString("yyyy-MM-dd-HHmmss")} - NewItemInvoice.html"))
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
            new frmAdmin().Show();
            this.Hide();
        }

        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            ////strItemName = cboItemName.SelectedItem.ToString();
            //try
            //{

            //    Connection.Open();
            //    Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
            //        "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
            //    Connection.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error :" + ex);
            //}
            //try
            //{

            //    //insert image

            //    byte[] image = File.ReadAllBytes("C:\\defaultPic.png");

            //    Connection.Open();

            //    string insertQuery = "UPDATE RandrezaVoharisoaM21Su2332.Items set Image = @Image where ItemID= '" + strItemID + "'"; // @Image is a parameter we will fill in later
            //    SqlCommand insertCmd = new SqlCommand(insertQuery, Connection);
            //    SqlParameter sqlParams = insertCmd.Parameters.AddWithValue("@Image", image); // The parameter will be the image as a byte array
            //    sqlParams.DbType = System.Data.DbType.Binary; // The type of data we are sending to the server will be a binary file
            //    insertCmd.ExecuteNonQuery();

            //    MessageBox.Show("File was successfully added to the database.", "File Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    //SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT Image FROM RandrezaVoharisoaM21Su2332.Items WHERE CategoryId = 2", Connection));
            //    //DataSet dataSet = new DataSet();
            //    //dataAdapter.Fill(dataSet);

            //    //Display Image
            //    byte[] imgData;
            //    SqlCommand cmd = new SqlCommand("Select Image From RandrezaVoharisoaM21Su2332.Items where ItemID = '" + strItemID + "'", Connection);
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    reader.Read();
            //    long bufLength = reader.GetBytes(0, 0, null, 0, 0);
            //    imgData = new byte[bufLength];
            //    reader.GetBytes(0, 0, imgData, 0, (int)bufLength);
            //    MemoryStream ms = new MemoryStream(imgData);
            //    ms.Position = 0;
            //    pbxItemPicture.Image = Image.FromStream(ms);
            //    reader.Close();

            //    Connection.Close();
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message, "Error During Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
    
}
