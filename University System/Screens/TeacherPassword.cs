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
    public partial class TeacherPassword : Form
    {
        // declaring variables
        public static string Password;
        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;
        private Teacher t;
        public TeacherPassword(Teacher t)
        {
            InitializeComponent();
            this.StartPosition = centerScreen;
            this.t = t;
        }

        // navigations 
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screens.loginScreen h = new Screens.loginScreen();
            h.Show();
        }

        private void branchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screens.TeacherHome home = new Screens.TeacherHome(t);
            home.Show();
        }

        private void stuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screens.TeacherStudent stu = new Screens.TeacherStudent(t);
            stu.Show();
        }


        private void changePassbtn_Click(object sender, EventArgs e)
        {
            string oldPassword = oldPasswordTextBox.Text;
            string newPassword = newPasswordTextBox.Text;
            string reEnterNewPassword = newPassword2TextBox.Text;

            // Check if the new passwords match
            if (newPassword != reEnterNewPassword)
            {
                MessageBox.Show("The new passwords do not match.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.Database1ConnectionString))
                {
                    conn.Open();

                    // Assuming 'userId' holds the ID of the user whose password is being changed
                    string userId = t.Id; // Replace with actual user ID

                    // Check if the old password is correct
                    if (IsOldPasswordCorrect(conn, userId, oldPassword))
                    {
                        // Update the password to the new one
                        UpdatePassword(conn, userId, newPassword);
                        MessageBox.Show("Password updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Old password is incorrect. Password not updated.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private bool IsOldPasswordCorrect(SqlConnection conn, string userId, string oldPassword)
        {
            string query = "SELECT password FROM [User] WHERE userId = @UserId";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);
                string storedPassword = cmd.ExecuteScalar()?.ToString().Trim();
                return storedPassword == oldPassword;
            }
        }

        private void UpdatePassword(SqlConnection conn, string userId, string newPassword)
        {
            string query = "UPDATE [User] SET password = @NewPassword WHERE userId = @UserId";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NewPassword", newPassword);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.ExecuteNonQuery();

            }
            classes.System s1 = Program.S1;

            foreach (var Teacher in s1.GetTeachers())
            {
                if (Teacher.Id.Trim() == t.Id)
                {
                    Teacher.Password = newPassword;
                }
            }

            Program.S1 = s1;
        }

    }
}
