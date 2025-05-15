using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentaion_Layer.ManageApplications.Detain_License.Controls
{
    public partial class DetainedControl : UserControl
    {
        public DetainedControl()
        {
            InitializeComponent();
        }
       
        //For RelaseForm
        private void FillTheDetainedInfo(clsDetainedLicense DL)
        {

            lblDetainID.Text = Convert.ToString(DL.DetainID);
            lblLiceseid.Text= Convert.ToString(DL.LicenseID);
            lblDetainDate.Text=Convert.ToString(DL.DetainDate);
lblcreatedbyuser.Text= Convert.ToString(DL.CreatedByUserID);
            txtFineFees.Text = Convert.ToString(DL.FineFees);
        }

        public void GetAndFillTheDetainedInfo(int LicenseID)
        {


            clsDetainedLicense _CurrentDetained = new clsDetainedLicense();
            _CurrentDetained.LicenseID = LicenseID;



            _CurrentDetained = clsDetainedLicense.FindByLicenseID(_CurrentDetained.LicenseID);

            FillTheDetainedInfo(_CurrentDetained);




        }

        public void RelaseTheLicense(int License)
        {
           // clsDetainedLicense.
        }
        // For Detained Form

        private void FillTheNewDetained(ref clsDetainedLicense ND)
        {
            ND.ReleaseDate = DateTime.Now;
            ND.CreatedByUserID = 1;
            ND.FineFees = clsDetainedLicense.GetDetainedFeesBy(Convert.ToString(cbdetained.SelectedValue));
        }
        public void AddNewDetained(int License)
        {
            clsDetainedLicense _newLicense = new clsDetainedLicense();
            _newLicense.LicenseID = License;    

            FillTheNewDetained(ref _newLicense);
          _newLicense.DetainID=  clsDetainedLicense._AddNewDetainedLicense(_newLicense.LicenseID, _newLicense.DetainDate, _newLicense.FineFees, _newLicense.CreatedByUserID);
            lblDetainID.Text=_newLicense.LicenseID.ToString();
        }

        //

        private void DetainedControl_Load(object sender, EventArgs e)
        {
            lblDetainDate.Text = DateTime.Now.ToString();
            
        }
    }
}
