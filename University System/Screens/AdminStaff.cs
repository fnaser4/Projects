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
    public partial class AdminStaff : Form
    {
        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;
        public AdminStaff()
        {
            InitializeComponent();
            this.StartPosition = centerScreen;
        }

        private void branchBtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            AdminCourses2 adminCourses = new AdminCourses2();
            adminCourses.Show();
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

        private void AdminStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.database1DataSet.Teacher);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.teacherTableAdapter.Update(this.database1DataSet.Teacher);
            MessageBox.Show("Data Updating Click on the save button to save");
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
