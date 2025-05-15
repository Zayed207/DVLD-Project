namespace Presentaion_Layer.Tests
{
    partial class TestAppoinmentForm1
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
            this.components = new System.ComponentModel.Container();
            this.ApplicationInfoControl = new Presentaion_Layer.ManageApplications.Controls.ApplicationInfoControl();
            this.LicenseInfoControl = new Presentaion_Layer.ManageApplications.Licenses.Controls.LicenseInfoControl();
            this.dgvAppoinment = new System.Windows.Forms.DataGridView();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblrecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmsTestAppoinment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbaddappoinment = new System.Windows.Forms.PictureBox();
            this.pbTest = new System.Windows.Forms.PictureBox();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoinment)).BeginInit();
            this.cmsTestAppoinment.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbaddappoinment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplicationInfoControl
            // 
            this.ApplicationInfoControl.Location = new System.Drawing.Point(12, 515);
            this.ApplicationInfoControl.Name = "ApplicationInfoControl";
            this.ApplicationInfoControl.Size = new System.Drawing.Size(957, 245);
            this.ApplicationInfoControl.TabIndex = 0;
            this.ApplicationInfoControl.Load += new System.EventHandler(this.ApplicationInfoControl_Load);
            // 
            // LicenseInfoControl
            // 
            this.LicenseInfoControl.Location = new System.Drawing.Point(32, 303);
            this.LicenseInfoControl.Name = "LicenseInfoControl";
            this.LicenseInfoControl.Size = new System.Drawing.Size(876, 196);
            this.LicenseInfoControl.TabIndex = 1;
            this.LicenseInfoControl.Load += new System.EventHandler(this.LicenseInfoControl_Load);
            // 
            // dgvAppoinment
            // 
            this.dgvAppoinment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppoinment.Location = new System.Drawing.Point(32, 825);
            this.dgvAppoinment.Name = "dgvAppoinment";
            this.dgvAppoinment.RowHeadersWidth = 51;
            this.dgvAppoinment.RowTemplate.Height = 24;
            this.dgvAppoinment.Size = new System.Drawing.Size(937, 150);
            this.dgvAppoinment.TabIndex = 3;
            this.dgvAppoinment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppoinment_CellContentClick);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(391, 220);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(179, 38);
            this.lbltitle.TabIndex = 4;
            this.lbltitle.Text = "Vision Test";
            // 
            // lblrecord
            // 
            this.lblrecord.AutoSize = true;
            this.lblrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecord.Location = new System.Drawing.Point(117, 993);
            this.lblrecord.Name = "lblrecord";
            this.lblrecord.Size = new System.Drawing.Size(27, 20);
            this.lblrecord.TabIndex = 6;
            this.lblrecord.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 989);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Records";
            // 
            // cmsTestAppoinment
            // 
            this.cmsTestAppoinment.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTestAppoinment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem});
            this.cmsTestAppoinment.Name = "cmsTestAppoinment";
            this.cmsTestAppoinment.Size = new System.Drawing.Size(86, 28);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.cToolStripMenuItem.Text = "c";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(142, 56);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::Presentaion_Layer.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // pbaddappoinment
            // 
            this.pbaddappoinment.Location = new System.Drawing.Point(905, 778);
            this.pbaddappoinment.Name = "pbaddappoinment";
            this.pbaddappoinment.Size = new System.Drawing.Size(54, 41);
            this.pbaddappoinment.TabIndex = 5;
            this.pbaddappoinment.TabStop = false;
            this.pbaddappoinment.Click += new System.EventHandler(this.pbaddappoinment_Click);
            // 
            // pbTest
            // 
            this.pbTest.Location = new System.Drawing.Point(351, 12);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(253, 161);
            this.pbTest.TabIndex = 2;
            this.pbTest.TabStop = false;
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::Presentaion_Layer.Properties.Resources.Test_32;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            // 
            // TestAppoinmentForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 1055);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblrecord);
            this.Controls.Add(this.pbaddappoinment);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.dgvAppoinment);
            this.Controls.Add(this.pbTest);
            this.Controls.Add(this.LicenseInfoControl);
            this.Controls.Add(this.ApplicationInfoControl);
            this.Name = "TestAppoinmentForm1";
            this.Text = "TestAppoinmentForm1";
            this.Load += new System.EventHandler(this.TestAppoinmentForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppoinment)).EndInit();
            this.cmsTestAppoinment.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbaddappoinment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Presentaion_Layer.ManageApplications.Controls.ApplicationInfoControl ApplicationInfoControl;
        private Presentaion_Layer.ManageApplications.Licenses.Controls.LicenseInfoControl LicenseInfoControl;
        private System.Windows.Forms.PictureBox pbTest;
        private System.Windows.Forms.DataGridView dgvAppoinment;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.PictureBox pbaddappoinment;
        private System.Windows.Forms.Label lblrecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cmsTestAppoinment;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}