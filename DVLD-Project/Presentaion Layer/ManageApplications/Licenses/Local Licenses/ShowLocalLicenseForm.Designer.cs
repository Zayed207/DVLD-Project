namespace Presentaion_Layer.ManageApplications.Licenses.Local_Licenses
{
    partial class ShowLocalLicenseForm
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
            this.driverLicenseControl1 = new Presentaion_Layer.ManageApplications.Licenses.Local_Licenses.Control.DriverLicenseControl();
            this.SuspendLayout();
            // 
            // driverLicenseControl1
            // 
            this.driverLicenseControl1.Location = new System.Drawing.Point(12, 32);
            this.driverLicenseControl1.Name = "driverLicenseControl1";
            this.driverLicenseControl1.Size = new System.Drawing.Size(878, 391);
            this.driverLicenseControl1.TabIndex = 0;
            this.driverLicenseControl1.Load += new System.EventHandler(this.driverLicenseControl1_Load);
            // 
            // ShowLocalLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 408);
            this.Controls.Add(this.driverLicenseControl1);
            this.Name = "ShowLocalLicenseForm";
            this.Text = "ShowLocalLicenseForm";
            this.Load += new System.EventHandler(this.ShowLocalLicenseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Control.DriverLicenseControl driverLicenseControl1;
    }
}