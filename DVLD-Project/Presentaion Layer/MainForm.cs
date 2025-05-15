using Presentaion_Layer.Application_Types;
using Presentaion_Layer.Application_Types.Licenses.Local_Licenses;
using Presentaion_Layer.Application_Types.ManageApplications;
using Presentaion_Layer.ManageApplications.ReNewLicense;
using Presentaion_Layer.Tests;
using Presentaion_Layer.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentaion_Layer
{
    public partial class MainForm : Form
    {
        private int _UserId;
       // int _PersonId;
        //string _user, _pass;
        bool remember;

        public MainForm(bool check)
        {
            InitializeComponent();
            //_UserId = Id;
            //_user = user;
            //_pass = Password;
           // label1.Text = UserId.ToString();
        }
        public MainForm()
        {
            InitializeComponent();
            //_UserId = Id;
            //_user = user;
            //_pass = Password;
            // label1.Text = UserId.ToString();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UsersForm UF = new UsersForm();
            UF.ShowDialog();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void aplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PeopleForm PF = new PeopleForm(_UserId);
            PF.ShowDialog();    
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AppTypesForm ATF = new AppTypesForm();
            ATF.ShowDialog();
        }

        private void manageTestsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestTypesForm TTF = new TestTypesForm();
            TTF.ShowDialog();
        }

        private void localLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocallicensesForm LLF = new AddLocallicensesForm();
            LLF.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationForm MALF = new ManageApplicationForm();
            MALF.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void renewLocalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReNewLocalLicenseForm RNLF =  new ReNewLocalLicenseForm();
            RNLF.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
