﻿using System;
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
    public partial class frmHelp : Form
    {

    
        public frmHelp()
        {
            InitializeComponent();

        }


        //Back to previous form based on picture Help
        private void btnClose_Click(object sender, EventArgs e)
        {


            if(pbxHelpLogin.Visible==true)
            {
                new frmLogin().Show();
                this.Hide();
            }
            else if (pbxHelpSignUp.Visible == true )
            {
                new frmSignUp().Show();
                this.Hide();
            }
           else if (pbxHelpResetPassword.Visible == true)
            {
                new frmResetPassword().Show();
                this.Hide();
            }

            else if (pbxAddEmployee.Visible == true)
            {
                new frmAdmin().Show();
                this.Hide();
            }
        }

        //Display picture Help based on form 
        private void frmHelp_Load(object sender, EventArgs e)
        {
            if (frmLogin.blnHelpLoginPicture == false)
            {
                pbxHelpLogin.Visible = true;
            }
            else if (frmSignUp.blnSignUpPicture == false)
            {
                pbxHelpSignUp.Visible = true;
                pbxHelpLogin.Visible = false;
            }
            else if (frmResetPassword.blnResetPasswordPicture == false)
            {
                pbxHelpResetPassword.Visible = true;
                pbxHelpLogin.Visible = false;
                pbxHelpSignUp.Visible = false;
            }
            else if (frmAddEmployee.blnAddEmployee == false)
            {
                pbxAddEmployee.Visible = true;
                pbxHelpResetPassword.Visible = false;
                pbxHelpLogin.Visible = false;
                pbxHelpSignUp.Visible = false;
            }

        }

        private void frmHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    if (MessageBox.Show("Do you want to close this form?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
