using PolyLearn.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyLearn.Screens
{
    public partial class StudentAnnouncements : Form
    {
        private const FormStartPosition center = FormStartPosition.CenterScreen;
        private Student student;
        private static bool check = false;
        public StudentAnnouncements()
        {
            InitializeComponent();
            this.StartPosition = center;
            announcementDataGridView.Update();
            check = true;
        }

        private void checkBool() {
            if (check)
            {
                NotifyIcon notifyIcon = new NotifyIcon()
                {
                    BalloonTipText = "New Announcements are available.",
                    BalloonTipTitle = "New Announcements",
                    Visible = true,
                    Icon = SystemIcons.Information
                };
                notifyIcon.ShowBalloonTip(3000);
                check = false;
            }
            }
        public StudentAnnouncements(Student s1)
        {
            InitializeComponent();
            this.StartPosition = center;
            announcementDataGridView.Update();
            student = s1;
           checkBool();
        }

        private void announcementBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.announcementBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet3);
        }

        private void StudentAnnouncements_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.Announcement' table. You can move, or remove it, as needed.
            this.announcementTableAdapter.Fill(this.database1DataSet3.Announcement);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void ViewCoursesBtn_Click(object sender, EventArgs e)
        {
            studentDashboardd studentDashboardd = new studentDashboardd(student);
            studentDashboardd.Show();
            this.Hide();
        }

        private void EmailBtn_Click(object sender, EventArgs e)
        {
            StudentEmailView studentEmailView = new StudentEmailView(student);
            studentEmailView.Show();
            this.Hide();
        }

        private void FeedbackBtn_Click(object sender, EventArgs e)
        {
            StudentFeedbackView studentFeedbackView = new StudentFeedbackView(student);
            studentFeedbackView.Show();
            this.Hide();
        }

        private void changePwdBtn_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword(student);
            changePassword.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
