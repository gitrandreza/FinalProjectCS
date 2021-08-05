
namespace SU21_Final_Project
{
    partial class frmAddEmployeeHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEmployeeHelp));
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.Gray;
            this.btnCloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.BackgroundImage")));
            this.btnCloseForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseForm.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnCloseForm.FlatAppearance.BorderSize = 4;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.Sienna;
            this.btnCloseForm.Location = new System.Drawing.Point(2, 552);
            this.btnCloseForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(570, 59);
            this.btnCloseForm.TabIndex = 5;
            this.btnCloseForm.Text = "&Close";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // frmAddEmployeeHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(572, 611);
            this.Controls.Add(this.btnCloseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddEmployeeHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee Help";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEmployeeHelp_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseForm;
    }
}