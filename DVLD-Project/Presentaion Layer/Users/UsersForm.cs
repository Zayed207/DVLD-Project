using Business_Layer;
using Presentaion_Layer.Users.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Layer;
namespace Presentaion_Layer.Users
{
    public partial class UsersForm: Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        clsUser _currentuser;
        private int _ID = -1;

        private void _Refresh()
        {
            dataGridView1.DataSource = clsUser.GetAllUsers();
        }


        private void GetDataFromCard()
        {
          


        }
        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            cmbfiltration.SelectedIndex = 0;
            txtfiltration.Enabled = true;
            cmbisactive.Enabled = false;
            _Refresh();
        }

        private void cmbfiltration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbfiltration.SelectedIndex == 4)
            {
                txtfiltration.Enabled = false;
                cmbisactive.Enabled = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddUersForm AUF = new AddUersForm();
            AUF.ShowDialog();
            _Refresh();
        }

        private void pbclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUser.DeleteUser(_ID);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (e.RowIndex >= 0)
                {
                    dataGridView1.Rows[e.RowIndex].Selected = true;
                    _ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PersonID"].Value);

                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUersForm ADDUF = new AddUersForm();
            ADDUF.ShowDialog();
        }
    }
}
