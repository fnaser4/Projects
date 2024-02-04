using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyLearn.classes
{
    public class System
    {
        private List<Student> listOfStudents = new List<Student>();
        private List<Teacher> listOfTeachers = new List<Teacher>();
        private List<Admin> listOfAdmins = new List<Admin>();

        // Method to add a Student
        public void AddStudent(Student student)
        {
            listOfStudents.Add(student);
        }

        // Method to retrieve all students
        public List<Student> GetStudents()
        {
            return listOfStudents;
        }

        // Method to add a Teacher
        public void AddTeacher(Teacher teacher)
        {
            listOfTeachers.Add(teacher);
        }

        // Method to retrieve all teachers
        public List<Teacher> GetTeachers()
        {
            return listOfTeachers;
        }

        // Method to add an Admin
        public void AddAdmin(Admin admin)
        {
            listOfAdmins.Add(admin);
        }

        // Method to retrieve all admins
        public List<Admin> GetAdmins()
        {
            return listOfAdmins;
        }
    }
}

