
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
            this.btnInsertImage = new System.Windows.Forms.Button();
            this.pbxItemPicture = new System.Windows.Forms.PictureBox();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.tbxUpDescrption = new System.Windows.Forms.TextBox();
            this.cboItemName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertImage
            // 
            this.btnInsertImage.Location = new System.Drawing.Point(32, 198);
            this.btnInsertImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertImage.Name = "btnInsertImage";
            this.btnInsertImage.Size = new System.Drawing.Size(100, 28);
            this.btnInsertImage.TabIndex = 0;
            this.btnInsertImage.Text = "&Insert Image";
            this.btnInsertImage.UseVisualStyleBackColor = true;
            this.btnInsertImage.Click += new System.EventHandler(this.btnInsertImage_Click);
            // 
            // pbxItemPicture
            // 
            this.pbxItemPicture.Location = new System.Drawing.Point(740, 36);
            this.pbxItemPicture.Margin = new System.Windows.Forms.Padding(4);
            this.pbxItemPicture.Name = "pbxItemPicture";
            this.pbxItemPicture.Size = new System.Drawing.Size(269, 352);
            this.pbxItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxItemPicture.TabIndex = 1;
            this.pbxItemPicture.TabStop = false;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Location = new System.Drawing.Point(32, 138);
            this.btnUpdateItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(137, 28);
            this.btnUpdateItem.TabIndex = 2;
            this.btnUpdateItem.Text = "&Update Description";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // tbxUpDescrption
            // 
            this.tbxUpDescrption.Location = new System.Drawing.Point(215, 141);
            this.tbxUpDescrption.Name = "tbxUpDescrption";
            this.tbxUpDescrption.Size = new System.Drawing.Size(449, 22);
            this.tbxUpDescrption.TabIndex = 3;
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
            this.cboItemName.Location = new System.Drawing.Point(32, 46);
            this.cboItemName.Name = "cboItemName";
            this.cboItemName.Size = new System.Drawing.Size(121, 24);
            this.cboItemName.TabIndex = 4;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cboItemName);
            this.Controls.Add(this.tbxUpDescrption);
            this.Controls.Add(this.btnUpdateItem);
            this.Controls.Add(this.pbxItemPicture);
            this.Controls.Add(this.btnInsertImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pbxItemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertImage;
        private System.Windows.Forms.PictureBox pbxItemPicture;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.TextBox tbxUpDescrption;
        private System.Windows.Forms.ComboBox cboItemName;
    }
}