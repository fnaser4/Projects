using Org.BouncyCastle.Crypto.Tls;
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
    public partial class studentCourseDetails : Form
    {
        //static Student student;
        private Student s2;
        private string courseId;
        private string courseName;
        private string courseDescription;
        private string programId;
        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;
        static bool newGrades = false;

        public studentCourseDetails(string courseId, string courseName, string courseDescription, string programId,Student s1)
        {
            InitializeComponent();
            this.StartPosition = centerScreen;
            this.courseId = courseId;
            this.courseName = courseName;
            this.courseDescription = courseDescription;
            this.programId = programId;
            course_GradesDataGridView.Visible = false;
            courseIdLbl.Text = courseId;
            courseNameLbl.Text = courseName;
           s2 = s1;
            checkAlert();
           
        }
        public studentCourseDetails()
        {
            newGrades = true;
        }

        public void updateGrid()
        {
            foreach(DataGridViewRow row in courseMaterialDataGridView.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["dataGridViewTextBoxColumn8"].Value.ToString().Trim() != courseId.Trim())
                {
                    courseMaterialBindingSource.SuspendBinding();
                    row.Visible = false;
                    courseMaterialBindingSource.ResumeBinding();
                }
            }
        }

        private void checkAlert()
        {
            if (newGrades)
            {
                NotifyIcon notifyIcon = new NotifyIcon()
                {
                    BalloonTipText = "New Grades are published.",
                    BalloonTipTitle = "New Grades!",
                    Visible = true,
                    Icon = SystemIcons.Information
                };
                notifyIcon.ShowBalloonTip(3000);
                newGrades = false;
            }
        }
        
        private bool DownloadFileFromDatabase(int infoId, string destinationFolder)
        {

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True";

            SqlConnection c1 = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = c1;
            c1.ConnectionString = Properties.Settings.Default.Database1ConnectionString;
            using (c1)
            {
                c1.Open();


                string selectSql = "SELECT materialLink, fileName FROM courseMaterial WHERE materialId = @InfoID";

                using (SqlCommand command = new SqlCommand(selectSql, c1))
                {
                    command.Parameters.AddWithValue("@InfoID", infoId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if(reader["materialLink"] == DBNull.Value)
                            {
                                MessageBox.Show("This Material Doesnt Have anything to download! wait on your tutor to download Material");
                                return false;
                            }
                            string fileName = reader["fileName"].ToString();
                            byte[] fileContent = (byte[])reader["materialLink"];

                            string destinationPath = Path.Combine(destinationFolder, fileName);

                            File.WriteAllBytes(destinationPath, fileContent);
                        }
                    }
                }
            }
            return true;
        }
        private void downloadBtn_Click(object sender, EventArgs e)
        {
            int index = courseMaterialBindingSource.Position;

            if (index >= 0)
            {
                string infoId = courseMaterialDataGridView.Rows[index].Cells["dataGridViewTextBoxColumn6"].Value.ToString().Trim();
                int infoId2 = int.Parse(infoId);

                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                DialogResult folderResult = folderBrowserDialog.ShowDialog();

                if (folderResult == DialogResult.OK)
                {
                    string destinationFolder = folderBrowserDialog.SelectedPath;

                   bool check =  DownloadFileFromDatabase(infoId2, destinationFolder);
                    if (check)
                    {
                        MessageBox.Show("File downloaded successfully!");
                    }
                    else
                    {

                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Please select a record to download.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentCourseDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet4.CourseMaterial' table. You can move, or remove it, as needed.
            this.courseMaterialTableAdapter.Fill(this.database1DataSet4.CourseMaterial);
            // TODO: This line of code loads data into the 'database1DataSet3.Course_Grades' table. You can move, or remove it, as needed.
            this.course_GradesTableAdapter.Fill(this.database1DataSet3.Course_Grades);
            // TODO: This line of code loads data into the 'database1DataSet3.Course_Grades' table. You can move, or remove it, as needed.
            this.course_GradesTableAdapter.Fill(this.database1DataSet3.Course_Grades);
            // TODO: This line of code loads data into the 'database1DataSet4.ImportantInformation' table. You can move, or remove it, as needed.
            this.importantInformationTableAdapter.Fill(this.database1DataSet4.ImportantInformation);
            updateGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            course_GradesDataGridView.Visible = true;
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            foreach (DataGridViewRow row in course_GradesDataGridView.Rows)
            {
                if (row.Cells["dataGridViewTextBoxColumn2"].Value != null && row.Cells["published"] != null)
                {


                    if (row.Cells["dataGridViewTextBoxColumn2"].Value.ToString().Trim() != s2.Id.Trim() && row.Cells["published"].Value.ToString().Trim() != "1")
                    {
                        if (row.Index == 0)
                        {
                            course_GradesDataGridView.CurrentCell = course_GradesDataGridView.Rows[1].Cells[0];
                        }
                        row.Visible = false;
                    }
                }
            }
        }

        private void ViewCoursesBtn_Click(object sender, EventArgs e)
        {
            studentDashboardd studentDashboardd = new studentDashboardd(s2);
            studentDashboardd.Show();
            this.Hide();
        }

        private void EmailBtn_Click(object sender, EventArgs e)
        {
            StudentEmailView StudentEmailView = new StudentEmailView(s2);
            StudentEmailView.Show();
            this.Hide();
        }

        private void FeedbackBtn_Click(object sender, EventArgs e)
        {
            StudentFeedbackView StudentFeedbackView = new StudentFeedbackView(s2);
            StudentFeedbackView.Show();
            this.Hide();
        }

        private void changePwdBtn_Click(object sender, EventArgs e)
        {
            ChangePassword ChangePassword = new ChangePassword(s2);
            ChangePassword.Show();
            this.Hide();
        }

        private void announcmentBtn_Click(object sender, EventArgs e)
        {
            StudentAnnouncements StudentAnnouncements = new StudentAnnouncements(s2);
            StudentAnnouncements.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
