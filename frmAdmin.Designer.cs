
namespace SU21_Final_Project
{
    partial class frmAdmin
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
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.gbxEdit = new System.Windows.Forms.GroupBox();
            this.cbxStates = new System.Windows.Forms.CheckBox();
            this.cbxEditPhone = new System.Windows.Forms.CheckBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.mskPhones = new System.Windows.Forms.MaskedTextBox();
            this.cbxLastName = new System.Windows.Forms.CheckBox();
            this.cbxAddress = new System.Windows.Forms.CheckBox();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.cbxFirstName = new System.Windows.Forms.CheckBox();
            this.cbxCity = new System.Windows.Forms.CheckBox();
            this.cbxEmail = new System.Windows.Forms.CheckBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxZip = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.cbxZip = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHiredDate = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblSalaryLabel = new System.Windows.Forms.Label();
            this.lblPositionLabel = new System.Windows.Forms.Label();
            this.lblHiredDateLabel = new System.Windows.Forms.Label();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.gbxUpdateField = new System.Windows.Forms.GroupBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboSupplierID = new System.Windows.Forms.ComboBox();
            this.cbxCategoryID = new System.Windows.Forms.CheckBox();
            this.cbxSupplierID = new System.Windows.Forms.CheckBox();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.cbxDescription = new System.Windows.Forms.CheckBox();
            this.cbxRetailPrice = new System.Windows.Forms.CheckBox();
            this.tbxRetailPrice = new System.Windows.Forms.TextBox();
            this.cbxCost = new System.Windows.Forms.CheckBox();
            this.cbxQuantity = new System.Windows.Forms.CheckBox();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.cbxName = new System.Windows.Forms.CheckBox();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.dgvAllProducts = new System.Windows.Forms.DataGridView();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.tabManagerFeatures = new System.Windows.Forms.TabControl();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLowItemLabel = new System.Windows.Forms.Label();
            this.dgvLowItem = new System.Windows.Forms.DataGridView();
            this.tabSalesReport = new System.Windows.Forms.TabPage();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.dgvSalesDetails = new System.Windows.Forms.DataGridView();
            this.lblSalesReportLabel = new System.Windows.Forms.Label();
            this.lblSalesDetailLabel = new System.Windows.Forms.Label();
            this.tabEmployee.SuspendLayout();
            this.gbxEdit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tabInventory.SuspendLayout();
            this.gbxUpdateField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).BeginInit();
            this.tabManagerFeatures.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowItem)).BeginInit();
            this.tabSalesReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.gbxEdit);
            this.tabEmployee.Controls.Add(this.groupBox1);
            this.tabEmployee.Controls.Add(this.btnRemoveEmployee);
            this.tabEmployee.Controls.Add(this.btnAddEmployee);
            this.tabEmployee.Controls.Add(this.btnEditEmployee);
            this.tabEmployee.Controls.Add(this.dgvEmployee);
            this.tabEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1097, 522);
            this.tabEmployee.TabIndex = 1;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // gbxEdit
            // 
            this.gbxEdit.Controls.Add(this.cbxStates);
            this.gbxEdit.Controls.Add(this.cbxEditPhone);
            this.gbxEdit.Controls.Add(this.btnSaveEdit);
            this.gbxEdit.Controls.Add(this.tbxAddress);
            this.gbxEdit.Controls.Add(this.mskPhones);
            this.gbxEdit.Controls.Add(this.cbxLastName);
            this.gbxEdit.Controls.Add(this.cbxAddress);
            this.gbxEdit.Controls.Add(this.cboStates);
            this.gbxEdit.Controls.Add(this.tbxLastName);
            this.gbxEdit.Controls.Add(this.tbxCity);
            this.gbxEdit.Controls.Add(this.cbxFirstName);
            this.gbxEdit.Controls.Add(this.cbxCity);
            this.gbxEdit.Controls.Add(this.cbxEmail);
            this.gbxEdit.Controls.Add(this.tbxFirstName);
            this.gbxEdit.Controls.Add(this.tbxZip);
            this.gbxEdit.Controls.Add(this.tbxEmail);
            this.gbxEdit.Controls.Add(this.cbxZip);
            this.gbxEdit.Enabled = false;
            this.gbxEdit.Location = new System.Drawing.Point(19, 309);
            this.gbxEdit.Name = "gbxEdit";
            this.gbxEdit.Size = new System.Drawing.Size(695, 213);
            this.gbxEdit.TabIndex = 57;
            this.gbxEdit.TabStop = false;
            this.gbxEdit.Text = "Edit Fields";
            // 
            // cbxStates
            // 
            this.cbxStates.AutoSize = true;
            this.cbxStates.Location = new System.Drawing.Point(385, 102);
            this.cbxStates.Name = "cbxStates";
            this.cbxStates.Size = new System.Drawing.Size(70, 21);
            this.cbxStates.TabIndex = 57;
            this.cbxStates.Text = "States";
            this.cbxStates.UseVisualStyleBackColor = true;
            this.cbxStates.CheckedChanged += new System.EventHandler(this.cbxStates_CheckedChanged_1);
            // 
            // cbxEditPhone
            // 
            this.cbxEditPhone.AutoSize = true;
            this.cbxEditPhone.Location = new System.Drawing.Point(385, 66);
            this.cbxEditPhone.Name = "cbxEditPhone";
            this.cbxEditPhone.Size = new System.Drawing.Size(79, 21);
            this.cbxEditPhone.TabIndex = 56;
            this.cbxEditPhone.Text = "Phone#";
            this.cbxEditPhone.UseVisualStyleBackColor = true;
            this.cbxEditPhone.CheckedChanged += new System.EventHandler(this.cbxEditPhone_CheckedChanged);
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(318, 173);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(103, 34);
            this.btnSaveEdit.TabIndex = 16;
            this.btnSaveEdit.Text = "&Save Edit";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // tbxAddress
            // 
            this.tbxAddress.Enabled = false;
            this.tbxAddress.Location = new System.Drawing.Point(138, 99);
            this.tbxAddress.MaxLength = 50;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(181, 22);
            this.tbxAddress.TabIndex = 43;
            // 
            // mskPhones
            // 
            this.mskPhones.Enabled = false;
            this.mskPhones.Location = new System.Drawing.Point(482, 64);
            this.mskPhones.Mask = "000-000-0000";
            this.mskPhones.Name = "mskPhones";
            this.mskPhones.Size = new System.Drawing.Size(100, 22);
            this.mskPhones.TabIndex = 55;
            // 
            // cbxLastName
            // 
            this.cbxLastName.AutoSize = true;
            this.cbxLastName.Location = new System.Drawing.Point(17, 64);
            this.cbxLastName.Name = "cbxLastName";
            this.cbxLastName.Size = new System.Drawing.Size(98, 21);
            this.cbxLastName.TabIndex = 40;
            this.cbxLastName.Text = "Last Name";
            this.cbxLastName.UseVisualStyleBackColor = true;
            this.cbxLastName.CheckedChanged += new System.EventHandler(this.cbxLastName_CheckedChanged_1);
            // 
            // cbxAddress
            // 
            this.cbxAddress.AutoSize = true;
            this.cbxAddress.Location = new System.Drawing.Point(16, 99);
            this.cbxAddress.Name = "cbxAddress";
            this.cbxAddress.Size = new System.Drawing.Size(82, 21);
            this.cbxAddress.TabIndex = 44;
            this.cbxAddress.Text = "Address";
            this.cbxAddress.UseVisualStyleBackColor = true;
            this.cbxAddress.CheckedChanged += new System.EventHandler(this.cbxAddress_CheckedChanged_1);
            // 
            // cboStates
            // 
            this.cboStates.Enabled = false;
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Items.AddRange(new object[] {
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
            this.cboStates.Location = new System.Drawing.Point(482, 99);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(89, 24);
            this.cboStates.TabIndex = 54;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Enabled = false;
            this.tbxLastName.Location = new System.Drawing.Point(140, 64);
            this.tbxLastName.MaxLength = 30;
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(181, 22);
            this.tbxLastName.TabIndex = 39;
            this.tbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastName_KeyPress);
            // 
            // tbxCity
            // 
            this.tbxCity.Enabled = false;
            this.tbxCity.Location = new System.Drawing.Point(138, 134);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(181, 22);
            this.tbxCity.TabIndex = 47;
            // 
            // cbxFirstName
            // 
            this.cbxFirstName.AutoSize = true;
            this.cbxFirstName.Location = new System.Drawing.Point(16, 27);
            this.cbxFirstName.Name = "cbxFirstName";
            this.cbxFirstName.Size = new System.Drawing.Size(98, 21);
            this.cbxFirstName.TabIndex = 17;
            this.cbxFirstName.Text = "First Name";
            this.cbxFirstName.UseVisualStyleBackColor = true;
            this.cbxFirstName.CheckedChanged += new System.EventHandler(this.cbxFirstName_CheckedChanged_1);
            // 
            // cbxCity
            // 
            this.cbxCity.AutoSize = true;
            this.cbxCity.Location = new System.Drawing.Point(16, 134);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(53, 21);
            this.cbxCity.TabIndex = 48;
            this.cbxCity.Text = "City";
            this.cbxCity.UseVisualStyleBackColor = true;
            this.cbxCity.CheckedChanged += new System.EventHandler(this.cbxCity_CheckedChanged);
            // 
            // cbxEmail
            // 
            this.cbxEmail.AutoSize = true;
            this.cbxEmail.Location = new System.Drawing.Point(385, 27);
            this.cbxEmail.Name = "cbxEmail";
            this.cbxEmail.Size = new System.Drawing.Size(64, 21);
            this.cbxEmail.TabIndex = 52;
            this.cbxEmail.Text = "Email";
            this.cbxEmail.UseVisualStyleBackColor = true;
            this.cbxEmail.CheckedChanged += new System.EventHandler(this.cbxEmail_CheckedChanged);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Enabled = false;
            this.tbxFirstName.Location = new System.Drawing.Point(138, 27);
            this.tbxFirstName.MaxLength = 30;
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(183, 22);
            this.tbxFirstName.TabIndex = 15;
            this.tbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFirstName_KeyPress);
            // 
            // tbxZip
            // 
            this.tbxZip.Enabled = false;
            this.tbxZip.Location = new System.Drawing.Point(482, 134);
            this.tbxZip.MaxLength = 5;
            this.tbxZip.Name = "tbxZip";
            this.tbxZip.Size = new System.Drawing.Size(97, 22);
            this.tbxZip.TabIndex = 49;
            this.tbxZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxZip_KeyPress);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Enabled = false;
            this.tbxEmail.Location = new System.Drawing.Point(482, 27);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(145, 22);
            this.tbxEmail.TabIndex = 51;
            // 
            // cbxZip
            // 
            this.cbxZip.AutoSize = true;
            this.cbxZip.Location = new System.Drawing.Point(388, 135);
            this.cbxZip.Name = "cbxZip";
            this.cbxZip.Size = new System.Drawing.Size(50, 21);
            this.cbxZip.TabIndex = 50;
            this.cbxZip.Text = "Zip";
            this.cbxZip.UseVisualStyleBackColor = true;
            this.cbxZip.CheckedChanged += new System.EventHandler(this.cbxZip_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHiredDate);
            this.groupBox1.Controls.Add(this.lblSalary);
            this.groupBox1.Controls.Add(this.lblPosition);
            this.groupBox1.Controls.Add(this.lblSalaryLabel);
            this.groupBox1.Controls.Add(this.lblPositionLabel);
            this.groupBox1.Controls.Add(this.lblHiredDateLabel);
            this.groupBox1.Location = new System.Drawing.Point(737, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 223);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Additional Information";
            // 
            // lblHiredDate
            // 
            this.lblHiredDate.AutoSize = true;
            this.lblHiredDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHiredDate.Location = new System.Drawing.Point(171, 26);
            this.lblHiredDate.Name = "lblHiredDate";
            this.lblHiredDate.Size = new System.Drawing.Size(2, 19);
            this.lblHiredDate.TabIndex = 5;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalary.Location = new System.Drawing.Point(171, 86);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(2, 19);
            this.lblSalary.TabIndex = 4;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosition.Location = new System.Drawing.Point(171, 150);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(2, 19);
            this.lblPosition.TabIndex = 3;
            // 
            // lblSalaryLabel
            // 
            this.lblSalaryLabel.AutoSize = true;
            this.lblSalaryLabel.Location = new System.Drawing.Point(33, 86);
            this.lblSalaryLabel.Name = "lblSalaryLabel";
            this.lblSalaryLabel.Size = new System.Drawing.Size(48, 17);
            this.lblSalaryLabel.TabIndex = 2;
            this.lblSalaryLabel.Text = "Salary";
            // 
            // lblPositionLabel
            // 
            this.lblPositionLabel.AutoSize = true;
            this.lblPositionLabel.Location = new System.Drawing.Point(33, 150);
            this.lblPositionLabel.Name = "lblPositionLabel";
            this.lblPositionLabel.Size = new System.Drawing.Size(62, 17);
            this.lblPositionLabel.TabIndex = 1;
            this.lblPositionLabel.Text = "Position:";
            // 
            // lblHiredDateLabel
            // 
            this.lblHiredDateLabel.AutoSize = true;
            this.lblHiredDateLabel.Location = new System.Drawing.Point(33, 26);
            this.lblHiredDateLabel.Name = "lblHiredDateLabel";
            this.lblHiredDateLabel.Size = new System.Drawing.Size(80, 17);
            this.lblHiredDateLabel.TabIndex = 0;
            this.lblHiredDateLabel.Text = "Hired Date:";
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(309, 260);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(137, 33);
            this.btnRemoveEmployee.TabIndex = 15;
            this.btnRemoveEmployee.Text = "&Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(136, 260);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(137, 33);
            this.btnAddEmployee.TabIndex = 14;
            this.btnAddEmployee.Text = "&Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(479, 260);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(137, 33);
            this.btnEditEmployee.TabIndex = 13;
            this.btnEditEmployee.Text = "&Edit ";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(8, 22);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(706, 223);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            this.dgvEmployee.SelectionChanged += new System.EventHandler(this.dgvEmployee_SelectionChanged_1);
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.dgvLowItem);
            this.tabInventory.Controls.Add(this.lblLowItemLabel);
            this.tabInventory.Controls.Add(this.gbxUpdateField);
            this.tabInventory.Controls.Add(this.btnRemoveItem);
            this.tabInventory.Controls.Add(this.btnAddItems);
            this.tabInventory.Controls.Add(this.dgvAllProducts);
            this.tabInventory.Controls.Add(this.btnUpdateItem);
            this.tabInventory.Location = new System.Drawing.Point(4, 25);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(1097, 522);
            this.tabInventory.TabIndex = 0;
            this.tabInventory.Text = "Inventory Control";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // gbxUpdateField
            // 
            this.gbxUpdateField.Controls.Add(this.cboCategory);
            this.gbxUpdateField.Controls.Add(this.cboSupplierID);
            this.gbxUpdateField.Controls.Add(this.cbxCategoryID);
            this.gbxUpdateField.Controls.Add(this.cbxSupplierID);
            this.gbxUpdateField.Controls.Add(this.tbxDescription);
            this.gbxUpdateField.Controls.Add(this.cbxDescription);
            this.gbxUpdateField.Controls.Add(this.cbxRetailPrice);
            this.gbxUpdateField.Controls.Add(this.tbxRetailPrice);
            this.gbxUpdateField.Controls.Add(this.cbxCost);
            this.gbxUpdateField.Controls.Add(this.cbxQuantity);
            this.gbxUpdateField.Controls.Add(this.tbxCost);
            this.gbxUpdateField.Controls.Add(this.tbxQuantity);
            this.gbxUpdateField.Controls.Add(this.cbxName);
            this.gbxUpdateField.Controls.Add(this.btnSaveUpdate);
            this.gbxUpdateField.Controls.Add(this.tbxName);
            this.gbxUpdateField.Enabled = false;
            this.gbxUpdateField.Location = new System.Drawing.Point(20, 249);
            this.gbxUpdateField.Name = "gbxUpdateField";
            this.gbxUpdateField.Size = new System.Drawing.Size(797, 203);
            this.gbxUpdateField.TabIndex = 13;
            this.gbxUpdateField.TabStop = false;
            this.gbxUpdateField.Text = "Update Fields";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Enabled = false;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboCategory.Location = new System.Drawing.Point(408, 149);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(101, 24);
            this.cboCategory.TabIndex = 38;
            // 
            // cboSupplierID
            // 
            this.cboSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplierID.Enabled = false;
            this.cboSupplierID.FormattingEnabled = true;
            this.cboSupplierID.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSupplierID.Location = new System.Drawing.Point(657, 149);
            this.cboSupplierID.Name = "cboSupplierID";
            this.cboSupplierID.Size = new System.Drawing.Size(80, 24);
            this.cboSupplierID.TabIndex = 37;
            // 
            // cbxCategoryID
            // 
            this.cbxCategoryID.AutoSize = true;
            this.cbxCategoryID.Location = new System.Drawing.Point(307, 152);
            this.cbxCategoryID.Name = "cbxCategoryID";
            this.cbxCategoryID.Size = new System.Drawing.Size(95, 21);
            this.cbxCategoryID.TabIndex = 36;
            this.cbxCategoryID.Text = "Category#";
            this.cbxCategoryID.UseVisualStyleBackColor = true;
            this.cbxCategoryID.CheckedChanged += new System.EventHandler(this.cbxCategoryID_CheckedChanged);
            // 
            // cbxSupplierID
            // 
            this.cbxSupplierID.AutoSize = true;
            this.cbxSupplierID.Location = new System.Drawing.Point(561, 153);
            this.cbxSupplierID.Name = "cbxSupplierID";
            this.cbxSupplierID.Size = new System.Drawing.Size(90, 21);
            this.cbxSupplierID.TabIndex = 35;
            this.cbxSupplierID.Text = "Supplier#";
            this.cbxSupplierID.UseVisualStyleBackColor = true;
            this.cbxSupplierID.CheckedChanged += new System.EventHandler(this.cbxSupplierID_CheckedChanged);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Enabled = false;
            this.tbxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescription.Location = new System.Drawing.Point(409, 35);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDescription.Size = new System.Drawing.Size(236, 92);
            this.tbxDescription.TabIndex = 34;
            // 
            // cbxDescription
            // 
            this.cbxDescription.AutoSize = true;
            this.cbxDescription.Location = new System.Drawing.Point(307, 37);
            this.cbxDescription.Name = "cbxDescription";
            this.cbxDescription.Size = new System.Drawing.Size(101, 21);
            this.cbxDescription.TabIndex = 23;
            this.cbxDescription.Text = "Description";
            this.cbxDescription.UseVisualStyleBackColor = true;
            this.cbxDescription.CheckedChanged += new System.EventHandler(this.cbxDescription_CheckedChanged);
            // 
            // cbxRetailPrice
            // 
            this.cbxRetailPrice.AutoSize = true;
            this.cbxRetailPrice.Location = new System.Drawing.Point(10, 152);
            this.cbxRetailPrice.Name = "cbxRetailPrice";
            this.cbxRetailPrice.Size = new System.Drawing.Size(102, 21);
            this.cbxRetailPrice.TabIndex = 21;
            this.cbxRetailPrice.Text = "Retail Price";
            this.cbxRetailPrice.UseVisualStyleBackColor = true;
            this.cbxRetailPrice.CheckedChanged += new System.EventHandler(this.cbxRetailPrice_CheckedChanged);
            // 
            // tbxRetailPrice
            // 
            this.tbxRetailPrice.Enabled = false;
            this.tbxRetailPrice.Location = new System.Drawing.Point(112, 152);
            this.tbxRetailPrice.Name = "tbxRetailPrice";
            this.tbxRetailPrice.Size = new System.Drawing.Size(142, 22);
            this.tbxRetailPrice.TabIndex = 20;
            // 
            // cbxCost
            // 
            this.cbxCost.AutoSize = true;
            this.cbxCost.Location = new System.Drawing.Point(10, 115);
            this.cbxCost.Name = "cbxCost";
            this.cbxCost.Size = new System.Drawing.Size(58, 21);
            this.cbxCost.TabIndex = 19;
            this.cbxCost.Text = "Cost";
            this.cbxCost.UseVisualStyleBackColor = true;
            this.cbxCost.CheckedChanged += new System.EventHandler(this.cbxCost_CheckedChanged);
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.AutoSize = true;
            this.cbxQuantity.Location = new System.Drawing.Point(10, 76);
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(112, 21);
            this.cbxQuantity.TabIndex = 19;
            this.cbxQuantity.Text = "Add Quantity";
            this.cbxQuantity.UseVisualStyleBackColor = true;
            this.cbxQuantity.CheckedChanged += new System.EventHandler(this.cbxQuantity_CheckedChanged);
            // 
            // tbxCost
            // 
            this.tbxCost.Enabled = false;
            this.tbxCost.Location = new System.Drawing.Point(111, 115);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(142, 22);
            this.tbxCost.TabIndex = 18;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Enabled = false;
            this.tbxQuantity.Location = new System.Drawing.Point(142, 74);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(111, 22);
            this.tbxQuantity.TabIndex = 18;
            // 
            // cbxName
            // 
            this.cbxName.AutoSize = true;
            this.cbxName.Location = new System.Drawing.Point(10, 39);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(67, 21);
            this.cbxName.TabIndex = 17;
            this.cbxName.Text = "Name";
            this.cbxName.UseVisualStyleBackColor = true;
            this.cbxName.CheckedChanged += new System.EventHandler(this.cbxName_CheckedChanged);
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.Location = new System.Drawing.Point(657, 64);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(103, 34);
            this.btnSaveUpdate.TabIndex = 16;
            this.btnSaveUpdate.Text = "&Save Change";
            this.btnSaveUpdate.UseVisualStyleBackColor = true;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // tbxName
            // 
            this.tbxName.Enabled = false;
            this.tbxName.Location = new System.Drawing.Point(111, 39);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(142, 22);
            this.tbxName.TabIndex = 15;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(567, 188);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(122, 38);
            this.btnRemoveItem.TabIndex = 12;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(73, 188);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(121, 37);
            this.btnAddItems.TabIndex = 3;
            this.btnAddItems.Text = "Add New Items";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            this.btnAddItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAddItems_KeyDown);
            // 
            // dgvAllProducts
            // 
            this.dgvAllProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProducts.Location = new System.Drawing.Point(8, 6);
            this.dgvAllProducts.Name = "dgvAllProducts";
            this.dgvAllProducts.ReadOnly = true;
            this.dgvAllProducts.RowHeadersWidth = 51;
            this.dgvAllProducts.RowTemplate.Height = 24;
            this.dgvAllProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllProducts.Size = new System.Drawing.Size(1009, 176);
            this.dgvAllProducts.TabIndex = 1;
            this.dgvAllProducts.SelectionChanged += new System.EventHandler(this.dgvAllProducts_SelectionChanged);
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(299, 189);
            this.btnUpdateItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(150, 37);
            this.btnUpdateItem.TabIndex = 7;
            this.btnUpdateItem.Text = "&Update Item ";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click_1);
            this.btnUpdateItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnUpdateItem_KeyDown);
            // 
            // tabManagerFeatures
            // 
            this.tabManagerFeatures.Controls.Add(this.tabInventory);
            this.tabManagerFeatures.Controls.Add(this.tabEmployee);
            this.tabManagerFeatures.Controls.Add(this.tabCustomer);
            this.tabManagerFeatures.Controls.Add(this.tabSalesReport);
            this.tabManagerFeatures.Location = new System.Drawing.Point(12, 52);
            this.tabManagerFeatures.Name = "tabManagerFeatures";
            this.tabManagerFeatures.SelectedIndex = 0;
            this.tabManagerFeatures.Size = new System.Drawing.Size(1105, 551);
            this.tabManagerFeatures.TabIndex = 0;
            this.tabManagerFeatures.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabManagerFeatures_Selected);
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.btnRemoveCustomer);
            this.tabCustomer.Controls.Add(this.btnEditCustomer);
            this.tabCustomer.Controls.Add(this.btnAddCustomer);
            this.tabCustomer.Controls.Add(this.dgvCustomer);
            this.tabCustomer.Location = new System.Drawing.Point(4, 25);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Size = new System.Drawing.Size(1097, 522);
            this.tabCustomer.TabIndex = 2;
            this.tabCustomer.Text = "Customer";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Location = new System.Drawing.Point(751, 287);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(114, 56);
            this.btnRemoveCustomer.TabIndex = 4;
            this.btnRemoveCustomer.Text = "Remove Customer";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(468, 287);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(128, 56);
            this.btnEditCustomer.TabIndex = 3;
            this.btnEditCustomer.Text = "Update Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(131, 287);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(113, 56);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add New Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(1057, 263);
            this.dgvCustomer.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(350, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 17);
            this.lblDate.TabIndex = 14;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(856, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 34);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblLowItemLabel
            // 
            this.lblLowItemLabel.AutoSize = true;
            this.lblLowItemLabel.Location = new System.Drawing.Point(820, 233);
            this.lblLowItemLabel.Name = "lblLowItemLabel";
            this.lblLowItemLabel.Size = new System.Drawing.Size(133, 17);
            this.lblLowItemLabel.TabIndex = 40;
            this.lblLowItemLabel.Text = "Restock Item below:";
            // 
            // dgvLowItem
            // 
            this.dgvLowItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLowItem.Location = new System.Drawing.Point(823, 253);
            this.dgvLowItem.Name = "dgvLowItem";
            this.dgvLowItem.ReadOnly = true;
            this.dgvLowItem.RowHeadersWidth = 51;
            this.dgvLowItem.RowTemplate.Height = 24;
            this.dgvLowItem.Size = new System.Drawing.Size(257, 199);
            this.dgvLowItem.TabIndex = 41;
            // 
            // tabSalesReport
            // 
            this.tabSalesReport.Controls.Add(this.lblSalesDetailLabel);
            this.tabSalesReport.Controls.Add(this.lblSalesReportLabel);
            this.tabSalesReport.Controls.Add(this.dgvSalesDetails);
            this.tabSalesReport.Controls.Add(this.dgvSalesReport);
            this.tabSalesReport.Location = new System.Drawing.Point(4, 25);
            this.tabSalesReport.Name = "tabSalesReport";
            this.tabSalesReport.Size = new System.Drawing.Size(1097, 522);
            this.tabSalesReport.TabIndex = 3;
            this.tabSalesReport.Text = "Sales Report";
            this.tabSalesReport.UseVisualStyleBackColor = true;
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(13, 43);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.ReadOnly = true;
            this.dgvSalesReport.RowHeadersWidth = 51;
            this.dgvSalesReport.RowTemplate.Height = 24;
            this.dgvSalesReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesReport.Size = new System.Drawing.Size(401, 191);
            this.dgvSalesReport.TabIndex = 0;
            this.dgvSalesReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesReport_CellClick);
            // 
            // dgvSalesDetails
            // 
            this.dgvSalesDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesDetails.Location = new System.Drawing.Point(475, 43);
            this.dgvSalesDetails.Name = "dgvSalesDetails";
            this.dgvSalesDetails.ReadOnly = true;
            this.dgvSalesDetails.RowHeadersWidth = 51;
            this.dgvSalesDetails.RowTemplate.Height = 24;
            this.dgvSalesDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesDetails.Size = new System.Drawing.Size(593, 198);
            this.dgvSalesDetails.TabIndex = 1;
            // 
            // lblSalesReportLabel
            // 
            this.lblSalesReportLabel.AutoSize = true;
            this.lblSalesReportLabel.Location = new System.Drawing.Point(10, 23);
            this.lblSalesReportLabel.Name = "lblSalesReportLabel";
            this.lblSalesReportLabel.Size = new System.Drawing.Size(240, 17);
            this.lblSalesReportLabel.TabIndex = 2;
            this.lblSalesReportLabel.Text = "Sales Report (Select Row for details)";
            // 
            // lblSalesDetailLabel
            // 
            this.lblSalesDetailLabel.AutoSize = true;
            this.lblSalesDetailLabel.Location = new System.Drawing.Point(472, 23);
            this.lblSalesDetailLabel.Name = "lblSalesDetailLabel";
            this.lblSalesDetailLabel.Size = new System.Drawing.Size(137, 17);
            this.lblSalesDetailLabel.TabIndex = 3;
            this.lblSalesDetailLabel.Text = "Sales Report Details";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 615);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.tabManagerFeatures);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator (Manager)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tabEmployee.ResumeLayout(false);
            this.gbxEdit.ResumeLayout(false);
            this.gbxEdit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            this.gbxUpdateField.ResumeLayout(false);
            this.gbxUpdateField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).EndInit();
            this.tabManagerFeatures.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowItem)).EndInit();
            this.tabSalesReport.ResumeLayout(false);
            this.tabSalesReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.DataGridView dgvAllProducts;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.TabControl tabManagerFeatures;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.GroupBox gbxUpdateField;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.CheckBox cbxName;
        private System.Windows.Forms.CheckBox cbxCost;
        private System.Windows.Forms.CheckBox cbxQuantity;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.CheckBox cbxDescription;
        private System.Windows.Forms.CheckBox cbxRetailPrice;
        private System.Windows.Forms.TextBox tbxRetailPrice;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboSupplierID;
        private System.Windows.Forms.CheckBox cbxCategoryID;
        private System.Windows.Forms.CheckBox cbxSupplierID;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHiredDate;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSalaryLabel;
        private System.Windows.Forms.Label lblPositionLabel;
        private System.Windows.Forms.Label lblHiredDateLabel;
        private System.Windows.Forms.CheckBox cbxLastName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.CheckBox cbxFirstName;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.CheckBox cbxZip;
        private System.Windows.Forms.TextBox tbxZip;
        private System.Windows.Forms.CheckBox cbxCity;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.CheckBox cbxAddress;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.CheckBox cbxEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.MaskedTextBox mskPhones;
        private System.Windows.Forms.Button btnRemoveCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.GroupBox gbxEdit;
        private System.Windows.Forms.CheckBox cbxStates;
        private System.Windows.Forms.CheckBox cbxEditPhone;
        private System.Windows.Forms.Label lblLowItemLabel;
        private System.Windows.Forms.DataGridView dgvLowItem;
        private System.Windows.Forms.TabPage tabSalesReport;
        private System.Windows.Forms.Label lblSalesDetailLabel;
        private System.Windows.Forms.Label lblSalesReportLabel;
        private System.Windows.Forms.DataGridView dgvSalesDetails;
        private System.Windows.Forms.DataGridView dgvSalesReport;
    }
}