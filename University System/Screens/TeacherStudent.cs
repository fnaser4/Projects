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
    public partial class TeacherStudent : Form
    {
        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;
        private Teacher t;
        private string ci;
        public TeacherStudent(Teacher t)
        {
            this.t = t;
            InitializeComponent();
            this.StartPosition = centerScreen;
            studentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void updateGrid()
        {
            //foreach(DataGridViewRow row in studentDataGridView.Rows)
            //{
            //    foreach (DataGridViewRow row in mailDataGridView.Rows)
            //    {
            //        if (row.IsNewRow) continue;
            //        if (row.Index == 0)
            //        {
            //            if (mailDataGridView.Rows.Count < 2)
            //            {
            //                continue;
            //            }
            //            //course_GradesDataGridView.CurrentCell = course_GradesDataGridView.Rows[1].Cells[0];
            //            mailDataGridView.CurrentCell = mailDataGridView.Rows[1].Cells[0];
            //        }

            //        if (row.Cells["dataGridViewTextBoxColumn2"].Value != null)
            //        {
            //            if (row.Cells["dataGridViewTextBoxColumn2"].Value.ToString().Trim() != s.Id.Trim())
            //            {
            //                row.Visible = false;
            //            }
            //        }
            //    }
            // Assuming 'studentDataGridView' is your DataGridView
            // and 'GetProgramIdFromCourseId' is a method you have defined
            foreach (DataGridViewRow row in studentDataGridView.Rows)
            {
                if (row.IsNewRow || row.Index == studentDataGridView.NewRowIndex) continue;  // Skip the new row placeholder

                if (row.Cells["proEn"].Value != null &&
                    row.Cells["proEn"].Value.ToString().Trim() != GetProgramIdFromCourseId(t.CourseAssigned.Trim()))
                {
                    if (studentDataGridView.CurrentRow == row)
                    {
                        // Move to next available row if this is the current row
                        MoveToNextAvailableRow(studentDataGridView, row.Index);
                    }
                    studentBindingSource.SuspendBinding();
                    row.Visible = false; // Now safe to hide the row
                    studentBindingSource.ResumeBinding();
                }
            }
        }

           private void MoveToNextAvailableRow(DataGridView dgv, int currentRowIndex)
            {
                for (int i = currentRowIndex + 1; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].Visible)
                    {
                        dgv.CurrentCell = dgv.Rows[i].Cells[0]; // Assuming the first cell is always visible
                        return;
                    }
                }

                for (int i = currentRowIndex - 1; i >= 0; i--)
                {
                    if (dgv.Rows[i].Visible)
                    {
                        dgv.CurrentCell = dgv.Rows[i].Cells[0];
                        return;
                    }
                }
            }


            private void TeacherStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.database1DataSet.Student);
            updateGrid();

        }

        private void branchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screens.TeacherHome home = new Screens.TeacherHome(t);
            home.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screens.TeacherPassword p = new Screens.TeacherPassword(t);
            p.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screens.loginScreen h = new Screens.loginScreen();
            h.Show();
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = studentDataGridView.SelectedRows[0]; // Assuming only one row can be selected
            string id = selectedRow.Cells["id"].Value.ToString();
            string fName = selectedRow.Cells["firstName"].Value.ToString();
            string lName = selectedRow.Cells["lastName"].Value.ToString();
            string email = selectedRow.Cells["email"].Value.ToString();
            string pro = selectedRow.Cells["proEn"].Value.ToString();

            Screens.TeacherSelectStudent tss = new Screens.TeacherSelectStudent(t, id, fName, lName, pro, email);
            tss.Show();
            this.Hide();
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {

        }



        public string GetProgramIdFromCourseId(string courseId)
        {
            switch (courseId)
            {
                case "CV301":
                case "ETH501":
                case "ML101":
                case "NLP201":
                case "DL401":
                    return "1"; // Assuming these course IDs are associated with program ID 1

                case "EEC401":
                case "PSG501":
                case "RET201":
                case "SEP301":
                case "SPS601":
                    return "2"; // Assuming these course IDs are associated with program ID 2

                case "IB201":
                case "IT101":
                case "MKT301":
                case "ST401":
                case "TRS501":
                    return "3"; // Assuming these course IDs are associated with program ID 3

                // Add more cases as necessary for other course IDs

                default:
                    return "-1";


            } } } }
            

