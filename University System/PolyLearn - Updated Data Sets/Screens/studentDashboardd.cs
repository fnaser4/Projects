using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using PolyLearn.classes;
using System.Drawing.Text;

namespace PolyLearn.Screens
{
    public partial class studentDashboardd : Form

    {
        private Student student;
        private const FormStartPosition center = FormStartPosition.CenterScreen;

        public studentDashboardd()
        {
           
            InitializeComponent();
            this.StartPosition = center;
        }

        public studentDashboardd(Student s1)
        {

            InitializeComponent();
            this.StartPosition = center;
            student = s1;
        }


        private void studentDashboardd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.database1DataSet.Course);
            // courses
            courses.Items.Clear();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            // string query = "Select courseName From Course";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Load all users
                // Dictionary users = new Dictionary();
                //reCheck();


                string userQuery = "SELECT * FROM [Courses]";
                //label1.Text = progId;
                //query users downloaded
                using (SqlCommand command = new SqlCommand(userQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(reader.GetOrdinal("programId")).Trim() == student.ProgramEnrolled.Trim())
                            {
                                courses.Items.Add(reader.GetString(reader.GetOrdinal("courseId")) + " - " + reader.GetString(reader.GetOrdinal("courseName")));
                            }
                            //Id = reader.GetString(reader.GetOrdinal("userId")),

                        }
                    }
                }
                connection.Close();
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            studentDashboardd studentDashboardd = new studentDashboardd(student);
            studentDashboardd.Show();
            this.Hide();
        }

        private void announcmentBtn_Click(object sender, EventArgs e)
        {
            StudentAnnouncements StudentAnnouncements = new StudentAnnouncements(student);
            StudentAnnouncements.Show();
            this.Hide();
        }

        private void changePwdBtn_Click(object sender, EventArgs e)
        {
            ChangePassword ChangePassword = new ChangePassword(student);
            ChangePassword.Show();
            this.Hide();
        }

        private void FeedbackBtn_Click(object sender, EventArgs e)
        {
            StudentFeedbackView StudentFeedbackView = new StudentFeedbackView(student);
            StudentFeedbackView.Show();
            this.Hide();
        }

        private void EmailBtn_Click(object sender, EventArgs e)
        {
            StudentEmailView StudentEmailView = new StudentEmailView(student);
            StudentEmailView.Show();
            this.Hide();
        }
        public static string courseCode;
        private void button2_Click(object sender, EventArgs e)
        {
            string content = courses.SelectedItem.ToString();
            string courseId = content.Split('-')[0].Trim();
            string courseName = content.Split('-')[1].Trim();




            courseCode = courses.Text;
            if (!string.IsNullOrEmpty(courseCode))
            {
                // Pass the selected course code to the studentCourseDetails form
                //StudentcourseDetails s = new StudentcourseDetails();
                studentCourseDetails s1 = new studentCourseDetails(courseId, courseName, "", "",student);

                s1.Show();

            }
            else
            {
                MessageBox.Show("Please select a course before clicking the button.");
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
