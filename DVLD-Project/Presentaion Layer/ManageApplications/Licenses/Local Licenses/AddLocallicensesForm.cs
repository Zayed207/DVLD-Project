using Business_Layer;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentaion_Layer.Application_Types.Licenses.Local_Licenses
{
    public partial class AddLocallicensesForm : Form
    {
        
        clsUser _CurrentUser=new clsUser();
        clsPerson _CurrentFindPerson=new clsPerson();
        clsApplications _LocalDrivingLicenseApplication =new clsApplications();
        clsApplications.enMode _mode;
        public AddLocallicensesForm( )
        {
            //_CurrentUser.PersonID = userid;
            //_CurrentUser.UserName = user;
            //_CurrentUser.Password = pass;

            InitializeComponent();
        }


        //public AddLocallicensesForm()
        //{
        //    InitializeComponent();
        //}

        void FillTheCard(clsPerson p ,clsApplications a)
        {
             lblname.Text= p.FirstName + "" + "" + p.SecondName + "" + p.ThirdName + ""    + p.LastName; 
            
            lblnationalno.Text=p.NationalNo;

            lblphone.Text=p.Phone;
            lblemail.Text= p.Email;
            lbladdress.Text= p.Address;
           dateTimePicker1.Value= p.DateOfBirth;
           lblcountry.Text   =Convert.ToString( p.NationalityCountryID);
            if (p.Gender == 0)
            {
                lblgender.Text = "Male";
               
            }
            else
            {
                lblgender.Text = "FeMale";

            }

           //  lblLocalDrivingLicebseApplicationID.Text= Convert.ToString(_LocalDrivingLicenseApplication.ApplicationID);
           // lblApplicationDate.Text = lblLocalDrivingLicebseApplicationID.Text = Convert.ToString(_LocalDrivingLicenseApplication.ApplicationDate);
           // //
           // cbLicenseClass.Enabled = false;
           // txtclassname.Enabled = true;
           //// txtclassname.Text = _LocalDrivingLicenseApplication.LicensesClassname;
           // //
           // lblFees.Text = lblLocalDrivingLicebseApplicationID.Text = Convert.ToString(_LocalDrivingLicenseApplication.PaidFees);
           // lblCreatedByUser.Text = lblLocalDrivingLicebseApplicationID.Text = Convert.ToString(_LocalDrivingLicenseApplication.CreatedByUserID);

        }
        private void LocallicensesForm_Load(object sender, EventArgs e)
        {
            btnsave.Enabled = false;
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            btnsave.Enabled = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {



            if (cmbfilter.Text  == "NationalNo")
            {


               _CurrentFindPerson = clsPerson.Find(txtfilter.Text.ToString());

                if (_CurrentFindPerson == null)
                {
                    MessageBox.Show("person is not founded");


                }
                else
                {
                   
                   // Appinfo=clsApplications.
                    FillTheCard(_CurrentFindPerson, _LocalDrivingLicenseApplication);

                }


                if (cmbfilter.Text == "PersonId")
                {
                    _CurrentFindPerson = clsPerson.Find(Convert.ToInt32(cmbfilter.Items.ToString()));
                }

            }

        } 
        
        
        
        
        

        private void tpappinfo_Click(object sender, EventArgs e)
        {

        }

        private void txtfilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblfirst_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            // validate if he has License
            int LicenseClassID = clsLicenseClass.Find( cbLicenseClass.Text).LicenseClassID;


            int LicenseID = clsApplications.GetActiveApplicationIDForLicenseClass(_CurrentFindPerson.PersonID, clsApplications.enApplicationType.NewDrivingLicense, LicenseClassID);

            
            int ActiveApplicationID = clsApplications.GetActiveApplicationID(_CurrentFindPerson.PersonID, clsApplications.enApplicationType.NewDrivingLicense);
            if (ActiveApplicationID != -1&& LicenseID!=-1)
            {
                MessageBox.Show("Choose another License Class, the selected Person Already have an active application for the selected class with id=" + ActiveApplicationID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbLicenseClass.Focus();
                return;
            }


            //check if user already have issued license of the same driving  class.
            if (clsLicenseClass.IsLicenseExistByPersonID(_CurrentFindPerson.PersonID, LicenseClassID))
            {

                MessageBox.Show("Person already have a license with the same applied driving class, Choose diffrent driving class", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  lblLocalDrivingLicebseApplication.Text= Convert.ToString(_LocalDrivingLicenseApplication.ApplicationID);
                 lblApplicationDate.Text = lblLocalDrivingLicebseApplication.Text = Convert.ToString(_LocalDrivingLicenseApplication.ApplicationDate);
                 //
                 cbLicenseClass.Enabled = false;
                 txtclassname.Enabled = true;
                // txtclassname.Text = _LocalDrivingLicenseApplication.LicensesClassname;
                 //
                 lblFees.Text = lblLocalDrivingLicebseApplication.Text = Convert.ToString(_LocalDrivingLicenseApplication.PaidFees);
                 lblCreatedByUser.Text = lblLocalDrivingLicebseApplication.Text = Convert.ToString(_LocalDrivingLicenseApplication.CreatedByUserID);
                return;
            }
            //int ID=
            _LocalDrivingLicenseApplication.ApplicantPersonID = _CurrentFindPerson.PersonID; 
            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;
            _LocalDrivingLicenseApplication.ApplicationTypeID = 1;
            _LocalDrivingLicenseApplication.ApplicationStatus = clsApplications.enApplicationStatus.New;
            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;
            _LocalDrivingLicenseApplication.PaidFees = 15;
            _LocalDrivingLicenseApplication.CreatedByUserID = 1;
            _LocalDrivingLicenseApplication.Mode = clsApplications.enMode.AddNew;
            _LocalDrivingLicenseApplication.LicenseClassID = LicenseClassID;

            //Add new applicationn

            _LocalDrivingLicenseApplication.ApplicationID = clsApplications._AddNewApplication(_LocalDrivingLicenseApplication.ApplicantPersonID, _LocalDrivingLicenseApplication.ApplicationDate, _LocalDrivingLicenseApplication.ApplicationTypeID,(byte) _LocalDrivingLicenseApplication.ApplicationStatus, _LocalDrivingLicenseApplication.LastStatusDate, _LocalDrivingLicenseApplication.PaidFees, _LocalDrivingLicenseApplication.CreatedByUserID);

            if (_LocalDrivingLicenseApplication.ApplicationID!=-1)
            {
                // lblLocalDrivingLicebseApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
                if (clsDrivingLicensesApplicatoin.AddNewLocalDrivingLicenseApplication(_LocalDrivingLicenseApplication.ApplicationID,LicenseClassID))
                {
                    //change form mode to update.
                    _mode = clsApplications.enMode.Update;
                    lblTitle.Text = "Update Local Driving License Application";

                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblLocalDrivingLicebseApplication.Text = Convert.ToString(_LocalDrivingLicenseApplication.ApplicationID);
                    lblApplicationDate.Text = Convert.ToString(_LocalDrivingLicenseApplication.ApplicationDate);

                    cbLicenseClass.Enabled = false;
                    txtclassname.Enabled = true;
                    // txtclassname.Text = _LocalDrivingLicenseApplication.LicensesClassname;
                    //

                    lblFees.Text =  Convert.ToString(_LocalDrivingLicenseApplication.PaidFees);
                    lblCreatedByUser.Text  = Convert.ToString(_LocalDrivingLicenseApplication.CreatedByUserID);
                }

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);




        }

        private void pbnew_Click(object sender, EventArgs e)
        {
            AddForm af = new AddForm();
            af.ShowDialog();
        }
    }
}

