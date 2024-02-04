using PolyLearn.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyLearn.Screens
{
    public partial class TeacherDoc : Form
    {
        private Teacher t;
        private int i = 0;

        public TeacherDoc(Teacher t, string courseId) 
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.t = t;
            this.courseId = courseId;
            courseMaterialDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screens.TeacherStudent stu = new Screens.TeacherStudent(t);
            stu.Show();
        }

        private void branchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screens.TeacherHome home = new Screens.TeacherHome(t);
            home.Show();
        }

        private void TeacherDoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet4.CourseMaterial' table. You can move, or remove it, as needed.
            this.courseMaterialTableAdapter.Fill(this.database1DataSet4.CourseMaterial);
            // TODO: This line of code loads data into the 'database1DataSet.CourseMaterial' table. You can move, or remove it, as needed.
            this.courseMaterialTableAdapter.Fill(this.database1DataSet4.CourseMaterial);
            PopulatecourseMaterialDataGridView();

        }
        private string selectedFilePath;
        private string courseId;

        //document
        private void addDocBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory (optional)
            openFileDialog.InitialDirectory = "C:\\";

            // Set the title of the dialog
            openFileDialog.Title = "Select a File";

            // Set the file filter
            openFileDialog.Filter = checkFileType();
            // Display the dialog and check if the user clicked OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                selectedFilePath = openFileDialog.FileName;

                // Update the text box with the selected file name
                fileNamebox.Text = Path.GetFileName(selectedFilePath);
            }
        }

        ////private void addAudBtn_click(object sender, EventArgs e)
        ////{
        ////    // Create an instance of OpenFileDialog
        ////    OpenFileDialog openFileDialog = new OpenFileDialog();

        ////    // Set the initial directory (optional)
        ////    openFileDialog.InitialDirectory = "C:\\";

        ////    // Set the title of the dialog
        ////    openFileDialog.Title = "Select a File";

        ////    // Set the file filter
        ////    openFileDialog.Filter = "Audio Files|*.mp3;*.wav|All Files (*.*)|*.*";

        ////    // Display the dialog and check if the user clicked OK
        ////    if (openFileDialog.ShowDialog() == DialogResult.OK)
        ////    {
        ////        // Get the selected file path
        ////        selectedFilePath = openFileDialog.FileName;

        ////        // Update the text box with the selected file name
        ////        fileNmB.Text = Path.GetFileName(selectedFilePath);
        ////    }
        ////}

        //private void addVidBtn_Click(object sender, EventArgs e)
        //{
        //    // Create an instance of OpenFileDialog
        //    OpenFileDialog openFileDialog = new OpenFileDialog();

        //    // Set the initial directory (optional)
        //    openFileDialog.InitialDirectory = "C:\\";

        //    // Set the title of the dialog
        //    openFileDialog.Title = "Select a File";

        //    // Set the file filter
        //    openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.wmv|All Files (*.*)|*.*";

        //    // Display the dialog and check if the user clicked OK
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        // Get the selected file path
        //        selectedFilePath = openFileDialog.FileName;

        //        // Update the text box with the selected file name
        //        vidBox.Text = Path.GetFileName(selectedFilePath);
        //    }
        //}

        //private void addImgBtn_Click(object sender, EventArgs e)
        //{
        //    // Create an instance of OpenFileDialog
        //    OpenFileDialog openFileDialog = new OpenFileDialog();

        //    // Set the initial directory (optional)
        //    openFileDialog.InitialDirectory = "C:\\";

        //    // Set the title of the dialog
        //    openFileDialog.Title = "Select a File";

        //    // Set the file filter
        //    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files (*.*)|*.*";

        //    // Display the dialog and check if the user clicked OK
        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        // Get the selected file path
        //        selectedFilePath = openFileDialog.FileName;

        //        // Update the text box with the selected file name
        //        imgBox.Text = Path.GetFileName(selectedFilePath);
        //    }
        //}
        private void uploadBtn_Click(object sender, EventArgs e)
            {
                // Check if a file is selected
                if (!string.IsNullOrEmpty(selectedFilePath))
                {
                    // Get additional information from textboxes
                    string informationTitle = matBox.Text;
                    string fileName = fileNamebox.Text;

                    // Validate that all required fields are not empty
                    if (ValidateInput(informationTitle, fileName))
                    {
                        // Read the file content into a byte array
                        byte[] fileContent = File.ReadAllBytes(selectedFilePath);

                        // Save the file content and additional information to the database
                        SaveFileToDatabase(fileContent, informationTitle, fileName);

                        MessageBox.Show("File uploaded successfully!");
                        PopulatecourseMaterialDataGridView();
                        matBox.Text = "";
                        fileNamebox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a file first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private bool ValidateInput(string informationTitle, string fileName)
            {
                // Add any additional validation rules as needed
                // For now, just check that the strings are not empty
                return !string.IsNullOrEmpty(informationTitle) && !string.IsNullOrEmpty(fileName);
            }

            private void SaveFileToDatabase(byte[] fileContent, string materialTitle, string fileName)
            {
            // Connection string


            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.Database1ConnectionString))
            {
                conn.Open();
                // SQL statement to insert file content and additional information into the database
                string insertSql = "INSERT INTO CourseMaterial (courseCode, materialLink, materialTitle, fileName,fileType) VALUES (@courseCode, @materialLink, @materialTitle, @fileName,@fileType)";
                i++;
                using (SqlCommand command = new SqlCommand(insertSql, conn))
                {
                    // Add parameters to the SQL command
                    
                    //command.Parameters.AddWithValue("@materialId", i);
                    command.Parameters.AddWithValue("@courseCode", courseId.Trim());
                    command.Parameters.AddWithValue("@materialLink", fileContent);
                    command.Parameters.AddWithValue("@fileName", fileName);
                    command.Parameters.AddWithValue("@materialTitle", matBox.Text.Trim());
                    command.Parameters.AddWithValue("@fileType", checkType());


                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
            }
            }

        private string checkType()
        {
            if(imageBtn.Checked)
            {
                return "Image";
            } else if(videoBtn.Checked)
            {
                return "Video";
            }else if (Documentbtn.Checked)
            {
                return "Document";
            } else
            {
                return "Audio";
            }
        }

        private string checkFileType()
        {
            if (imageBtn.Checked)
            {
                return "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files (*.*)|*.*";
            } else if (videoBtn.Checked)
            {
                return "Video Files|*.mp4;*.avi;*.wmv|All Files (*.*)|*.*";
            } else if (audiobtn.Checked)
            {
                return "Audio Files|*.mp3;*.wav|All Files (*.*)|*.*";
            }
            else
            {
                return "Document Files|*.pdf;*.doc;*.txt|All Files (*.*)|*.*";
            }
        }

        private void courseMaterialDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PopulatecourseMaterialDataGridView()
        {
            DataTable materialsTable = GetMaterials(courseId);
            courseMaterialDataGridView.DataSource = materialsTable;

            // Ensure the DataGridView has had time to create its columns from the data source
            courseMaterialDataGridView.AutoGenerateColumns = true;
            courseMaterialDataGridView.Refresh();

            // Now attempt to hide the columns by name
            if (courseMaterialDataGridView.Columns.Contains("MaterialId"))
            {
                courseMaterialDataGridView.Columns["MaterialId"].Visible = false;
            }
            if (courseMaterialDataGridView.Columns.Contains("MaterialLink"))
            {
                courseMaterialDataGridView.Columns["MaterialLink"].Visible = false;
            }
        }

        private DataTable GetMaterials(string courseCode)
        {
            DataTable materialsTable = new DataTable();
            string connectionString = Properties.Settings.Default.Database1ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM CourseMaterial WHERE courseCode = @courseCode";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@courseCode", courseCode);

                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(materialsTable);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to retrieve course materials: {ex.Message}");
                    }
                }
            }

            return materialsTable;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int index = courseMaterialBindingSource.Position;
            DataRow currentRow = this.database1DataSet4.CourseMaterial[index];
            MessageBox.Show("Are you sure you want to delete this record");
            currentRow.Delete();
             // Update the underlying data source and database
            this.courseMaterialTableAdapter.Update(this.database1DataSet4.CourseMaterial);

            // Refresh DataGridView
            courseMaterialDataGridView.Refresh();
            MessageBox.Show("Record will be hidden!");

        }

        private void courseMaterialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.courseMaterialBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.database1DataSet4);

        }

        private void type_Enter(object sender, EventArgs e)
        {

        }
    }
}


