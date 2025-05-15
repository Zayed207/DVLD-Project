namespace Presentaion_Layer
{
    partial class AddForm
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
            this.person1 = new Presentaion_Layer.Person();
            this.SuspendLayout();
            // 
            // person1
            // 
            this.person1.Location = new System.Drawing.Point(5, 12);
            this.person1.Name = "person1";
            this.person1.Size = new System.Drawing.Size(877, 504);
            this.person1.TabIndex = 0;
            this.person1.Load += new System.EventHandler(this.person1_Load);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 528);
            this.Controls.Add(this.person1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Person person1;
    }
}