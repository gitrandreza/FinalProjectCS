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


                               


                                string strItemTotalPriceFormat = dblTotalPrice.ToString("C2");

                                string strPriceFormat = dblPrice.ToString("C2");

                                string[] row = { strItemSelectedName, strItemDeco, strItemColor, strItemSize, strQuantityNeeded, strPriceFormat, strItemTotalPriceFormat };
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
    }
}



