using PolyLearn.classes;
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
    public partial class AdminHome : Form
    {
        private static Admin chosenAdmin;
        private bool add = false;
        static Admin Admin
        {
            set { chosenAdmin = value; }
            get { return chosenAdmin; }
        }
        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;
        public AdminHome()
        {
            InitializeComponent();
            this.StartPosition = centerScreen;
        }

        public AdminHome(Admin chosen)
        {
            InitializeComponent();
            chosenAdmin = chosen;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.UniversityBranch' table. You can move, or remove it, as needed.
            this.universityBranchTableAdapter.Fill(this.database1DataSet.UniversityBranch);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminDashboard_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            AdminCourses2 c1 = new AdminCourses2();
            c1.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            AdminStaff s1 = new AdminStaff();
            s1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminServices se1 = new AdminServices();
            se1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminMessages adminMessages = new AdminMessages();
            adminMessages.Show();
            this.Hide();
        }

        private void universityBranchBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.universityBranchBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.universityBranchBindingSource.AddNew();
            add = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.universityBranchBindingSource.AddNew();
            add = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (add)
            {
                this.universityBranchBindingSource.EndEdit();
                this.universityBranchTableAdapter.Update(this.database1DataSet);
                this.universityBranchTableAdapter.Fill(this.database1DataSet.UniversityBranch);
                this.universityBranchBindingSource.MoveLast();
                MessageBox.Show("Your record has been added successfully");
                add = false;
            }
            else
            {
                this.universityBranchTableAdapter.Update(this.database1DataSet);
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            loginScreen l1 = new loginScreen();
            l1.Show();
            this.Hide();
        }
    }
}
