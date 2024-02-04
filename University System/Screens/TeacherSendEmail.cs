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
    public partial class TeacherSendEmail : Form
    {
        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;
        public TeacherSendEmail()
        {
            InitializeComponent();
            this.StartPosition = centerScreen;
        }

        private void TeacherSendEmail_Load(object sender, EventArgs e)
        {

        }

        private void branchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Screens.TeacherHome home = new Screens.TeacherHome();
           // home.Show();
        }

        private void stuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Screens.TeacherStudent stu = new Screens.TeacherStudent();
            //stu.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           // Screens.TeacherPassword p = new Screens.TeacherPassword();
            //p.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           // Screens.loginScreen h = new Screens.loginScreen();
           // h.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
