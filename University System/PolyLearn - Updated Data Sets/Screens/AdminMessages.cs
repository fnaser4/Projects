using iTextSharp.text.pdf;
using iTextSharp.text;
using PolyLearn.classes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyLearn.Screens
{
    public partial class AdminMessages : Form
    {
        private string selectedPath;
        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;
        private List<string> IDS = new List<string>();
        public AdminMessages()
        {
            InitializeComponent();
            this.StartPosition = centerScreen;
            this.announcementBindingSource.MoveLast();
            loadCombo();
            loadCombo2();
            loadCombo3();
            course_GradesDataGridView.Visible = false;
            course_GradesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void loadCombo3()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "Select * from Courses";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IDS.Add(reader.GetString(reader.GetOrdinal("courseId")).Trim());
                            courses3.Items.Add(reader.GetString(reader.GetOrdinal("courseId")).Trim() + "-" + reader.GetString(reader.GetOrdinal("courseName")));
                        }
                    }
                }
                connection.Close();
            }
            courses3.SelectedIndex = 0;
        }

        private void mainLabel_Click(object sender, EventArgs e)
        {

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

        private void staffBtn_Click(object sender, EventArgs e)
        {
            AdminStaff adminStaff = new AdminStaff();
            adminStaff.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminServices adminServices = new AdminServices();
            adminServices.Show();
            this.Hide();
        }

        private void AdminMessages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet4.FeedBacks' table. You can move, or remove it, as needed.
            this.feedBacksTableAdapter.Fill(this.database1DataSet4.FeedBacks);
            // TODO: This line of code loads data into the 'database1DataSet3.Course_Grades' table. You can move, or remove it, as needed.
            this.course_GradesTableAdapter.Fill(this.database1DataSet3.Course_Grades);
            // TODO: This line of code loads data into the 'database1DataSet3.Announcement' table. You can move, or remove it, as needed.
            this.announcementTableAdapter.Fill(this.database1DataSet3.Announcement);
            //updateGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\";

            openFileDialog.Title = "Select a File";

            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedPath = openFileDialog.FileName;

                fileText.Text = Path.GetFileName(selectedPath);
                //fileNameTextBox.Text = Path.GetFileName(selectedPath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string informationTitle = title.Text;
            string informationText = message.Text;
            string fileName = fileText.Text;
            if (validateData(informationTitle, informationText, fileName))
            {
                byte[] fileContnt = File.ReadAllBytes(selectedPath);
                //    informationLinkTextBox.Text = fileContnt.ToString();

                saveFileToDataBase(informationTitle, informationText, fileContnt, fileName);
                MessageBox.Show("Announcement Added Successfully!");
                StudentAnnouncements s = new StudentAnnouncements();

            }
            else
            {
                MessageBox.Show("Please fill all the information", "Validation Error");
            }
            //this.announcementBindingSource.AddNew();
            this.announcementTableAdapter.Update(this.database1DataSet3);
            this.announcementTableAdapter.Fill(this.database1DataSet3.Announcement);
            this.announcementBindingSource.MoveLast();
            MessageBox.Show("Your record has been added successfully");
            StudentAnnouncements s1 = new StudentAnnouncements();
        }

        private void saveFileToDataBase(string title, string text, byte[] fileContent, string fileName)
        {
            int id = getNewId();
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Announcement values(@v1,@v2,@v3,@v4,@v5)";
            cmd.Parameters.AddWithValue("@v1", id);
            cmd.Parameters.AddWithValue("@v2", title);
            cmd.Parameters.AddWithValue("@v3", text);
            cmd.Parameters.AddWithValue("@v4", fileContent);
            cmd.Parameters.AddWithValue("@v5", fileName);
            con.ConnectionString = Properties.Settings.Default.Database1ConnectionString;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            announcementDataGridView.Update();
        }


        private int getNewId()
        {
            int newId = 0;
            string connectionString = Properties.Settings.Default.Database1ConnectionString; // Replace with your connection string
            string query = "SELECT MAX(announcementid) FROM Announcement"; // Replace 'Id' with your actual column name

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        // Execute the query and get the maximum ID value
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            newId = Convert.ToInt32(result);
                        }
                        newId++; // Increment the ID
                    }
                    catch (SqlException ex)
                    {
                        // Handle exceptions
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return newId;
        }
        private bool validateData(string ititle, string informationText, string fileName)
        {
            if (informationText.Trim() != "" || ititle.Trim() != "" || fileName.Trim() != "")
            {
                return true;
            }

            return false;
        }

        private void announcementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.announcementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet3);

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void BookingMng_Btn_Click(object sender, EventArgs e)
        {
            loginScreen l1 = new loginScreen();
            l1.Show();
            this.Hide();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            loadCombo();
        }

        private void loadCombo()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "Select * from Courses";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses.Items.Add(reader.GetString(reader.GetOrdinal("courseId")).Trim()+ "-"+ reader.GetString(reader.GetOrdinal("courseName")));
                        }
                    }
                }
                connection.Close();
            }
            courses.SelectedIndex = 0;
        }

        private void chooseCourseBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in course_GradesDataGridView.Rows)
            {
                // Check if the row is not the new row placeholder
                if (!row.IsNewRow)
                {
                    row.Visible = true; // Make the row visible
                }
            }
            updateGrid();
            course_GradesDataGridView.Visible = true;
        }

        private void updateGrid()
        {
            course_GradesDataGridView.ClearSelection();
            course_GradesDataGridView.CancelEdit();
            string courseId = courses.SelectedItem.ToString().Split('-')[0].Trim();
            foreach (DataGridViewRow row in course_GradesDataGridView.Rows)
            {
                // Check if the cell is not null
                if (row.Cells["dataGridViewTextBoxColumn4"].Value != null)
                {

                  

                    string cellValue = row.Cells["dataGridViewTextBoxColumn4"].Value.ToString().Trim();
                  
                    // Hide the row if the cell value does not match courseId
                    if (cellValue != courseId)
                    {
                        course_GradesDataGridView.ClearSelection();
                        //mainLabel.Text = "Hello" + courseId;
                      

                        // courseDataGridView.CurrentCell = courseDataGridView.Rows[rowIndexToSelect].Cells[0];
                        course_GradesBindingSource.SuspendBinding();
                        row.Visible = false;
                        course_GradesBindingSource.ResumeBinding();
                    }
                }
            }
            course_GradesDataGridView.Refresh(); // Refresh DataGridView
        }

        private void publish_Click(object sender, EventArgs e)
        {
            if(course_GradesDataGridView.RowCount == 0)
            {
                MessageBox.Show("There is nothing to publish!");
            }
            else
            {
                string selectedCourseID = courses.SelectedItem.ToString().Split('-')[0].Trim();
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True"; // Typically, you'd get this from a config file or a secure source.

                // Define the SQL update statement
                string updateQuery = @"
            UPDATE [dbo].[Course_Grades]
            SET [published] = 1
            WHERE [courseid] = @courseID";

                // Create a new SqlConnection within a using block for proper disposal
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Create a SqlCommand also within a using block
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        // Add the courseID parameter to avoid SQL injection
                        cmd.Parameters.AddWithValue("@courseID", selectedCourseID);

                        // Open the connection
                        conn.Open();

                        // Execute the update command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if any rows were updated
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The course grades have been successfully published!");
                            studentCourseDetails s1 = new studentCourseDetails();
                            

                        }
                        else
                        {
                            MessageBox.Show("No course grades were published. Please check the course ID.");
                        }
                    }
                }
                course_GradesDataGridView.Update();
                course_GradesDataGridView.Refresh();
            }

        }

        private void courses2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loadCombo2()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "Select * from Programs";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            courses2.Items.Add(reader.GetString(reader.GetOrdinal("programId")).Trim() + " - " + reader.GetString(reader.GetOrdinal("programDescription")));
                        }
                    }
                }
                connection.Close();
            }
            courses.SelectedIndex = 0;
        }

        private void chooseCourse2_Click(object sender, EventArgs e)
        {
            // Call the GeneratePdfReport method without any student list
            string reportPath = GeneratePdfReport();

            // Optionally, open the report for the user
            System.Diagnostics.Process.Start(reportPath);
        }

        private string GeneratePdfReport()
        {
            string reportPath = "";
            try
            {
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.Database1ConnectionString))
                {
                    conn.Open();

                    // Define the file path for the PDF report
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    reportPath = Path.Combine(desktopPath, "StudentsReport.pdf");

                    // Create a document object
                    Document document = new Document(PageSize.A4, 25, 25, 30, 30);

                    // Create a writer that listens to the document
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(reportPath, FileMode.Create));

                    // Open the document
                    document.Open();

                    // Add a title to the document
                    document.Add(new Paragraph("Students Enrolled in the Course"));
                    document.Add(new Paragraph(" "));

                    // Add a table to the document
                    PdfPTable studList = new PdfPTable(4); // 3 columns
                    studList.WidthPercentage = 100; // Table width is 100% of the page
                    studList.AddCell("Student ID");
                    studList.AddCell("First Name");
                    studList.AddCell("Last Name");
                    studList.AddCell("Program ID");

                    // SQL Query to fetch students in a specific program
                    string query = "SELECT s.studentId, u.firstName, u.lastName, s.programEnrolled " +
                                   "FROM [Student] s " +
                                   "INNER JOIN [User] u ON s.studentId = u.userId " +
                                   "WHERE s.programEnrolled = @ProgramId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProgramId", checkProgram());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                studList.AddCell(reader["studentId"].ToString());
                                studList.AddCell(reader["firstName"].ToString());
                                studList.AddCell(reader["lastName"].ToString());
                                studList.AddCell(reader["programEnrolled"].ToString());
                            }
                        }
                    }

                    // Add the table to the document
                    document.Add(studList);

                    // Close the document
                    document.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return reportPath; // Return the path to the generated report file
        }

        private int checkProgram()
        {
            if(courses2.SelectedIndex == 0){
                return 1;
            } else if(courses2.SelectedIndex == 1)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void courses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseCourseBtn3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in feedBacksDataGridView.Rows)
            {
                // Check if the row is not the new row placeholder
                if (!row.IsNewRow)
                {
                    row.Visible = true; // Make the row visible
                }
            }
            foreach (DataGridViewRow row in feedBacksDataGridView.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["dataGridViewTextBoxColumn12"].Value.ToString().Trim() != IDS[courses3.SelectedIndex].Trim())
                {
                    feedBacksBindingSource.SuspendBinding();
                    row.Visible = false;
                    feedBacksBindingSource.ResumeBinding();
                }
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
    }

