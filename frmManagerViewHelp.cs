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
    public partial class frmManagerViewHelp : Form
    {
        public frmManagerViewHelp()
        {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            new frmAdmin().Show();
            this.Hide();
        }

        private void frmManagerViewHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show("Are you sure you want to close this?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        new frmAdmin().Show();
                        this.Hide();
                    }
                    break;
            }
        }
    }
}
