using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyLearn.classes
{
    public class Student: User
    {
        private string programEnrolled;
        // Constructor for Student
        public Student(string id, string firstName, string lastName, string email, string gender,
                    string password, int phoneNumber, string dateOfBirth)
            : base(id, firstName, lastName, email, gender, password, phoneNumber, dateOfBirth)
        {
        }
        //constructor 2 
        public Student(string id, string firstName, string lastName, string email, string gender,
            string password, int phoneNumber, string dateOfBirth, string programEnrolled)
    : base(id, firstName, lastName, email, gender, password, phoneNumber, dateOfBirth)
        {
        this.programEnrolled = programEnrolled;
        }

        public Student(User u) 
            : base(u.Id, u.FirstName, u.LastName, u.Email, u.Gender, u.Password, u.PhoneNumber, u.DateOfBirth)
        {

        }



        // public attributes
        public string ProgramEnrolled
        {
            get { return programEnrolled; }
            set { programEnrolled = value; }
        }
        public int DownloadContent()
        {
            // Logic to download content
            return 0; // Placeholder return value
        }

        public new int GiveFeedback()
        {
            // Logic to give feedback
            return 0; // Placeholder return value
        }

        public int Register()
        {
            // Logic to register
            return 0; // Placeholder return value
        }

        public int SendEmail()
        {
            // Logic to send an email
            return 0; // Placeholder return value
        }

        public int ViewRegisteredCourse()
        {
            // Logic to view registered courses
            return 0; // Placeholder return value
        }
    }
}
