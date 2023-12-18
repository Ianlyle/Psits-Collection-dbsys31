using Final_Project.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Final_Project
{
    public partial class Signup : Form
    {
        public string username = String.Empty;
        DB_PsitsModel db;

        private UserRepository userRepo;
        public Signup()
        {
            InitializeComponent();
            userRepo= new UserRepository();
            db = new DB_PsitsModel();
        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtUsername.Text))
            {
                errorProvider1.SetError(TxtUsername, "Empty field");
                return;

            }

            if (String.IsNullOrEmpty(TxtPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(TxtPassword, "Empty field");
                return;
            }

            if (String.IsNullOrEmpty(TxtConfirm.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(TxtConfirm, "Empty field");
                return;
            }

            if (!TxtPassword.Text.Equals(TxtConfirm.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(TxtConfirm, "Password not match");
                return;
            }

            USERACCOUNT nUserAccount = new USERACCOUNT();
            nUserAccount.username = TxtUsername.Text;
            nUserAccount.userpassword = TxtPassword.Text;
            nUserAccount.ROLEID = (Int32)CbRole.SelectedValue;
            nUserAccount.idnumber = int.Parse(TxtIdnum.Text); 
            username = TxtUsername.Text;
            db.USERACCOUNTs.Add(nUserAccount);
            db.SaveChanges();

            TxtPassword.Clear();
            TxtConfirm.Clear();
            TxtUsername.Clear();
            MessageBox.Show("Registered!");

            new Form1().Show();
            this.Hide();

        }

        //


        private void CbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadCbBoxRole()
        {
            // SELECT * FROM ROLE
            var roles = db.Roles.ToList();

            CbRole.ValueMember = "roleId";
            CbRole.DisplayMember = "roleName";
            CbRole.DataSource = roles;

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            LoadCbBoxRole();
        }

        private void LblLogin_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void Cbshow_CheckedChanged(object sender, EventArgs e)
        {
            if (Cbshow.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
                TxtConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
                TxtConfirm.UseSystemPasswordChar = true;
            }
        }
    }
}
