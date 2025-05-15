using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Layer;
namespace Presentaion_Layer.Tests
{
    public partial class TestAppointmentForm: Form
    {
        int _ApplicationId,_PassedTest;
        string _ClassName;
        string _FullName;
        int _LDLApplictionID;
        string _Title;
        public TestAppointmentForm(int LDLApplictionID,int ApplicationId,int PassedTest,string ClassName,string Fullname,string Title)

        {
            _LDLApplictionID = LDLApplictionID;
            _ApplicationId = ApplicationId;
            _ClassName = ClassName;
            _PassedTest = PassedTest;
            _FullName = Fullname;
            _Title = Title;
            InitializeComponent();
        }

        public void Refreach()
        {
            dataGridView1.DataSource = clsTestAppoinment.GetAppoinmentsByLDLApplicationID(_LDLApplictionID);
        }
        private void ctrlApplicationInfo_Load(object sender, EventArgs e)
        {
          
           // ctrlApplicationInfo._FillTheAppInfo(_ApplicationId,_FullName,_ClassName);
        }

        private void TestAppointmentForm_Load(object sender, EventArgs e)
        {
            lblTitle.Text = _Title;
            //switch (_Title)
            //{
            //    case "Schedule Vision Test":
            //        pbphotooftest.

            //}

        }

        private void pbaddapoinment_Click(object sender, EventArgs e)
        {
           
        }

        private void TestAppointmentForm_Load_1(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TestAppointmentForm
            // 
            this.ClientSize = new System.Drawing.Size(1095, 892);
            this.Name = "TestAppointmentForm";
            this.Load += new System.EventHandler(this.TestAppointmentForm_Load_2);
            this.ResumeLayout(false);

        }

        private void TestAppointmentForm_Load_2(object sender, EventArgs e)
        {

        }

        private void LicenseInfoControl_Load(object sender, EventArgs e)
        {
            //LicenseInfoControl.FillTheLicense(_LDLApplictionID, _PassedTest,_ClassName);

        }
    }
}
