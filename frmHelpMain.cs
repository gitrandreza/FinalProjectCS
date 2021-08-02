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
    public partial class frmHelpMain : Form
    {
        public frmHelpMain()
        {
            InitializeComponent();
        }

        private void btnBacktoMain_Click(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Hide();
        }
    }
}
