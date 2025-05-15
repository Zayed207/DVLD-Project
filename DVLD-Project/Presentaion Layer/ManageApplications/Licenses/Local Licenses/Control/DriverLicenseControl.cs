using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Business_Layer;

namespace Presentaion_Layer.ManageApplications.Licenses.Local_Licenses.Control
{


    public partial class DriverLicenseControl: System.Windows.Forms. UserControl
    {
        public DriverLicenseControl()
        {
            InitializeComponent();
        }
      public  byte _IssueReason;
      public  int _licenseID, _DriverID, _Gender;
       public  string _Name="", _NationalNo, _Notes, _ImagePath,_LicenseClass;

       public DateTime _DataIssue, _DataOfBirth, _DateExpiration;
       public bool _IsActive, _IsDetained;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //public static void Broker(int LicenseID)
        //{
        //    GetTheLicenseInfo(LicenseID);
        //}
        
       public  void  GetTheLicenseInfo(int LicenseID)
        {
            if (LicenseID !=-1)
            {
                _licenseID = LicenseID;
                clsLicense.GetDriverLicenseByID(LicenseID, ref _Name, ref _DriverID, ref _LicenseClass,
                  ref _DataIssue, ref _DateExpiration, ref _Notes,
                 ref _NationalNo, ref _IsActive, ref _IssueReason, ref _Gender, ref _DataOfBirth,
                  ref _ImagePath);

                FillTheLicenseCard();
            }
        }

        private void FillTheLicenseCard()
        {
            lblLicenseID.Text = Convert.ToString(_licenseID);
            lblDriverID.Text= Convert.ToString(_DriverID);
            if (_Gender == 0)
            {
                lblGendor.Text = "Male";
            }
            else
            {
                lblGendor.Text = "Female";
            }
            lblIssueReason.Text = Convert.ToString((clsLicense.enIssueReason)_IssueReason);
            lblFullName.Text = _Name;
            lblNationalNo.Text = _NationalNo;
            lblNotes.Text = _Notes;
            lblClass.Text = _LicenseClass;
            lblIssueDate.Text = Convert.ToString(_DataIssue);
            lblDateOfBirth.Text = Convert.ToString(_DataOfBirth);
            lblExpirationDate.Text = Convert.ToString(_DateExpiration);
            if (_IsActive)
            {
                lblIsActive.Text = "Yes";


            }
            else
            {
                lblIsActive.Text = "No";
            }

            _IsDetained = clsDetainedLicense.IsLicenseDetained(_licenseID);
            if (_IsDetained)
            {
                lblIsDetained.Text = "yes";



            }
            else {
                _IsDetained = false;
                lblIsDetained.Text = "No";

            }
        }



        private void DriverLicenseControl_Load(object sender, EventArgs e)
        {
           
        }
    }
}
