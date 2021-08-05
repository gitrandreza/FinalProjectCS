
namespace SU21_Final_Project
{
    partial class frmHelpMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelpMain));
            this.btnBacktoMain = new System.Windows.Forms.Button();
            this.pbxHelpMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelpMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBacktoMain
            // 
            this.btnBacktoMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBacktoMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBacktoMain.BackgroundImage")));
            this.btnBacktoMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBacktoMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBacktoMain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBacktoMain.Location = new System.Drawing.Point(0, 624);
            this.btnBacktoMain.Margin = new System.Windows.Forms.Padding(4);
            this.btnBacktoMain.Name = "btnBacktoMain";
            this.btnBacktoMain.Size = new System.Drawing.Size(849, 54);
            this.btnBacktoMain.TabIndex = 48;
            this.btnBacktoMain.Text = "&Close ";
            this.btnBacktoMain.UseVisualStyleBackColor = false;
            this.btnBacktoMain.Click += new System.EventHandler(this.btnBacktoMain_Click);
            // 
            // pbxHelpMain
            // 
            this.pbxHelpMain.Image = ((System.Drawing.Image)(resources.GetObject("pbxHelpMain.Image")));
            this.pbxHelpMain.Location = new System.Drawing.Point(0, 0);
            this.pbxHelpMain.Name = "pbxHelpMain";
            this.pbxHelpMain.Size = new System.Drawing.Size(849, 625);
            this.pbxHelpMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxHelpMain.TabIndex = 49;
            this.pbxHelpMain.TabStop = false;
            // 
            // frmHelpMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 682);
            this.Controls.Add(this.pbxHelpMain);
            this.Controls.Add(this.btnBacktoMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmHelpMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHelpMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHelpMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBacktoMain;
        private System.Windows.Forms.PictureBox pbxHelpMain;
    }
}