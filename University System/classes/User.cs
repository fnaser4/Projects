using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyLearn.classes
{
    public class User
    {
        // Private fields
        private string id;
        private string firstName;
        private string lastName;
        private string email;
        private string gender;
        private string password;
        //private string username;
        private int phoneNumber;
        private string dateOfBirth;

        // Public properties
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

  

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        // Constructor


        public User()
        {

        }
        public User(string id, string firstName, string lastName, string email, string gender,
                    string password, int phoneNumber, string dateOfBirth)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Gender = gender;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
            this.DateOfBirth = dateOfBirth;
        }

        // Methods
        public void LogIn()
        {
            // Logic for logging in the user
        }

        public void ManagePassword()
        {
            // Logic for managing the user's password
        }

        public void GiveFeedback()
        {
            // Logic for giving feedback
        }


    }
}
