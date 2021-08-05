
namespace SU21_Final_Project
{
    partial class frmHelpEmployeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelpEmployeeView));
            this.tabEmployeeViewHelp = new System.Windows.Forms.TabControl();
            this.tabPOSHelp = new System.Windows.Forms.TabPage();
            this.tabInformation = new System.Windows.Forms.TabPage();
            this.btnReturnEmployeeView = new System.Windows.Forms.Button();
            this.tabEmployeeViewHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEmployeeViewHelp
            // 
            this.tabEmployeeViewHelp.Controls.Add(this.tabPOSHelp);
            this.tabEmployeeViewHelp.Controls.Add(this.tabInformation);
            this.tabEmployeeViewHelp.Location = new System.Drawing.Point(0, 0);
            this.tabEmployeeViewHelp.Name = "tabEmployeeViewHelp";
            this.tabEmployeeViewHelp.SelectedIndex = 0;
            this.tabEmployeeViewHelp.Size = new System.Drawing.Size(861, 674);
            this.tabEmployeeViewHelp.TabIndex = 0;
            // 
            // tabPOSHelp
            // 
            this.tabPOSHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPOSHelp.BackgroundImage")));
            this.tabPOSHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPOSHelp.Location = new System.Drawing.Point(4, 25);
            this.tabPOSHelp.Name = "tabPOSHelp";
            this.tabPOSHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPOSHelp.Size = new System.Drawing.Size(853, 645);
            this.tabPOSHelp.TabIndex = 0;
            this.tabPOSHelp.Text = "Point Of Sale(POS) Help";
            this.tabPOSHelp.UseVisualStyleBackColor = true;
            // 
            // tabInformation
            // 
            this.tabInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabInformation.BackgroundImage")));
            this.tabInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabInformation.Location = new System.Drawing.Point(4, 25);
            this.tabInformation.Name = "tabInformation";
            this.tabInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformation.Size = new System.Drawing.Size(853, 645);
            this.tabInformation.TabIndex = 1;
            this.tabInformation.Text = "Additional Information Help";
            this.tabInformation.UseVisualStyleBackColor = true;
            // 
            // btnReturnEmployeeView
            // 
            this.btnReturnEmployeeView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReturnEmployeeView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturnEmployeeView.BackgroundImage")));
            this.btnReturnEmployeeView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnEmployeeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnEmployeeView.ForeColor = System.Drawing.Color.Maroon;
            this.btnReturnEmployeeView.Location = new System.Drawing.Point(1, 670);
            this.btnReturnEmployeeView.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnEmployeeView.Name = "btnReturnEmployeeView";
            this.btnReturnEmployeeView.Size = new System.Drawing.Size(856, 51);
            this.btnReturnEmployeeView.TabIndex = 49;
            this.btnReturnEmployeeView.Text = "&Close ";
            this.btnReturnEmployeeView.UseVisualStyleBackColor = false;
            this.btnReturnEmployeeView.Click += new System.EventHandler(this.btnReturnEmployeeView_Click);
            // 
            // frmHelpEmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 720);
            this.Controls.Add(this.btnReturnEmployeeView);
            this.Controls.Add(this.tabEmployeeViewHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHelpEmployeeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help Employee View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHelpEmployeeView_FormClosing);
            this.tabEmployeeViewHelp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEmployeeViewHelp;
        private System.Windows.Forms.TabPage tabPOSHelp;
        private System.Windows.Forms.TabPage tabInformation;
        private System.Windows.Forms.Button btnReturnEmployeeView;
    }
}