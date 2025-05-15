using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentaion_Layer.Application_Types
{
    public partial class EditForm: Form
    {
        int _ID;
        public EditForm(int ID)
        {
            int _ID = ID;
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string Title = txttitle.Text.Trim();
            float Fees = Convert.ToSingle(txtfee.Text.Trim());

          //  clsApplicationTypes.UpdateApplication(_ID,Title,Fees);
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
