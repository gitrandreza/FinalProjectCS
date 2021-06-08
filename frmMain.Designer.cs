
namespace SU21_Final_Project
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMessage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabItemCategory = new System.Windows.Forms.TabControl();
            this.tabClothes = new System.Windows.Forms.TabPage();
            this.tabGifts = new System.Windows.Forms.TabPage();
            this.dgvGift = new System.Windows.Forms.DataGridView();
            this.pbxGift = new System.Windows.Forms.PictureBox();
            this.tabBags = new System.Windows.Forms.TabPage();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.pbxAll = new System.Windows.Forms.PictureBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.gbxSelectedItem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabItemCategory.SuspendLayout();
            this.tabGifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGift)).BeginInit();
            this.tabAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.gbxSelectedItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(327, 4);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(73, 15);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "TestMessage";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(829, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newOrderToolStripMenuItem.Text = "&New Order";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // tabItemCategory
            // 
            this.tabItemCategory.Controls.Add(this.tabClothes);
            this.tabItemCategory.Controls.Add(this.tabGifts);
            this.tabItemCategory.Controls.Add(this.tabBags);
            this.tabItemCategory.Controls.Add(this.tabAll);
            this.tabItemCategory.Location = new System.Drawing.Point(0, 28);
            this.tabItemCategory.Name = "tabItemCategory";
            this.tabItemCategory.SelectedIndex = 0;
            this.tabItemCategory.Size = new System.Drawing.Size(421, 259);
            this.tabItemCategory.TabIndex = 2;
            this.tabItemCategory.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabItemCategory_Selected);
            // 
            // tabClothes
            // 
            this.tabClothes.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClothes.Location = new System.Drawing.Point(4, 22);
            this.tabClothes.Name = "tabClothes";
            this.tabClothes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClothes.Size = new System.Drawing.Size(413, 233);
            this.tabClothes.TabIndex = 0;
            this.tabClothes.Text = "           Clothes         ";
            this.tabClothes.UseVisualStyleBackColor = true;
            // 
            // tabGifts
            // 
            this.tabGifts.Controls.Add(this.dgvGift);
            this.tabGifts.Controls.Add(this.pbxGift);
            this.tabGifts.Location = new System.Drawing.Point(4, 22);
            this.tabGifts.Name = "tabGifts";
            this.tabGifts.Padding = new System.Windows.Forms.Padding(3);
            this.tabGifts.Size = new System.Drawing.Size(413, 233);
            this.tabGifts.TabIndex = 1;
            this.tabGifts.Text = "              Gifts             ";
            this.tabGifts.UseVisualStyleBackColor = true;
            // 
            // dgvGift
            // 
            this.dgvGift.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGift.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGift.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvGift.Location = new System.Drawing.Point(5, 16);
            this.dgvGift.Name = "dgvGift";
            this.dgvGift.ReadOnly = true;
            this.dgvGift.RowHeadersVisible = false;
            this.dgvGift.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvGift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvGift.Size = new System.Drawing.Size(103, 200);
            this.dgvGift.TabIndex = 20;
            this.dgvGift.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGift_CellClick);
            // 
            // pbxGift
            // 
            this.pbxGift.Location = new System.Drawing.Point(222, 16);
            this.pbxGift.Name = "pbxGift";
            this.pbxGift.Size = new System.Drawing.Size(185, 169);
            this.pbxGift.TabIndex = 19;
            this.pbxGift.TabStop = false;
            // 
            // tabBags
            // 
            this.tabBags.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBags.Location = new System.Drawing.Point(4, 22);
            this.tabBags.Name = "tabBags";
            this.tabBags.Size = new System.Drawing.Size(413, 233);
            this.tabBags.TabIndex = 2;
            this.tabBags.Text = "            Bags           ";
            this.tabBags.UseVisualStyleBackColor = true;
            // 
            // tabAll
            // 
            this.tabAll.Controls.Add(this.dgvAll);
            this.tabAll.Controls.Add(this.pbxAll);
            this.tabAll.Location = new System.Drawing.Point(4, 22);
            this.tabAll.Name = "tabAll";
            this.tabAll.Size = new System.Drawing.Size(413, 233);
            this.tabAll.TabIndex = 3;
            this.tabAll.Text = "            All           ";
            this.tabAll.UseVisualStyleBackColor = true;
            // 
            // dgvAll
            // 
            this.dgvAll.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAll.Location = new System.Drawing.Point(8, 14);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.ReadOnly = true;
            this.dgvAll.RowHeadersVisible = false;
            this.dgvAll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAll.Size = new System.Drawing.Size(103, 200);
            this.dgvAll.TabIndex = 6;
            this.dgvAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAll_CellClick);
            // 
            // pbxAll
            // 
            this.pbxAll.Location = new System.Drawing.Point(195, 14);
            this.pbxAll.Name = "pbxAll";
            this.pbxAll.Size = new System.Drawing.Size(215, 200);
            this.pbxAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAll.TabIndex = 0;
            this.pbxAll.TabStop = false;
            // 
            // lblAvailable
            // 
            this.lblAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvailable.Location = new System.Drawing.Point(212, 290);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(72, 28);
            this.lblAvailable.TabIndex = 18;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(316, 290);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(72, 28);
            this.lblPrice.TabIndex = 17;
            // 
            // dgvCart
            // 
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCart.Location = new System.Drawing.Point(427, 180);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCart.Size = new System.Drawing.Size(282, 210);
            this.dgvCart.TabIndex = 3;
            // 
            // gbxSelectedItem
            // 
            this.gbxSelectedItem.Controls.Add(this.label1);
            this.gbxSelectedItem.Controls.Add(this.label9);
            this.gbxSelectedItem.Controls.Add(this.lblItemName);
            this.gbxSelectedItem.Location = new System.Drawing.Point(12, 325);
            this.gbxSelectedItem.Name = "gbxSelectedItem";
            this.gbxSelectedItem.Size = new System.Drawing.Size(405, 134);
            this.gbxSelectedItem.TabIndex = 4;
            this.gbxSelectedItem.TabStop = false;
            this.gbxSelectedItem.Text = "Your Selection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Item:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(175, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 12;
            // 
            // lblItemName
            // 
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemName.Location = new System.Drawing.Point(48, 21);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(121, 23);
            this.lblItemName.TabIndex = 20;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(119, 294);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(62, 20);
            this.tbxQuantity.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Add Quantity:";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(544, 1);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 22;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(149, 1);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 23;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.YellowGreen;
            this.lblUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUser.Location = new System.Drawing.Point(687, 6);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(46, 15);
            this.lblUser.TabIndex = 24;
            this.lblUser.Text = "GUEST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "User:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 471);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.gbxSelectedItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.tabItemCategory);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "2021.05.02";
            this.Text = "Imprint Manager System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabItemCategory.ResumeLayout(false);
            this.tabGifts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGift)).EndInit();
            this.tabAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.gbxSelectedItem.ResumeLayout(false);
            this.gbxSelectedItem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabItemCategory;
        private System.Windows.Forms.TabPage tabClothes;
        private System.Windows.Forms.TabPage tabGifts;
        private System.Windows.Forms.TabPage tabBags;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.PictureBox pbxAll;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox gbxSelectedItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvGift;
        private System.Windows.Forms.PictureBox pbxGift;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label2;
    }
}

