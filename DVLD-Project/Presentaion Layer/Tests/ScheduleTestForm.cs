using Business_Layer;
using Presentaion_Layer.Tests.Controls;
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
    public partial class ScheduleTestForm: Form
    {
        clsTestAppoinment _AddNewAppoinment = new clsTestAppoinment();
        string _FullName,  _Title;

        
        public ScheduleTestForm(string fullname,string classname,int DLappID,string Title)
        {
            _AddNewAppoinment.LocalDrivingLicenseApplicoationID = DLappID;
            _Title = Title;
            _AddNewAppoinment.licenseClassName.ClassName = classname;
            _FullName = fullname;
            SelectTestTypeID(_Title);

            InitializeComponent();
        }

        private void SelectTestTypeID(string NameOfTest)
        {
            switch (NameOfTest)
            {
                case "Vision Test":
                    _AddNewAppoinment.TestTypeID = (int)clsTestAppoinment.enTestTypeID.VisionTest;
                    break;

                case"Written Test":
                        _AddNewAppoinment.TestTypeID = (int)clsTestAppoinment.enTestTypeID.WrittenTest;
                    break;
                case "Street Test":
                    _AddNewAppoinment.TestTypeID = (int)clsTestAppoinment.enTestTypeID.StreetTest;
                    break;

               
            }
        }

       

        private void scheduleTestControl11_Load(object sender, EventArgs e)
        {
            
        }

        private void ScheduleTestForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
