using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentaion_Layer
{
    public partial class PeopleForm: Form
    {

        public PeopleForm( int userid)
        {
            InitializeComponent();
           
            
        }
        private int _ID;

        private void _RefreshbyFiltration()
        {
            dataGridView1.DataSource = clsPerson.GetDataByFiltration(cmbfilter.Text.Trim(),txtfilter.Text.Trim());
        }

        private void _Refresh()
        {
            dataGridView1.DataSource = clsPerson.GetAllData();


        }
     

       
        private void txtfilter_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void txtfilter_VisibleChanged(object sender, EventArgs e)
        {
          
        }

        private void txtfilter_DragEnter(object sender, DragEventArgs e)
        {
         
        }

        private void txtfilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            
                if(txtfilter.Text!="")
                {
                    _Refresh();
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.ShowDialog();
            _Refresh();
        }

        private void txtfilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AddForm d = new AddForm();
            d.ShowDialog();
            _Refresh();
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e,int i)
        {
            if (clsPerson.DeletePerson(_ID))
            {
                MessageBox.Show("succeded delete");
            }
            else
            {
                MessageBox.Show("unsucceded delete");
            }
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

        private void deletePersonToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsPerson.GetAllData();
            cmbfilter.SelectedIndex = 0;
    
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPerson.DeletePerson(_ID);
            _Refresh();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
