
namespace SU21_Final_Project
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            this.pbxHelpLogin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbxHelpSignUp = new System.Windows.Forms.PictureBox();
            this.pbxHelpResetPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelpLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelpSignUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelpResetPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxHelpLogin
            // 
            this.pbxHelpLogin.ErrorImage = null;
            this.pbxHelpLogin.Image = ((System.Drawing.Image)(resources.GetObject("pbxHelpLogin.Image")));
            this.pbxHelpLogin.Location = new System.Drawing.Point(16, 12);
            this.pbxHelpLogin.Name = "pbxHelpLogin";
            this.pbxHelpLogin.Size = new System.Drawing.Size(691, 591);
            this.pbxHelpLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHelpLogin.TabIndex = 0;
            this.pbxHelpLogin.TabStop = false;
            this.pbxHelpLogin.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 3;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(7, 612);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(720, 66);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbxHelpSignUp
            // 
            this.pbxHelpSignUp.Image = ((System.Drawing.Image)(resources.GetObject("pbxHelpSignUp.Image")));
            this.pbxHelpSignUp.Location = new System.Drawing.Point(12, 3);
            this.pbxHelpSignUp.Name = "pbxHelpSignUp";
            this.pbxHelpSignUp.Size = new System.Drawing.Size(695, 562);
            this.pbxHelpSignUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHelpSignUp.TabIndex = 4;
            this.pbxHelpSignUp.TabStop = false;
            this.pbxHelpSignUp.Visible = false;
            // 
            // pbxHelpResetPassword
            // 
            this.pbxHelpResetPassword.Image = ((System.Drawing.Image)(resources.GetObject("pbxHelpResetPassword.Image")));
            this.pbxHelpResetPassword.Location = new System.Drawing.Point(20, 11);
            this.pbxHelpResetPassword.Name = "pbxHelpResetPassword";
            this.pbxHelpResetPassword.Size = new System.Drawing.Size(692, 563);
            this.pbxHelpResetPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHelpResetPassword.TabIndex = 5;
            this.pbxHelpResetPassword.TabStop = false;
            this.pbxHelpResetPassword.Visible = false;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(740, 691);
            this.Controls.Add(this.pbxHelpResetPassword);
            this.Controls.Add(this.pbxHelpSignUp);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbxHelpLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelpLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelpSignUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelpResetPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbxHelpSignUp;
        public System.Windows.Forms.PictureBox pbxHelpLogin;
        private System.Windows.Forms.PictureBox pbxHelpResetPassword;
    }
}