
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
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(124, 240);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "*Who is your idol?";
            // 
            // tbxIdol
            // 
            this.tbxIdol.Location = new System.Drawing.Point(270, 240);
            this.tbxIdol.Name = "tbxIdol";
            this.tbxIdol.Size = new System.Drawing.Size(165, 22);
            this.tbxIdol.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(20, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(226, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "*What is your favorite type of dog?";
            // 
            // tbxDog
            // 
            this.tbxDog.Location = new System.Drawing.Point(270, 192);
            this.tbxDog.Name = "tbxDog";
            this.tbxDog.Size = new System.Drawing.Size(165, 22);
            this.tbxDog.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(60, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "*What is your favorite drink?";
            // 
            // tbxDrink
            // 
            this.tbxDrink.Location = new System.Drawing.Point(270, 145);
            this.tbxDrink.Name = "tbxDrink";
            this.tbxDrink.Size = new System.Drawing.Size(165, 22);
            this.tbxDrink.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Please answer the 3 questions below to verify you information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheck.Location = new System.Drawing.Point(278, 178);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(143, 30);
            this.btnCheck.TabIndex = 39;
            this.btnCheck.Text = "&Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblValidAnswers
            // 
            this.lblValidAnswers.AutoSize = true;
            this.lblValidAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblValidAnswers.Location = new System.Drawing.Point(210, 349);
            this.lblValidAnswers.Name = "lblValidAnswers";
            this.lblValidAnswers.Size = new System.Drawing.Size(253, 17);
            this.lblValidAnswers.TabIndex = 40;
            this.lblValidAnswers.Text = "Please enter your new password below";
            this.lblValidAnswers.Visible = false;
            // 
            // lblInvalidAnswers
            // 
            this.lblInvalidAnswers.AutoSize = true;
            this.lblInvalidAnswers.BackColor = System.Drawing.Color.White;
            this.lblInvalidAnswers.ForeColor = System.Drawing.Color.Red;
            this.lblInvalidAnswers.Location = new System.Drawing.Point(124, 311);
            this.lblInvalidAnswers.Name = "lblInvalidAnswers";
            this.lblInvalidAnswers.Size = new System.Drawing.Size(418, 17);
            this.lblInvalidAnswers.TabIndex = 41;
            this.lblInvalidAnswers.Text = "Sorry, one or more of your answers don\'t match.Please try again.";
            this.lblInvalidAnswers.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "New Password";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.BackColor = System.Drawing.Color.White;
            this.tbxNewPassword.Enabled = false;
            this.tbxNewPassword.Location = new System.Drawing.Point(167, 388);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(165, 22);
            this.tbxNewPassword.TabIndex = 4;
            this.tbxNewPassword.UseSystemPasswordChar = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(122, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 17);
            this.label12.TabIndex = 45;
            this.label12.Text = "Enter Username";
            // 
            // tbxEnterUsername
            // 
            this.tbxEnterUsername.Location = new System.Drawing.Point(270, 60);
            this.tbxEnterUsername.Name = "tbxEnterUsername";
            this.tbxEnterUsername.Size = new System.Drawing.Size(165, 22);
            this.tbxEnterUsername.TabIndex = 0;
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewPassword.Location = new System.Drawing.Point(270, 489);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(136, 30);
            this.btnNewPassword.TabIndex = 47;
            this.btnNewPassword.Text = "&Save Password";
            this.btnNewPassword.UseVisualStyleBackColor = false;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(339, 414);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(236, 13);
            this.label23.TabIndex = 50;
            this.label23.Text = "Must contain one special character and no space";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(339, 381);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(185, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Must be between 8 and 14 characters";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(339, 397);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(274, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "Must contains one digit, one upper case , one lower case";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Location = new System.Drawing.Point(-1, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 244);
            this.panel1.TabIndex = 51;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(23, 489);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 30);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Confirm Password";
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.BackColor = System.Drawing.Color.White;
            this.tbxConfirmPassword.Location = new System.Drawing.Point(167, 431);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(165, 22);
            this.tbxConfirmPassword.TabIndex = 5;
            this.tbxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(26, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 43);
            this.label3.TabIndex = 55;
            this.label3.Text = "mprint ";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 43);
            this.label4.TabIndex = 56;
            this.label4.Text = "i";
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnNewPassword);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxEnterUsername);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.lblInvalidAnswers);
            this.Controls.Add(this.lblValidAnswers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbxIdol);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbxDog);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbxDrink);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmResetPassword";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResetPassword";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnNewPassword;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}