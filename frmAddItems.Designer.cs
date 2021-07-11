
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
            this.gbxItemInformation = new System.Windows.Forms.GroupBox();
            this.btnSaveItems = new System.Windows.Forms.Button();
            this.cboSupplier = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.lblTagItemName = new System.Windows.Forms.Label();
            this.tbxItemCost = new System.Windows.Forms.TextBox();
            this.tbxItemName = new System.Windows.Forms.TextBox();
            this.lblTagCost = new System.Windows.Forms.Label();
            this.lblTagQuantity = new System.Windows.Forms.Label();
            this.lblTagDescription = new System.Windows.Forms.Label();
            this.lblTagCategory = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxPhoneTwo = new System.Windows.Forms.TextBox();
            this.tbxRetailPrice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTagRetailPrice = new System.Windows.Forms.Label();
            this.tbxPhoneOne = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxAddressOne = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxAddressTwo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxAddressThree = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxZip = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbxItemInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxItemInformation
            // 
            this.gbxItemInformation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxItemInformation.Controls.Add(this.btnSaveItems);
            this.gbxItemInformation.Controls.Add(this.cboSupplier);
            this.gbxItemInformation.Controls.Add(this.cboCategory);
            this.gbxItemInformation.Controls.Add(this.label24);
            this.gbxItemInformation.Controls.Add(this.lblTagItemName);
            this.gbxItemInformation.Controls.Add(this.tbxItemCost);
            this.gbxItemInformation.Controls.Add(this.tbxItemName);
            this.gbxItemInformation.Controls.Add(this.lblTagCost);
            this.gbxItemInformation.Controls.Add(this.lblTagQuantity);
            this.gbxItemInformation.Controls.Add(this.lblTagDescription);
            this.gbxItemInformation.Controls.Add(this.lblTagCategory);
            this.gbxItemInformation.Controls.Add(this.tbxDescription);
            this.gbxItemInformation.Controls.Add(this.tbxQuantity);
            this.gbxItemInformation.Controls.Add(this.label18);
            this.gbxItemInformation.Controls.Add(this.tbxPhoneTwo);
            this.gbxItemInformation.Controls.Add(this.tbxRetailPrice);
            this.gbxItemInformation.Controls.Add(this.label17);
            this.gbxItemInformation.Controls.Add(this.lblTagRetailPrice);
            this.gbxItemInformation.Controls.Add(this.tbxPhoneOne);
            this.gbxItemInformation.Controls.Add(this.tbxCity);
            this.gbxItemInformation.Controls.Add(this.label6);
            this.gbxItemInformation.Controls.Add(this.tbxAddressOne);
            this.gbxItemInformation.Controls.Add(this.label7);
            this.gbxItemInformation.Controls.Add(this.label8);
            this.gbxItemInformation.Controls.Add(this.tbxAddressTwo);
            this.gbxItemInformation.Controls.Add(this.label9);
            this.gbxItemInformation.Controls.Add(this.tbxAddressThree);
            this.gbxItemInformation.Controls.Add(this.label10);
            this.gbxItemInformation.Controls.Add(this.tbxZip);
            this.gbxItemInformation.Controls.Add(this.label11);
            this.gbxItemInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxItemInformation.Location = new System.Drawing.Point(2, 31);
            this.gbxItemInformation.Name = "gbxItemInformation";
            this.gbxItemInformation.Size = new System.Drawing.Size(795, 325);
            this.gbxItemInformation.TabIndex = 45;
            this.gbxItemInformation.TabStop = false;
            this.gbxItemInformation.Text = "Item Information";
            // 
            // btnSaveItems
            // 
            this.btnSaveItems.Location = new System.Drawing.Point(522, 289);
            this.btnSaveItems.Name = "btnSaveItems";
            this.btnSaveItems.Size = new System.Drawing.Size(101, 28);
            this.btnSaveItems.TabIndex = 43;
            this.btnSaveItems.Text = "Save Item";
            this.btnSaveItems.UseVisualStyleBackColor = true;
            this.btnSaveItems.Click += new System.EventHandler(this.btnSaveItems_Click);
            // 
            // cboSupplier
            // 
            this.cboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplier.FormattingEnabled = true;
            this.cboSupplier.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSupplier.Location = new System.Drawing.Point(133, 289);
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
            this.cboCategory.Location = new System.Drawing.Point(133, 162);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(78, 24);
            this.cboCategory.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label24.Location = new System.Drawing.Point(667, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(122, 17);
            this.label24.TabIndex = 46;
            this.label24.Text = "(*)Required Fields";
            // 
            // lblTagItemName
            // 
            this.lblTagItemName.AutoSize = true;
            this.lblTagItemName.Location = new System.Drawing.Point(41, 46);
            this.lblTagItemName.Name = "lblTagItemName";
            this.lblTagItemName.Size = new System.Drawing.Size(75, 17);
            this.lblTagItemName.TabIndex = 2;
            this.lblTagItemName.Text = "Item Name";
            // 
            // tbxItemCost
            // 
            this.tbxItemCost.Location = new System.Drawing.Point(133, 124);
            this.tbxItemCost.MaxLength = 20;
            this.tbxItemCost.Name = "tbxItemCost";
            this.tbxItemCost.Size = new System.Drawing.Size(114, 22);
            this.tbxItemCost.TabIndex = 2;
            // 
            // tbxItemName
            // 
            this.tbxItemName.Location = new System.Drawing.Point(133, 42);
            this.tbxItemName.MaxLength = 20;
            this.tbxItemName.Name = "tbxItemName";
            this.tbxItemName.Size = new System.Drawing.Size(165, 22);
            this.tbxItemName.TabIndex = 0;
            // 
            // lblTagCost
            // 
            this.lblTagCost.AutoSize = true;
            this.lblTagCost.Location = new System.Drawing.Point(80, 126);
            this.lblTagCost.Name = "lblTagCost";
            this.lblTagCost.Size = new System.Drawing.Size(36, 17);
            this.lblTagCost.TabIndex = 3;
            this.lblTagCost.Text = "Cost";
            // 
            // lblTagQuantity
            // 
            this.lblTagQuantity.AutoSize = true;
            this.lblTagQuantity.Location = new System.Drawing.Point(55, 84);
            this.lblTagQuantity.Name = "lblTagQuantity";
            this.lblTagQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblTagQuantity.TabIndex = 4;
            this.lblTagQuantity.Text = "Quantity";
            // 
            // lblTagDescription
            // 
            this.lblTagDescription.AutoSize = true;
            this.lblTagDescription.Location = new System.Drawing.Point(42, 247);
            this.lblTagDescription.Name = "lblTagDescription";
            this.lblTagDescription.Size = new System.Drawing.Size(79, 17);
            this.lblTagDescription.TabIndex = 38;
            this.lblTagDescription.Text = "Description";
            // 
            // lblTagCategory
            // 
            this.lblTagCategory.AutoSize = true;
            this.lblTagCategory.Location = new System.Drawing.Point(56, 164);
            this.lblTagCategory.Name = "lblTagCategory";
            this.lblTagCategory.Size = new System.Drawing.Size(65, 17);
            this.lblTagCategory.TabIndex = 5;
            this.lblTagCategory.Text = "Category";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(133, 245);
            this.tbxDescription.MaxLength = 40;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(335, 22);
            this.tbxDescription.TabIndex = 5;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(133, 84);
            this.tbxQuantity.MaxLength = 20;
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(78, 22);
            this.tbxQuantity.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(402, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 17);
            this.label18.TabIndex = 36;
            this.label18.Text = "Phone 2";
            // 
            // tbxPhoneTwo
            // 
            this.tbxPhoneTwo.Location = new System.Drawing.Point(478, 202);
            this.tbxPhoneTwo.MaxLength = 20;
            this.tbxPhoneTwo.Name = "tbxPhoneTwo";
            this.tbxPhoneTwo.Size = new System.Drawing.Size(158, 22);
            this.tbxPhoneTwo.TabIndex = 10;
            // 
            // tbxRetailPrice
            // 
            this.tbxRetailPrice.Location = new System.Drawing.Point(133, 202);
            this.tbxRetailPrice.Name = "tbxRetailPrice";
            this.tbxRetailPrice.Size = new System.Drawing.Size(114, 22);
            this.tbxRetailPrice.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(397, 162);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 17);
            this.label17.TabIndex = 34;
            this.label17.Text = "*Phone 1";
            // 
            // lblTagRetailPrice
            // 
            this.lblTagRetailPrice.AutoSize = true;
            this.lblTagRetailPrice.Location = new System.Drawing.Point(41, 206);
            this.lblTagRetailPrice.Name = "lblTagRetailPrice";
            this.lblTagRetailPrice.Size = new System.Drawing.Size(80, 17);
            this.lblTagRetailPrice.TabIndex = 9;
            this.lblTagRetailPrice.Text = "Retail Price";
            // 
            // tbxPhoneOne
            // 
            this.tbxPhoneOne.Location = new System.Drawing.Point(478, 159);
            this.tbxPhoneOne.MaxLength = 20;
            this.tbxPhoneOne.Name = "tbxPhoneOne";
            this.tbxPhoneOne.Size = new System.Drawing.Size(158, 22);
            this.tbxPhoneOne.TabIndex = 9;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(391, 244);
            this.tbxCity.MaxLength = 30;
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(144, 22);
            this.tbxCity.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "*City";
            // 
            // tbxAddressOne
            // 
            this.tbxAddressOne.Location = new System.Drawing.Point(478, 42);
            this.tbxAddressOne.MaxLength = 30;
            this.tbxAddressOne.Name = "tbxAddressOne";
            this.tbxAddressOne.Size = new System.Drawing.Size(232, 22);
            this.tbxAddressOne.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "*Address 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Supplier";
            // 
            // frmAddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.gbxItemInformation);
            this.Name = "frmAddItems";
            this.Text = "Add Items";
            this.gbxItemInformation.ResumeLayout(false);
            this.gbxItemInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxItemInformation;
        private System.Windows.Forms.ComboBox cboSupplier;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblTagItemName;
        private System.Windows.Forms.TextBox tbxItemCost;
        private System.Windows.Forms.TextBox tbxItemName;
        private System.Windows.Forms.Label lblTagCost;
        private System.Windows.Forms.Label lblTagQuantity;
        private System.Windows.Forms.Label lblTagDescription;
        private System.Windows.Forms.Label lblTagCategory;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbxPhoneTwo;
        private System.Windows.Forms.TextBox tbxRetailPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTagRetailPrice;
        private System.Windows.Forms.TextBox tbxPhoneOne;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxAddressOne;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveItems;
    }
}