using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolyLearn.classes;
using System.Data.SqlClient;
using PolyLearn.Screens;

namespace PolyLearn
{
    internal static class Program
    {

       private static classes.System s1 = new classes.System();
        private static classes.Singleton x1 = Singleton.Instance;
        public static string connections = x1.getConnection();

        public static classes.System S1 { get { return s1; }  set { s1 = value; } }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loadProgram();


            Screens.loginScreen mainForm = new loginScreen(); // Replace MainForm with the actual name of your main form
            mainForm.StartPosition = FormStartPosition.CenterScreen; // Set the start position
            Application.Run(mainForm);
            //Application.Run(new Login());
            //Application.Run(new Screens.AdminHome().);
        }

        public static classes.System loadProgram()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Load all users
                Dictionary<string, User> users = new Dictionary<string, User>();
                string userQuery = "SELECT * FROM [User]";

                //query users downloaded
                using (SqlCommand command = new SqlCommand(userQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User
                            {
                                Id = reader.GetString(reader.GetOrdinal("userId")),
                                FirstName = reader.GetString(reader.GetOrdinal("firstName")), // Example column name
                                LastName = reader.GetString(reader.GetOrdinal("lastName")),
                                Email = reader.GetString(reader.GetOrdinal("email")),
                                Gender = reader.GetString(reader.GetOrdinal("gender")),
                                Password = reader.GetString(reader.GetOrdinal("password")),
                                PhoneNumber = reader.GetInt32(reader.GetOrdinal("phoneNumber")), // Assuming it's an int
                                DateOfBirth = reader.GetString(reader.GetOrdinal("dateOfBirth")) // Assuming it's stored as string
                            };
                            users[user.Id] = user;
                        }
                    }
                }

                // Load students and match to users
                string studentQuery = "SELECT * FROM Student";
                using (SqlCommand command = new SqlCommand(studentQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userId = reader.GetString(reader.GetOrdinal("studentId"));
                            if (users.TryGetValue(userId, out User user))
                            {
                                Student student = new Student(user)
                                {
                                    // Populate Student-specific properties
                                    ProgramEnrolled = reader.GetString(reader.GetOrdinal("programEnrolled"))
                                };
                               s1.AddStudent(student);
                            }
                        }
                    }
                }

                string teacherQuery = "SELECT * FROM Teacher";
                using (SqlCommand command = new SqlCommand(teacherQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userId = reader.GetString(reader.GetOrdinal("teacherId"));
                            if (users.TryGetValue(userId, out User user))
                            {
                                Teacher teacher = new Teacher(user)
                                {
                                    // Populate Student-specific properties
                                    CourseAssigned = reader.GetString(reader.GetOrdinal("courseAssigned")),
                                DepartmentName = reader.GetString(reader.GetOrdinal("departmentName"))
                                };
                                s1.AddTeacher(teacher);
                            }
                        }
                    }
                }
                string AdminQuery = "SELECT * FROM Admin";
                using (SqlCommand command = new SqlCommand(AdminQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userId = reader.GetString(reader.GetOrdinal("adminId"));
                            if (users.TryGetValue(userId, out User user))
                            {
                                Admin admin = new Admin(user)
                                {
                                    // Populate Student-specific properties
                                };
                                s1.AddAdmin(admin);
                            }
                        }
                    }
                }
                connection.Close();
                return s1;
            }
        }
    }
}
