
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.pbxAll = new System.Windows.Forms.PictureBox();
            this.lblQuantityAvailable = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gbxSelectedItem = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.gbxSize = new System.Windows.Forms.GroupBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.gbxDecorationOption = new System.Windows.Forms.GroupBox();
            this.radBlank = new System.Windows.Forms.RadioButton();
            this.radPrinted = new System.Windows.Forms.RadioButton();
            this.radEmbroidered = new System.Windows.Forms.RadioButton();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDisplayAmount = new System.Windows.Forms.Button();
            this.gbxAmount = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNameOfUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAll)).BeginInit();
            this.gbxSelectedItem.SuspendLayout();
            this.gbxSize.SuspendLayout();
            this.gbxDecorationOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.gbxAmount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDate.Location = new System.Drawing.Point(346, 13);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 17);
            this.lblDate.TabIndex = 0;
            // 
            // dgvAll
            // 
            this.dgvAll.AllowUserToAddRows = false;
            this.dgvAll.AllowUserToDeleteRows = false;
            this.dgvAll.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAll.Location = new System.Drawing.Point(30, 88);
            this.dgvAll.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.ReadOnly = true;
            this.dgvAll.RowHeadersVisible = false;
            this.dgvAll.RowHeadersWidth = 51;
            this.dgvAll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAll.Size = new System.Drawing.Size(143, 227);
            this.dgvAll.TabIndex = 6;
            this.dgvAll.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAll_CellClick);
            // 
            // pbxAll
            // 
            this.pbxAll.Location = new System.Drawing.Point(310, 78);
            this.pbxAll.Margin = new System.Windows.Forms.Padding(4);
            this.pbxAll.Name = "pbxAll";
            this.pbxAll.Size = new System.Drawing.Size(215, 200);
            this.pbxAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxAll.TabIndex = 0;
            this.pbxAll.TabStop = false;
            // 
            // lblQuantityAvailable
            // 
            this.lblQuantityAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantityAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityAvailable.Location = new System.Drawing.Point(584, 18);
            this.lblQuantityAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityAvailable.Name = "lblQuantityAvailable";
            this.lblQuantityAvailable.Size = new System.Drawing.Size(75, 26);
            this.lblQuantityAvailable.TabIndex = 18;
            this.lblQuantityAvailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Eras Demi ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblPrice.Location = new System.Drawing.Point(276, 330);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 28);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbxSelectedItem
            // 
            this.gbxSelectedItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxSelectedItem.Controls.Add(this.label3);
            this.gbxSelectedItem.Controls.Add(this.tbxDescription);
            this.gbxSelectedItem.Controls.Add(this.btnAddToList);
            this.gbxSelectedItem.Controls.Add(this.label6);
            this.gbxSelectedItem.Controls.Add(this.cboColor);
            this.gbxSelectedItem.Controls.Add(this.gbxSize);
            this.gbxSelectedItem.Controls.Add(this.gbxDecorationOption);
            this.gbxSelectedItem.Controls.Add(this.tbxQuantity);
            this.gbxSelectedItem.Controls.Add(this.label4);
            this.gbxSelectedItem.Controls.Add(this.lblQuantityAvailable);
            this.gbxSelectedItem.Controls.Add(this.label5);
            this.gbxSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSelectedItem.Location = new System.Drawing.Point(30, 366);
            this.gbxSelectedItem.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSelectedItem.Name = "gbxSelectedItem";
            this.gbxSelectedItem.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSelectedItem.Size = new System.Drawing.Size(748, 272);
            this.gbxSelectedItem.TabIndex = 4;
            this.gbxSelectedItem.TabStop = false;
            this.gbxSelectedItem.Text = "Choose your features";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Description:";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescription.Location = new System.Drawing.Point(14, 47);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.ReadOnly = true;
            this.tbxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDescription.Size = new System.Drawing.Size(251, 192);
            this.tbxDescription.TabIndex = 33;
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackColor = System.Drawing.Color.DimGray;
            this.btnAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddToList.Location = new System.Drawing.Point(613, 227);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(129, 28);
            this.btnAddToList.TabIndex = 28;
            this.btnAddToList.Text = "&Add Item";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(610, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 32;
            this.label6.Text = "Color:";
            // 
            // cboColor
            // 
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Yellow",
            "White",
            "Green",
            "Black",
            "Grey",
            "Pink"});
            this.cboColor.Location = new System.Drawing.Point(613, 77);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(121, 24);
            this.cboColor.TabIndex = 31;
            // 
            // cboCategory
            // 
            this.cboCategory.Enabled = false;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "All ",
            "Clothes",
            "Bags",
            "Gifts"});
            this.cboCategory.Location = new System.Drawing.Point(163, 657);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(113, 24);
            this.cboCategory.TabIndex = 33;
            this.cboCategory.Text = "All ";
            this.cboCategory.Visible = false;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // gbxSize
            // 
            this.gbxSize.Controls.Add(this.radLarge);
            this.gbxSize.Controls.Add(this.radMedium);
            this.gbxSize.Controls.Add(this.radSmall);
            this.gbxSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSize.Location = new System.Drawing.Point(457, 66);
            this.gbxSize.Name = "gbxSize";
            this.gbxSize.Size = new System.Drawing.Size(138, 177);
            this.gbxSize.TabIndex = 30;
            this.gbxSize.TabStop = false;
            this.gbxSize.Text = "Size";
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(6, 132);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(66, 21);
            this.radLarge.TabIndex = 29;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Location = new System.Drawing.Point(7, 86);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(78, 21);
            this.radMedium.TabIndex = 28;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(7, 42);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(63, 21);
            this.radSmall.TabIndex = 27;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // gbxDecorationOption
            // 
            this.gbxDecorationOption.Controls.Add(this.radBlank);
            this.gbxDecorationOption.Controls.Add(this.radPrinted);
            this.gbxDecorationOption.Controls.Add(this.radEmbroidered);
            this.gbxDecorationOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDecorationOption.Location = new System.Drawing.Point(281, 66);
            this.gbxDecorationOption.Name = "gbxDecorationOption";
            this.gbxDecorationOption.Size = new System.Drawing.Size(160, 177);
            this.gbxDecorationOption.TabIndex = 23;
            this.gbxDecorationOption.TabStop = false;
            this.gbxDecorationOption.Text = "Decoration ";
            // 
            // radBlank
            // 
            this.radBlank.AutoSize = true;
            this.radBlank.Location = new System.Drawing.Point(6, 132);
            this.radBlank.Name = "radBlank";
            this.radBlank.Size = new System.Drawing.Size(64, 21);
            this.radBlank.TabIndex = 29;
            this.radBlank.TabStop = true;
            this.radBlank.Text = "Blank";
            this.radBlank.UseVisualStyleBackColor = true;
            // 
            // radPrinted
            // 
            this.radPrinted.AutoSize = true;
            this.radPrinted.Location = new System.Drawing.Point(7, 86);
            this.radPrinted.Name = "radPrinted";
            this.radPrinted.Size = new System.Drawing.Size(74, 21);
            this.radPrinted.TabIndex = 28;
            this.radPrinted.TabStop = true;
            this.radPrinted.Text = "Printed";
            this.radPrinted.UseVisualStyleBackColor = true;
            // 
            // radEmbroidered
            // 
            this.radEmbroidered.AutoSize = true;
            this.radEmbroidered.Location = new System.Drawing.Point(7, 42);
            this.radEmbroidered.Name = "radEmbroidered";
            this.radEmbroidered.Size = new System.Drawing.Size(110, 21);
            this.radEmbroidered.TabIndex = 27;
            this.radEmbroidered.TabStop = true;
            this.radEmbroidered.Text = "Embroidered";
            this.radEmbroidered.UseVisualStyleBackColor = true;
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuantity.Location = new System.Drawing.Point(389, 22);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(75, 22);
            this.tbxQuantity.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Enter Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(508, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Available:";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.DimGray;
            this.btnAdmin.Enabled = false;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdmin.Location = new System.Drawing.Point(30, 654);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(129, 28);
            this.btnAdmin.TabIndex = 23;
            this.btnAdmin.Text = "&Admin Only";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUser.Location = new System.Drawing.Point(601, 11);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 17);
            this.lblUser.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(517, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "User ID#:";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvList.Location = new System.Drawing.Point(643, 92);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(493, 186);
            this.dgvList.TabIndex = 27;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DimGray;
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemove.Location = new System.Drawing.Point(688, 285);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(129, 28);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "&Remove Item";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDisplayAmount
            // 
            this.btnDisplayAmount.BackColor = System.Drawing.Color.DimGray;
            this.btnDisplayAmount.Enabled = false;
            this.btnDisplayAmount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplayAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAmount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDisplayAmount.Location = new System.Drawing.Point(946, 285);
            this.btnDisplayAmount.Name = "btnDisplayAmount";
            this.btnDisplayAmount.Size = new System.Drawing.Size(149, 28);
            this.btnDisplayAmount.TabIndex = 28;
            this.btnDisplayAmount.Text = "&DisplayTotal";
            this.btnDisplayAmount.UseVisualStyleBackColor = false;
            this.btnDisplayAmount.Click += new System.EventHandler(this.btnDisplayAmount_Click);
            // 
            // gbxAmount
            // 
            this.gbxAmount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbxAmount.Controls.Add(this.lblTotalAmount);
            this.gbxAmount.Controls.Add(this.btnReset);
            this.gbxAmount.Controls.Add(this.lblTaxAmount);
            this.gbxAmount.Controls.Add(this.lblSubTotal);
            this.gbxAmount.Controls.Add(this.label10);
            this.gbxAmount.Controls.Add(this.label9);
            this.gbxAmount.Controls.Add(this.label7);
            this.gbxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAmount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxAmount.Location = new System.Drawing.Point(799, 366);
            this.gbxAmount.Name = "gbxAmount";
            this.gbxAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbxAmount.Size = new System.Drawing.Size(338, 262);
            this.gbxAmount.TabIndex = 29;
            this.gbxAmount.TabStop = false;
            this.gbxAmount.Text = "Amount to Pay";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Eras Demi ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalAmount.Location = new System.Drawing.Point(147, 134);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 19);
            this.lblTotalAmount.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DimGray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Location = new System.Drawing.Point(167, 227);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 28);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Eras Demi ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTaxAmount.Location = new System.Drawing.Point(147, 86);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(0, 19);
            this.lblTaxAmount.TabIndex = 6;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Eras Demi ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubTotal.Location = new System.Drawing.Point(147, 36);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(0, 19);
            this.lblSubTotal.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tax Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sub Total";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckout.Location = new System.Drawing.Point(966, 654);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(129, 28);
            this.btnCheckout.TabIndex = 30;
            this.btnCheckout.Text = "&Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.btnExit.Location = new System.Drawing.Point(419, 654);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 28);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(699, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Name:";
            // 
            // lblNameOfUser
            // 
            this.lblNameOfUser.AutoSize = true;
            this.lblNameOfUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNameOfUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameOfUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNameOfUser.Location = new System.Drawing.Point(757, 12);
            this.lblNameOfUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameOfUser.Name = "lblNameOfUser";
            this.lblNameOfUser.Size = new System.Drawing.Size(0, 16);
            this.lblNameOfUser.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Select Item to customize: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(644, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "Your Order List:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblName.Location = new System.Drawing.Point(58, 330);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 23);
            this.lblName.TabIndex = 38;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DimGray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(958, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(129, 28);
            this.btnLogout.TabIndex = 39;
            this.btnLogout.Text = "&Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNameOfUser);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 51);
            this.panel1.TabIndex = 41;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1149, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.pbxAll);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.dgvAll);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbxAmount);
            this.Controls.Add(this.btnDisplayAmount);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.gbxSelectedItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "2021.05.02";
            this.Text = "Imprint Manager System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAll)).EndInit();
            this.gbxSelectedItem.ResumeLayout(false);
            this.gbxSelectedItem.PerformLayout();
            this.gbxSize.ResumeLayout(false);
            this.gbxSize.PerformLayout();
            this.gbxDecorationOption.ResumeLayout(false);
            this.gbxDecorationOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.gbxAmount.ResumeLayout(false);
            this.gbxAmount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.PictureBox pbxAll;
        private System.Windows.Forms.Label lblQuantityAvailable;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox gbxSelectedItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxDecorationOption;
        private System.Windows.Forms.RadioButton radBlank;
        private System.Windows.Forms.RadioButton radPrinted;
        private System.Windows.Forms.RadioButton radEmbroidered;
        private System.Windows.Forms.GroupBox gbxSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDisplayAmount;
        private System.Windows.Forms.GroupBox gbxAmount;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lblNameOfUser;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
    }
}

