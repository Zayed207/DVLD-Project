using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Layer;

namespace Presentaion_Layer.ManageApplications.Controls
{
    public partial class ApplicationInfoControl:System.Windows.Forms. UserControl
    {
        public ApplicationInfoControl()
        {
            InitializeComponent();
        }

        clsApplications _currentApplication = new clsApplications();

        // int applictionid,string licensetypee_AppId = applictionid;
        public void _FillTheAppInfo(int Appid, string fullname, string Classname)
        {
            //load the info of application
            _currentApplication = clsApplications.FindBaseApplication(Appid);

            lblApplicationID.Text = Convert.ToString(_currentApplication.ApplicationID);
            lblStatus.Text = _currentApplication.StatusText;
            lblFees.Text = Convert.ToString(_currentApplication.PaidFees);
            lblType.Text = Classname;
            lblApplicant.Text = fullname;
            lblDate.Text = Convert.ToString(_currentApplication.ApplicationDate);
            lblStatusDate.Text = Convert.ToString(_currentApplication.LastStatusDate);
            lblCreatedByUser.Text = Convert.ToString(_currentApplication.CreatedByUserID);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ApplicationInfoControl_Load(object sender, EventArgs e)
        {

        }
    }
}
