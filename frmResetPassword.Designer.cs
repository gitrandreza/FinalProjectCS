
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetPassword));
            this.lblQuestionThree = new System.Windows.Forms.Label();
            this.tbxIdol = new System.Windows.Forms.TextBox();
            this.lblQuestionTwo = new System.Windows.Forms.Label();
            this.tbxDog = new System.Windows.Forms.TextBox();
            this.lblQuestionOne = new System.Windows.Forms.Label();
            this.tbxDrink = new System.Windows.Forms.TextBox();
            this.lblMessageText = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblValidAnswers = new System.Windows.Forms.Label();
            this.lblInvalidAnswers = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.lblUsernameLabel = new System.Windows.Forms.Label();
            this.tbxEnterUsername = new System.Windows.Forms.TextBox();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.lblPasswordRules3 = new System.Windows.Forms.Label();
            this.lblPasswordRules1 = new System.Windows.Forms.Label();
            this.lblPasswordRules2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestionThree
            // 
            this.lblQuestionThree.AutoSize = true;
            this.lblQuestionThree.BackColor = System.Drawing.Color.White;
            this.lblQuestionThree.Location = new System.Drawing.Point(124, 240);
            this.lblQuestionThree.Name = "lblQuestionThree";
            this.lblQuestionThree.Size = new System.Drawing.Size(122, 17);
            this.lblQuestionThree.TabIndex = 37;
            this.lblQuestionThree.Text = "*Who is your idol?";
            // 
            // tbxIdol
            // 
            this.tbxIdol.Location = new System.Drawing.Point(270, 240);
            this.tbxIdol.Name = "tbxIdol";
            this.tbxIdol.Size = new System.Drawing.Size(165, 22);
            this.tbxIdol.TabIndex = 3;
            // 
            // lblQuestionTwo
            // 
            this.lblQuestionTwo.AutoSize = true;
            this.lblQuestionTwo.BackColor = System.Drawing.Color.White;
            this.lblQuestionTwo.Location = new System.Drawing.Point(20, 192);
            this.lblQuestionTwo.Name = "lblQuestionTwo";
            this.lblQuestionTwo.Size = new System.Drawing.Size(226, 17);
            this.lblQuestionTwo.TabIndex = 35;
            this.lblQuestionTwo.Text = "*What is your favorite type of dog?";
            // 
            // tbxDog
            // 
            this.tbxDog.Location = new System.Drawing.Point(270, 192);
            this.tbxDog.Name = "tbxDog";
            this.tbxDog.Size = new System.Drawing.Size(165, 22);
            this.tbxDog.TabIndex = 2;
            // 
            // lblQuestionOne
            // 
            this.lblQuestionOne.AutoSize = true;
            this.lblQuestionOne.BackColor = System.Drawing.Color.White;
            this.lblQuestionOne.Location = new System.Drawing.Point(60, 148);
            this.lblQuestionOne.Name = "lblQuestionOne";
            this.lblQuestionOne.Size = new System.Drawing.Size(186, 17);
            this.lblQuestionOne.TabIndex = 33;
            this.lblQuestionOne.Text = "*What is your favorite drink?";
            // 
            // tbxDrink
            // 
            this.tbxDrink.Location = new System.Drawing.Point(270, 145);
            this.tbxDrink.Name = "tbxDrink";
            this.tbxDrink.Size = new System.Drawing.Size(165, 22);
            this.tbxDrink.TabIndex = 1;
            // 
            // lblMessageText
            // 
            this.lblMessageText.AutoSize = true;
            this.lblMessageText.BackColor = System.Drawing.Color.White;
            this.lblMessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageText.Location = new System.Drawing.Point(115, 115);
            this.lblMessageText.Name = "lblMessageText";
            this.lblMessageText.Size = new System.Drawing.Size(457, 17);
            this.lblMessageText.TabIndex = 38;
            this.lblMessageText.Text = "Please answer the 3 questions below to verify you information";
            this.lblMessageText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "&Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCheck_KeyDown);
            // 
            // lblValidAnswers
            // 
            this.lblValidAnswers.AutoSize = true;
            this.lblValidAnswers.ForeColor = System.Drawing.Color.ForestGreen;
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
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(31, 364);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(112, 17);
            this.lblNewPassword.TabIndex = 43;
            this.lblNewPassword.Text = "New Password";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.BackColor = System.Drawing.Color.White;
            this.tbxNewPassword.Enabled = false;
            this.tbxNewPassword.Location = new System.Drawing.Point(14, 384);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(165, 22);
            this.tbxNewPassword.TabIndex = 5;
            this.tbxNewPassword.UseSystemPasswordChar = true;
            // 
            // lblUsernameLabel
            // 
            this.lblUsernameLabel.AutoSize = true;
            this.lblUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameLabel.Location = new System.Drawing.Point(122, 60);
            this.lblUsernameLabel.Name = "lblUsernameLabel";
            this.lblUsernameLabel.Size = new System.Drawing.Size(125, 17);
            this.lblUsernameLabel.TabIndex = 45;
            this.lblUsernameLabel.Text = "Enter Username";
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
            this.btnNewPassword.Location = new System.Drawing.Point(340, 515);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(136, 30);
            this.btnNewPassword.TabIndex = 7;
            this.btnNewPassword.Text = "&Save Password";
            this.btnNewPassword.UseVisualStyleBackColor = false;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            this.btnNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNewPassword_KeyDown);
            // 
            // lblPasswordRules3
            // 
            this.lblPasswordRules3.AutoSize = true;
            this.lblPasswordRules3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordRules3.ForeColor = System.Drawing.Color.Blue;
            this.lblPasswordRules3.Location = new System.Drawing.Point(217, 432);
            this.lblPasswordRules3.Name = "lblPasswordRules3";
            this.lblPasswordRules3.Size = new System.Drawing.Size(318, 17);
            this.lblPasswordRules3.TabIndex = 50;
            this.lblPasswordRules3.Text = "Must contain one special character and no space";
            // 
            // lblPasswordRules1
            // 
            this.lblPasswordRules1.AutoSize = true;
            this.lblPasswordRules1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordRules1.ForeColor = System.Drawing.Color.Blue;
            this.lblPasswordRules1.Location = new System.Drawing.Point(217, 398);
            this.lblPasswordRules1.Name = "lblPasswordRules1";
            this.lblPasswordRules1.Size = new System.Drawing.Size(246, 17);
            this.lblPasswordRules1.TabIndex = 48;
            this.lblPasswordRules1.Text = "Must be between 8 and 20 characters";
            // 
            // lblPasswordRules2
            // 
            this.lblPasswordRules2.AutoSize = true;
            this.lblPasswordRules2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordRules2.ForeColor = System.Drawing.Color.Blue;
            this.lblPasswordRules2.Location = new System.Drawing.Point(217, 415);
            this.lblPasswordRules2.Name = "lblPasswordRules2";
            this.lblPasswordRules2.Size = new System.Drawing.Size(376, 17);
            this.lblPasswordRules2.TabIndex = 49;
            this.lblPasswordRules2.Text = "Must contains one digit, one upper case or one lower case";
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
            this.btnBack.Location = new System.Drawing.Point(93, 515);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(102, 30);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBack_KeyDown);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(23, 439);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(137, 17);
            this.lblConfirmPassword.TabIndex = 54;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.BackColor = System.Drawing.Color.White;
            this.tbxConfirmPassword.Location = new System.Drawing.Point(14, 459);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(165, 22);
            this.tbxConfirmPassword.TabIndex = 6;
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
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPasswordRules3);
            this.Controls.Add(this.lblPasswordRules1);
            this.Controls.Add(this.lblPasswordRules2);
            this.Controls.Add(this.btnNewPassword);
            this.Controls.Add(this.lblUsernameLabel);
            this.Controls.Add(this.tbxEnterUsername);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.lblInvalidAnswers);
            this.Controls.Add(this.lblValidAnswers);
            this.Controls.Add(this.lblMessageText);
            this.Controls.Add(this.lblQuestionThree);
            this.Controls.Add(this.tbxIdol);
            this.Controls.Add(this.lblQuestionTwo);
            this.Controls.Add(this.tbxDog);
            this.Controls.Add(this.lblQuestionOne);
            this.Controls.Add(this.tbxDrink);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmResetPassword";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmResetPassword_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionThree;
        private System.Windows.Forms.TextBox tbxIdol;
        private System.Windows.Forms.Label lblQuestionTwo;
        private System.Windows.Forms.TextBox tbxDog;
        private System.Windows.Forms.Label lblQuestionOne;
        private System.Windows.Forms.TextBox tbxDrink;
        private System.Windows.Forms.Label lblMessageText;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblValidAnswers;
        private System.Windows.Forms.Label lblInvalidAnswers;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Label lblUsernameLabel;
        private System.Windows.Forms.TextBox tbxEnterUsername;
        private System.Windows.Forms.Button btnNewPassword;
        private System.Windows.Forms.Label lblPasswordRules3;
        private System.Windows.Forms.Label lblPasswordRules1;
        private System.Windows.Forms.Label lblPasswordRules2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}