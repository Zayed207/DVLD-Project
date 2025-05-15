using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Layer;
using Presentaion_Layer;
namespace Presentaion_Layer.Tests
{
    public partial class TestAppoinmentForm1: Form
    {
        int _ApplicationId, _PassedTest;
        string _ClassName;
        string _FullName;
        int _LDLApplictionID;
        string _Title;

        //Prepare ElemnetsTo inesrt
        clsTestAppoinment _PrepareElmentes;
        public TestAppoinmentForm1(int LDLApplictionID, int ApplicationId, int PassedTest, string ClassName, string Fullname, string Title)

        {
           _LDLApplictionID= LDLApplictionID;
            _ApplicationId = ApplicationId;
            _ClassName = ClassName;
            _PassedTest = PassedTest;
            _FullName = Fullname;
            _Title = Title;
            InitializeComponent();
        }

        public void Refreach()
        {
            dgvAppoinment.DataSource = clsTestAppoinment.GetAppoinmentsByLDLApplicationID(_LDLApplictionID);
        }
        private void TestAppoinmentForm1_Load(object sender, EventArgs e)
        {
            Refreach();
            lbltitle.Text
                = _Title;
        }

        private void pbaddappoinment_Click(object sender, EventArgs e)
        {
            if (clsTestAppoinment.IsHasAppoinment(_LDLApplictionID))
            {
                MessageBox.Show($"You alraedy has a appoinment in {clsTestAppoinment.GetTheExistDateOfAppoinment(_LDLApplictionID)}");
            }

            else
            {
                ScheduleTestForm scheduleTest = new ScheduleTestForm(_FullName,_ClassName,_LDLApplictionID,_Title);
                scheduleTest.ShowDialog();
                Refreach();
            }
        }

        private void ApplicationInfoControl_Load(object sender, EventArgs e)
        {
            ApplicationInfoControl._FillTheAppInfo(_ApplicationId,_FullName,_ClassName);
        }

        private void dgvAppoinment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LicenseInfoControl_Load(object sender, EventArgs e)
        {
            LicenseInfoControl.FillTheLicense(_LDLApplictionID, _PassedTest, _ClassName);
        }
    }
}
