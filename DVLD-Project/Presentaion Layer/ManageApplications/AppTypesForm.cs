using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentaion_Layer.Application_Types
{
    public partial class AppTypesForm: Form
    {
        public AppTypesForm()
        {
            InitializeComponent();
        }
        DataTable _dtAllApplicationTypes;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

            
        }

        private void AppTypesForm_Load(object sender, EventArgs e)
        {
            _dtAllApplicationTypes = clsApplicationTypes.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = _dtAllApplicationTypes;
            label2.Text = dgvApplicationTypes.Rows.Count.ToString();

            dgvApplicationTypes.Columns[0].HeaderText = "ID";
            dgvApplicationTypes.Columns[0].Width = 110;

            dgvApplicationTypes.Columns[1].HeaderText = "Title";
            dgvApplicationTypes.Columns[1].Width = 400;

            dgvApplicationTypes.Columns[2].HeaderText = "Fees";
            dgvApplicationTypes.Columns[2].Width = 100;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm((int)dgvApplicationTypes.CurrentRow.Cells[0].Value);
            edit.ShowDialog();
        }
    }
}
