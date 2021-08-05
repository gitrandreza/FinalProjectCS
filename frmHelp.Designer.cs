
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tabHelp = new System.Windows.Forms.TabControl();
            this.tabLoginHelp = new System.Windows.Forms.TabPage();
            this.tabSignUp = new System.Windows.Forms.TabPage();
            this.tabResetPassword = new System.Windows.Forms.TabPage();
            this.tabHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.BorderSize = 4;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Sienna;
            this.btnClose.Location = new System.Drawing.Point(3, 622);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(734, 64);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabHelp
            // 
            this.tabHelp.Controls.Add(this.tabLoginHelp);
            this.tabHelp.Controls.Add(this.tabSignUp);
            this.tabHelp.Controls.Add(this.tabResetPassword);
            this.tabHelp.Location = new System.Drawing.Point(7, 2);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.SelectedIndex = 0;
            this.tabHelp.Size = new System.Drawing.Size(720, 588);
            this.tabHelp.TabIndex = 6;
            // 
            // tabLoginHelp
            // 
            this.tabLoginHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabLoginHelp.BackgroundImage")));
            this.tabLoginHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabLoginHelp.Location = new System.Drawing.Point(4, 25);
            this.tabLoginHelp.Name = "tabLoginHelp";
            this.tabLoginHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoginHelp.Size = new System.Drawing.Size(712, 559);
            this.tabLoginHelp.TabIndex = 0;
            this.tabLoginHelp.Text = "Login Form Help";
            this.tabLoginHelp.UseVisualStyleBackColor = true;
            // 
            // tabSignUp
            // 
            this.tabSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabSignUp.BackgroundImage")));
            this.tabSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabSignUp.Location = new System.Drawing.Point(4, 25);
            this.tabSignUp.Name = "tabSignUp";
            this.tabSignUp.Padding = new System.Windows.Forms.Padding(3);
            this.tabSignUp.Size = new System.Drawing.Size(712, 559);
            this.tabSignUp.TabIndex = 1;
            this.tabSignUp.Text = "Sign Up Form Help";
            this.tabSignUp.UseVisualStyleBackColor = true;
            // 
            // tabResetPassword
            // 
            this.tabResetPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabResetPassword.BackgroundImage")));
            this.tabResetPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabResetPassword.Location = new System.Drawing.Point(4, 25);
            this.tabResetPassword.Name = "tabResetPassword";
            this.tabResetPassword.Size = new System.Drawing.Size(712, 559);
            this.tabResetPassword.TabIndex = 2;
            this.tabResetPassword.Text = "Reset Password Form Help";
            this.tabResetPassword.UseVisualStyleBackColor = true;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(736, 685);
            this.Controls.Add(this.tabHelp);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHelp_FormClosing);
            this.tabHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabHelp;
        private System.Windows.Forms.TabPage tabLoginHelp;
        private System.Windows.Forms.TabPage tabSignUp;
        private System.Windows.Forms.TabPage tabResetPassword;
    }
}