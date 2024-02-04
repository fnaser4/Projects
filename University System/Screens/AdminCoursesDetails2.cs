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

namespace PolyLearn.Screens
{
    public partial class AdminCoursesDetails2 : Form
    {
        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;
        public string progId;
        public AdminCoursesDetails2()
        {
            InitializeComponent();
        }

        public AdminCoursesDetails2(string prog)
        {
            InitializeComponent();
            this.StartPosition = centerScreen;
            progId = prog;
            loadData();
        }

        private void AdminCoursesDetails2_Load(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            //courses
            courses.Items.Clear();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            // string query = "Select courseName From Course";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Load all users
                //  Dictionary<string, User> users = new Dictionary<string, User>();
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
                            if (reader.GetString(reader.GetOrdinal("programId")).Trim() == progId.Trim())
                            {
                                courses.Items.Add(reader.GetString(reader.GetOrdinal("courseId")) + " - " + reader.GetString(reader.GetOrdinal("courseName")));
                            }
                            //Id = reader.GetString(reader.GetOrdinal("userId")),

                        }
                    }
                }
            }
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            AdminCourses2 adminCourses2 = new AdminCourses2();
            adminCourses2.Show();
            this.Hide();
        }

        private void branchBtn_Click(object sender, EventArgs e)
        {
            AdminHome a1 = new AdminHome();
            a1.Show();
            this.Hide();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            AdminStaff a1 = new AdminStaff();
            a1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminServices a1 = new AdminServices();
            a1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AdminMessages a1 = new AdminMessages();
            a1.Show();
            this.Hide();
        }

        private void courses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminCourses2 adminCourses2 = new AdminCourses2();
            adminCourses2.Show();       
            this.Hide();
        }
    }
}
