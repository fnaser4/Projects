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
    public partial class AdminCourseDetails : Form
    {
        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;
        public string progId; 
        public AdminCourseDetails()
        {
            InitializeComponent();
            this.StartPosition = centerScreen;
            loadData();
        }

        public AdminCourseDetails(string prog)
        {
            InitializeComponent();
            progId = prog;
            loadData();
        }



        private void mainLabel_Click(object sender, EventArgs e)
        {

        }

        private void AdminCourseDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.database1DataSet.Course);

        }

        private void courseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void courses_SelectedIndexChanged(object sender, EventArgs e)
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

             
                string userQuery = "SELECT * FROM [Course]";
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
            AdminCourses2 ac1 = new AdminCourses2();
            ac1.Show();
            this.Hide();
        }
    }
}
