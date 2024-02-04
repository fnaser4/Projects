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
    public partial class StudentEmailView : Form
    {
        private const FormStartPosition center = FormStartPosition.CenterScreen;
        private Student s;
        public StudentEmailView()
        {
            InitializeComponent();
            this.StartPosition = center;
        }
        public StudentEmailView(Student s1)
        {
            InitializeComponent();
            this.StartPosition = center;
            s = s1;
            mailDataGridView.Update();
        }


        private void StudentEmailView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet4.Mail' table. You can move, or remove it, as needed.
            this.mailTableAdapter.Fill(this.database1DataSet4.Mail);
            // TODO: This line of code loads data into the 'database1DataSet4.Mail' table. You can move, or remove it, as needed.
            this.mailTableAdapter.Fill(this.database1DataSet4.Mail);
            updateGrid();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StudentSendEmail StudentSendEmail = new StudentSendEmail(s);
            StudentSendEmail.Show();
            this.Hide();
        }

        private void mailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet4);

        }

        private void mailDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateGrid()
        {
            foreach(DataGridViewRow row in mailDataGridView.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Index == 0)
                {
                    if(mailDataGridView.Rows.Count < 2)
                    {
                        continue;
                    }
                    //course_GradesDataGridView.CurrentCell = course_GradesDataGridView.Rows[1].Cells[0];
                    mailDataGridView.CurrentCell = mailDataGridView.Rows[1].Cells[0];
                }

                if (row.Cells["dataGridViewTextBoxColumn2"].Value != null)
                {
                    if (row.Cells["dataGridViewTextBoxColumn2"].Value.ToString().Trim() != s.Id.Trim())
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void ViewCoursesBtn_Click(object sender, EventArgs e)
        {
            studentDashboardd studentDashboardd = new studentDashboardd(s);
            studentDashboardd.Show();
            this.Hide();
        }

        private void FeedbackBtn_Click(object sender, EventArgs e)
        {
            StudentFeedbackView ay = new StudentFeedbackView(s);
            ay.Show();
            this.Hide();
        }

        private void changePwdBtn_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(s);
            changePassword.Show();
            this.Hide();
        }

        private void announcmentBtn_Click_1(object sender, EventArgs e)
        {
            StudentAnnouncements studentAnnouncements = new StudentAnnouncements(s);
            studentAnnouncements.Show();
            this.Hide();
        }

        private void logoutLbl_Click(object sender, EventArgs e)
        {
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
