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
    public partial class ForgotPasswordScreen : Form
    {
        public ForgotPasswordScreen()
        {
            InitializeComponent();
        }

        // ChangePassword method to update the password in the database
       /* private void ChangePassword(string username, string newPassword)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\202101800\\Desktop\\Combined\\PolyLearn\\PolyLearn\\Database1.mdf;Integrated Security=True"; // Replace with your actual connection string

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE Users SET Password = @NewPassword WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewPassword", newPassword);
                    command.Parameters.AddWithValue("@Username", username);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Password changed successfully!");
        }
       */

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ForgotPasswordScreen_Load(object sender, EventArgs e)
        {

        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            /*string username = usernameTextBox.Text; // Replace with the actual control for entering the username
            string newPassword = newPasswordTextBox.Text; // Replace with the actual control for entering the new password

            ChangePassword(username, newPassword);*/
        }
    }
}
