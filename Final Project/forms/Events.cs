using Final_Project.AppData;
using Final_Project.forms;
//using Final_Project.Model;
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
    public partial class Events : Form
    {
        public string Eventname = String.Empty;
        private DB_PsitsModel db;
        private UserRepository userRepo;
        public Events()
        {
            InitializeComponent();
            userRepo = new UserRepository();
            db = new DB_PsitsModel();
        }
        private void loaduser()
        {
            Dgevent.DataSource = db.Events.ToList();
        }

        private void BtnADD_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtEventname.Text))
            {
                errorProvider1.SetError(TxtEventname, "Empty field");
                return;

            }

            if (String.IsNullOrEmpty(TxtDate.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(TxtDate, "Empty field");
                return;
            }

            if (String.IsNullOrEmpty(TxtAmount.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(TxtAmount, "Empty field");
                return;
            }

            Event ev = new Event();
            ev.eventName = TxtEventname.Text;
            ev.eventDate = TxtDate.Text;
            ev.eventAmount = int.Parse(TxtAmount.Text);

            db.Events.Add(ev);
            db.SaveChanges();

            //TxtEventname.Clear();
            //TxtDate.Clear();
            //TxtAmount.Clear();
            MessageBox.Show("Event Added!");
            loaduser();

        }

        private void Events_Load(object sender, EventArgs e)
        {
            loaduser();
        }

        private void BtnEDIT_Click(object sender, EventArgs e)
        {
            //Event ev = new Event();
            //ev.eventName = TxtEventname.Text;
            //ev.eventDate = TxtDate.Text;
            //ev.eventAmount = int.Parse(TxtAmount.Text);

            //String strOutputMsg = "";

            //// Validation not allow empty or null value
            //if (String.IsNullOrEmpty(TxtEventname.Text) || String.IsNullOrEmpty(TxtDate.Text) || String.IsNullOrEmpty(TxtAmount.Text))
            //{
            //    errorProvider1.SetError(TxtEventname, "All fields must be filled!");
            //    return;
            //}

            //var userAccount = userRepo.GetUserByUsername(username);

            //if (userAccount != null)
            //{
            //    // Update userAccount with new values
            //    userAccount.EventName = EventName;
            //    userAccount.FirstName = fname;
            //    userAccount.LastName = lname;
            //    userAccount.ContactInfo = con;
            //    userAccount.RoleID = role;

            //    ErrorCode retValue = Repo.UpdateUser(userSelectedId, userAccount, ref strOutputMsg);

            //    if (retValue == ErrorCode.Success)
            //    {
            //        // Clear the errors
            //        errorProvider1.Clear();
            //        MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        loadUser();
            //        // Reset the selected id
            //        userSelectedId = null;

            //        TBPass.Clear();
            //        TBUser.Clear();
            //        TBContact.Clear();
            //        TBFName.Clear();
            //        TBLName.Clear();
            //        CBRole.ResetText();
            //    }
            //    else
            //    {
            //        // Error
            //        MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }
            //}
            //else
            //{
            //    // User not found
            //    MessageBox.Show("User not found.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void BtnDELETE_Click(object sender, EventArgs e)
        {

            String ename = TxtEventname.Text;
            String strOutputMsg = "";

            // Check if the event name is empty or null
            if (string.IsNullOrEmpty(ename))
            {
                MessageBox.Show("No Event Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int? eventId = null; // You might want to assign a valid event ID here if applicable

            // Assuming your RemoveUser method needs some parameters, pass the necessary values
            ErrorCode retValue = userRepo.RemoveUser(EventID, ref strOutputMsg);

            // Rest of your code remains unchanged
            if (retValue == ErrorCode.Success)
            {
                // Clear the errors
                errorProvider1.Clear();

                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loaduser();

                TxtEventname.Clear();
                TxtDate.Clear();
                TxtAmount.Clear();
            }
            else
            {
                // Handle the error
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Dgevent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


