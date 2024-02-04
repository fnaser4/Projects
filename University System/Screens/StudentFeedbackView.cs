using PolyLearn.classes;
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
    public partial class StudentFeedbackView : Form
    {
        private Student s1;
        private List<string> users = new List<string>();

        public StudentFeedbackView()
        {
            InitializeComponent();
        }
        public StudentFeedbackView(Student s)
        {
            InitializeComponent();
            UpdateCombo();
            s1 = s;
        }
        private void UpdateCombo()
      
        {
            receiverUsersComboBox.Items.Clear();
            // string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            SqlConnection c1 = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c1;
            c1.ConnectionString = Properties.Settings.Default.Database1ConnectionString;
            using (c1)
            {
                c1.Open();
                string query = "Select * From [Courses]";
                using (cmd = new SqlCommand(query, c1))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            receiverUsersComboBox.Items.Add(reader.GetString(reader.GetOrdinal("courseId")).Trim() + " - " + reader.GetString(reader.GetOrdinal("courseName")));
                            users.Add(reader.GetString(reader.GetOrdinal("courseId")));
                        }
                    }
                }
            }
        }

        private string getReciever()
        {
            if (receiverUsersComboBox.SelectedIndex == null)
            {
                MessageBox.Show("Please choose reciever");
            }
            else
            {
                return users[receiverUsersComboBox.SelectedIndex];
            }
            return "-1";
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
cmd.CommandText = "INSERT INTO Feedbacks (senderUsername, courseId, message) VALUES (@senderUsername, @courseId, @message)";
            cmd.Parameters.AddWithValue("@senderUsername", s1.Id.Trim());
            cmd.Parameters.AddWithValue("@courseId", getReciever());
            cmd.Parameters.AddWithValue("@message", messageRichTxt.Text);
           

            con.ConnectionString = Properties.Settings.Default.Database1ConnectionString;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //mailCount++;
            MessageBox.Show("Feedback Added To database successfully!!!");
            messageRichTxt.Text = "";
        }
        
        
        private void StudentFeedbackView_Load(object sender, EventArgs e)
        {

        }

        private void ViewCoursesBtn_Click(object sender, EventArgs e)
        {
            studentDashboardd sd = new studentDashboardd(s1);
            sd.Show();
            this.Hide();
        }

        private void EmailBtn_Click(object sender, EventArgs e)
        {
            StudentEmailView se = new StudentEmailView(s1);
            se.Show();
            this.Hide();
        }

        private void changePwdBtn_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(s1);
            changePassword.Show();
            this.Hide();
        }

        private void announcmentBtn_Click(object sender, EventArgs e)
        {
            StudentAnnouncements studentAnnouncements = new StudentAnnouncements(s1);
            studentAnnouncements.Show();
            this.Hide();
        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
