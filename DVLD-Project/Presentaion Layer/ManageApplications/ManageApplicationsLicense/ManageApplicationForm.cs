using Business_Layer;
using Presentaion_Layer.Application_Types.Licenses.Local_Licenses;
using Presentaion_Layer.ManageApplications.Licenses.Local_Licenses;
using Presentaion_Layer.Tests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Presentaion_Layer.Application_Types.ManageApplications
{
    public partial class ManageApplicationForm: Form
    {
        public ManageApplicationForm()
        {
            InitializeComponent();
           
        }
        //local driving license application id
       int 
            _ApplicationID

            , _PassedTest;

        int _LDLApplicationID;
        string _ClassName;
        string _FullName;
        string d,_NO;
        private void _refrash()
        {
            dgvLocalDrivingLicenseApplications.DataSource= clsApplications.GetAllApplications();

        }

       private bool IsHeHAsLicense(int appID)
        {
            //appid=ApplicationI
            //_ApplicationID =  clsDrivingLicensesApplicatoin.GetApplicationIDByLocalDrivingLicenseApplicationID(_LDLApplicationID);

            return clsLicense.IsHeHasLicense(appID);

        }

        private int HowManyTestsPassed(int LocalDLApplicationID_)
        {
            int pass = 0;

            for (byte i=1;i<=3;i++)
            {
                if(clsTest.IsTheLastTestPassed(i, LocalDLApplicationID_))
                {
                    pass++;
                }

                else
                {
                    if (i==1)
                    {
                        return pass;

                    }

                }

            }
            return pass;



        }

        private void FillTheNewLicenseObject( ref clsLicense NewLicense)
        {
            int personid = -1;
           
            personid = clsPerson.GetPersonIDByNationalNo(_NO);

            NewLicense.DriverID = clsDriver.AddNewDriver(personid, 1);
            NewLicense.LicenseClassID = clsLicenseClass.GetLicenseClassIDByClassName(_ClassName);
            NewLicense.IssueDate=DateTime.Now;  
            NewLicense.ExpirationDate=DateTime.Now.AddYears(10);
            NewLicense.PaidFees = clsLicenseClass.FeesOfLicenseClass(_ClassName);
            NewLicense.ApplicationID = _ApplicationID;
            NewLicense.Notes = "";
            NewLicense.IssueReason = clsLicense.enIssueReason.FirstTime;
            NewLicense.IsActive = true;
            NewLicense.CreatedByUserID = 1;

        }

        private void DepanedOnTestsPassed(int passed)
        {

            switch (passed)
            {

                case 0:
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
                    showLicenseToolStripMenuItem.Enabled = false;
                    showPersonLicenseHistoryToolStripMenuItem.Enabled = false;
                    break;
                case 1:
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                  
                    break;
                case 2:
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    break;
                case 3:
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                    break;

              



            }

        }

        private void ManageApplicationForm_Load(object sender, EventArgs e)
        {
            
            cmbfilter.SelectedText = "None";
            // dataGridView1.Columns[0].Width = 200;
            //dataGridView1.Columns[1].Width = 80;
            //dataGridView1.Columns[2].Width = 80;
            //dataGridView1.Columns[3].Width = 80;
            //dataGridView1.Columns[4].Width = 80;
            //dataGridView1.Columns[5].Width = 300;
            _refrash();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddLocallicensesForm ALLF = new AddLocallicensesForm();
            ALLF.ShowDialog();
            _refrash();
        }

        private void txtfilter_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void cmbfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //(cmbfilter.SelectedText = "None");
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageApplicationForm_Load_1(object sender, EventArgs e)
        {
           // cmbfilter.SelectedItem = 0;
            _refrash();
        }

        private void dgvLocalDrivingLicenseApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void schedualVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //send the titel of test
            _ApplicationID= clsDrivingLicensesApplicatoin.GetApplicationIDByLocalDrivingLicenseApplicationID(_LDLApplicationID);
            TestAppointmentForm TAFvision = new TestAppointmentForm(_LDLApplicationID, _ApplicationID,_PassedTest,_ClassName,_FullName,"Vision Test");
            TAFvision.ShowDialog();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShowLocalLicenseForm Show = new ShowLocalLicenseForm(_LDLApplicationID);
            //Show.ShowDialog();
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ApplicationID = clsDrivingLicensesApplicatoin.GetApplicationIDByLocalDrivingLicenseApplicationID(_LDLApplicationID);
            TestAppointmentForm TAFvision = new TestAppointmentForm(_LDLApplicationID, _ApplicationID, _PassedTest, _ClassName, _FullName, "Written Test");
            TAFvision.ShowDialog();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ApplicationID = clsDrivingLicensesApplicatoin.GetApplicationIDByLocalDrivingLicenseApplicationID(_LDLApplicationID);
            TestAppointmentForm TAFvision = new TestAppointmentForm(_LDLApplicationID, _ApplicationID, _PassedTest, _ClassName, _FullName, "Street Test");
            TAFvision.ShowDialog();
        }

        private void btnAddNewApplication_Click(object sender, EventArgs e)
        {

        }

        private void dgvLocalDrivingLicenseApplications_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (e.RowIndex >= 0)
                {
                    dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Selected = true;
                    _LDLApplicationID = Convert.ToInt32(dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Cells[0].Value);

                    //Get appliccation ID by Localdrivingappid
                    _ApplicationID = clsDrivingLicensesApplicatoin.GetApplicationIDByLocalDrivingLicenseApplicationID(_LDLApplicationID);
                    if (clsLicense.IsHeHasLicense(_ApplicationID))
                    {
                        ScheduleTestsMenue.Enabled = false;
                        issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;

                    }

                    else
                    {
                        int passed = HowManyTestsPassed(_LDLApplicationID);

                        DepanedOnTestsPassed(passed);

                        if (passed == 3)
                        {
                            _NO = Convert.ToString(dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Cells[2].Value);
                        }

                    }



                    //Local Driving License ApplicationID
                    _PassedTest = Convert.ToInt32(dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Cells[5].Value); //pasedtest
                    _ClassName = Convert.ToString(dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Cells[1].Value);//"DrivingClass"
                    _FullName = Convert.ToString(dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Cells[3].Value);//"FullName"

                }
            }
        }
            
        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLicense NewLicense = new clsLicense();
            FillTheNewLicenseObject( ref NewLicense);
            NewLicense.LicenseID = clsLicense.AddNewLicense(_ApplicationID,NewLicense.DriverID,NewLicense.LicenseClassID,NewLicense.IssueDate,NewLicense.ExpirationDate,NewLicense.Notes,NewLicense.PaidFees,NewLicense.IsActive,(byte)NewLicense.IssueReason,NewLicense.CreatedByUserID);

            MessageBox.Show($"Your LicenseID is {NewLicense.LicenseID} and will Expired in {NewLicense.ExpirationDate}");
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{

            //    if (e.RowIndex >= 0)
            //    {
            //        dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Selected = true;
            //        _LDLApplicationID = Convert.ToInt32(dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Cells[0].Value);

            //        //Get appliccation ID by Localdrivingappid
            //        _ApplicationID = clsDrivingLicensesApplicatoin.GetApplicationIDByLocalDrivingLicenseApplicationID(_LDLApplicationID);
            //        if (clsLicense.IsHeHasLicense(_ApplicationID))
            //        {
            //            ScheduleTestsMenue.Enabled = false;
            //            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;

            //        }

            //        else
            //        {
            //            int passed = HowManyTestsPassed(_LDLApplicationID);

            //            DepanedOnTestsPassed(passed);

            //            if (passed == 3)
            //            {
            //                _NO = Convert.ToString(dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Cells[2].Value);
            //            }

            //        }



            //            //Local Driving License ApplicationID
            //            _PassedTest = Convert.ToInt32(dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Cells[5].Value); //pasedtest
            //        _ClassName=Convert.ToString(dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Cells[1].Value);//"DrivingClass"
            //        _FullName = Convert.ToString(dgvLocalDrivingLicenseApplications.Rows[e.RowIndex].Cells[3].Value);//"FullName"

                }
            }
        
    
}
