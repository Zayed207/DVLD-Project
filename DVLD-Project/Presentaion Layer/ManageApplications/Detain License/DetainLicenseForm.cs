using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentaion_Layer.ManageApplications.Detain_License
{
    public partial class DetainLicenseForm: Form
    {
        public DetainLicenseForm()
        {
            

      
                InitializeComponent();
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void DetainLicenseForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            driverLicenseControl1.GetTheLicenseInfo(Convert.ToInt32(txtlicense.Text));
            if (driverLicenseControl1._IsDetained)
            {
                MessageBox.Show("The License Already Take");
                btnDetained.Enabled = false;
                detainedControl1.GetAndFillTheDetainedInfo(Convert.ToInt32(txtlicense.Text));
            }

        }

        private void InitializeComponent()
        {
            this.Filter = new System.Windows.Forms.ListBox();
            this.txtlicense = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.driverLicenseControl1 = new Presentaion_Layer.ManageApplications.Licenses.Local_Licenses.Control.DriverLicenseControl();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnDetained = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.detainedControl1 = new Presentaion_Layer.ManageApplications.Detain_License.Controls.DetainedControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // Filter
            // 
            this.Filter.FormattingEnabled = true;
            this.Filter.ItemHeight = 16;
            this.Filter.Location = new System.Drawing.Point(64, 215);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(831, 84);
            this.Filter.TabIndex = 215;
            // 
            // txtlicense
            // 
            this.txtlicense.Location = new System.Drawing.Point(379, 252);
            this.txtlicense.Name = "txtlicense";
            this.txtlicense.Size = new System.Drawing.Size(205, 22);
            this.txtlicense.TabIndex = 217;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 218;
            this.label3.Text = "License ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(361, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 42);
            this.label6.TabIndex = 219;
            this.label6.Text = "Detain License";
            // 
            // driverLicenseControl1
            // 
            this.driverLicenseControl1.Location = new System.Drawing.Point(50, 305);
            this.driverLicenseControl1.Name = "driverLicenseControl1";
            this.driverLicenseControl1.Size = new System.Drawing.Size(878, 391);
            this.driverLicenseControl1.TabIndex = 212;
            // 
            // btnclose
            // 
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose.Location = new System.Drawing.Point(643, 877);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(124, 38);
            this.btnclose.TabIndex = 222;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // btnDetained
            // 
            this.btnDetained.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetained.Location = new System.Drawing.Point(788, 877);
            this.btnDetained.Name = "btnDetained";
            this.btnDetained.Size = new System.Drawing.Size(118, 38);
            this.btnDetained.TabIndex = 223;
            this.btnDetained.Text = "Detained";
            this.btnDetained.UseVisualStyleBackColor = true;
            this.btnDetained.Click += new System.EventHandler(this.btnDetained_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Presentaion_Layer.Properties.Resources.Detain_512;
            this.pictureBox6.Location = new System.Drawing.Point(342, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(314, 123);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 221;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Presentaion_Layer.Properties.Resources.Detain_32;
            this.pictureBox5.Location = new System.Drawing.Point(673, 248);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 220;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // detainedControl1
            // 
            this.detainedControl1.Location = new System.Drawing.Point(50, 691);
            this.detainedControl1.Name = "detainedControl1";
            this.detainedControl1.Size = new System.Drawing.Size(811, 151);
            this.detainedControl1.TabIndex = 224;
            // 
            // DetainLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 951);
            this.Controls.Add(this.detainedControl1);
            this.Controls.Add(this.btnDetained);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlicense);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.driverLicenseControl1);
            this.Name = "DetainLicenseForm";
            this.Text = "DetainLicenseForm";
            this.Load += new System.EventHandler(this.DetainLicenseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnDetained_Click(object sender, EventArgs e)
        {
            detainedControl1.AddNewDetained(Convert.ToInt32(txtlicense.Text));
        }
    }
}
