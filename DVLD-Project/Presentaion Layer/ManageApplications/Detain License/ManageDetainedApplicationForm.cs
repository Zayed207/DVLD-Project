using Business_Layer;
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
    public partial class ManageDetainedApplicationForm : Form
    {
        public ManageDetainedApplicationForm()
        {
            InitializeComponent();
        }

        private void _Refreach()
        {

            dataGridView1.DataSource=clsDetainedLicense.GetAllDetainedLicenses();   
        }
        private void ManageDetainedApplicationForm_Load(object sender, EventArgs e)
        {
            _Refreach();
        }

        private void pbrelase_Click(object sender, EventArgs e)
        {
            RelaseLicenseForm form = new RelaseLicenseForm();
            form.ShowDialog();  
        }

        private void pbdetained_Click(object sender, EventArgs e)
        {
            DetainLicenseForm form = new DetainLicenseForm();   
            form.ShowDialog();  
        }
    }
}
