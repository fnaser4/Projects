using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PolyLearn.classes;
using System.Diagnostics.Eventing.Reader;
using Microsoft.SqlServer.Server;
using static PolyLearn.Database1DataSet;
using static PolyLearn.Database1DataSet2;

namespace PolyLearn.Screens
{
    public partial class registraionScreen : Form
    {
        private classes.System s1 = Program.loadProgram();
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private string phone;
        private string gender1;
        private string dateofBirth;
        private string uniID;
        private string type;
        private string program;
        private string Departmentname;
        private string courseID;

        public registraionScreen()
        {
            InitializeComponent();
            userTypecomboBox.Items.Add("Student");
            userTypecomboBox.Items.Add("Teacher");
            programEnrolled.Items.Add("Masters in Science in Artificial Intelligence");
            programEnrolled.Items.Add("Masters in Engineering (Applied) in Sustainable Energy Systems");
            programEnrolled.Items.Add("Masters in International Trade and Strategy");
            departmentCombo.Items.Add("Science");
            departmentCombo.Items.Add("Engineering");
            departmentCombo.Items.Add("nternational Trade");
            departmentCombo.Visible = false;
            programEnrolled.Visible = false;
            optionalPanel.Visible = false;
            reg2.Visible = false;
            courses.Visible = false;
            updateCombo();
        }

        private void registraionScreen_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void userTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool first = true;
            if (first)
            {
                firstName = firstNameTextBox.Text.Trim();
                lastName = lastNameTextBox.Text.Trim();
                phone = phonetxt.Text.Trim();
                password = passwordTextBox.Text.Trim();
                if (male.Checked)
                {
                    gender1 = "M";
                }
                else
                {
                    gender1 = "F";
                }

                email = emailtxt.Text.Trim();
                dateofBirth = dateOfBirth.Value.ToString();
                uniID = uniIdtxt.Text.Trim();

                try
                {
                    if (userTypecomboBox.SelectedItem != null)
                    {

                        type = userTypecomboBox.SelectedItem.ToString();
                        if (type == "Student")
                        {
                            optional1.Visible = false;
                            programEnrolled.Visible = true;
                            optionalPanel.Visible = true;
                            check.Text = "Program Enrolled:";
                            departmentName.Visible = false;
                            departmentTxt.Visible = false;
                            first = false;
                            reg2.Visible = true;

                        }
                        else if (type == "Teacher")
                        {
                            departmentCombo.Visible = true;
                            programEnrolled.Items.Clear();
                            optional1.Visible = false;
                            programEnrolled.Visible = true;
                            courses.Visible = true;
                            optionalPanel.Visible = true;
                            departmentName.Text = "course Assigned:";
                            departmentName.Visible = true;
                            departmentTxt.Visible = false;
                            check.Text = "Department Name:";
                            //Departmentname = departmentTxt.Text;
                            courseID = optional1.Text.Trim();
                            first = false;
                            //register.Text = "Register";
                            reg2.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select user Type", "Error");
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Please select user Type", "Error");
                }
            }
      

        }

        public void reCheck()
        {
            firstName = firstNameTextBox.Text.Trim();
            lastName = lastNameTextBox.Text.Trim();
            phone = phonetxt.Text.Trim();
            password = passwordTextBox.Text.Trim();
            if (male.Checked)
            {
                gender1 = "M";
            }
            else
            {
                gender1 = "F";
            }

            email = emailtxt.Text.Trim();
            dateofBirth = dateOfBirth.Value.ToString();
            uniID = uniIdtxt.Text.Trim();

            try
            {
                if (userTypecomboBox.SelectedItem != null)
                {

                    type = userTypecomboBox.SelectedItem.ToString();
                    if (type == "Student")
                    {
                        optional1.Visible = false;
                        programEnrolled.Visible = true;
                        optionalPanel.Visible = true;
                        check.Text = "Program Enrolled:";
                        departmentName.Visible = false;
                        departmentTxt.Visible = false;
                        reg2.Visible = true;
                        departmentCombo.Visible = false;
                        
                    }
                    else if (type == "Teacher")
                    {
                        Departmentname = departmentCombo.SelectedItem.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Please select user Type", "Error");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Please select user Type", "Error");
            }
        }
    

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void optionalLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void optional1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg2_Click(object sender, EventArgs e)

        {
            bool check = true;
            if (type == "Student")
            {
                if (programEnrolled.SelectedItem != null)
                {
                    program = programEnrolled.ToString();
                }
                else
                {
                    MessageBox.Show("Please select Program", "Error");
                    check = false;
                }

            }
            else if (type == "Teacher")
            {
                if (departmentCombo.SelectedItem != null)
                {
                    
                    if (departmentCombo.SelectedIndex == 0)
                    {
                        Departmentname = "AI";
                    } else if (departmentCombo.SelectedIndex == 1)
                    {
                        Departmentname = "Engineering";
                    }else
                    {
                        Departmentname = "Trade";
                    }
                }
                else
                {
                    MessageBox.Show("Please select Department", "Error");
                    check = false;
                }

                if (courses.SelectedItem != null)
                {
                    courseID = courses.SelectedItem.ToString().Split(' ')[0];
                }
                else
                {
                    MessageBox.Show("Please select Course");
                    check = false;
                }

               

            }
            bool save1;
            save1 = checkData();

            if (save1 && check)
            {
                if (type == "Student")
                {

                    SaveStudent();
                }
                else
                {
                    saveTeacher();
                }
            }


        }

        private void SaveStudent()
        {

            string connectionString = Properties.Settings.Default.Database1ConnectionString;
            string query = "INSERT INTO [User] (userId, gender, firstName, lastName, phoneNumber, password,email,dateOfBirth) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7,@Value8 );";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value1", uniID);
                    command.Parameters.AddWithValue("@Value2", gender1);
                    command.Parameters.AddWithValue("@Value3", firstName);
                    command.Parameters.AddWithValue("@Value4", lastName);
                    command.Parameters.AddWithValue("@Value5", int.Parse(phone));
                    command.Parameters.AddWithValue("@Value6", password);
                    command.Parameters.AddWithValue("@Value7", email);
                    command.Parameters.AddWithValue("@Value8", dateofBirth);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                    {
                        MessageBox.Show("Oops! an error occured, try again in a bit!");
                    }
                    else
                    {

                        MessageBox.Show("User created! the system will update shortly! Welcome to PolyLearn");
                       
                     
                    }
                }


                query = "Insert Into Student(studentId, programEnrolled) Values(@v1,@v2);";

                using (SqlCommand command1 = new SqlCommand(query, connection))
                {
                    command1.Parameters.AddWithValue("@v1", uniID);
                    command1.Parameters.AddWithValue("@v2", (programEnrolled.SelectedIndex + 1).ToString());
                    int result = command1.ExecuteNonQuery();
                    if (result < 0)
                    {
                        MessageBox.Show("oops! an error occured come back later");
                    }
                    else
                    {
                        MessageBox.Show("Student Created!");
                        classes.Student student = new classes.Student(uniID, gender1, firstName, email, gender1, password, int.Parse(phone), dateofBirth, (programEnrolled.SelectedIndex + 1).ToString());
                        s1.AddStudent(student);
                        Program.S1 = s1;
                        studentDashboardd studentDashboardd = new studentDashboardd(student);
                        studentDashboardd.Show();
                        this.Hide();

                    }
                }
            }
        }
        private void saveTeacher()
        {
            string connectionString = Properties.Settings.Default.Database1ConnectionString;
            string query = "INSERT INTO [User] (userId, gender, firstName, lastName, phoneNumber, password,email,dateOfBirth) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7,@Value8 );";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value1", uniID);
                    command.Parameters.AddWithValue("@Value2", gender1);
                    command.Parameters.AddWithValue("@Value3", firstName);
                    command.Parameters.AddWithValue("@Value4", lastName);
                    command.Parameters.AddWithValue("@Value5", int.Parse(phone));
                    command.Parameters.AddWithValue("@Value6", password);
                    command.Parameters.AddWithValue("@Value7", email);
                    command.Parameters.AddWithValue("@Value8", dateofBirth);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                    {
                        MessageBox.Show("Oops! an error occured, try again in a bit!");
                    }
                    else
                    {

                        MessageBox.Show("User created! the system will update shortly! Welcome to PolyLearn");


                    }
                }
                query = "Insert Into Teacher(TeacherId, courseAssigned,departmentName) Values(@v1,@v2,@v3);";

                using (SqlCommand command1 = new SqlCommand(query, connection))
                {
                    command1.Parameters.AddWithValue("@v1", uniID);
                    command1.Parameters.AddWithValue("@v2", courseID);
                    command1.Parameters.AddWithValue("@v3",Departmentname);
                    int result = command1.ExecuteNonQuery();
                    if (result < 0)
                    {
                        MessageBox.Show("oops! an error occured come back later");
                    }
                    else
                    {
                        MessageBox.Show("Teacher Created!");
                        classes.Teacher teacher = new classes.Teacher(uniID, gender1, firstName, email, gender1, password, int.Parse(phone), dateofBirth,courseID,Departmentname);
                        s1.AddTeacher(teacher);
                        Program.S1 = s1;
                        TeacherHome teacherHome = new TeacherHome(teacher);
                        teacherHome.Show();
                        this.Hide();
                    }
                }
            }
        }
        private void saveData()
        {

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

                string query = "INSERT INTO [User] (userId, gender, firstName, lastName, phoneNumber, password,email,dateOfBirth) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7,@Value8 );";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        using (SqlCommand command = new SqlCommand(query, connection, transaction))
                        {
                            try
                            {
                                // Replace these with the actual values you want to insert
                                command.Parameters.AddWithValue("@Value1", uniID);
                                command.Parameters.AddWithValue("@Value2", gender1);
                                command.Parameters.AddWithValue("@Value3", firstName);
                                command.Parameters.AddWithValue("@Value4", lastName);
                                command.Parameters.AddWithValue("@Value5", phone);
                                command.Parameters.AddWithValue("@Value6", password);
                                command.Parameters.AddWithValue("@Value7", email);
                                command.Parameters.AddWithValue("@Value8", dateofBirth);


                                int result = command.ExecuteNonQuery();
                                transaction.Commit();
                                connection.Close();
                                // Check the result here
                                if (result < 0)
                                    Console.WriteLine("Error inserting data into database!");
                                else
                                {
                                    Console.WriteLine("Data inserted successfully!");
                                    if (type == "Student")
                                    {
                                        query = "Insert into [Student] (studentId,programEnrolled) VALUES (@v1,@v2)";
                                        using (SqlConnection connection1 = new SqlConnection(connectionString))
                                        {
                                            connection1.Open();
                                            using (SqlCommand command1 = new SqlCommand(query, connection1))
                                            {
                                                command1.Parameters.AddWithValue("@v1", uniID);
                                                command1.Parameters.AddWithValue("@v2", getProgramID());


                                                // command1.ExecuteNonQuery();
                                                int result2 = command1.ExecuteNonQuery();
                                                connection1.Close();
                                                if (result2 < 0)
                                                    Console.WriteLine("Error inserting data into database!");
                                                else
                                                {
                                                    MessageBox.Show("User created successfully!, redirecting to dashboard\nWelcome to PolyLearn", "Login successful");
                                                    studentDashboardd sd1 = new studentDashboardd();
                                                    sd1.Show();
                                                    this.Hide();
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        query = "Insert into [Teacher] (TeacherId,courseAssigned,departmentName) VALUES (@v1,@v2,@v3)";
                                        using (SqlConnection connection1 = new SqlConnection(connectionString))
                                        {
                                            connection1.Open();
                                            using (SqlCommand command1 = new SqlCommand(query, connection1))
                                            {
                                                command1.Parameters.AddWithValue("@v1", uniID);
                                                command1.Parameters.AddWithValue("@v2", courseID);
                                                command1.Parameters.AddWithValue("@v3", Departmentname);


                                                // command1.ExecuteNonQuery();
                                                int result2 = command1.ExecuteNonQuery();
                                                connection1.Close();
                                                if (result2 < 0)
                                                    Console.WriteLine("Error inserting data into database!");
                                                else
                                                {
                                                    MessageBox.Show("User created successfully!, redirecting to dashboard\nWelcome to PolyLearn", "Login successful");
                                                    TeacherHome sd1 = new TeacherHome();
                                                    sd1.Show();
                                                    this.Hide();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                //  transaction.Rollback();
                                Console.WriteLine("There was an error. Transaction rolled back.");
                                Console.WriteLine(ex.Message);
                            }

                        }
                    }
                }
            
        }

        public int getProgramID()
        {
            if (program == "Masters in Science in Artificial Intelligence")
            {
                return 1;
            } else if(program == "Masters in Engineering (Applied) in Sustainable Energy Systems")
            {
                return 2;
            }
            else
            {
                return 3;
            }
            return -1;
        }
       
        public bool checkData()
        {

            firstName = firstNameTextBox.Text.Trim();
            lastName = lastNameTextBox.Text.Trim();
            phone = phonetxt.Text.Trim();
            password = passwordTextBox.Text.Trim();
            if (male.Checked)
            {
                gender1 = "M";
            }
            else
            {
                gender1 = "F";
            }

            email = emailtxt.Text.Trim();
            dateofBirth = dateOfBirth.Value.ToString();
            uniID = uniIdtxt.Text.Trim();
            bool trial = true;
            if (firstName.Length < 2)
            {
                MessageBox.Show("Please Enter Valid FirstName", "Invalid Data");
                return false;
            } else if (lastName.Length < 2)
            {
                MessageBox.Show("Please enter Valid last name", "Invalid Data");
                return false;
            } else if (email.Length < 10)
            {
                MessageBox.Show("Please enter valid email", "Invalid Data");
                return false;
            } else if(uniID.Length < 5) {
                MessageBox.Show("Please enter valid 5 character university ID", "Invalid Data");
                return false;
            } else if (password.Length < 8)
            {
                MessageBox.Show("Please enter valid password with atleast 8 characters", "Invalid Data");
                return false;
            } else if (phone.Length < 8)
            {
                MessageBox.Show("Plese enter a valid Phone Number", "Invalid Data");
                return false;
            }

            foreach (var student in s1.GetStudents())
            {
                if(uniID == student.Id.Trim())
                {
                    MessageBox.Show("This Univeristy Id already Has an Account Please Go back to the login Page\nIf password is forgotten please click Contact your adminstrator", "Error");
                    return false;
                }
            }

            foreach (var teacher in s1.GetTeachers())
            {
                if(uniID == teacher.Id.Trim())
                {
                    MessageBox.Show("This Univeristy Id already Has an Account Please Go back to the login Page\nIf password is forgotten please click Contact your adminstrator", "Error");
                    return false;
                }
            }
          
            
            return trial;
        }

        public void updateCombo()
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
                            courses.Items.Add(reader.GetString(reader.GetOrdinal("courseId")) + " - "+ reader.GetString(reader.GetOrdinal("courseName")));
                        }
                    }
                }
            }
        }
            

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    

        }




    }

