using iTextSharp.text.pdf;
using iTextSharp.text;
using PolyLearn.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyLearn.Screens
{
    public partial class TeacherSelectCourse : Form
    {
        public TeacherSelectCourse()
        {
            InitializeComponent();
        }
        private string courseId;
        private string courseName;
        private string courseDescription;
        private string programId;
        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;
        private Teacher t;
        private string selectedFilePath;
        private string fileTxt;
        public TeacherSelectCourse(Teacher t, string courseId, string courseName, string courseDescription, string programId)
        {
            InitializeComponent();
            this.StartPosition = centerScreen;
            this.courseId = courseId;
            this.courseName = courseName;
            this.courseDescription = courseDescription;
            this.programId = programId;
            this.t = t;

            courseIdLbl.Text = courseId;
            courseNameLbl.Text = courseName;
            descLbl.Text = courseDescription;
            progIdLbl.Text = programId;

        }

        private void TeacherSelectCourse_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherGradeStudent s1 = new TeacherGradeStudent(t, programId,courseId);
            s1.Show();
            this.Hide();
        }

        private void generateReportBtn_Click(object sender, EventArgs e)
        {
            string reportPath = GeneratePdfReport();

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
                        cmd.Parameters.AddWithValue("@ProgramId", programId);

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


        private void addDocBtn_Click(object sender, EventArgs e)
        {
            TeacherDoc td = new TeacherDoc(t, courseId);
            td.Show();
            this.Hide();
        }

        private void stuBtn_Click(object sender, EventArgs e)
        {
            TeacherStudent ts = new TeacherStudent(t);
            ts.Show();
            this.Hide();
        }

        private void branchBtn_Click(object sender, EventArgs e)
        {
            TeacherHome home = new TeacherHome(t);
            home.Show();
            this.Hide();
        }
    }
}
