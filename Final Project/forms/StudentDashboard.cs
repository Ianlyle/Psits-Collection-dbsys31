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

namespace Final_Project
{
    public partial class FORM_Students : Form
    {
        private DB_PsitsModel db;
        public FORM_Students()
        {
            InitializeComponent();
            db = new DB_PsitsModel();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FORM_Students_Load(object sender, EventArgs e)
        {
            DgShowEvent.DataSource = db.Events.ToList();
        }
    }
}
