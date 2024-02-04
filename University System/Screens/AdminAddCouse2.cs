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
    public partial class AdminAddCouse2 : Form
    {
        public AdminAddCouse2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);
           

        }
        private bool add = false;

        private void AdminAddCouse2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.database1DataSet1.Courses);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.coursesBindingSource.AddNew();
            add = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.coursesBindingSource.AddNew();
            add = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (add)
            {
                try
                {


                    this.coursesBindingSource.EndEdit();
                    this.coursesTableAdapter.Update(this.database1DataSet1.Courses);
                    this.coursesBindingSource.MoveLast();
                    MessageBox.Show("Your record has been added successfully");
                    add = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter data");
                }
            }
            else
            {
                this.coursesTableAdapter.Update(this.database1DataSet1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = coursesBindingSource.Position;
            DataRow currentRow = this.database1DataSet1.Courses[index];
            MessageBox.Show("Are you sure you want to delete this record");
            currentRow.Delete();
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            AdminCourses2 course = new AdminCourses2();
            course.Show();
            this.Hide();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            AdminStaff adminStaff = new AdminStaff();
            adminStaff.Show();
            this.Hide();
        }

        private void branchBtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
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
    }
}
