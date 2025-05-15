using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentaion_Layer.Tests
{
    public partial class TestTypesForm: Form
    {
        public TestTypesForm()
        {
            InitializeComponent();
        }
        DataTable _dgvmanagetests;

        private void TestTypesForm_Load(object sender, EventArgs e)
        {
            _dgvmanagetests = clsManageTests.GetAllTypesOfTest();
            dgvmanagetests.DataSource = _dgvmanagetests;
            lblrecord.Text = dgvmanagetests.Rows.Count.ToString();

            dgvmanagetests.Columns[0].HeaderText = "ID";
            dgvmanagetests.Columns[0].Width = 110;

            dgvmanagetests.Columns[1].HeaderText = "Title";
            dgvmanagetests.Columns[1].Width = 170;

            dgvmanagetests.Columns[2].HeaderText = "Description";
            dgvmanagetests.Columns[2].Width = 600;

            dgvmanagetests.Columns[3].HeaderText = "Fees";
            dgvmanagetests.Columns[3].Width = 100;

        }

        private void cms_Opening(object sender, CancelEventArgs e)
        {

        }

        private void eidtToolStripMenuItem_Click(object sender, EventArgs e)
        {
          int id=  (int)dgvmanagetests.CurrentRow.Cells[0].Value;
            string title= (string)dgvmanagetests.CurrentRow.Cells[1].Value;
           string Description=(string)dgvmanagetests.CurrentRow.Cells[2].Value;
          string fee=  (string)dgvmanagetests.CurrentRow.Cells[3].Value;





            Edit edit = new Edit(id,title,Description,fee);
            edit.ShowDialog();
        }

        private void dgvmanagetests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            
        }
    }
}
