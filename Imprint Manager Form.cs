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
    public partial class frmAdmin : Form
    {
        public SqlConnection Connection;

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            try
            {
                //connect to database
                Connection = new SqlConnection("Server=cstnt.tstc.edu;" +
                    "Database= inew2332su21 ;User Id=RandrezaVoharisoaM21Su2332; password = 1760945");
                //open the database
                Connection.Open();
                //display message
               // lblMessage.Text = Connection.State.ToString();
                //close the database
                Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }
            try
            {
               
                //insert image

                byte[] image = File.ReadAllBytes("C:\\T-Shirt.png");

                Connection.Open();

                string insertQuery = "UPDATE RandrezaVoharisoaM21Su2332.Items set Image = @Image where ItemID= 8001"; // @Image is a parameter we will fill in later
                SqlCommand insertCmd = new SqlCommand(insertQuery, Connection);
                SqlParameter sqlParams = insertCmd.Parameters.AddWithValue("@Image", image); // The parameter will be the image as a byte array
                sqlParams.DbType = System.Data.DbType.Binary; // The type of data we are sending to the server will be a binary file
                insertCmd.ExecuteNonQuery();

                MessageBox.Show("File was successfully added to the database.", "File Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT Image FROM RandrezaVoharisoaM21Su2332.Items WHERE CategoryId = 2", Connection));
                //DataSet dataSet = new DataSet();
                //dataAdapter.Fill(dataSet);

                //Display Image
                byte[] imgData;
                SqlCommand cmd = new SqlCommand("Select Image From RandrezaVoharisoaM21Su2332.Items where Description = 'T-Shirt'", Connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                long bufLength = reader.GetBytes(0, 0, null, 0, 0);
                imgData = new byte[bufLength];
                reader.GetBytes(0, 0, imgData, 0, (int)bufLength);
                MemoryStream ms = new MemoryStream(imgData);
                ms.Position = 0;
                pictureBox1.Image = Image.FromStream(ms);
                reader.Close();

                Connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error During Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    }
        

