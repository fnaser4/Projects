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
using static System.Net.Mime.MediaTypeNames;

namespace PolyLearn.Screens
{
    public partial class TeacherSelectStudent : Form
    {
        private const FormStartPosition centerScreen = FormStartPosition.CenterScreen;
        private string email;
        private Teacher t2;
        private static int mailCount = 1;
        private string teacherid = "";
        public TeacherSelectStudent(Teacher t3, string id, string fname, string lname, string proID, string emaill)
        {
            InitializeComponent();
            this.StartPosition = centerScreen;
            string fn = fname.Trim()+" " + lname.Trim();
            StuIdLbl.Text = id;
            NameLbl.Text = fn;
            progIdLbl.Text = proID;
            EmailLbl.Text = emaill;
            email = emaill;
            t2 = t3;
            teacherid = t3.Id.Trim();
        }

        // Navigations
        private void branchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screens.TeacherHome home = new Screens.TeacherHome(t2);
            home.Show();
        }

        private void stuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screens.TeacherStudent stu = new Screens.TeacherStudent(t2);
            stu.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screens.TeacherPassword p = new Screens.TeacherPassword(t2);
            p.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Screens.loginScreen login = new Screens.loginScreen();
            login.Show();
        }

        private void addAudBtn_Click(object sender, EventArgs e)
        {
               // string this.email = email; // This could be left blank or set to a default address

                // Only the 'mailto' with the recipient is necessary; subject and body are omitted
                string mailtoUrl = $"mailto:{email}";

                // Try to open the default mail client
                try
                {
                    System.Diagnostics.Process.Start(mailtoUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open student's email. ");
                }
        }

        private void addDocBtn_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "insert into Mail(senderUsername,recieverUsername,message,subject) values (@v2,@v3,@v4,@v5)";
           // cmd.Parameters.AddWithValue("@v1", 1);
            cmd.Parameters.AddWithValue("@v2", teacherid);
            cmd.Parameters.AddWithValue("@v3", StuIdLbl.Text.Trim());
            cmd.Parameters.AddWithValue("@v4", messageBox.Text);
            cmd.Parameters.AddWithValue("@v5", subject.Text);
            con.ConnectionString = Properties.Settings.Default.Database1ConnectionString;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            mailCount++;
            MessageBox.Show("Mail Added To database successfully!!!");

        }

        private void TeacherSelectStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
