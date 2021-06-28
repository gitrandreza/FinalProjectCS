
namespace SU21_Final_Project
{
    partial class frmResetPassword
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
            this.label16 = new System.Windows.Forms.Label();
            this.tbxIdol = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxDog = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxDrink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblValidAnswers = new System.Windows.Forms.Label();
            this.lblInvalidAnswers = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxEnterUsername = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(115, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "*Who is your idol?";
            // 
            // tbxIdol
            // 
            this.tbxIdol.Location = new System.Drawing.Point(254, 204);
            this.tbxIdol.Name = "tbxIdol";
            this.tbxIdol.Size = new System.Drawing.Size(165, 22);
            this.tbxIdol.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(226, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "*What is your favorite type of dog?";
            // 
            // tbxDog
            // 
            this.tbxDog.Location = new System.Drawing.Point(254, 156);
            this.tbxDog.Name = "tbxDog";
            this.tbxDog.Size = new System.Drawing.Size(165, 22);
            this.tbxDog.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "*What is your favorite drink?";
            // 
            // tbxDrink
            // 
            this.tbxDrink.Location = new System.Drawing.Point(254, 109);
            this.tbxDrink.Name = "tbxDrink";
            this.tbxDrink.Size = new System.Drawing.Size(165, 22);
            this.tbxDrink.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Please answer these 3 questions to reset your password";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(276, 242);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(143, 23);
            this.btnCheck.TabIndex = 39;
            this.btnCheck.Text = "&Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblValidAnswers
            // 
            this.lblValidAnswers.AutoSize = true;
            this.lblValidAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblValidAnswers.Location = new System.Drawing.Point(230, 301);
            this.lblValidAnswers.Name = "lblValidAnswers";
            this.lblValidAnswers.Size = new System.Drawing.Size(213, 17);
            this.lblValidAnswers.TabIndex = 40;
            this.lblValidAnswers.Text = "Please enter your new password";
            this.lblValidAnswers.Visible = false;
            // 
            // lblInvalidAnswers
            // 
            this.lblInvalidAnswers.AutoSize = true;
            this.lblInvalidAnswers.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidAnswers.Location = new System.Drawing.Point(114, 284);
            this.lblInvalidAnswers.Name = "lblInvalidAnswers";
            this.lblInvalidAnswers.Size = new System.Drawing.Size(418, 17);
            this.lblInvalidAnswers.TabIndex = 41;
            this.lblInvalidAnswers.Text = "Sorry, one or more of your answers don\'t match.Please try again.";
            this.lblInvalidAnswers.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(99, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "Enter New Password";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Enabled = false;
            this.tbxNewPassword.Location = new System.Drawing.Point(254, 332);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(165, 22);
            this.tbxNewPassword.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(113, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Enter Username";
            // 
            // tbxEnterUsername
            // 
            this.tbxEnterUsername.Location = new System.Drawing.Point(254, 35);
            this.tbxEnterUsername.Name = "tbxEnterUsername";
            this.tbxEnterUsername.Size = new System.Drawing.Size(165, 22);
            this.tbxEnterUsername.TabIndex = 44;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(51, 248);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(46, 17);
            this.lblMessage.TabIndex = 46;
            this.lblMessage.Text = "label2";
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.Enabled = false;
            this.btnNewPassword.Location = new System.Drawing.Point(276, 369);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(143, 29);
            this.btnNewPassword.TabIndex = 47;
            this.btnNewPassword.Text = "&Save Password";
            this.btnNewPassword.UseVisualStyleBackColor = true;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 421);
            this.Controls.Add(this.btnNewPassword);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxEnterUsername);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.lblInvalidAnswers);
            this.Controls.Add(this.lblValidAnswers);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbxIdol);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbxDog);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbxDrink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResetPassword";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxIdol;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxDog;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblValidAnswers;
        private System.Windows.Forms.Label lblInvalidAnswers;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxEnterUsername;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnNewPassword;
    }
}