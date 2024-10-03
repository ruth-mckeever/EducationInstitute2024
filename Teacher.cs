using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationInstitute2024
{
    internal class Teacher: User
    {
        //Fields (private, camelCase)
        private string degreeLevel;
        private DateTime startDate;
        
        //Properties (public, PascalCase)
        public string DegreeLevel
        {
            get { return degreeLevel; }
            set { degreeLevel = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        //Constructors
        public Teacher() : base()
        {
            degreeLevel = "Level 8";
            startDate = DateTime.Now;
        }

        public Teacher(string degreeLevel, DateTime startDate, string name, string email) : base(name, email)
        {
            this.degreeLevel = degreeLevel;
            this.startDate = startDate;
        }

        //Override methods
        public override string ToString()
        {
            return $"Teacher - Degree: {degreeLevel}, start: {startDate}, {base.ToString()}";
        }

    }
}
