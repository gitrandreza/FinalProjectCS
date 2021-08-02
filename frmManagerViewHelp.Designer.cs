
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
            this.tabInventoryHelp = new System.Windows.Forms.TabPage();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.tabSalesReport = new System.Windows.Forms.TabPage();
            this.tabSupplier = new System.Windows.Forms.TabPage();
            this.btnReturnEmployeeView = new System.Windows.Forms.Button();
            this.tabManagementHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabManagementHelp
            // 
            this.tabManagementHelp.Controls.Add(this.tabInventoryHelp);
            this.tabManagementHelp.Controls.Add(this.tabEmployee);
            this.tabManagementHelp.Controls.Add(this.tabCustomer);
            this.tabManagementHelp.Controls.Add(this.tabSalesReport);
            this.tabManagementHelp.Controls.Add(this.tabSupplier);
            this.tabManagementHelp.Location = new System.Drawing.Point(0, 0);
            this.tabManagementHelp.Name = "tabManagementHelp";
            this.tabManagementHelp.SelectedIndex = 0;
            this.tabManagementHelp.Size = new System.Drawing.Size(891, 657);
            this.tabManagementHelp.TabIndex = 0;
            // 
            // tabInventoryHelp
            // 
            this.tabInventoryHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabInventoryHelp.BackgroundImage")));
            this.tabInventoryHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabInventoryHelp.Location = new System.Drawing.Point(4, 25);
            this.tabInventoryHelp.Name = "tabInventoryHelp";
            this.tabInventoryHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabInventoryHelp.Size = new System.Drawing.Size(883, 628);
            this.tabInventoryHelp.TabIndex = 0;
            this.tabInventoryHelp.Text = "Inventory Management Help";
            this.tabInventoryHelp.UseVisualStyleBackColor = true;
            // 
            // tabEmployee
            // 
            this.tabEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabEmployee.BackgroundImage")));
            this.tabEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployee.Size = new System.Drawing.Size(883, 628);
            this.tabEmployee.TabIndex = 1;
            this.tabEmployee.Text = "Employee Management Help";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // tabCustomer
            // 
            this.tabCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCustomer.BackgroundImage")));
            this.tabCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCustomer.Location = new System.Drawing.Point(4, 25);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Size = new System.Drawing.Size(883, 628);
            this.tabCustomer.TabIndex = 2;
            this.tabCustomer.Text = "Customer Management Help";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // tabSalesReport
            // 
            this.tabSalesReport.Location = new System.Drawing.Point(4, 25);
            this.tabSalesReport.Name = "tabSalesReport";
            this.tabSalesReport.Size = new System.Drawing.Size(883, 628);
            this.tabSalesReport.TabIndex = 3;
            this.tabSalesReport.Text = "Sales Management help";
            this.tabSalesReport.UseVisualStyleBackColor = true;
            // 
            // tabSupplier
            // 
            this.tabSupplier.Location = new System.Drawing.Point(4, 25);
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.Size = new System.Drawing.Size(849, 628);
            this.tabSupplier.TabIndex = 4;
            this.tabSupplier.Text = "Supplier Management Help";
            this.tabSupplier.UseVisualStyleBackColor = true;
            // 
            // btnReturnEmployeeView
            // 
            this.btnReturnEmployeeView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReturnEmployeeView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturnEmployeeView.BackgroundImage")));
            this.btnReturnEmployeeView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnEmployeeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnEmployeeView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturnEmployeeView.Location = new System.Drawing.Point(0, 651);
            this.btnReturnEmployeeView.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnEmployeeView.Name = "btnReturnEmployeeView";
            this.btnReturnEmployeeView.Size = new System.Drawing.Size(890, 55);
            this.btnReturnEmployeeView.TabIndex = 50;
            this.btnReturnEmployeeView.Text = "&Close ";
            this.btnReturnEmployeeView.UseVisualStyleBackColor = false;
            // 
            // frmManagerViewHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(890, 707);
            this.Controls.Add(this.btnReturnEmployeeView);
            this.Controls.Add(this.tabManagementHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManagerViewHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager View Help";
            this.tabManagementHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabManagementHelp;
        private System.Windows.Forms.TabPage tabInventoryHelp;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabSalesReport;
        private System.Windows.Forms.TabPage tabSupplier;
        private System.Windows.Forms.Button btnReturnEmployeeView;
    }
}