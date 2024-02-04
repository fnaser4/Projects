using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyLearn.Screens
{
    public partial class AdminCourses2 : Form
    {

        public AdminCourses2()
        {
            InitializeComponent();
            programsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.StartPosition = FormStartPosition.CenterScreen;
           
        }

        private void programsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.programsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void AdminCourses2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Programs' table. You can move, or remove it, as needed.
            this.programsTableAdapter.Fill(this.database1DataSet1.Programs);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = programsDataGridView.SelectedRows[0];
            string id = selectedRow.Cells[0].Value.ToString();
            AdminCoursesDetails2 courseDetails = new AdminCoursesDetails2(id);
            courseDetails.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminAddCouse2 courseDetails = new AdminAddCouse2();
            courseDetails.Show();
            this.Hide();
        }

        private void branchBtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();

        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            AdminStaff adminStaff = new AdminStaff();
            adminStaff.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminServices adminServices = new AdminServices();
            adminServices.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminMessages adminMessages = new AdminMessages();
            adminMessages.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
                    