
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
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.dgvAllProducts = new System.Windows.Forms.DataGridView();
            this.cboItemName = new System.Windows.Forms.ComboBox();
            this.tbxUpDescrption = new System.Windows.Forms.TextBox();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.pbxItemPicture = new System.Windows.Forms.PictureBox();
            this.btnInsertImage = new System.Windows.Forms.Button();
            this.tabManagerFeatures = new System.Windows.Forms.TabControl();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.tabInventory.SuspendLayout();
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
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(162, 199);
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
            this.dgvAllProducts.RowHeadersWidth = 51;
            this.dgvAllProducts.RowTemplate.Height = 24;
            this.dgvAllProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllProducts.Size = new System.Drawing.Size(1043, 176);
            this.dgvAllProducts.TabIndex = 10;
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
            this.cboItemName.Location = new System.Drawing.Point(223, 426);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(121, 24);
            this.cboItemName.TabIndex = 9;
            // 
            // tbxUpDescrption
            // 
            this.tbxUpDescrption.Location = new System.Drawing.Point(534, 426);
            this.tbxUpDescrption.Name = "tbxUpDescrption";
            this.tbxUpDescrption.Size = new System.Drawing.Size(449, 22);
            this.tbxUpDescrption.TabIndex = 8;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(330, 199);
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
            this.btnInsertImage.Location = new System.Drawing.Point(534, 203);
            this.btnInsertImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertImage.Name = "btnInsertImage";
            this.btnInsertImage.Size = new System.Drawing.Size(100, 28);
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
    }
}