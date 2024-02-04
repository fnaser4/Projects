using PolyLearn.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyLearn.Screens
{
    public partial class AdminServices : Form
    {
        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;
        private classes.System s1 = Program.S1;
        private List<String> courseIDs = new List<String>();
        //declare all the variables you need for creating a teacher
        private string teacherId, teacherFname, teacherLname, teacherPass, teacherGender, teacherPhone, teacherEmail, teacherDOB, teacherCourse, teacherDepartment;
        private int teacherInt,studentInt;
        private string studentId, studentFname, studentLname, studentPass, studentGender, studentPhone, studentEmail, studentDOB, studentProgram;
        public AdminServices()
        {
            InitializeComponent();
            this.StartPosition = centerScreen;
           // addPanel.Visible = false;
            studentPanel.Visible = true;
            femalebtn.Checked = true;
            femalebtn2.Checked = true;
            updateCourses();
            updateDepartment();
            updateProgram();
        }
        private void updateProgram()
        { 
                programEnrolledCombo.Items.Add("Master in Science in Artificial Intelligence");
            programEnrolledCombo.Items.Add("Masters in Science in Engineering(Applied) in Sustainable Energy Systems");
            programEnrolledCombo.Items.Add(" Masters in International Trade and Strategy");
        }

        private string returnProgramID()
        {
            if(programEnrolledCombo.SelectedIndex == 0)
            {
                return "1";
            } else if (programEnrolledCombo.SelectedIndex == 1)
            {
                return "2";
            }
            else
            {
                return "3";
            }
        }
        private void updateCourses()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";
            // string query = "Select courseName From Course";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Load all users
                //  Dictionary<string, User> users = new Dictionary<string, User>();
                //reCheck();


                string userQuery = "SELECT * FROM [Courses] ";

                //query users downloaded
                using (SqlCommand command = new SqlCommand(userQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Id = reader.GetString(reader.GetOrdinal("userId")),
                            courses.Items.Add(reader.GetString(reader.GetOrdinal("courseId")) + " - " + reader.GetString(reader.GetOrdinal("courseName")));
                            courseIDs.Add(reader.GetString(reader.GetOrdinal("courseId")));
                        }
                    }
                }
            }
        }

        private void updateDepartment()
        {
            departmentCombo.Items.Add("AI");
            departmentCombo.Items.Add("Engineering");
            departmentCombo.Items.Add("Trade");
        }

        private void branchBtn_Click(object sender, EventArgs e)
        {
            AdminHome adminHome = new AdminHome();
            adminHome.Show();
            this.Hide();
        }

        private void courseBtn_Click(object sender, EventArgs e)
        {
            AdminCourses2 adminCourses = new AdminCourses2();
            adminCourses.Show();
            this.Hide();
        }

        private void courses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void departmentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            AdminStaff adminStaff = new AdminStaff();
            adminStaff.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            teacherId = studentIDtext.Text;
            studentFname = studentFnametxt.Text;
            studentLname = studentLnametxt.Text;
            if (femalebtn2.Checked)
            {
                studentGender = "F";
            }else
            {
                studentGender = "M";
            }

            studentEmail = studentemailtxt.Text;
            studentPhone = studentPhonetxt.Text;
            studentPass = studentPasstxt.Text;
            studentDOB = studentDate.Value.ToString();
            bool save = checkValidity2();
            bool check = checkId();
            if(save && check)
            {
                string connectionString = Properties.Settings.Default.Database1ConnectionString;
                string query = "INSERT INTO [User] (userId, gender, firstName, lastName, phoneNumber, password,email,dateOfBirth) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7,@Value8 );";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Value1", teacherId);
                        command.Parameters.AddWithValue("@Value2", studentGender);
                        command.Parameters.AddWithValue("@Value3", studentFname);
                        command.Parameters.AddWithValue("@Value4", studentLname);
                        command.Parameters.AddWithValue("@Value5", studentInt);
                        command.Parameters.AddWithValue("@Value6", studentPass);
                        command.Parameters.AddWithValue("@Value7", studentEmail);
                        command.Parameters.AddWithValue("@Value8", studentDOB);
                        int result = command.ExecuteNonQuery();
                        if (result < 0)
                        {
                            MessageBox.Show("Oops! an error occured, try again in a bit!");
                        }
                        else
                        {
                            
                            MessageBox.Show("User created! the system will update shortly! Welcome to PolyLearn");
                            classes.Student student = new classes.Student(teacherId, studentFname, studentLname, studentEmail, studentGender, studentPass, studentInt, studentDOB,returnProgramID());
                            s1.AddStudent(student);
                            Program.S1 = s1;
                        }
                    }

                    query = "Insert Into Student(studentId, programEnrolled) Values(@v1,@v2);";

                    using (SqlCommand command1 = new SqlCommand(query, connection))
                    {
                        command1.Parameters.AddWithValue("@v1", teacherId);
                        command1.Parameters.AddWithValue("@v2", returnProgramID());
                        int result = command1.ExecuteNonQuery();
                        if (result < 0)
                        {
                            MessageBox.Show("oops! an error occured come back later");
                        }
                        else
                        {
                            MessageBox.Show("Student Created!");
                            teacherDataGridView.Update();
                        }
                    }
                }
            }

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private bool checkValidity2()
        {
            if (studentFname.Length < 2)
            {
                MessageBox.Show("Pleas Enter First Name");
                return false;
            }
            else if (studentFname.Length < 2)
            {
                MessageBox.Show("Please Enter Last Name");
                return false;
            }
            else if (teacherId.Trim().Length != 5)
            {
                MessageBox.Show("Please enter a 5 character University ID");
                return false;
            }
            else if (studentPhone.Length != 8)
            {
                MessageBox.Show("Please enter a valid Phone Number");
                return false;
            }
            else if (studentPass.Length < 2)
            {
                MessageBox.Show("Please enter a valid password");
            }
            else if (studentEmail.Length < 2)
            {
                MessageBox.Show("Please enter a valid email");
            }

            bool result = Int32.TryParse(studentPhone, out int number);
            if (result)
            {
                // number contains the integer value now
                studentInt = Int32.Parse(studentPhone);
            }
            else
            {
                // Handle the case where the string is not a valid integer
                MessageBox.Show("Phone number can only be a number!");
                return false;
            }

            return true;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            AdminMessages adminMessages = new AdminMessages();  
            adminMessages.Show();
            this.Hide();
        }

        private void AdminServices_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.database1DataSet.Student);
            // TODO: This line of code loads data into the 'database1DataSet.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.database1DataSet.Teacher);
            // TODO: This line of code loads data into the 'database1DataSet2.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.database1DataSet2.User);
            // TODO: This line of code loads data into the 'database1DataSet.User' table. You can move, or remove it, as needed.
           // this.userTableAdapter.Fill(this.database1DataSet.User);

        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void userBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Attempt to update the database
                this.userTableAdapter.Update(this.database1DataSet2);

                // Optionally, notify the user of success
                MessageBox.Show("Database updated successfully.");
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show("An error occurred: " + ex.Message);

                // Optionally, log the exception details for further analysis
                // LogException(ex); // Assuming LogException is a method you've defined for logging
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            services.SelectedIndex = 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            services.SelectedIndex = 4;
        }

        private void addPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewTeacher_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void createbtn_Click(object sender, EventArgs e)
        {
           teacherId = uniIdtxt.Text;
           teacherFname = firstNameTxt.Text;
           teacherLname = lastnametxt.Text;
            if (femalebtn.Checked)
            {
                teacherGender = "F";
            }
            else
            {
                teacherGender = "M";
            }

            teacherEmail = emailtxt.Text;
            teacherDOB = dateTeacher.Value.ToString();
            teacherPass = passtxt.Text;
            teacherPhone = phonetxt.Text;
            bool save = checkValidity();
            bool check = checkId();
            if (save && check)
            {
                string connectionString = Properties.Settings.Default.Database1ConnectionString;
                string query = "INSERT INTO [User] (userId, gender, firstName, lastName, phoneNumber, password,email,dateOfBirth) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7,@Value8 );";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Value1", teacherId);
                        command.Parameters.AddWithValue("@Value2", teacherGender);
                        command.Parameters.AddWithValue("@Value3", teacherFname);
                        command.Parameters.AddWithValue("@Value4", teacherLname);
                        command.Parameters.AddWithValue("@Value5", teacherInt);
                        command.Parameters.AddWithValue("@Value6", teacherPass);
                        command.Parameters.AddWithValue("@Value7", teacherEmail);
                        command.Parameters.AddWithValue("@Value8", teacherDOB);
                        int result = command.ExecuteNonQuery();
                        if (result < 0) {
                            MessageBox.Show("Oops! an error occured, try again in a bit!");
                        } else
                        {
                            MessageBox.Show("User created! the system will update shortly! Welcome to PolyLearn");
                            classes.Teacher teacher = new classes.Teacher(teacherId, teacherFname, teacherLname, teacherEmail, teacherGender, teacherPass, teacherInt, teacherDOB, courseIDs[courses.SelectedIndex], departmentCombo.SelectedItem.ToString());
                            s1.AddTeacher(teacher);
                            Program.S1 = s1;
                        }
                    }

                    query = "Insert Into Teacher(TeacherId, courseAssigned,departmentName) Values(@v1,@v2,@v3);";

                    using (SqlCommand command1 = new SqlCommand(query, connection))
                    {
                        command1.Parameters.AddWithValue("@v1", teacherId);
                        command1.Parameters.AddWithValue("@v2", courseIDs[courses.SelectedIndex]);
                        command1.Parameters.AddWithValue("@v3", departmentCombo.SelectedItem.ToString());
                        int result = command1.ExecuteNonQuery();
                        if (result < 0)
                        {
                            MessageBox.Show("oops! an error occured come back later");
                        }else
                        {
                            MessageBox.Show("Teacher Created!");
                            teacherDataGridView.Update();
                        }
                    }
                }

            }
        }
        


            private bool checkValidity()
        {
            if(teacherFname.Length < 2)
            {
                MessageBox.Show("Pleas Enter First Name");
                 return false;
            } else if (teacherFname.Length < 2)
            {
                MessageBox.Show("Please Enter Last Name");
                return false;
            } else if (teacherId.Trim().Length != 5)
            {
                MessageBox.Show("Please enter a 5 character University ID");
                return false;
            } else if (teacherPhone.Length != 8)
            {
                MessageBox.Show("Please enter a valid Phone Number");
                return false;
            }else if (teacherPass.Length < 2)
            {
                MessageBox.Show("Please enter a valid password");
            } else if (teacherEmail.Length < 2)
            {
                MessageBox.Show("Please enter a valid email");
            }

            bool result = Int32.TryParse(teacherPhone, out int number);
            if (result)
            {
                // number contains the integer value now
                teacherInt = Int32.Parse(teacherPhone);
            }
            else
            {
                // Handle the case where the string is not a valid integer
                MessageBox.Show("Phone number can only be a number!");
                return false;
            }

            return true;
        }
        private bool checkId()
        {
            foreach (var student in s1.GetStudents())
            {
                if (teacherId == student.Id.Trim())
                {
                    MessageBox.Show("This Univeristy Id already Has an Account", "Error");
                    return false;
                }
            }

            foreach (var teacher in s1.GetTeachers())
            {
                if (teacherId == teacher.Id.Trim())
                {
                    MessageBox.Show("This Univeristy Id already Has an Account Please Go back to the login Page", "Error");
                    return false;
                }
            }

            return true;
        }
    }
}
