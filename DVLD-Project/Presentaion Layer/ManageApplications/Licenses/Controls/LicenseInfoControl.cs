using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentaion_Layer.ManageApplications.Licenses.Controls
{
    public partial class LicenseInfoControl:System.Windows.Forms. UserControl
    {
        public LicenseInfoControl()
        {
            InitializeComponent();
        }



        public void FillTheLicense(int LDLAppid, int passedtest, string classname)
        {

            lblLocalDrivingLicenseApplicationID.Text = Convert.ToString(LDLAppid);
            lblPassedTests.Text = Convert.ToString(passedtest);
            lblAppliedFor.Text = classname;


        }
        private void LicenseInfoControl_Load(object sender, EventArgs e)
        {

        }
    }
}
