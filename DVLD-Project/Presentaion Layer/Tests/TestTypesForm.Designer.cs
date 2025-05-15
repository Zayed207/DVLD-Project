namespace Presentaion_Layer.Tests
{
    partial class TestTypesForm
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
            this.dgvmanagetests = new System.Windows.Forms.DataGridView();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblrecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.eidtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanagetests)).BeginInit();
            this.cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvmanagetests
            // 
            this.dgvmanagetests.AllowUserToAddRows = false;
            this.dgvmanagetests.AllowUserToDeleteRows = false;
            this.dgvmanagetests.AllowUserToOrderColumns = true;
            this.dgvmanagetests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmanagetests.ContextMenuStrip = this.cms;
            this.dgvmanagetests.Location = new System.Drawing.Point(12, 280);
            this.dgvmanagetests.Name = "dgvmanagetests";
            this.dgvmanagetests.ReadOnly = true;
            this.dgvmanagetests.RowHeadersWidth = 51;
            this.dgvmanagetests.RowTemplate.Height = 24;
            this.dgvmanagetests.ShowCellErrors = false;
            this.dgvmanagetests.Size = new System.Drawing.Size(1028, 395);
            this.dgvmanagetests.TabIndex = 1;
            this.dgvmanagetests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmanagetests_CellContentClick);
            // 
            // cms
            // 
            this.cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eidtToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(109, 30);
            this.cms.Opening += new System.ComponentModel.CancelEventHandler(this.cms_Opening);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 684);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Records";
            // 
            // lblrecord
            // 
            this.lblrecord.AutoSize = true;
            this.lblrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecord.Location = new System.Drawing.Point(106, 681);
            this.lblrecord.Name = "lblrecord";
            this.lblrecord.Size = new System.Drawing.Size(30, 22);
            this.lblrecord.TabIndex = 4;
            this.lblrecord.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(283, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Manage Test Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentaion_Layer.Properties.Resources.TestType_512;
            this.pictureBox1.Location = new System.Drawing.Point(269, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnclose
            // 
            this.btnclose.Image = global::Presentaion_Layer.Properties.Resources.Close_32;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(936, 678);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(104, 33);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "close";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // eidtToolStripMenuItem
            // 
            this.eidtToolStripMenuItem.Image = global::Presentaion_Layer.Properties.Resources.edit_32;
            this.eidtToolStripMenuItem.Name = "eidtToolStripMenuItem";
            this.eidtToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.eidtToolStripMenuItem.Text = "Eidt";
            this.eidtToolStripMenuItem.Click += new System.EventHandler(this.eidtToolStripMenuItem_Click);
            // 
            // TestTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 726);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblrecord);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvmanagetests);
            this.Controls.Add(this.btnclose);
            this.Name = "TestTypesForm";
            this.Text = "TestTypesForm";
            this.Load += new System.EventHandler(this.TestTypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmanagetests)).EndInit();
            this.cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dgvmanagetests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblrecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem eidtToolStripMenuItem;
    }
}