
namespace SU21_Final_Project
{
    partial class frmAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEmployee));
            this.gbxInformation = new System.Windows.Forms.GroupBox();
            this.lblPositionLabel = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.mskHiredDate = new System.Windows.Forms.MaskedTextBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblRoleLabel = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.cboSuffix = new System.Windows.Forms.ComboBox();
            this.lblInfosOneLabel = new System.Windows.Forms.Label();
            this.lblFirstNameLabel = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastNameLabel = new System.Windows.Forms.Label();
            this.lblMiddleNameLabel = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.lblSuffixLabel = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.lblHiredDateLabel = new System.Windows.Forms.Label();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblCityLabel = new System.Windows.Forms.Label();
            this.tbxAddressOne = new System.Windows.Forms.TextBox();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.lblStateLabel = new System.Windows.Forms.Label();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.lblSalaryLabel = new System.Windows.Forms.Label();
            this.tbxZip = new System.Windows.Forms.TextBox();
            this.lblZipLabel = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInformation
            // 
            this.gbxInformation.BackColor = System.Drawing.SystemColors.Control;
            this.gbxInformation.Controls.Add(this.lblPositionLabel);
            this.gbxInformation.Controls.Add(this.cboPosition);
            this.gbxInformation.Controls.Add(this.mskHiredDate);
            this.gbxInformation.Controls.Add(this.mskPhone);
            this.gbxInformation.Controls.Add(this.lblRoleLabel);
            this.gbxInformation.Controls.Add(this.cboRole);
            this.gbxInformation.Controls.Add(this.cboState);
            this.gbxInformation.Controls.Add(this.cboSuffix);
            this.gbxInformation.Controls.Add(this.lblInfosOneLabel);
            this.gbxInformation.Controls.Add(this.lblFirstNameLabel);
            this.gbxInformation.Controls.Add(this.tbxLastName);
            this.gbxInformation.Controls.Add(this.tbxFirstName);
            this.gbxInformation.Controls.Add(this.lblLastNameLabel);
            this.gbxInformation.Controls.Add(this.lblMiddleNameLabel);
            this.gbxInformation.Controls.Add(this.lblEmailLabel);
            this.gbxInformation.Controls.Add(this.lblSuffixLabel);
            this.gbxInformation.Controls.Add(this.tbxEmail);
            this.gbxInformation.Controls.Add(this.tbxMiddleName);
            this.gbxInformation.Controls.Add(this.lblHiredDateLabel);
            this.gbxInformation.Controls.Add(this.lblPhoneLabel);
            this.gbxInformation.Controls.Add(this.tbxCity);
            this.gbxInformation.Controls.Add(this.lblCityLabel);
            this.gbxInformation.Controls.Add(this.tbxAddressOne);
            this.gbxInformation.Controls.Add(this.lblAddressLabel);
            this.gbxInformation.Controls.Add(this.lblStateLabel);
            this.gbxInformation.Controls.Add(this.tbxSalary);
            this.gbxInformation.Controls.Add(this.lblSalaryLabel);
            this.gbxInformation.Controls.Add(this.tbxZip);
            this.gbxInformation.Controls.Add(this.lblZipLabel);
            this.gbxInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInformation.Location = new System.Drawing.Point(3, 12);
            this.gbxInformation.Name = "gbxInformation";
            this.gbxInformation.Size = new System.Drawing.Size(795, 286);
            this.gbxInformation.TabIndex = 45;
            this.gbxInformation.TabStop = false;
            this.gbxInformation.Text = "Information";
            // 
            // lblPositionLabel
            // 
            this.lblPositionLabel.AutoSize = true;
            this.lblPositionLabel.Location = new System.Drawing.Point(621, 70);
            this.lblPositionLabel.Name = "lblPositionLabel";
            this.lblPositionLabel.Size = new System.Drawing.Size(63, 17);
            this.lblPositionLabel.TabIndex = 55;
            this.lblPositionLabel.Text = "*Position";
            // 
            // cboPosition
            // 
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Items.AddRange(new object[] {
            "Manager",
            "Clerk",
            "Technician"});
            this.cboPosition.Location = new System.Drawing.Point(685, 66);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(78, 24);
            this.cboPosition.TabIndex = 54;
            // 
            // mskHiredDate
            // 
            this.mskHiredDate.Location = new System.Drawing.Point(501, 184);
            this.mskHiredDate.Mask = "00/00/0000";
            this.mskHiredDate.Name = "mskHiredDate";
            this.mskHiredDate.Size = new System.Drawing.Size(100, 22);
            this.mskHiredDate.TabIndex = 53;
            this.mskHiredDate.ValidatingType = typeof(System.DateTime);
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(501, 146);
            this.mskPhone.Mask = "000-000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(89, 22);
            this.mskPhone.TabIndex = 52;
            // 
            // lblRoleLabel
            // 
            this.lblRoleLabel.AutoSize = true;
            this.lblRoleLabel.Location = new System.Drawing.Point(437, 73);
            this.lblRoleLabel.Name = "lblRoleLabel";
            this.lblRoleLabel.Size = new System.Drawing.Size(42, 17);
            this.lblRoleLabel.TabIndex = 51;
            this.lblRoleLabel.Text = "*Role";
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboRole.Location = new System.Drawing.Point(501, 69);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(78, 24);
            this.cboRole.TabIndex = 50;
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "AK",
            "AS",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FM",
            "FL",
            "GA",
            "GU",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MH",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "MP",
            "OH",
            "OK",
            "OR",
            "PW",
            "PA",
            "PR",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VI",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cboState.Location = new System.Drawing.Point(444, 248);
            this.cboState.MaxLength = 3;
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(63, 24);
            this.cboState.TabIndex = 12;
            // 
            // cboSuffix
            // 
            this.cboSuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuffix.FormattingEnabled = true;
            this.cboSuffix.Items.AddRange(new object[] {
            "Mrs",
            "Mr",
            "Ms"});
            this.cboSuffix.Location = new System.Drawing.Point(133, 162);
            this.cboSuffix.Name = "cboSuffix";
            this.cboSuffix.Size = new System.Drawing.Size(78, 24);
            this.cboSuffix.TabIndex = 3;
            // 
            // lblInfosOneLabel
            // 
            this.lblInfosOneLabel.AutoSize = true;
            this.lblInfosOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfosOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfosOneLabel.Location = new System.Drawing.Point(667, 18);
            this.lblInfosOneLabel.Name = "lblInfosOneLabel";
            this.lblInfosOneLabel.Size = new System.Drawing.Size(122, 17);
            this.lblInfosOneLabel.TabIndex = 46;
            this.lblInfosOneLabel.Text = "(*)Required Fields";
            // 
            // lblFirstNameLabel
            // 
            this.lblFirstNameLabel.AutoSize = true;
            this.lblFirstNameLabel.Location = new System.Drawing.Point(41, 46);
            this.lblFirstNameLabel.Name = "lblFirstNameLabel";
            this.lblFirstNameLabel.Size = new System.Drawing.Size(81, 17);
            this.lblFirstNameLabel.TabIndex = 2;
            this.lblFirstNameLabel.Text = "*First Name";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(133, 124);
            this.tbxLastName.MaxLength = 20;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(165, 22);
            this.tbxLastName.TabIndex = 2;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(133, 42);
            this.tbxFirstName.MaxLength = 20;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(165, 22);
            this.tbxFirstName.TabIndex = 0;
            // 
            // lblLastNameLabel
            // 
            this.lblLastNameLabel.AutoSize = true;
            this.lblLastNameLabel.Location = new System.Drawing.Point(41, 126);
            this.lblLastNameLabel.Name = "lblLastNameLabel";
            this.lblLastNameLabel.Size = new System.Drawing.Size(81, 17);
            this.lblLastNameLabel.TabIndex = 3;
            this.lblLastNameLabel.Text = "*Last Name";
            // 
            // lblMiddleNameLabel
            // 
            this.lblMiddleNameLabel.AutoSize = true;
            this.lblMiddleNameLabel.Location = new System.Drawing.Point(32, 88);
            this.lblMiddleNameLabel.Name = "lblMiddleNameLabel";
            this.lblMiddleNameLabel.Size = new System.Drawing.Size(90, 17);
            this.lblMiddleNameLabel.TabIndex = 4;
            this.lblMiddleNameLabel.Text = "Middle Name";
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Location = new System.Drawing.Point(385, 37);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(103, 17);
            this.lblEmailLabel.TabIndex = 38;
            this.lblEmailLabel.Text = "*Email Address";
            // 
            // lblSuffixLabel
            // 
            this.lblSuffixLabel.AutoSize = true;
            this.lblSuffixLabel.Location = new System.Drawing.Point(80, 161);
            this.lblSuffixLabel.Name = "lblSuffixLabel";
            this.lblSuffixLabel.Size = new System.Drawing.Size(42, 17);
            this.lblSuffixLabel.TabIndex = 5;
            this.lblSuffixLabel.Text = "Suffix";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(501, 35);
            this.tbxEmail.MaxLength = 40;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(165, 22);
            this.tbxEmail.TabIndex = 5;
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Location = new System.Drawing.Point(133, 84);
            this.tbxMiddleName.MaxLength = 20;
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(165, 22);
            this.tbxMiddleName.TabIndex = 1;
            // 
            // lblHiredDateLabel
            // 
            this.lblHiredDateLabel.AutoSize = true;
            this.lblHiredDateLabel.Location = new System.Drawing.Point(414, 189);
            this.lblHiredDateLabel.Name = "lblHiredDateLabel";
            this.lblHiredDateLabel.Size = new System.Drawing.Size(85, 17);
            this.lblHiredDateLabel.TabIndex = 36;
            this.lblHiredDateLabel.Text = "*Hired Date ";
            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.Location = new System.Drawing.Point(422, 146);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(58, 17);
            this.lblPhoneLabel.TabIndex = 34;
            this.lblPhoneLabel.Text = "*Phone ";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(133, 246);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(144, 22);
            this.tbxCity.TabIndex = 11;
            // 
            // lblCityLabel
            // 
            this.lblCityLabel.AutoSize = true;
            this.lblCityLabel.Location = new System.Drawing.Point(94, 248);
            this.lblCityLabel.Name = "lblCityLabel";
            this.lblCityLabel.Size = new System.Drawing.Size(36, 17);
            this.lblCityLabel.TabIndex = 11;
            this.lblCityLabel.Text = "*City";
            // 
            // tbxAddressOne
            // 
            this.tbxAddressOne.Location = new System.Drawing.Point(133, 202);
            this.tbxAddressOne.MaxLength = 30;
            this.tbxAddressOne.Name = "tbxAddressOne";
            this.tbxAddressOne.Size = new System.Drawing.Size(269, 22);
            this.tbxAddressOne.TabIndex = 6;
            // 
            // lblAddressLabel
            // 
            this.lblAddressLabel.AutoSize = true;
            this.lblAddressLabel.Location = new System.Drawing.Point(41, 202);
            this.lblAddressLabel.Name = "lblAddressLabel";
            this.lblAddressLabel.Size = new System.Drawing.Size(77, 17);
            this.lblAddressLabel.TabIndex = 13;
            this.lblAddressLabel.Text = "*Address 1";
            // 
            // lblStateLabel
            // 
            this.lblStateLabel.AutoSize = true;
            this.lblStateLabel.Location = new System.Drawing.Point(395, 252);
            this.lblStateLabel.Name = "lblStateLabel";
            this.lblStateLabel.Size = new System.Drawing.Size(46, 17);
            this.lblStateLabel.TabIndex = 15;
            this.lblStateLabel.Text = "*State";
            // 
            // tbxSalary
            // 
            this.tbxSalary.Location = new System.Drawing.Point(501, 105);
            this.tbxSalary.MaxLength = 30;
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(158, 22);
            this.tbxSalary.TabIndex = 8;
            // 
            // lblSalaryLabel
            // 
            this.lblSalaryLabel.AutoSize = true;
            this.lblSalaryLabel.Location = new System.Drawing.Point(427, 108);
            this.lblSalaryLabel.Name = "lblSalaryLabel";
            this.lblSalaryLabel.Size = new System.Drawing.Size(53, 17);
            this.lblSalaryLabel.TabIndex = 19;
            this.lblSalaryLabel.Text = "*Salary";
            // 
            // tbxZip
            // 
            this.tbxZip.Location = new System.Drawing.Point(550, 250);
            this.tbxZip.MaxLength = 5;
            this.tbxZip.Name = "tbxZip";
            this.tbxZip.Size = new System.Drawing.Size(94, 22);
            this.tbxZip.TabIndex = 13;
            // 
            // lblZipLabel
            // 
            this.lblZipLabel.AutoSize = true;
            this.lblZipLabel.Location = new System.Drawing.Point(511, 250);
            this.lblZipLabel.Name = "lblZipLabel";
            this.lblZipLabel.Size = new System.Drawing.Size(33, 17);
            this.lblZipLabel.TabIndex = 21;
            this.lblZipLabel.Text = "*Zip";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(152, 317);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 31);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(483, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 31);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 359);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEmployee_FormClosing);
            this.gbxInformation.ResumeLayout(false);
            this.gbxInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInformation;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.ComboBox cboSuffix;
        private System.Windows.Forms.Label lblInfosOneLabel;
        private System.Windows.Forms.Label lblFirstNameLabel;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblLastNameLabel;
        private System.Windows.Forms.Label lblMiddleNameLabel;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.Label lblSuffixLabel;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.Label lblHiredDateLabel;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblCityLabel;
        private System.Windows.Forms.TextBox tbxAddressOne;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.Label lblStateLabel;
        private System.Windows.Forms.Label lblSalaryLabel;
        private System.Windows.Forms.TextBox tbxZip;
        private System.Windows.Forms.Label lblZipLabel;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRoleLabel;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.MaskedTextBox mskHiredDate;
        private System.Windows.Forms.Label lblPositionLabel;
        private System.Windows.Forms.ComboBox cboPosition;
    }
}