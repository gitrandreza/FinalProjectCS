
namespace SU21_Final_Project
{
    partial class frmAddItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddItems));
            this.gbxItemInformation = new System.Windows.Forms.GroupBox();
            this.btnSaveItems = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbxDisplayItemImage = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tbxItemCost = new System.Windows.Forms.TextBox();
            this.tbxItemName = new System.Windows.Forms.TextBox();
            this.lblTagCost = new System.Windows.Forms.Label();
            this.lblTagQuantity = new System.Windows.Forms.Label();
            this.lblTagDescription = new System.Windows.Forms.Label();
            this.lblTagCategory = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.tbxRetailPrice = new System.Windows.Forms.TextBox();
            this.lblTagRetailPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHelpAddItem = new System.Windows.Forms.Button();
            this.gbxItemInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisplayItemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxItemInformation
            // 
            this.gbxItemInformation.BackColor = System.Drawing.Color.White;
            this.gbxItemInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbxItemInformation.Controls.Add(this.btnSaveItems);
            this.gbxItemInformation.Controls.Add(this.btnBack);
            this.gbxItemInformation.Controls.Add(this.pbxDisplayItemImage);
            this.gbxItemInformation.Controls.Add(this.btnLoad);
            this.gbxItemInformation.Controls.Add(this.cboSupplier);
            this.gbxItemInformation.Controls.Add(this.cboCategory);
            this.gbxItemInformation.Controls.Add(this.lblItemName);
            this.gbxItemInformation.Controls.Add(this.tbxItemCost);
            this.gbxItemInformation.Controls.Add(this.tbxItemName);
            this.gbxItemInformation.Controls.Add(this.lblTagCost);
            this.gbxItemInformation.Controls.Add(this.lblTagQuantity);
            this.gbxItemInformation.Controls.Add(this.lblTagDescription);
            this.gbxItemInformation.Controls.Add(this.lblTagCategory);
            this.gbxItemInformation.Controls.Add(this.tbxDescription);
            this.gbxItemInformation.Controls.Add(this.tbxQuantity);
            this.gbxItemInformation.Controls.Add(this.tbxRetailPrice);
            this.gbxItemInformation.Controls.Add(this.lblTagRetailPrice);
            this.gbxItemInformation.Controls.Add(this.label8);
            this.gbxItemInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItemInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxItemInformation.Location = new System.Drawing.Point(3, 62);
            this.gbxItemInformation.Name = "gbxItemInformation";
            this.gbxItemInformation.Size = new System.Drawing.Size(824, 423);
            this.gbxItemInformation.TabIndex = 45;
            this.gbxItemInformation.TabStop = false;
            this.gbxItemInformation.Text = "Add New Item";
            // 
            // btnSaveItems
            // 
            this.btnSaveItems.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSaveItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveItems.BackgroundImage")));
            this.btnSaveItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveItems.Enabled = false;
            this.btnSaveItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveItems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveItems.Location = new System.Drawing.Point(400, 359);
            this.btnSaveItems.Name = "btnSaveItems";
            this.btnSaveItems.Size = new System.Drawing.Size(424, 53);
            this.btnSaveItems.TabIndex = 43;
            this.btnSaveItems.Text = "Save Item";
            this.btnSaveItems.UseVisualStyleBackColor = false;
            this.btnSaveItems.Click += new System.EventHandler(this.btnSaveItems_Click);
            this.btnSaveItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSaveItems_KeyDown);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(0, 359);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(403, 53);
            this.btnBack.TabIndex = 47;
            this.btnBack.Text = "&Close";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbxDisplayItemImage
            // 
            this.pbxDisplayItemImage.BackColor = System.Drawing.Color.White;
            this.pbxDisplayItemImage.Location = new System.Drawing.Point(550, 88);
            this.pbxDisplayItemImage.Name = "pbxDisplayItemImage";
            this.pbxDisplayItemImage.Size = new System.Drawing.Size(250, 192);
            this.pbxDisplayItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDisplayItemImage.TabIndex = 48;
            this.pbxDisplayItemImage.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoad.Location = new System.Drawing.Point(550, 37);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(250, 53);
            this.btnLoad.TabIndex = 46;
            this.btnLoad.Text = "&Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnInsertImage_Click);
            // 
            // cboSupplier
            // 
            this.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSupplier.Location = new System.Drawing.Point(137, 298);
            this.cboSupplier.MaxLength = 3;
            this.cboSupplier.Name = "cboSupplier";
            this.cboSupplier.Size = new System.Drawing.Size(63, 24);
            this.cboSupplier.TabIndex = 12;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboCategory.Location = new System.Drawing.Point(137, 171);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(78, 24);
            this.cboCategory.TabIndex = 3;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(34, 55);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(84, 17);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "Item Name";
            // 
            // tbxItemCost
            // 
            this.tbxItemCost.Location = new System.Drawing.Point(137, 133);
            this.tbxItemCost.MaxLength = 20;
            this.tbxItemCost.Name = "tbxItemCost";
            this.tbxItemCost.Size = new System.Drawing.Size(114, 22);
            this.tbxItemCost.TabIndex = 2;
            // 
            // tbxItemName
            // 
            this.tbxItemName.Location = new System.Drawing.Point(137, 53);
            this.tbxItemName.MaxLength = 20;
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.Size = new System.Drawing.Size(165, 22);
            this.tbxItemName.TabIndex = 0;
            // 
            // lblTagCost
            // 
            this.lblTagCost.AutoSize = true;
            this.lblTagCost.Location = new System.Drawing.Point(73, 135);
            this.lblTagCost.Name = "lblTagCost";
            this.lblTagCost.Size = new System.Drawing.Size(40, 17);
            this.lblTagCost.TabIndex = 3;
            this.lblTagCost.Text = "Cost";
            // 
            // lblTagQuantity
            // 
            this.lblTagQuantity.AutoSize = true;
            this.lblTagQuantity.Location = new System.Drawing.Point(48, 93);
            this.lblTagQuantity.Name = "lblTagQuantity";
            this.lblTagQuantity.Size = new System.Drawing.Size(69, 17);
            this.lblTagQuantity.TabIndex = 4;
            this.lblTagQuantity.Text = "Quantity";
            // 
            // lblTagDescription
            // 
            this.lblTagDescription.AutoSize = true;
            this.lblTagDescription.Location = new System.Drawing.Point(35, 256);
            this.lblTagDescription.Name = "lblTagDescription";
            this.lblTagDescription.Size = new System.Drawing.Size(90, 17);
            this.lblTagDescription.TabIndex = 38;
            this.lblTagDescription.Text = "Description";
            // 
            // lblTagCategory
            // 
            this.lblTagCategory.AutoSize = true;
            this.lblTagCategory.Location = new System.Drawing.Point(49, 173);
            this.lblTagCategory.Name = "lblTagCategory";
            this.lblTagCategory.Size = new System.Drawing.Size(73, 17);
            this.lblTagCategory.TabIndex = 5;
            this.lblTagCategory.Text = "Category";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(137, 254);
            this.tbxDescription.MaxLength = 40;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(335, 22);
            this.tbxDescription.TabIndex = 5;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(137, 93);
            this.tbxQuantity.MaxLength = 20;
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(78, 22);
            this.tbxQuantity.TabIndex = 1;
            this.tbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxQuantity_KeyPress);
            // 
            // tbxRetailPrice
            // 
            this.tbxRetailPrice.Location = new System.Drawing.Point(137, 211);
            this.tbxRetailPrice.Name = "tbxRetailPrice";
            this.tbxRetailPrice.Size = new System.Drawing.Size(114, 22);
            this.tbxRetailPrice.TabIndex = 4;
            // 
            // lblTagRetailPrice
            // 
            this.lblTagRetailPrice.AutoSize = true;
            this.lblTagRetailPrice.Location = new System.Drawing.Point(34, 215);
            this.lblTagRetailPrice.Name = "lblTagRetailPrice";
            this.lblTagRetailPrice.Size = new System.Drawing.Size(92, 17);
            this.lblTagRetailPrice.TabIndex = 9;
            this.lblTagRetailPrice.Text = "Retail Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Supplier";
            // 
            // btnHelpAddItem
            // 
            this.btnHelpAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpAddItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelpAddItem.BackgroundImage")));
            this.btnHelpAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpAddItem.FlatAppearance.BorderSize = 3;
            this.btnHelpAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpAddItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHelpAddItem.Location = new System.Drawing.Point(711, 12);
            this.btnHelpAddItem.Name = "btnHelpAddItem";
            this.btnHelpAddItem.Size = new System.Drawing.Size(109, 43);
            this.btnHelpAddItem.TabIndex = 57;
            this.btnHelpAddItem.Text = "HELP?";
            this.btnHelpAddItem.UseVisualStyleBackColor = false;
            this.btnHelpAddItem.Click += new System.EventHandler(this.btnHelpAddItem_Click);
            // 
            // frmAddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(832, 497);
            this.Controls.Add(this.btnHelpAddItem);
            this.Controls.Add(this.gbxItemInformation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Items";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddItems_FormClosing);
            this.gbxItemInformation.ResumeLayout(false);
            this.gbxItemInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisplayItemImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxItemInformation;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox tbxItemCost;
        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.Label lblTagCost;
        private System.Windows.Forms.Label lblTagQuantity;
        private System.Windows.Forms.Label lblTagDescription;
        private System.Windows.Forms.Label lblTagCategory;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.TextBox tbxRetailPrice;
        private System.Windows.Forms.Label lblTagRetailPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveItems;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pbxDisplayItemImage;
        private System.Windows.Forms.Button btnHelpAddItem;
    }
}