
namespace SU21_Final_Project
{
    partial class frmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstNameLabel = new System.Windows.Forms.Label();
            this.lblLastNameLabel = new System.Windows.Forms.Label();
            this.lblMiddleNameLabel = new System.Windows.Forms.Label();
            this.lblSuffixLabel = new System.Windows.Forms.Label();
            this.tbxMiddleName = new System.Windows.Forms.TextBox();
            this.lblCityLabel = new System.Windows.Forms.Label();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.tbxAddressOne = new System.Windows.Forms.TextBox();
            this.lblStateLabel = new System.Windows.Forms.Label();
            this.lblAddressTwoLabel = new System.Windows.Forms.Label();
            this.tbxAddressTwo = new System.Windows.Forms.TextBox();
            this.lblAddressThreeLabel = new System.Windows.Forms.Label();
            this.tbxAddressThree = new System.Windows.Forms.TextBox();
            this.lblZipLabel = new System.Windows.Forms.Label();
            this.tbxZip = new System.Windows.Forms.TextBox();
            this.lblCreateUsernameLabel = new System.Windows.Forms.Label();
            this.tbxCreateUsername = new System.Windows.Forms.TextBox();
            this.lblCreatePasswordLabel = new System.Windows.Forms.Label();
            this.tbxCreatePassword = new System.Windows.Forms.TextBox();
            this.lblQuestionOneLabel = new System.Windows.Forms.Label();
            this.tbxAnswerOne = new System.Windows.Forms.TextBox();
            this.lblQuestionTwoLabel = new System.Windows.Forms.Label();
            this.tbxAnswerTwo = new System.Windows.Forms.TextBox();
            this.lblQuestionThreeLabel = new System.Windows.Forms.Label();
            this.tbxAnswerThree = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.lblPhoneTwoLabel = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblPasswordRulesOne = new System.Windows.Forms.Label();
            this.lblPasswordRulesTwo = new System.Windows.Forms.Label();
            this.lblPasswordRulesThree = new System.Windows.Forms.Label();
            this.gbxInformation = new System.Windows.Forms.GroupBox();
            this.mskPhone2 = new System.Windows.Forms.MaskedTextBox();
            this.mskPhone1 = new System.Windows.Forms.MaskedTextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.cboSuffix = new System.Windows.Forms.ComboBox();
            this.lblInfosOneLabel = new System.Windows.Forms.Label();
            this.gbxSecurityQuestion = new System.Windows.Forms.GroupBox();
            this.gbxCreateLogin = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHelpSignUp = new System.Windows.Forms.Button();
            this.gbxInformation.SuspendLayout();
            this.gbxSecurityQuestion.SuspendLayout();
            this.gbxCreateLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(145, 108);
            this.tbxLastName.MaxLength = 20;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(165, 22);
            this.tbxLastName.TabIndex = 2;
            this.tbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastName_KeyPress);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(145, 26);
            this.tbxFirstName.MaxLength = 20;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(165, 22);
            this.tbxFirstName.TabIndex = 0;
            this.tbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFirstName_KeyPress);
            // 
            // lblFirstNameLabel
            // 
            this.lblFirstNameLabel.AutoSize = true;
            this.lblFirstNameLabel.Location = new System.Drawing.Point(53, 30);
            this.lblFirstNameLabel.Name = "lblFirstNameLabel";
            this.lblFirstNameLabel.Size = new System.Drawing.Size(92, 17);
            this.lblFirstNameLabel.TabIndex = 2;
            this.lblFirstNameLabel.Text = "*First Name";
            // 
            // lblLastNameLabel
            // 
            this.lblLastNameLabel.AutoSize = true;
            this.lblLastNameLabel.Location = new System.Drawing.Point(53, 110);
            this.lblLastNameLabel.Name = "lblLastNameLabel";
            this.lblLastNameLabel.Size = new System.Drawing.Size(91, 17);
            this.lblLastNameLabel.TabIndex = 3;
            this.lblLastNameLabel.Text = "*Last Name";
            // 
            // lblMiddleNameLabel
            // 
            this.lblMiddleNameLabel.AutoSize = true;
            this.lblMiddleNameLabel.Location = new System.Drawing.Point(44, 72);
            this.lblMiddleNameLabel.Name = "lblMiddleNameLabel";
            this.lblMiddleNameLabel.Size = new System.Drawing.Size(101, 17);
            this.lblMiddleNameLabel.TabIndex = 4;
            this.lblMiddleNameLabel.Text = "Middle Name";
            // 
            // lblSuffixLabel
            // 
            this.lblSuffixLabel.AutoSize = true;
            this.lblSuffixLabel.Location = new System.Drawing.Point(92, 145);
            this.lblSuffixLabel.Name = "lblSuffixLabel";
            this.lblSuffixLabel.Size = new System.Drawing.Size(48, 17);
            this.lblSuffixLabel.TabIndex = 5;
            this.lblSuffixLabel.Text = "Suffix";
            // 
            // tbxMiddleName
            // 
            this.tbxMiddleName.Location = new System.Drawing.Point(145, 68);
            this.tbxMiddleName.MaxLength = 20;
            this.tbxMiddleName.Name = "tbxMiddleName";
            this.tbxMiddleName.Size = new System.Drawing.Size(165, 22);
            this.tbxMiddleName.TabIndex = 1;
            // 
            // lblCityLabel
            // 
            this.lblCityLabel.AutoSize = true;
            this.lblCityLabel.Location = new System.Drawing.Point(468, 186);
            this.lblCityLabel.Name = "lblCityLabel";
            this.lblCityLabel.Size = new System.Drawing.Size(41, 17);
            this.lblCityLabel.TabIndex = 11;
            this.lblCityLabel.Text = "*City";
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(523, 184);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(144, 22);
            this.tbxCity.TabIndex = 11;
            // 
            // lblAddressLabel
            // 
            this.lblAddressLabel.AutoSize = true;
            this.lblAddressLabel.Location = new System.Drawing.Point(431, 71);
            this.lblAddressLabel.Name = "lblAddressLabel";
            this.lblAddressLabel.Size = new System.Drawing.Size(87, 17);
            this.lblAddressLabel.TabIndex = 13;
            this.lblAddressLabel.Text = "*Address 1";
            // 
            // tbxAddressOne
            // 
            this.tbxAddressOne.Location = new System.Drawing.Point(523, 71);
            this.tbxAddressOne.MaxLength = 30;
            this.tbxAddressOne.Name = "tbxAddressOne";
            this.tbxAddressOne.Size = new System.Drawing.Size(232, 22);
            this.tbxAddressOne.TabIndex = 6;
            // 
            // lblStateLabel
            // 
            this.lblStateLabel.AutoSize = true;
            this.lblStateLabel.Location = new System.Drawing.Point(460, 233);
            this.lblStateLabel.Name = "lblStateLabel";
            this.lblStateLabel.Size = new System.Drawing.Size(52, 17);
            this.lblStateLabel.TabIndex = 15;
            this.lblStateLabel.Text = "*State";
            // 
            // lblAddressTwoLabel
            // 
            this.lblAddressTwoLabel.AutoSize = true;
            this.lblAddressTwoLabel.Location = new System.Drawing.Point(436, 111);
            this.lblAddressTwoLabel.Name = "lblAddressTwoLabel";
            this.lblAddressTwoLabel.Size = new System.Drawing.Size(81, 17);
            this.lblAddressTwoLabel.TabIndex = 17;
            this.lblAddressTwoLabel.Text = "Address 2";
            // 
            // tbxAddressTwo
            // 
            this.tbxAddressTwo.Location = new System.Drawing.Point(523, 108);
            this.tbxAddressTwo.MaxLength = 30;
            this.tbxAddressTwo.Name = "tbxAddressTwo";
            this.tbxAddressTwo.Size = new System.Drawing.Size(232, 22);
            this.tbxAddressTwo.TabIndex = 7;
            // 
            // lblAddressThreeLabel
            // 
            this.lblAddressThreeLabel.AutoSize = true;
            this.lblAddressThreeLabel.Location = new System.Drawing.Point(436, 153);
            this.lblAddressThreeLabel.Name = "lblAddressThreeLabel";
            this.lblAddressThreeLabel.Size = new System.Drawing.Size(81, 17);
            this.lblAddressThreeLabel.TabIndex = 19;
            this.lblAddressThreeLabel.Text = "Address 3";
            // 
            // tbxAddressThree
            // 
            this.tbxAddressThree.Location = new System.Drawing.Point(523, 150);
            this.tbxAddressThree.MaxLength = 30;
            this.tbxAddressThree.Name = "tbxAddressThree";
            this.tbxAddressThree.Size = new System.Drawing.Size(232, 22);
            this.tbxAddressThree.TabIndex = 8;
            // 
            // lblZipLabel
            // 
            this.lblZipLabel.AutoSize = true;
            this.lblZipLabel.Location = new System.Drawing.Point(622, 229);
            this.lblZipLabel.Name = "lblZipLabel";
            this.lblZipLabel.Size = new System.Drawing.Size(37, 17);
            this.lblZipLabel.TabIndex = 21;
            this.lblZipLabel.Text = "*Zip";
            // 
            // tbxZip
            // 
            this.tbxZip.Location = new System.Drawing.Point(661, 229);
            this.tbxZip.MaxLength = 5;
            this.tbxZip.Name = "tbxZip";
            this.tbxZip.Size = new System.Drawing.Size(94, 22);
            this.tbxZip.TabIndex = 13;
            this.tbxZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxZip_KeyPress);
            // 
            // lblCreateUsernameLabel
            // 
            this.lblCreateUsernameLabel.AutoSize = true;
            this.lblCreateUsernameLabel.Location = new System.Drawing.Point(2, 51);
            this.lblCreateUsernameLabel.Name = "lblCreateUsernameLabel";
            this.lblCreateUsernameLabel.Size = new System.Drawing.Size(124, 17);
            this.lblCreateUsernameLabel.TabIndex = 23;
            this.lblCreateUsernameLabel.Text = "*Create Username";
            // 
            // tbxCreateUsername
            // 
            this.tbxCreateUsername.Location = new System.Drawing.Point(143, 51);
            this.tbxCreateUsername.Name = "tbxCreateUsername";
            this.tbxCreateUsername.Size = new System.Drawing.Size(165, 22);
            this.tbxCreateUsername.TabIndex = 14;
            // 
            // lblCreatePasswordLabel
            // 
            this.lblCreatePasswordLabel.AutoSize = true;
            this.lblCreatePasswordLabel.Location = new System.Drawing.Point(6, 102);
            this.lblCreatePasswordLabel.Name = "lblCreatePasswordLabel";
            this.lblCreatePasswordLabel.Size = new System.Drawing.Size(120, 17);
            this.lblCreatePasswordLabel.TabIndex = 25;
            this.lblCreatePasswordLabel.Text = "*Create Password";
            // 
            // tbxCreatePassword
            // 
            this.tbxCreatePassword.Location = new System.Drawing.Point(143, 99);
            this.tbxCreatePassword.Name = "tbxCreatePassword";
            this.tbxCreatePassword.Size = new System.Drawing.Size(165, 22);
            this.tbxCreatePassword.TabIndex = 15;
            this.tbxCreatePassword.UseSystemPasswordChar = true;
            // 
            // lblQuestionOneLabel
            // 
            this.lblQuestionOneLabel.AutoSize = true;
            this.lblQuestionOneLabel.Location = new System.Drawing.Point(45, 35);
            this.lblQuestionOneLabel.Name = "lblQuestionOneLabel";
            this.lblQuestionOneLabel.Size = new System.Drawing.Size(186, 17);
            this.lblQuestionOneLabel.TabIndex = 27;
            this.lblQuestionOneLabel.Text = "*What is your favorite drink?";
            // 
            // tbxAnswerOne
            // 
            this.tbxAnswerOne.Location = new System.Drawing.Point(242, 32);
            this.tbxAnswerOne.Name = "tbxAnswerOne";
            this.tbxAnswerOne.Size = new System.Drawing.Size(165, 22);
            this.tbxAnswerOne.TabIndex = 16;
            // 
            // lblQuestionTwoLabel
            // 
            this.lblQuestionTwoLabel.AutoSize = true;
            this.lblQuestionTwoLabel.Location = new System.Drawing.Point(5, 79);
            this.lblQuestionTwoLabel.Name = "lblQuestionTwoLabel";
            this.lblQuestionTwoLabel.Size = new System.Drawing.Size(226, 17);
            this.lblQuestionTwoLabel.TabIndex = 29;
            this.lblQuestionTwoLabel.Text = "*What is your favorite type of dog?";
            // 
            // tbxAnswerTwo
            // 
            this.tbxAnswerTwo.Location = new System.Drawing.Point(242, 79);
            this.tbxAnswerTwo.Name = "tbxAnswerTwo";
            this.tbxAnswerTwo.Size = new System.Drawing.Size(165, 22);
            this.tbxAnswerTwo.TabIndex = 17;
            // 
            // lblQuestionThreeLabel
            // 
            this.lblQuestionThreeLabel.AutoSize = true;
            this.lblQuestionThreeLabel.Location = new System.Drawing.Point(109, 127);
            this.lblQuestionThreeLabel.Name = "lblQuestionThreeLabel";
            this.lblQuestionThreeLabel.Size = new System.Drawing.Size(122, 17);
            this.lblQuestionThreeLabel.TabIndex = 31;
            this.lblQuestionThreeLabel.Text = "*Who is your idol?";
            // 
            // tbxAnswerThree
            // 
            this.tbxAnswerThree.Location = new System.Drawing.Point(242, 127);
            this.tbxAnswerThree.Name = "tbxAnswerThree";
            this.tbxAnswerThree.Size = new System.Drawing.Size(165, 22);
            this.tbxAnswerThree.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSave.Location = new System.Drawing.Point(2, 516);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(795, 46);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.Location = new System.Drawing.Point(59, 233);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(74, 17);
            this.lblPhoneLabel.TabIndex = 34;
            this.lblPhoneLabel.Text = "*Phone 1";
            // 
            // lblPhoneTwoLabel
            // 
            this.lblPhoneTwoLabel.AutoSize = true;
            this.lblPhoneTwoLabel.Location = new System.Drawing.Point(447, 33);
            this.lblPhoneTwoLabel.Name = "lblPhoneTwoLabel";
            this.lblPhoneTwoLabel.Size = new System.Drawing.Size(68, 17);
            this.lblPhoneTwoLabel.TabIndex = 36;
            this.lblPhoneTwoLabel.Text = "Phone 2";
            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Location = new System.Drawing.Point(29, 191);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(117, 17);
            this.lblEmailLabel.TabIndex = 38;
            this.lblEmailLabel.Text = "*Email Address";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(145, 189);
            this.tbxEmail.MaxLength = 40;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(165, 22);
            this.tbxEmail.TabIndex = 5;
            // 
            // lblPasswordRulesOne
            // 
            this.lblPasswordRulesOne.AutoSize = true;
            this.lblPasswordRulesOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordRulesOne.ForeColor = System.Drawing.Color.Blue;
            this.lblPasswordRulesOne.Location = new System.Drawing.Point(4, 137);
            this.lblPasswordRulesOne.Name = "lblPasswordRulesOne";
            this.lblPasswordRulesOne.Size = new System.Drawing.Size(246, 17);
            this.lblPasswordRulesOne.TabIndex = 41;
            this.lblPasswordRulesOne.Text = "Must be between 8 and 20 characters";
            // 
            // lblPasswordRulesTwo
            // 
            this.lblPasswordRulesTwo.AutoSize = true;
            this.lblPasswordRulesTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordRulesTwo.ForeColor = System.Drawing.Color.Blue;
            this.lblPasswordRulesTwo.Location = new System.Drawing.Point(3, 154);
            this.lblPasswordRulesTwo.Name = "lblPasswordRulesTwo";
            this.lblPasswordRulesTwo.Size = new System.Drawing.Size(376, 17);
            this.lblPasswordRulesTwo.TabIndex = 42;
            this.lblPasswordRulesTwo.Text = "Must contains one digit, one upper case or one lower case";
            // 
            // lblPasswordRulesThree
            // 
            this.lblPasswordRulesThree.AutoSize = true;
            this.lblPasswordRulesThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordRulesThree.ForeColor = System.Drawing.Color.Blue;
            this.lblPasswordRulesThree.Location = new System.Drawing.Point(2, 171);
            this.lblPasswordRulesThree.Name = "lblPasswordRulesThree";
            this.lblPasswordRulesThree.Size = new System.Drawing.Size(325, 17);
            this.lblPasswordRulesThree.TabIndex = 43;
            this.lblPasswordRulesThree.Text = "Must contains one special character and no space";
            // 
            // gbxInformation
            // 
            this.gbxInformation.BackColor = System.Drawing.Color.Transparent;
            this.gbxInformation.Controls.Add(this.mskPhone2);
            this.gbxInformation.Controls.Add(this.mskPhone1);
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
            this.gbxInformation.Controls.Add(this.lblPhoneTwoLabel);
            this.gbxInformation.Controls.Add(this.lblPhoneLabel);
            this.gbxInformation.Controls.Add(this.tbxCity);
            this.gbxInformation.Controls.Add(this.lblCityLabel);
            this.gbxInformation.Controls.Add(this.tbxAddressOne);
            this.gbxInformation.Controls.Add(this.lblAddressLabel);
            this.gbxInformation.Controls.Add(this.lblStateLabel);
            this.gbxInformation.Controls.Add(this.tbxAddressTwo);
            this.gbxInformation.Controls.Add(this.lblAddressTwoLabel);
            this.gbxInformation.Controls.Add(this.tbxAddressThree);
            this.gbxInformation.Controls.Add(this.lblAddressThreeLabel);
            this.gbxInformation.Controls.Add(this.tbxZip);
            this.gbxInformation.Controls.Add(this.lblZipLabel);
            this.gbxInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInformation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxInformation.Location = new System.Drawing.Point(2, 49);
            this.gbxInformation.Name = "gbxInformation";
            this.gbxInformation.Size = new System.Drawing.Size(795, 259);
            this.gbxInformation.TabIndex = 44;
            this.gbxInformation.TabStop = false;
            this.gbxInformation.Text = "Information";
            // 
            // mskPhone2
            // 
            this.mskPhone2.Location = new System.Drawing.Point(523, 30);
            this.mskPhone2.Mask = "000-000-0000";
            this.mskPhone2.Name = "mskPhone2";
            this.mskPhone2.Size = new System.Drawing.Size(100, 22);
            this.mskPhone2.TabIndex = 48;
            // 
            // mskPhone1
            // 
            this.mskPhone1.Location = new System.Drawing.Point(145, 231);
            this.mskPhone1.Mask = "000-000-0000";
            this.mskPhone1.Name = "mskPhone1";
            this.mskPhone1.Size = new System.Drawing.Size(100, 22);
            this.mskPhone1.TabIndex = 47;
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
            this.cboState.Location = new System.Drawing.Point(523, 229);
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
            this.cboSuffix.Location = new System.Drawing.Point(145, 146);
            this.cboSuffix.Name = "cboSuffix";
            this.cboSuffix.Size = new System.Drawing.Size(78, 24);
            this.cboSuffix.TabIndex = 3;
            // 
            // lblInfosOneLabel
            // 
            this.lblInfosOneLabel.AutoSize = true;
            this.lblInfosOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfosOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfosOneLabel.Location = new System.Drawing.Point(667, 18);
            this.lblInfosOneLabel.Name = "lblInfosOneLabel";
            this.lblInfosOneLabel.Size = new System.Drawing.Size(97, 17);
            this.lblInfosOneLabel.TabIndex = 46;
            this.lblInfosOneLabel.Text = "(*)Required ";
            // 
            // gbxSecurityQuestion
            // 
            this.gbxSecurityQuestion.BackColor = System.Drawing.Color.Transparent;
            this.gbxSecurityQuestion.Controls.Add(this.lblQuestionOneLabel);
            this.gbxSecurityQuestion.Controls.Add(this.tbxAnswerOne);
            this.gbxSecurityQuestion.Controls.Add(this.tbxAnswerTwo);
            this.gbxSecurityQuestion.Controls.Add(this.lblQuestionTwoLabel);
            this.gbxSecurityQuestion.Controls.Add(this.tbxAnswerThree);
            this.gbxSecurityQuestion.Controls.Add(this.lblQuestionThreeLabel);
            this.gbxSecurityQuestion.Location = new System.Drawing.Point(385, 309);
            this.gbxSecurityQuestion.Name = "gbxSecurityQuestion";
            this.gbxSecurityQuestion.Size = new System.Drawing.Size(412, 205);
            this.gbxSecurityQuestion.TabIndex = 45;
            this.gbxSecurityQuestion.TabStop = false;
            this.gbxSecurityQuestion.Text = "Security Question";
            // 
            // gbxCreateLogin
            // 
            this.gbxCreateLogin.BackColor = System.Drawing.Color.Transparent;
            this.gbxCreateLogin.Controls.Add(this.tbxCreateUsername);
            this.gbxCreateLogin.Controls.Add(this.lblCreateUsernameLabel);
            this.gbxCreateLogin.Controls.Add(this.tbxCreatePassword);
            this.gbxCreateLogin.Controls.Add(this.lblCreatePasswordLabel);
            this.gbxCreateLogin.Controls.Add(this.lblPasswordRulesThree);
            this.gbxCreateLogin.Controls.Add(this.lblPasswordRulesOne);
            this.gbxCreateLogin.Controls.Add(this.lblPasswordRulesTwo);
            this.gbxCreateLogin.Location = new System.Drawing.Point(2, 309);
            this.gbxCreateLogin.Name = "gbxCreateLogin";
            this.gbxCreateLogin.Size = new System.Drawing.Size(382, 205);
            this.gbxCreateLogin.TabIndex = 47;
            this.gbxCreateLogin.TabStop = false;
            this.gbxCreateLogin.Text = "Create Login Access";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 3;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnBack.Location = new System.Drawing.Point(2, 568);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(795, 43);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBack_KeyDown);
            // 
            // btnHelpSignUp
            // 
            this.btnHelpSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpSignUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHelpSignUp.FlatAppearance.BorderSize = 3;
            this.btnHelpSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpSignUp.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnHelpSignUp.Location = new System.Drawing.Point(690, 4);
            this.btnHelpSignUp.Name = "btnHelpSignUp";
            this.btnHelpSignUp.Size = new System.Drawing.Size(97, 46);
            this.btnHelpSignUp.TabIndex = 48;
            this.btnHelpSignUp.Text = "HELP?";
            this.btnHelpSignUp.UseVisualStyleBackColor = false;
            this.btnHelpSignUp.Click += new System.EventHandler(this.btnHelpSignUp_Click);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 615);
            this.Controls.Add(this.btnHelpSignUp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxCreateLogin);
            this.Controls.Add(this.gbxSecurityQuestion);
            this.Controls.Add(this.gbxInformation);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSignUp_FormClosing);
            this.gbxInformation.ResumeLayout(false);
            this.gbxInformation.PerformLayout();
            this.gbxSecurityQuestion.ResumeLayout(false);
            this.gbxSecurityQuestion.PerformLayout();
            this.gbxCreateLogin.ResumeLayout(false);
            this.gbxCreateLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblFirstNameLabel;
        private System.Windows.Forms.Label lblLastNameLabel;
        private System.Windows.Forms.Label lblMiddleNameLabel;
        private System.Windows.Forms.Label lblSuffixLabel;
        private System.Windows.Forms.TextBox tbxMiddleName;
        private System.Windows.Forms.Label lblCityLabel;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.TextBox tbxAddressOne;
        private System.Windows.Forms.Label lblStateLabel;
        private System.Windows.Forms.Label lblAddressTwoLabel;
        private System.Windows.Forms.TextBox tbxAddressTwo;
        private System.Windows.Forms.Label lblAddressThreeLabel;
        private System.Windows.Forms.TextBox tbxAddressThree;
        private System.Windows.Forms.Label lblZipLabel;
        private System.Windows.Forms.TextBox tbxZip;
        private System.Windows.Forms.Label lblCreateUsernameLabel;
        private System.Windows.Forms.TextBox tbxCreateUsername;
        private System.Windows.Forms.Label lblCreatePasswordLabel;
        private System.Windows.Forms.TextBox tbxCreatePassword;
        private System.Windows.Forms.Label lblQuestionOneLabel;
        private System.Windows.Forms.TextBox tbxAnswerOne;
        private System.Windows.Forms.Label lblQuestionTwoLabel;
        private System.Windows.Forms.TextBox tbxAnswerTwo;
        private System.Windows.Forms.Label lblQuestionThreeLabel;
        private System.Windows.Forms.TextBox tbxAnswerThree;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPhoneLabel;
        private System.Windows.Forms.Label lblPhoneTwoLabel;
        private System.Windows.Forms.Label lblEmailLabel;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblPasswordRulesOne;
        private System.Windows.Forms.Label lblPasswordRulesTwo;
        private System.Windows.Forms.Label lblPasswordRulesThree;
        private System.Windows.Forms.GroupBox gbxInformation;
        private System.Windows.Forms.GroupBox gbxSecurityQuestion;
        private System.Windows.Forms.Label lblInfosOneLabel;
        private System.Windows.Forms.ComboBox cboSuffix;
        private System.Windows.Forms.GroupBox gbxCreateLogin;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.MaskedTextBox mskPhone2;
        private System.Windows.Forms.MaskedTextBox mskPhone1;
        private System.Windows.Forms.Button btnHelpSignUp;
    }
}