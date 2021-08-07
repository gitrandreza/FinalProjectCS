
namespace SU21_Final_Project
{
    partial class frmManagerViewHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerViewHelp));
            this.tabManagementHelp = new System.Windows.Forms.TabControl();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.tabSalesReport = new System.Windows.Forms.TabPage();
            this.tabSupplier = new System.Windows.Forms.TabPage();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.tabManagementHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManagementHelp
            // 
            this.tabManagementHelp.Controls.Add(this.tabInventory);
            this.tabManagementHelp.Controls.Add(this.tabEmployee);
            this.tabManagementHelp.Controls.Add(this.tabCustomer);
            this.tabManagementHelp.Controls.Add(this.tabSalesReport);
            this.tabManagementHelp.Controls.Add(this.tabSupplier);
            this.tabManagementHelp.Location = new System.Drawing.Point(0, 0);
            this.tabManagementHelp.Name = "tabManagementHelp";
            this.tabManagementHelp.SelectedIndex = 0;
            this.tabManagementHelp.Size = new System.Drawing.Size(789, 599);
            this.tabManagementHelp.TabIndex = 0;
            // 
            // tabInventory
            // 
            this.tabInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabInventory.BackgroundImage")));
            this.tabInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabInventory.Location = new System.Drawing.Point(4, 25);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventory.Size = new System.Drawing.Size(781, 570);
            this.tabInventory.TabIndex = 0;
            this.tabInventory.Text = "Inventory Management";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // tabEmployee
            // 
            this.tabEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabEmployee.BackgroundImage")));
            this.tabEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(781, 570);
            this.tabEmployee.TabIndex = 1;
            this.tabEmployee.Text = "Employee Management";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // tabCustomer
            // 
            this.tabCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCustomer.BackgroundImage")));
            this.tabCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabCustomer.Location = new System.Drawing.Point(4, 25);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Size = new System.Drawing.Size(781, 570);
            this.tabCustomer.TabIndex = 2;
            this.tabCustomer.Text = "Customer Management";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // tabSalesReport
            // 
            this.tabSalesReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabSalesReport.BackgroundImage")));
            this.tabSalesReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabSalesReport.Location = new System.Drawing.Point(4, 25);
            this.tabSalesReport.Name = "tabSalesReport";
            this.tabSalesReport.Size = new System.Drawing.Size(781, 570);
            this.tabSalesReport.TabIndex = 3;
            this.tabSalesReport.Text = "Sales Management";
            this.tabSalesReport.UseVisualStyleBackColor = true;
            // 
            // tabSupplier
            // 
            this.tabSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabSupplier.BackgroundImage")));
            this.tabSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabSupplier.Location = new System.Drawing.Point(4, 25);
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.Size = new System.Drawing.Size(781, 570);
            this.tabSupplier.TabIndex = 4;
            this.tabSupplier.Text = "Supplier Management";
            this.tabSupplier.UseVisualStyleBackColor = true;
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.BackgroundImage")));
            this.btnCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.Maroon;
            this.btnCloseForm.Location = new System.Drawing.Point(4, 602);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(781, 51);
            this.btnCloseForm.TabIndex = 51;
            this.btnCloseForm.Text = "&Close ";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // frmManagerViewHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 653);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.tabManagementHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManagerViewHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager View Help";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManagerViewHelp_FormClosing);
            this.tabManagementHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManagementHelp;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabSalesReport;
        private System.Windows.Forms.TabPage tabSupplier;
        private System.Windows.Forms.Button btnCloseForm;
    }
}