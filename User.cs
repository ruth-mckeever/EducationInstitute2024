using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationInstitute2024
{
    internal class User
    {
        //Fields (private, camelCase)
        private string userID;
        private string name;
        private string email;

        //Properties (public, PascalCase)
        public string UserID
        {
            get { return userID; }
            //Not going to implement set - might not want other classes changing this
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //Constructors
        public User()
        {
            userID = "unknown";
            name = "unknown";
            email = "unknown";
        }

        public User(string name, string email)
        {
            userID = "1";       //Think of a way to create a unique userID each time...
            this.name = name;
            this.email = email;
        }

        //Methods (PascalCase)


        //Override methods
        public override string ToString()
        {
            return $"User - {userID}, name: {name}, email: {email}";
        }
    }
}
