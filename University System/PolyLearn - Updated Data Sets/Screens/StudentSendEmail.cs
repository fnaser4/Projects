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
using System.Xml.Linq;

namespace PolyLearn.Screens
{
    public partial class StudentSendEmail : Form
    {
        private Student s1;
        private List<string> users = new List<string>();

        public StudentSendEmail(Student s)
        {
            InitializeComponent();
            UpdateCombo();
            s1 = s;
        }

        private void StudentSendEmail_Load(object sender, EventArgs e)
        {

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
                string query = "Select * From [User]";
                using (cmd = new SqlCommand(query, c1))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            receiverUsersComboBox.Items.Add(reader.GetString(reader.GetOrdinal("userId")).Trim() + " - " + reader.GetString(reader.GetOrdinal("firstName")).Trim() + " - " + reader.GetString(reader.GetOrdinal("lastName")).Trim());
                            users.Add(reader.GetString(reader.GetOrdinal("userId")));
                        }
                    }
                }
            }
        }
        private void SendBtn_Click(object sender, EventArgs e)
        {
            //string theSender = Program.userId;
            //string receiver = receiverUsersComboBox.Text;
            //string subject = subjectTxt.Text;
            //string message = messageRichTxt.Text;
            //if (string.IsNullOrEmpty(theSender) || string.IsNullOrEmpty(receiver) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(message))
            //{
            //    MessageBox.Show("Error: Empty Feilds");// Validation failed
            //}
            //else
            //{
            //    SendEmail(theSender, receiver, subject, message);
            //    receiverUsersComboBox.Text = "";
            //    subjectTxt.Text = "";
            //    subjectTxt.Text = "";
            //    messageRichTxt.Text = "";
            //    this.Close();
            //}


            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Mail(senderUsername,recieverUsername,message,subject) values (@v2,@v3,@v4,@v5)";
            // cmd.Parameters.AddWithValue("@v1", 1);
            cmd.Parameters.AddWithValue("@v2", s1.Id.Trim());
            cmd.Parameters.AddWithValue("@v3", getReciever());
            cmd.Parameters.AddWithValue("@v4", messageRichTxt.Text);
            cmd.Parameters.AddWithValue("@v5", subjectTxt.Text);
            con.ConnectionString = Properties.Settings.Default.Database1ConnectionString;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //mailCount++;
            MessageBox.Show("Mail Sent successfully!!!");
        }

        private string getReciever()
        {
            if(receiverUsersComboBox.SelectedIndex == null)
            {
                MessageBox.Show("Please choose reciever");
            }
            else
            {
                return users[receiverUsersComboBox.SelectedIndex];
            }
            return "-1";
        }

        private void receiverUsersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewCoursesBtn_Click(object sender, EventArgs e)
        {
            studentDashboardd studentDashboardd = new studentDashboardd(s1);
            studentDashboardd.Show();
            this.Hide();
        }

        private void EmailBtn_Click(object sender, EventArgs e)
        {
            StudentEmailView StudentEmailView = new StudentEmailView(s1);
            StudentEmailView.Show();
            this.Hide();
        }

        private void FeedbackBtn_Click(object sender, EventArgs e)
        {
            StudentFeedbackView StudentFeedbackView = new StudentFeedbackView(s1);
            StudentFeedbackView.Show();
            this.Hide();
        }

        private void changePwdBtn_Click(object sender, EventArgs e)
        {
            ChangePassword ChangePassword = new ChangePassword(s1);
            ChangePassword.Show();
            this.Hide();
        }

        private void announcmentBtn_Click(object sender, EventArgs e)
        {
            StudentAnnouncements StudentAnnouncements = new StudentAnnouncements(s1);
            StudentAnnouncements.Show();
            this.Hide();
        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {

            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
