﻿
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
            this.cboItemName = new System.Windows.Forms.ComboBox();
            this.tbxUpDescrption = new System.Windows.Forms.TextBox();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.pbxItemPicture = new System.Windows.Forms.PictureBox();
            this.btnInsertImage = new System.Windows.Forms.Button();
            this.tabManagerFeatures = new System.Windows.Forms.TabControl();
            this.lblDate = new System.Windows.Forms.Label();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tabInventory.SuspendLayout();
            this.gbxUpdateField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemPicture)).BeginInit();
            this.tabManagerFeatures.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.btnRemoveEmployee);
            this.tabEmployee.Controls.Add(this.btnAddEmployee);
            this.tabEmployee.Controls.Add(this.btnEditEmployee);
            this.tabEmployee.Controls.Add(this.dgvEmployee);
            this.tabEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1082, 461);
            this.tabEmployee.TabIndex = 1;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(429, 303);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(137, 33);
            this.btnRemoveEmployee.TabIndex = 15;
            this.btnRemoveEmployee.Text = "&Remove Employee";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(256, 303);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(137, 33);
            this.btnAddEmployee.TabIndex = 14;
            this.btnAddEmployee.Text = "&Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(599, 303);
            this.btnEditEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(137, 33);
            this.btnEditEmployee.TabIndex = 13;
            this.btnEditEmployee.Text = "&Edit ";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(8, 22);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(1057, 263);
            this.dgvEmployee.TabIndex = 0;
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.gbxUpdateField);
            this.tabInventory.Controls.Add(this.btnRemoveItem);
            this.tabInventory.Controls.Add(this.btnAddItems);
            this.tabInventory.Controls.Add(this.dgvAllProducts);
            this.tabInventory.Controls.Add(this.cboItemName);
            this.tabInventory.Controls.Add(this.tbxUpDescrption);
            this.tabInventory.Controls.Add(this.btnUpdateItem);
            this.tabInventory.Controls.Add(this.pbxItemPicture);
            this.tabInventory.Controls.Add(this.btnInsertImage);
            this.tabInventory.Location = new System.Drawing.Point(4, 25);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(1082, 461);
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
            this.btnRemoveItem.Location = new System.Drawing.Point(723, 183);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(121, 47);
            this.btnRemoveItem.TabIndex = 12;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(20, 188);
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
            // cboItemName
            // 
            this.cboItemName.AutoCompleteCustomSource.AddRange(new string[] {
            "T-Shirt",
            "Mugs",
            "Bagpack",
            "Sweats",
            "Jacket",
            "Polos",
            "Caps",
            "Casual Shirt",
            "Face Mask",
            "Hand Sanitizer",
            "Pens",
            "Iphone Wallet",
            "Bottle Opener",
            "Duffle",
            "Tote",
            "Cooler Bag",
            "Hooded",
            "Lip Balm",
            "Antibacterial Wipes",
            "Leeds Insulated",
            "Blanket",
            "Towel",
            "Robe",
            "Stress ball",
            "Grocery Bag"});
            this.cboItemName.FormattingEnabled = true;
            this.cboItemName.Items.AddRange(new object[] {
            "T-Shirt",
            "Mugs",
            "Bagpack",
            "Sweats",
            "Jacket",
            "Polos",
            "Caps",
            "Casual Shirt",
            "Face Mask",
            "Hand Sanitizer",
            "Pens",
            "Iphone Wallet",
            "Bottle Opener",
            "Duffle",
            "Tote",
            "Cooler Bag",
            "Hooded",
            "Lip Balm",
            "Antibacterial Wipes",
            "Leeds Insulated",
            "Blanket",
            "Towel",
            "Robe",
            "Stress ball",
            "Grocery Bag"});
            this.cboItemName.Location = new System.Drawing.Point(880, 489);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(121, 24);
            this.cboItemName.TabIndex = 9;
            // 
            // tbxUpDescrption
            // 
            this.tbxUpDescrption.Location = new System.Drawing.Point(880, 454);
            this.tbxUpDescrption.Name = "tbxUpDescrption";
            this.tbxUpDescrption.Size = new System.Drawing.Size(117, 22);
            this.tbxUpDescrption.TabIndex = 8;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(379, 188);
            this.btnUpdateItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(150, 37);
            this.btnUpdateItem.TabIndex = 7;
            this.btnUpdateItem.Text = "&Update Item ";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click_1);
            this.btnUpdateItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnUpdateItem_KeyDown);
            // 
            // pbxItemPicture
            // 
            this.pbxItemPicture.Location = new System.Drawing.Point(844, 257);
            this.pbxItemPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pbxItemPicture.Name = "pbxItemPicture";
            this.pbxItemPicture.Size = new System.Drawing.Size(173, 195);
            this.pbxItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxItemPicture.TabIndex = 6;
            this.pbxItemPicture.TabStop = false;
            // 
            // btnInsertImage
            // 
            this.btnInsertImage.Location = new System.Drawing.Point(886, 189);
            this.btnInsertImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertImage.Name = "btnInsertImage";
            this.btnInsertImage.Size = new System.Drawing.Size(131, 37);
            this.btnInsertImage.TabIndex = 5;
            this.btnInsertImage.Text = "&Insert Item Image";
            this.btnInsertImage.UseVisualStyleBackColor = true;
            // 
            // tabManagerFeatures
            // 
            this.tabManagerFeatures.Controls.Add(this.tabInventory);
            this.tabManagerFeatures.Controls.Add(this.tabEmployee);
            this.tabManagerFeatures.Controls.Add(this.tabCustomer);
            this.tabManagerFeatures.Location = new System.Drawing.Point(12, 12);
            this.tabManagerFeatures.Name = "tabManagerFeatures";
            this.tabManagerFeatures.SelectedIndex = 0;
            this.tabManagerFeatures.Size = new System.Drawing.Size(1090, 490);
            this.tabManagerFeatures.TabIndex = 0;
            this.tabManagerFeatures.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabManagerFeatures_Selected);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(350, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 17);
            this.lblDate.TabIndex = 14;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.dgvCustomer);
            this.tabCustomer.Location = new System.Drawing.Point(4, 25);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Size = new System.Drawing.Size(1082, 461);
            this.tabCustomer.TabIndex = 2;
            this.tabCustomer.Text = "Customer";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(1057, 263);
            this.dgvCustomer.TabIndex = 1;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 554);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            this.gbxUpdateField.ResumeLayout(false);
            this.gbxUpdateField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemPicture)).EndInit();
            this.tabManagerFeatures.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.DataGridView dgvAllProducts;
        private System.Windows.Forms.ComboBox cboItemName;
        private System.Windows.Forms.TextBox tbxUpDescrption;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.PictureBox pbxItemPicture;
        private System.Windows.Forms.Button btnInsertImage;
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
    }
}