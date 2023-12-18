using Final_Project.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        UserRepository userRepo;

        public Form1()
        {
            InitializeComponent();
            userRepo = new UserRepository();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtUsername.Text))
            {
                errorProvider1.SetError(TxtUsername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(TxtPassword.Text))
            {
                errorProvider1.SetError(TxtPassword, "Empty Field!");
                return;
            }

            var userLogged = userRepo.GetUserByUsername(TxtUsername.Text);

            if (userLogged != null)
            {
                if (userLogged.userpassword.Equals(TxtPassword.Text))
                {
                    // Assigned to a singleton
                    GetSet.GetInstance().UserAccount = userLogged;

                    switch ((Role)userLogged.ROLEID)
                    {
                        case Role.Student:
                            // Load student Dashboard
                            new FORM_Students().Show();
                            this.Hide();
                            break;
                        case Role.PSITS_Officer:
                            // Load Teacher Dashboard
                            new Officer().Show();
                            this.Hide();
                            break;
                        case Role.Admin:
                            // Load Admin Dashboard
                            new admindashboard().Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("User has no role!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Username not found");
            }


            //private void checkBox1_CheckedChanged(object sender, EventArgs e)
            //{
            //    if (checkBox1.Checked)
            //    {
            //        string pass = checkBox1.Text;
            //        TxtPassword.PasswordChar = '\0';
            //    }
            //    else
            //    {
            //        TxtPassword.PasswordChar = '*';

            //    }
            //}
        }



        private void LblSignup_Click_1(object sender, EventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }

        private void CbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (CbShow.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
