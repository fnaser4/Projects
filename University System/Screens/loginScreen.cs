using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolyLearn.classes;


namespace PolyLearn.Screens
{
    public partial class loginScreen : Form
    {
        public DateTime dateValue = new DateTime(2003, 12, 10);
        // static Admin user1 = new Admin("1", "Noora", "Qasim", "nooraw376@gmail.com", "F", "123", "Admin", 12345678, "12/10/2003");
        // private List<Admin> users = new List<Admin> { user1 };
        classes.System s1 = Program.loadProgram();
        public loginScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void useeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = userName.Text;
            string password = passWord.Text;

           // usernameLabel.Text = "hello";
            List < Student > students = s1.GetStudents();
            // usernameLabel.Text = students[0].Id.ToString();
            //  passwordLabel.Text = students[0].Password.ToString();

            // Assuming 'system' is your instantiated System object
            // Check in the list of students
            foreach (var student in s1.GetStudents())
            {
                // Use breakpoints or logging to check if this loop is being entered
                Console.WriteLine($"Checking student: {student.Id}");
                Console.WriteLine($"Checking student: {student.Password}");

                if (student.Id.Trim() == username.Trim() && student.Password.Trim() == password.Trim())
                {
                    Console.WriteLine("Login successful");
                    studentDashboardd studentPage = new studentDashboardd(student);
                    studentPage.Show();
                    this.Hide();
                    return;
                }
            }

            // Check in the list of teachers
            foreach (var teacher in s1.GetTeachers())
            {
                if (teacher.Id.Trim() == username.Trim() && teacher.Password.Trim() == password.Trim())
                {
                    // Open teacher page
                    TeacherHome teacherPage = new TeacherHome(teacher);
                    teacherPage.Show();
                    this.Hide();
                    return;
                }
            }

            // Check in the list of admins
            foreach (var admin in s1.GetAdmins())
            {
                if (admin.Id.Trim() == username.Trim() && admin.Password.Trim() == password.Trim())
                {
                    // Open admin page
                    AdminHome adminPage = new AdminHome();
                    adminPage.Show();
                    this.Hide();
                    return;
                }
            }

            // User not found or password doesn't match
            MessageBox.Show("Invalid username or password.");
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
          registraionScreen registraionScreen = new registraionScreen();
            registraionScreen.Show();
            this.Hide();
        }

        private void forgotPassLabel_Click(object sender, EventArgs e)
        {
            ForgotPasswordScreen forgotPasswordScreen = new ForgotPasswordScreen();
            forgotPasswordScreen.Show();
            this.Hide();
        }
    }
}
