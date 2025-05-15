using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Layer;

namespace Presentaion_Layer
{
    public partial class Person: UserControl
    {
        public Person()
        {
            InitializeComponent();
        }
        clsPerson _person=new clsPerson();

        private void FillTheObject(ref clsPerson p)
        {

            p.FirstName = txtfirstname.Text;
            p.SecondName = txtsec.Text;
            p.ThirdName = txtthird.Text;
            p.LastName = txtlast.Text;
            p.NationalNo = txtnationalno.Text;
            p.Email = txtemail.Text;
            p.Address = txtaddress.Text;
            p.Phone = txtphone.Text;
            p.DateOfBirth = dateTimePicker1.Value;
            p.NationalityCountryID = cmbcountry.TabIndex;
            p.ImagePath = pbimage.Location.ToString();
            if (rdmale.Checked)
            {
                p.Gender = 0;

            }
            else
            {
                p.Gender = 1;
            }

        }


        private void FillTheCard()
        {
            txtfirstname.Text = _person.FirstName;

            lblPersonid.Text =  Convert.ToString( _person.PersonID);


            txtsec.Text= _person.SecondName;      
                              
            txtthird.Text= _person.ThirdName;    
                              
            txtlast.Text= _person.LastName ;     
                              
            txtnationalno.Text= _person.NationalNo;
                              
            txtemail.Text= _person.Email;    
                              
            txtaddress.Text= _person.Address;  
                              
            txtphone.Text= _person.Phone;    
                              
            dateTimePicker1.Value= _person.DateOfBirth;

            cmbcountry.TabIndex= _person.NationalityCountryID;


            if (_person.Gender == 0)
            {
                 rdmale.Enabled=true;
            }

            else
            {
                rdfemele.Enabled = true;
            }
            

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Person_Load(object sender, EventArgs e)
        {

        }

        private void lblPersonid_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            FillTheObject(ref _person);
            _person.PersonID= clsPerson.AddNewPerson(_person);
            if (_person.PersonID != -1)
            {
                FillTheCard();
                clsPerson.GetAllData();
            }
            else
            {
                MessageBox.Show("unsucceded opreation");
            }
        }

        private void txtnationalno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
