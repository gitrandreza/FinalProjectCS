using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SU21_Final_Project
{
    public partial class frmHelpAddItem : Form
    {
        public frmHelpAddItem()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAddItems().Visible = true;
        }

        private void frmHelpAddItemEmployee_FormClosing(object sender, FormClosingEventArgs e)
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


                        this.Hide();
                        new frmAddItems().Visible = true;
                    }
                    break;
            }
        }
    }
}