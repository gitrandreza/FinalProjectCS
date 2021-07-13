
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.gbxUpdateField = new System.Windows.Forms.GroupBox();
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
            this.cbxRetailPrice = new System.Windows.Forms.CheckBox();
            this.tbxRetailPrice = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tabInventory.SuspendLayout();
            this.gbxUpdateField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemPicture)).BeginInit();
            this.tabManagerFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.dgvEmployee);
            this.tabEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(1057, 513);
            this.tabEmployee.TabIndex = 1;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(8, 22);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(852, 263);
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
            this.tabInventory.Size = new System.Drawing.Size(1057, 513);
            this.tabInventory.TabIndex = 0;
            this.tabInventory.Text = "Inventory Control";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // gbxUpdateField
            // 
            this.gbxUpdateField.Controls.Add(this.checkBox1);
            this.gbxUpdateField.Controls.Add(this.textBox1);
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
            this.gbxUpdateField.Location = new System.Drawing.Point(8, 257);
            this.gbxUpdateField.Name = "gbxUpdateField";
            this.gbxUpdateField.Size = new System.Drawing.Size(810, 249);
            this.gbxUpdateField.TabIndex = 13;
            this.gbxUpdateField.TabStop = false;
            this.gbxUpdateField.Text = "Update Fields";
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
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.AutoSize = true;
            this.cbxQuantity.Location = new System.Drawing.Point(10, 77);
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(83, 21);
            this.cbxQuantity.TabIndex = 19;
            this.cbxQuantity.Text = "Quantity";
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
            this.tbxQuantity.Location = new System.Drawing.Point(111, 77);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(58, 22);
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
            this.btnSaveUpdate.Location = new System.Drawing.Point(666, 199);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(110, 39);
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
            this.btnRemoveItem.Location = new System.Drawing.Point(224, 203);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(108, 37);
            this.btnRemoveItem.TabIndex = 12;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(8, 199);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(108, 37);
            this.btnAddItems.TabIndex = 11;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
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
            this.dgvAllProducts.Size = new System.Drawing.Size(1043, 176);
            this.dgvAllProducts.TabIndex = 10;
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
            this.cboItemName.Location = new System.Drawing.Point(908, 472);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(121, 24);
            this.cboItemName.TabIndex = 9;
            // 
            // tbxUpDescrption
            // 
            this.tbxUpDescrption.Location = new System.Drawing.Point(912, 421);
            this.tbxUpDescrption.Name = "tbxUpDescrption";
            this.tbxUpDescrption.Size = new System.Drawing.Size(117, 22);
            this.tbxUpDescrption.TabIndex = 8;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(430, 203);
            this.btnUpdateItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(150, 37);
            this.btnUpdateItem.TabIndex = 7;
            this.btnUpdateItem.Text = "&Update ";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click_1);
            // 
            // pbxItemPicture
            // 
            this.pbxItemPicture.Location = new System.Drawing.Point(877, 189);
            this.pbxItemPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pbxItemPicture.Name = "pbxItemPicture";
            this.pbxItemPicture.Size = new System.Drawing.Size(173, 195);
            this.pbxItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxItemPicture.TabIndex = 6;
            this.pbxItemPicture.TabStop = false;
            // 
            // btnInsertImage
            // 
            this.btnInsertImage.Location = new System.Drawing.Point(674, 203);
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
            this.tabManagerFeatures.Location = new System.Drawing.Point(0, 0);
            this.tabManagerFeatures.Name = "tabManagerFeatures";
            this.tabManagerFeatures.SelectedIndex = 0;
            this.tabManagerFeatures.Size = new System.Drawing.Size(1065, 542);
            this.tabManagerFeatures.TabIndex = 0;
            this.tabManagerFeatures.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabManagerFeatures_Selected);
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
            // 
            // tbxRetailPrice
            // 
            this.tbxRetailPrice.Enabled = false;
            this.tbxRetailPrice.Location = new System.Drawing.Point(112, 152);
            this.tbxRetailPrice.Name = "tbxRetailPrice";
            this.tbxRetailPrice.Size = new System.Drawing.Size(142, 22);
            this.tbxRetailPrice.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(401, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 21);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Retail Price";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(346, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 22);
            this.textBox1.TabIndex = 22;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 543);
            this.Controls.Add(this.tabManagerFeatures);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator (Manager)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.tabEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.tabInventory.ResumeLayout(false);
            this.tabInventory.PerformLayout();
            this.gbxUpdateField.ResumeLayout(false);
            this.gbxUpdateField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemPicture)).EndInit();
            this.tabManagerFeatures.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbxRetailPrice;
        private System.Windows.Forms.TextBox tbxRetailPrice;
    }
}