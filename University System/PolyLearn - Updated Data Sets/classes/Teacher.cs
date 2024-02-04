using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyLearn.classes
{
    public class Teacher : User
    {
        private string courseAssigned;
        private string departmentName;

        public Teacher(string id, string firstName, string lastName, string email, string gender,
            string password, int phoneNumber, string dateOfBirth, string course, string department)
    : base(id, firstName, lastName, email, gender, password, phoneNumber, dateOfBirth)
        {
            this.courseAssigned = course;
            this.departmentName = department;
        }

        public Teacher(User u)
      : base(u.Id, u.FirstName, u.LastName, u.Email, u.Gender, u.Password, u.PhoneNumber, u.DateOfBirth)
        {

        }

        public string CourseAssigned { get { return courseAssigned; } set {  courseAssigned = value; } }
        public string DepartmentName { get {  return departmentName; } set {  departmentName = value; } }
    }
}
