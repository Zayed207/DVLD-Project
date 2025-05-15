using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Presentaion_Layer.Tests
{
    public partial class Edit: Form
    {
        int _id;
        string _title;
        string _Desc;
        string _fee;
        public Edit(int id,string title,string des,string fees)
        {
            InitializeComponent();

             _id   = Convert.ToInt32(id);
            _title = Convert.ToString(title);
            _Desc = Convert.ToString(des);
            _fee = Convert.ToString(fees);


          

          
        }

        private void Edit_Load(object sender, EventArgs e)
        {

            lblidtest.Text = Convert.ToString(_id);
            txttitle.Text = Convert.ToString(_title);
            txtdescription.Text = Convert.ToString(_Desc);
            txtfees.Text = Convert.ToString(_fee);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //title
            string tit = txttitle.Text.ToString().Trim();
            //description
            string des = txtdescription.Text.ToString().Trim();
            float fee =Convert.ToSingle( txtfees.Text.Trim());

            clsManageTests.UpdateTestType(_id, tit, des, fee);
        }
    }
}
