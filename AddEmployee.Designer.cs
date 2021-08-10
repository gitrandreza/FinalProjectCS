
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
            this.dtpEmployeeHiredDate = new System.Windows.Forms.DateTimePicker();
            this.lblPositionLabel = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
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
            this.btnHelpAddEmployee = new System.Windows.Forms.Button();
            this.gbxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInformation
            // 
            this.gbxInformation.BackColor = System.Drawing.Color.White;
            this.gbxInformation.Controls.Add(this.dtpEmployeeHiredDate);
            this.gbxInformation.Controls.Add(this.lblPositionLabel);
            this.gbxInformation.Controls.Add(this.cboPosition);
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
            this.gbxInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInformation.ForeColor = System.Drawing.Color.Black;
            this.gbxInformation.Location = new System.Drawing.Point(2, 46);
            this.gbxInformation.Name = "gbxInformation";
            this.gbxInformation.Size = new System.Drawing.Size(717, 296);
            this.gbxInformation.TabIndex = 45;
            this.gbxInformation.TabStop = false;
            this.gbxInformation.Text = "Add New Employee";
            // 
            // dtpEmployeeHiredDate
            // 
            this.dtpEmployeeHiredDate.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpEmployeeHiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmployeeHiredDate.Location = new System.Drawing.Point(484, 204);
            this.dtpEmployeeHiredDate.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtpEmployeeHiredDate.Name = "dtpEmployeeHiredDate";
            this.dtpEmployeeHiredDate.Size = new System.Drawing.Size(158, 22);
            this.dtpEmployeeHiredDate.TabIndex = 11;
            // 
            // lblPositionLabel
            // 
            this.lblPositionLabel.AutoSize = true;
            this.lblPositionLabel.Location = new System.Drawing.Point(536, 86);
            this.lblPositionLabel.Name = "lblPositionLabel";
            this.lblPositionLabel.Size = new System.Drawing.Size(72, 17);
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
            this.cboPosition.Location = new System.Drawing.Point(619, 81);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(78, 24);
            this.cboPosition.TabIndex = 8;
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(439, 161);
            this.mskPhone.Mask = "000-000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(89, 22);
            this.mskPhone.TabIndex = 10;
            // 
            // lblRoleLabel
            // 
            this.lblRoleLabel.AutoSize = true;
            this.lblRoleLabel.Location = new System.Drawing.Point(375, 88);
            this.lblRoleLabel.Name = "lblRoleLabel";
            this.lblRoleLabel.Size = new System.Drawing.Size(47, 17);
            this.lblRoleLabel.TabIndex = 51;
            this.lblRoleLabel.Text = "*Role";
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Manager",
            "Employee"});
            this.cboRole.Location = new System.Drawing.Point(439, 84);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(78, 24);
            this.cboRole.TabIndex = 7;
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.ItemHeight = 16;
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
            this.cboState.Location = new System.Drawing.Point(401, 264);
            this.cboState.MaxLength = 3;
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(63, 24);
            this.cboState.TabIndex = 12;
            // 
            // cboSuffix
            // 
            this.cboSuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuffix.FormattingEnabled = true;
            this.cboSuffix.ItemHeight = 16;
            this.cboSuffix.Items.AddRange(new object[] {
            "Mrs",
            "Mr",
            "Ms"});
            this.cboSuffix.Location = new System.Drawing.Point(133, 177);
            this.cboSuffix.Name = "cboSuffix";
            this.cboSuffix.Size = new System.Drawing.Size(78, 24);
            this.cboSuffix.TabIndex = 3;
            // 
            // lblInfosOneLabel
            // 
            this.lblInfosOneLabel.AutoSize = true;
            this.lblInfosOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfosOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfosOneLabel.Location = new System.Drawing.Point(605, 30);
            this.lblInfosOneLabel.Name = "lblInfosOneLabel";
            this.lblInfosOneLabel.Size = new System.Drawing.Size(92, 17);
            this.lblInfosOneLabel.TabIndex = 46;
            this.lblInfosOneLabel.Text = "(*)Required";
            // 
            // lblFirstNameLabel
            // 
            this.lblFirstNameLabel.AutoSize = true;
            this.lblFirstNameLabel.Location = new System.Drawing.Point(41, 61);
            this.lblFirstNameLabel.Name = "lblFirstNameLabel";
            this.lblFirstNameLabel.Size = new System.Drawing.Size(92, 17);
            this.lblFirstNameLabel.TabIndex = 2;
            this.lblFirstNameLabel.Text = "*First Name";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(140, 139);
            this.tbxLastName.MaxLength = 20;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(165, 22);
            this.tbxLastName.TabIndex = 2;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(140, 57);
            this.tbxFirstName.MaxLength = 20;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(165, 22);
            this.tbxFirstName.TabIndex = 0;
            // 
            // lblLastNameLabel
            // 
            this.lblLastNameLabel.AutoSize = true;
            this.lblLastNameLabel.Location = new System.Drawing.Point(41, 141);
            this.lblLastNameLabel.Name = "lblLastNameLabel";
            this.lblLastNameLabel.Size = new System.Drawing.Size(91, 17);
            this.lblLastNameLabel.TabIndex = 3;
            this.lblLastNameLabel.Text = "*Last Name";
            // 
            // lblMiddleNameLabel
            // 
            this.lblMiddleNameLabel.AutoSize = true;
            this.lblMiddleNameLabel.Location = new System.Drawing.Point(32, 103);
            this.lblMiddleNameLabel.Name = "lblMiddleNameLabel";
            this.lblMiddleNameLabel.Size = new System.Drawing.Size(101, 17);
            this.lblMiddleNameLabel.TabIndex = 4;
            this.lblMiddleNameLabel.Text = "Middle Name";
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Location = new System.Drawing.Point(369, 50);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(53, 17);
            this.lblEmailLabel.TabIndex = 38;
            this.lblEmailLabel.Text = "*Email";
            // 
            // lblSuffixLabel
            // 
            this.lblSuffixLabel.AutoSize = true;
            this.lblSuffixLabel.Location = new System.Drawing.Point(80, 176);
            this.lblSuffixLabel.Name = "lblSuffixLabel";
            this.lblSuffixLabel.Size = new System.Drawing.Size(48, 17);
            this.lblSuffixLabel.TabIndex = 5;
            this.lblSuffixLabel.Text = "Suffix";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(439, 50);
            this.tbxEmail.MaxLength = 40;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(165, 22);
            this.tbxEmail.TabIndex = 6;
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Location = new System.Drawing.Point(140, 99);
            this.tbxMiddleName.MaxLength = 20;
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(165, 22);
            this.tbxMiddleName.TabIndex = 1;
            // 
            // lblHiredDateLabel
            // 
            this.lblHiredDateLabel.AutoSize = true;
            this.lblHiredDateLabel.Location = new System.Drawing.Point(352, 204);
            this.lblHiredDateLabel.Name = "lblHiredDateLabel";
            this.lblHiredDateLabel.Size = new System.Drawing.Size(97, 17);
            this.lblHiredDateLabel.TabIndex = 36;
            this.lblHiredDateLabel.Text = "*Hired Date ";
            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.Location = new System.Drawing.Point(360, 161);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(65, 17);
            this.lblPhoneLabel.TabIndex = 34;
            this.lblPhoneLabel.Text = "*Phone ";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(133, 261);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(144, 22);
            this.tbxCity.TabIndex = 5;
            // 
            // lblCityLabel
            // 
            this.lblCityLabel.AutoSize = true;
            this.lblCityLabel.Location = new System.Drawing.Point(94, 263);
            this.lblCityLabel.Name = "lblCityLabel";
            this.lblCityLabel.Size = new System.Drawing.Size(41, 17);
            this.lblCityLabel.TabIndex = 11;
            this.lblCityLabel.Text = "*City";
            // 
            // tbxAddressOne
            // 
            this.tbxAddressOne.Location = new System.Drawing.Point(138, 217);
            this.tbxAddressOne.MaxLength = 30;
            this.tbxAddressOne.Name = "tbxAddressOne";
            this.tbxAddressOne.Size = new System.Drawing.Size(165, 22);
            this.tbxAddressOne.TabIndex = 4;
            // 
            // lblAddressLabel
            // 
            this.lblAddressLabel.AutoSize = true;
            this.lblAddressLabel.Location = new System.Drawing.Point(41, 217);
            this.lblAddressLabel.Name = "lblAddressLabel";
            this.lblAddressLabel.Size = new System.Drawing.Size(78, 17);
            this.lblAddressLabel.TabIndex = 13;
            this.lblAddressLabel.Text = "*Address ";
            // 
            // lblStateLabel
            // 
            this.lblStateLabel.AutoSize = true;
            this.lblStateLabel.Location = new System.Drawing.Point(333, 267);
            this.lblStateLabel.Name = "lblStateLabel";
            this.lblStateLabel.Size = new System.Drawing.Size(52, 17);
            this.lblStateLabel.TabIndex = 15;
            this.lblStateLabel.Text = "*State";
            // 
            // tbxSalary
            // 
            this.tbxSalary.Location = new System.Drawing.Point(439, 120);
            this.tbxSalary.MaxLength = 10;
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(158, 22);
            this.tbxSalary.TabIndex = 9;
            this.tbxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSalary_KeyPress);
            // 
            // lblSalaryLabel
            // 
            this.lblSalaryLabel.AutoSize = true;
            this.lblSalaryLabel.Location = new System.Drawing.Point(365, 123);
            this.lblSalaryLabel.Name = "lblSalaryLabel";
            this.lblSalaryLabel.Size = new System.Drawing.Size(60, 17);
            this.lblSalaryLabel.TabIndex = 19;
            this.lblSalaryLabel.Text = "*Salary";
            // 
            // tbxZip
            // 
            this.tbxZip.Location = new System.Drawing.Point(539, 264);
            this.tbxZip.MaxLength = 5;
            this.tbxZip.Name = "tbxZip";
            this.tbxZip.Size = new System.Drawing.Size(94, 22);
            this.tbxZip.TabIndex = 13;
            this.tbxZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxZip_KeyPress_1);
            // 
            // lblZipLabel
            // 
            this.lblZipLabel.AutoSize = true;
            this.lblZipLabel.Location = new System.Drawing.Point(491, 266);
            this.lblZipLabel.Name = "lblZipLabel";
            this.lblZipLabel.Size = new System.Drawing.Size(37, 17);
            this.lblZipLabel.TabIndex = 21;
            this.lblZipLabel.Text = "*Zip";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(2, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(717, 66);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(2, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(717, 62);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHelpAddEmployee
            // 
            this.btnHelpAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpAddEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelpAddEmployee.BackgroundImage")));
            this.btnHelpAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpAddEmployee.FlatAppearance.BorderSize = 3;
            this.btnHelpAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpAddEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHelpAddEmployee.Location = new System.Drawing.Point(604, 1);
            this.btnHelpAddEmployee.Name = "btnHelpAddEmployee";
            this.btnHelpAddEmployee.Size = new System.Drawing.Size(109, 43);
            this.btnHelpAddEmployee.TabIndex = 16;
            this.btnHelpAddEmployee.Text = "HELP?";
            this.btnHelpAddEmployee.UseVisualStyleBackColor = false;
            this.btnHelpAddEmployee.Click += new System.EventHandler(this.btnHelpAddEmployee_Click);
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(722, 484);
            this.Controls.Add(this.btnHelpAddEmployee);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
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
        private System.Windows.Forms.Label lblPositionLabel;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.DateTimePicker dtpEmployeeHiredDate;
        private System.Windows.Forms.Button btnHelpAddEmployee;
    }
}