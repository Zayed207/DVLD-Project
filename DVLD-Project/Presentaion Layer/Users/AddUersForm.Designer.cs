namespace Presentaion_Layer.Users
{
    partial class AddUersForm
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
            this.addUserControl1 = new Presentaion_Layer.Users.Controls.AddUserControl();
            this.SuspendLayout();
            // 
            // addUserControl1
            // 
            this.addUserControl1.Location = new System.Drawing.Point(-9, -37);
            this.addUserControl1.Name = "addUserControl1";
            this.addUserControl1.Size = new System.Drawing.Size(876, 674);
            this.addUserControl1.TabIndex = 0;
            this.addUserControl1.Load += new System.EventHandler(this.addUserControl1_Load);
            // 
            // AddUersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 622);
            this.Controls.Add(this.addUserControl1);
            this.Name = "AddUersForm";
            this.Text = "AddUersForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.AddUserControl addUserControl1;
    }
}