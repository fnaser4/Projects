using PolyLearn.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyLearn.Screens
{
    public partial class TeacherGradeStudent : Form
    {
        private string programId;
        private string courseId;
        private Teacher t;
        public TeacherGradeStudent()
        {
            InitializeComponent();
            updateassessmentCombo();
            updateStudentCombo();
        }
        private void updateassessmentCombo()
        {
            assessmentCombo.Items.Add("Assessment 1");
            assessmentCombo.Items.Add("Assessment 2");
            assessmentCombo.Items.Add("Assessment 3");
        }

        public TeacherGradeStudent(Teacher t, string program, string course)
        {
            InitializeComponent();
            programId = program;
            courseId = course;
            updateassessmentCombo();
            updateStudentCombo();
            this.t = t;

        }

        private void updateStudentCombo()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM STUDENT";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(reader.GetOrdinal("programEnrolled")).Trim() == programId.Trim())
                            {
                                studentCombo.Items.Add(reader.GetString(reader.GetOrdinal("studentId")).Trim());
                            }
                        }
                    }
                }
            }
        }

        private void course_GradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.course_GradesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet3);

        }

        private void TeacherGradeStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.Course_Grades' table. You can move, or remove it, as needed.
            this.course_GradesTableAdapter.Fill(this.database1DataSet3.Course_Grades);
            udpateGrid();

        }

        private void udpateGrid()
        {
            foreach(DataGridViewRow row in course_GradesDataGridView.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["dataGridViewTextBoxColumn1"].Value.ToString().Trim() != t.CourseAssigned.Trim())
                {
                    course_GradesBindingSource.SuspendBinding();
                    row.Visible = false;
                    course_GradesBindingSource.ResumeBinding();
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void changePassBtn_Click(object sender, EventArgs e) { 
        //{
        //    using (SqlConnection connection1 = new SqlConnection(connectionString))
        //    {
        //        connection1.Open();
        //        using (SqlCommand command1 = new SqlCommand(query, connection1))
        //        {
        //            command1.Parameters.AddWithValue("@v1", uniID);
        //            command1.Parameters.AddWithValue("@v2", getProgramID());


        //            // command1.ExecuteNonQuery();
        //            int result2 = command1.ExecuteNonQuery();
        //            connection1.Close();
                    string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "Insert Into Course_Grades(courseid, studentId," + returnAssessment() + ",published) Values (@v1,@v2,@v3,@v4)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@v1", courseId);
                    command.Parameters.AddWithValue("@v2", selectStudent());
                    command.Parameters.AddWithValue("@v3", grade.Text);
                    command.Parameters.AddWithValue("@v4", 0);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Grade added!, Waiting for Admin moderator to publish");
                    course_GradesDataGridView.Update();
                }

            }
        }

        private string returnAssessment()
        {
            switch (assessmentCombo.SelectedIndex)
            {
                case 0: return "assessment1";
                case 1: return "assessment2";
                case 2: return "assessment3";
            }

            return "";
        }

        private string selectStudent()
        {
            return studentCombo.SelectedItem.ToString().Trim();
        }

        private void branchBtn_Click(object sender, EventArgs e)
        {
            TeacherHome home = new TeacherHome(t);
            home.Show();
            this.Hide();
        }

        private void stuBtn_Click(object sender, EventArgs e)
        {
            TeacherStudent ts = new TeacherStudent(t);
            ts.Show();
            this.Hide();
        }
    }
}
