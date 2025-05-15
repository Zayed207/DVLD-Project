using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentaion_Layer.ManageApplications.Licenses.Local_Licenses
{
    public partial class ShowLocalLicenseForm : Form
    {
      int  _Licenseid=-1;
        public ShowLocalLicenseForm(int License)
        {
            _Licenseid = License;
            InitializeComponent();
        }

        private void ShowLocalLicenseForm_Load(object sender, EventArgs e)
        {
            driverLicenseControl1.GetTheLicenseInfo(_Licenseid);
        }

        private void driverLicenseControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
