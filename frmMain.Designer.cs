
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
            this.tabBags = new System.Windows.Forms.TabPage();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.dgrdAll = new System.Windows.Forms.DataGridView();
            this.pbxAll = new System.Windows.Forms.PictureBox();
            this.dgrdCart = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabItemCategory.SuspendLayout();
            this.tabAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMessage.Location = new System.Drawing.Point(722, 429);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(95, 15);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "labelTestMessage";
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
            this.tabGifts.Location = new System.Drawing.Point(4, 22);
            this.tabGifts.Name = "tabGifts";
            this.tabGifts.Padding = new System.Windows.Forms.Padding(3);
            this.tabGifts.Size = new System.Drawing.Size(413, 233);
            this.tabGifts.TabIndex = 1;
            this.tabGifts.Text = "              Gifts             ";
            this.tabGifts.UseVisualStyleBackColor = true;
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
            this.tabAll.Controls.Add(this.dgrdAll);
            this.tabAll.Controls.Add(this.pbxAll);
            this.tabAll.Location = new System.Drawing.Point(4, 22);
            this.tabAll.Name = "tabAll";
            this.tabAll.Size = new System.Drawing.Size(413, 233);
            this.tabAll.TabIndex = 3;
            this.tabAll.Text = "            All           ";
            this.tabAll.UseVisualStyleBackColor = true;
            // 
            // dgrdAll
            // 
            this.dgrdAll.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrdAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdAll.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgrdAll.Location = new System.Drawing.Point(8, 14);
            this.dgrdAll.Name = "dgrdAll";
            this.dgrdAll.ReadOnly = true;
            this.dgrdAll.RowHeadersVisible = false;
            this.dgrdAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrdAll.Size = new System.Drawing.Size(128, 206);
            this.dgrdAll.TabIndex = 6;
            // 
            // pbxAll
            // 
            this.pbxAll.Location = new System.Drawing.Point(205, 14);
            this.pbxAll.Name = "pbxAll";
            this.pbxAll.Size = new System.Drawing.Size(202, 206);
            this.pbxAll.TabIndex = 0;
            this.pbxAll.TabStop = false;
            // 
            // dgrdCart
            // 
            this.dgrdCart.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrdCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrdCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrdCart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrdCart.Location = new System.Drawing.Point(551, 28);
            this.dgrdCart.Name = "dgrdCart";
            this.dgrdCart.ReadOnly = true;
            this.dgrdCart.RowHeadersVisible = false;
            this.dgrdCart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgrdCart.Size = new System.Drawing.Size(251, 259);
            this.dgrdCart.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 453);
            this.Controls.Add(this.dgrdCart);
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
            this.tabAll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdCart)).EndInit();
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
        private System.Windows.Forms.DataGridView dgrdAll;
        private System.Windows.Forms.PictureBox pbxAll;
        private System.Windows.Forms.DataGridView dgrdCart;
    }
}

