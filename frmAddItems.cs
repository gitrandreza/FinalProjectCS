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

namespace SU21_Final_Project
{
    public partial class frmAddItems : Form
    {
        SqlConnection Connection;



        string strItemName;
        
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            try
            {

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


                            SqlCommand commandItem = new SqlCommand("INSERT INTO RandrezaVoharisoaM21Su2332.Items(Name,Quantity,Cost,Image,CategoryID,RetailPrice,Description,SupplierID)" +
                                "VALUES(@Name,@Quantity,@Cost,NULL,@CategoryID,@RetailPrice,@Description,@SupplierID)", Connection);
                            commandItem.Parameters.AddWithValue("@Name", strItemName);
                            commandItem.Parameters.AddWithValue("@Quantity", intQuantityPurchased);
                            commandItem.Parameters.AddWithValue("@Cost", dblItemCost);
                            commandItem.Parameters.AddWithValue("@CategoryID", intCategory);
                            commandItem.Parameters.AddWithValue("@RetailPrice", dblRetailPrice);
                            commandItem.Parameters.AddWithValue("@Description", strDescription);
                            commandItem.Parameters.AddWithValue("@SupplierID", intSupplierID);


                            commandItem.ExecuteNonQuery();
                            MessageBox.Show("New Item added", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            Connection.Close();

                            new frmAdmin().Show();
                            this.Hide();
                       
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
    }
    
}
