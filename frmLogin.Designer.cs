
namespace SU21_Final_Project
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblLoginlabel = new System.Windows.Forms.Label();
            this.lblPasswordlLabel = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblLoginFailed = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblProgramLogoTwo = new System.Windows.Forms.Label();
            this.lblProgramLogoOne = new System.Windows.Forms.Label();
            this.btnHelpLoginForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginlabel
            // 
            this.lblLoginlabel.AutoSize = true;
            this.lblLoginlabel.BackColor = System.Drawing.Color.Transparent;
            this.lblLoginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginlabel.Location = new System.Drawing.Point(46, 68);
            this.lblLoginlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginlabel.Name = "lblLoginlabel";
            this.lblLoginlabel.Size = new System.Drawing.Size(86, 17);
            this.lblLoginlabel.TabIndex = 0;
            this.lblLoginlabel.Text = "Username:";
            // 
            // lblPasswordlLabel
            // 
            this.lblPasswordlLabel.AutoSize = true;
            this.lblPasswordlLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordlLabel.Location = new System.Drawing.Point(46, 107);
            this.lblPasswordlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordlLabel.Name = "lblPasswordlLabel";
            this.lblPasswordlLabel.Size = new System.Drawing.Size(82, 17);
            this.lblPasswordlLabel.TabIndex = 1;
            this.lblPasswordlLabel.Text = "Password:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(146, 65);
            this.tbxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(219, 22);
            this.tbxUsername.TabIndex = 0;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(146, 107);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(219, 22);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(188, 197);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 33);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "&Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLogin_KeyDown);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(13, 264);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(105, 33);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign &Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            this.btnSignUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSignUp_KeyDown);
            // 
            // lblLoginFailed
            // 
            this.lblLoginFailed.AutoSize = true;
            this.lblLoginFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginFailed.ForeColor = System.Drawing.Color.Black;
            this.lblLoginFailed.Location = new System.Drawing.Point(143, 146);
            this.lblLoginFailed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginFailed.Name = "lblLoginFailed";
            this.lblLoginFailed.Size = new System.Drawing.Size(0, 17);
            this.lblLoginFailed.TabIndex = 6;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.White;
            this.btnResetPassword.Location = new System.Drawing.Point(324, 264);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(153, 33);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "&Reset Password ";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            this.btnResetPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnResetPassword_KeyDown);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(188, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 33);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnExit_KeyDown);
            // 
            // lblProgramLogoTwo
            // 
            this.lblProgramLogoTwo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblProgramLogoTwo.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramLogoTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProgramLogoTwo.Location = new System.Drawing.Point(30, 0);
            this.lblProgramLogoTwo.Name = "lblProgramLogoTwo";
            this.lblProgramLogoTwo.Size = new System.Drawing.Size(144, 43);
            this.lblProgramLogoTwo.TabIndex = 9;
            this.lblProgramLogoTwo.Text = "mprint";
            // 
            // lblProgramLogoOne
            // 
            this.lblProgramLogoOne.BackColor = System.Drawing.Color.Cyan;
            this.lblProgramLogoOne.Font = new System.Drawing.Font("Microsoft Uighur", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramLogoOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProgramLogoOne.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProgramLogoOne.Location = new System.Drawing.Point(8, 0);
            this.lblProgramLogoOne.Name = "lblProgramLogoOne";
            this.lblProgramLogoOne.Size = new System.Drawing.Size(29, 43);
            this.lblProgramLogoOne.TabIndex = 10;
            this.lblProgramLogoOne.Text = "i";
            // 
            // btnHelpLoginForm
            // 
            this.btnHelpLoginForm.Location = new System.Drawing.Point(382, 11);
            this.btnHelpLoginForm.Name = "btnHelpLoginForm";
            this.btnHelpLoginForm.Size = new System.Drawing.Size(72, 31);
            this.btnHelpLoginForm.TabIndex = 11;
            this.btnHelpLoginForm.Text = "&Help";
            this.btnHelpLoginForm.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 318);
            this.Controls.Add(this.btnHelpLoginForm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.lblLoginFailed);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblPasswordlLabel);
            this.Controls.Add(this.lblLoginlabel);
            this.Controls.Add(this.lblProgramLogoTwo);
            this.Controls.Add(this.lblProgramLogoOne);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginlabel;
        private System.Windows.Forms.Label lblPasswordlLabel;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Label lblLoginFailed;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblProgramLogoTwo;
        private System.Windows.Forms.Label lblProgramLogoOne;
        private System.Windows.Forms.Button btnHelpLoginForm;
    }
}