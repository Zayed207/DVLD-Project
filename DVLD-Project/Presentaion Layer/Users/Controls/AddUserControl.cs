using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Layer;

namespace Presentaion_Layer.Users.Controls
{
    public partial class AddUserControl: UserControl
    {
        public AddUserControl()
        {
            InitializeComponent();
        }
        clsUser _User =new clsUser();
       
        private void person1_Load(object sender, EventArgs e)
        {

        }

        private void FIllTheLoginfo()
        {


            _User.UserName = txtusername.Text;
            _User.Password = txtuserpassword.Text;


            if (cbisactive.Checked)
                _User.IsActive = true;


            else
                _User.IsActive = false;



                    
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            btnnext.Enabled = false;
            btnsave.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
          _User.UserID = clsUser._AddNewUser(_User.PersonInfo.PersonID, _User.UserName, _User.Password, _User.IsActive);
            lbluserid.Text = Convert.ToString( _User.UserID);
        }

        private void AddUserControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cmbfiltr.SelectedText=="NationalNo")
            {
                _User.PersonInfo = clsPerson.Find(txtfilter.Text);

                //enabled the next button
                if (_User.PersonInfo != null)
                {
                    btnnext.Enabled = true;
                }

            }
            else
            {
              _User.PersonInfo= clsPerson.Find( txtfilter.Text.ToString());
                //enabled the next button
                if (_User.PersonInfo != null)
                {
                    btnnext.Enabled = true;
                }

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AddForm ADDNEWPERSON = new AddForm();
            ADDNEWPERSON.ShowDialog();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            btnsave.Enabled = true;

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
           
        }
    }
}
