using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationInstitute2024
{
    internal class Admin: User, IEmployee
    {
        //Fields (private, camelCase)
        private string department;
        private DateTime startDate;

        //Properties (public, PascalCase)
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        //Constructors
        public Admin(): base()
        {
            department = "HR";
            startDate = DateTime.Now;
        }
        public Admin(string department, DateTime startDate, string name, string email) : base(name, email)
        {
            this.department = department;
            this.startDate = startDate;
        }
        //Override methods
        public override string ToString()
        {
            return $"Admin - department: {department}, start: {startDate}, {base.ToString()}";
        }

        public double GetSalary()
        {
            //TODO: finish this
            throw new NotImplementedException();
        }
    }
}
