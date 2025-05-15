using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Business_Layer;
namespace Presentaion_Layer
{
    public partial class LoginForm : Form
    {
        string _user, _password;
        bool check ;
        public LoginForm()
        {
            InitializeComponent();
        }

        public static void Remember(string user,string password)
        {
           


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbUser.Select();

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            //MainForm mainForm = new MainForm(check);
            //mainForm.ShowDialog();
            if (!Valedatetxtb())
            {

                MessageBox.Show(" Fill the empty ");

            }

            else
            {

                int id = clsMain.FindByUser(tbUser.Text, tbpassword.Text);

                if (id != -1)
                {
                    if (ckbremember.Checked)
                    {
                        _user = tbUser.Text.ToString().Trim();

                        _password = tbpassword.Text.ToString().Trim();

                        check = true;

                        MainForm main = new MainForm(check);
                        main.ShowDialog();

                    }
                    else
                    {
                        check = false;

                        MainForm main = new MainForm();
                        main.ShowDialog();
                    }


                   



                }
                else
                {

                     MessageBox.Show("User or Password is wrong");
                }
            }
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
       {

        }

        private bool Valedatetxtb()
        {



            if (string.IsNullOrEmpty(tbpassword.Text )  || string.IsNullOrEmpty(tbUser.Text))
            {


                if (string.IsNullOrEmpty(tbpassword.Text))
                {

                    tbpassword.Focus();

                }
                else { 


                    tbUser.Focus();
                
                
                }

                return false;

            }

            return true;
        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ckbremember_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
