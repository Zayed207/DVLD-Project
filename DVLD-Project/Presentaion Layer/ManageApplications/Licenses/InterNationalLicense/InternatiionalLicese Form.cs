using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentaion_Layer.ManageApplications.Licenses.InterNationalLicense
{
    public partial class InternatiionalLicese_Form: Form
    {
        public InternatiionalLicese_Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void FillTheApplicationInfo()
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilter_TabStopChanged(object sender, EventArgs e)
        {
           if(clsLicense.IsLicenseExist(Convert.ToInt32(txtFilter.Text)))
            {
                lblLocalLicenseID.Text= txtFilter.Text;
            }


        }

        private void InternatiionalLicese_Form_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = Convert.ToString(DateTime.Now);
            lblExpirationDate.Text = Convert.ToString(DateTime.Now.AddYears(1));
            lblIssueDate.Text= Convert.ToString(DateTime.Now);
        }
    }
}
