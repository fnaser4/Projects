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
    public partial class TeacherHome : Form
    {
        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;
        private Teacher t;
        public TeacherHome()
        {
            InitializeComponent();
            this.t = t;
        }

        public TeacherHome(Teacher t)
        {

            InitializeComponent();
            this.StartPosition = centerScreen;
            coursesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            coursesDataGridView.ClearSelection();
            this.t = t;
            //updateGrid();
        }
        private void updateGrid()

        {
            // Deselect the currently selected row
            coursesDataGridView.ClearSelection();

            //courseDataGridView
            foreach (DataGridViewRow row in coursesDataGridView.Rows)
            {
                if (row.Cells["courseIdColumn"].Value != null){
                    //mainLabel.Text = row.Index.ToString();
                    if (row.Cells["courseIdColumn"].Value != null && row.Cells["courseIdColumn"].Value.ToString().Trim().ToLower() != t.CourseAssigned.ToString().Trim().ToLower())
                    {
                        if (row.IsNewRow) continue;
                        if (row.Index == 0)
                        {
                            if (coursesDataGridView.Rows.Count < 2)
                            {
                                continue;
                            }
                            
                            coursesDataGridView.CurrentCell = coursesDataGridView.Rows[1].Cells[0];
                        }
                        coursesBindingSource.SuspendBinding();
                        row.Visible = false;
                        coursesBindingSource.ResumeBinding();
                    } }
            }
        }
        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);
           

        }

        private void TeacherHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.database1DataSet1.Courses);
           updateGrid();

        }

        private void selectedCourseBtn_Click(object sender, EventArgs e)
        {
            if (coursesDataGridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = coursesDataGridView.SelectedRows[0]; // Assuming only one row can be selected
                string id = selectedRow.Cells["courseIdColumn"].Value.ToString();
                string name = selectedRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString();
                string desc = selectedRow.Cells["courseDescription"].Value.ToString();
                string progId = selectedRow.Cells["programId"].Value.ToString();

                Screens.TeacherSelectCourse cc = new Screens.TeacherSelectCourse(t, id, name, desc, progId);
                cc.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Please select a course.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateGrid();
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            TeacherStudent ts1 = new TeacherStudent(t);
            ts1.Show();
            this.Hide();
        }

        private void coursesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherPassword p = new TeacherPassword(t);
            p.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginScreen l = new loginScreen();
            l.Show();
            this.Hide();
        }
    }
}
