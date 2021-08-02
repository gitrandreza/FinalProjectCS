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
    public partial class frmHelpEmployeeView : Form
    {
        public frmHelpEmployeeView()
        {
            InitializeComponent();
        }

        private void btnReturnEmployeeView_Click(object sender, EventArgs e)
        {
            new frmEmployee().Visible = true;
            this.Hide();
        }

        private void frmHelpEmployeeView_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show("Are you sure you want to close?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {


                        this.Hide();
                        new frmEmployee().Visible = true;
                    }
                    break;
            }
        }
    }
}
