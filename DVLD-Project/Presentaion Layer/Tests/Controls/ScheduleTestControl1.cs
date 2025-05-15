using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Layer;
using static Business_Layer.clsTestAppoinment;
using System.Windows.Controls;


namespace Presentaion_Layer.Tests.Controls
{
    public partial class ScheduleTestControl1:System.Windows.Forms.UserControl
    {
        public ScheduleTestControl1()
        {
            InitializeComponent();
        }

        clsTestAppoinment _newtest =new clsTestAppoinment();


        public void FillTheObject(clsTestAppoinment newappoinment)
        {

            newappoinment.AppoinmentDate = dtpTestDate.Value;
            
        }

        public void FillTheCardOFSchedule(clsTestAppoinment TA,string FullName )
        {
            _newtest = TA;
            lblDrivingClass.Text = TA.licenseClassName.ClassName;
            lblLocalDrivingLicenseAppID.Text = Convert.ToString(TA.LocalDrivingLicenseApplicoationID);
            lblFees.Text = Convert.ToString(clsManageTests.GetPaidFeesInfo(TA.TestTypeID));
            dtpTestDate.Value = DateTime.Now;
            lblFullName.Text = FullName;


        }

        private void gbTestType_Enter(object sender, EventArgs e)
        {
            dtpTestDate.Value = DateTime.Now;
//            select Tests.TestResult,TestAppointments.AppointmentDate from TestAppointments inner join Tests on TestAppointments.TestAppointmentID = Tests.TestAppointmentID
//where TestAppointments.TestAppointmentID = 70
//order by TestAppointments.AppointmentDate desc

//select* from TestAppointments where TestAppointments.LocalDrivingLicenseApplicationID = 31 and TestAppointments.TestTypeID = 2
//order by TestAppointments.AppointmentDate desc

            //cbRetakeTestInfo.Enabled = false;
        }

        private void dtpTestDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _newtest.AppoinmentDate = dtpTestDate.Value;
            _newtest.IsLocked = true;

           _newtest.TestAppoinmentID= clsTestAppoinment.AddNewAppoinmentTest(_newtest.TestTypeID, _newtest.LocalDrivingLicenseApplicoationID, _newtest.AppoinmentDate, _newtest.TestFees, _newtest.CreatedByUserID, _newtest.IsLocked );

            if (clsTestAppoinment.AddNewAppoinmentTest(_newtest.TestTypeID, _newtest.LocalDrivingLicenseApplicoationID, _newtest.AppoinmentDate, _newtest.TestFees, _newtest.CreatedByUserID, _newtest.IsLocked)!=-1);

            {
                MessageBox.Show($" the appoinment in the Center of station in{_newtest.AppoinmentDate} your test appoinment id is {_newtest.TestAppoinmentID}");
            }
           





        }
        private void ScheduleTestControl1_Load(object sender, EventArgs e)
        {



        }

        private void lblUserMessage_Click(object sender, EventArgs e)
        {

        }

        private void lblDrivingClass_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pbTestTypeImage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lblLocalDrivingLicenseAppID_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblTrial_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblFees_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
