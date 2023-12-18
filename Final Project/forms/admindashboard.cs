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

namespace Final_Project.forms
{
    public partial class admindashboard : Form
    {
        private DB_PsitsModel db;
        public admindashboard()
        {
            InitializeComponent();
            db = new DB_PsitsModel();
        }

        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Lbldate_Click(object sender, EventArgs e)
        {
            Lbldate.Text = DateTime.Now.ToLongTimeString();

        }

        private void admindashboard_Load(object sender, EventArgs e)
        {
            Lbldate.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loaduser();
        }

        private void loaduser()
        {
            DatagridStudent.DataSource = db.USERACCOUNTs.ToList();
        }

        private void BtnSignout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
    
        }

        private void BtnAddEvent_Click(object sender, EventArgs e)
        {
            new Events().Show();
            this.Hide();
        }
        private List<int> hiddenRows = new List<int>();
        private void TxtNameSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = TxtNameSearch.Text.ToLower();

            // Clear the list of hidden rows
            hiddenRows.Clear(); 

            // Iterate through the rows in the DataGridView
            for (int i = 0; i < DatagridStudent.Rows.Count; i++)
            {
                // Check if any cell in the row contains the search text
                bool rowContainsSearchText = DatagridStudent.Rows[i].Cells.Cast<DataGridViewCell>().Any(cell =>
                {
                    if (cell.Value != null)
                    {
                        // Handle different cell types if necessary
                        string cellValue = cell.Value.ToString().ToLower();
                        return cellValue.Contains(searchText);
                    }
                    return false;
                });

                // Update the visibility of the row based on whether it contains the search text
                DatagridStudent.Rows[i].Visible = rowContainsSearchText;

                // If the row should be hidden, add its index to the list
                if (!rowContainsSearchText)
                {
                    hiddenRows.Add(i);
                }
            }

            // Update the currency manager's position to a valid index
            DatagridStudent.CurrentCell = null;

            // Handle the case where the currently selected row is hidden
            if (DatagridStudent.CurrentRow != null && !DatagridStudent.CurrentRow.Visible)
            {
                DatagridStudent.CurrentRow.Selected = false;
            }
        }

        private void DatagridStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
