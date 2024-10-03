using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EducationInstitute2024
{
    internal class Student: User
    {
        //Fields (private, camelCase)
        private string courseTitle;
        private int currentYear;

        //Properties (public, PascalCase)
        public string CourseTitle
        {
            get { return courseTitle; }
            set { courseTitle = value; }
        }

        public int CurrentYear
        {
            get { return currentYear; }
            set { currentYear = value; }
        }

        //Constructors
        public Student(): base()
        {
            courseTitle = "HDip in COmputing";
            currentYear = 1;
        }

        public Student(string courseTitle, int currentYear, string name, string email): base(name, email)
        {
            this.courseTitle = courseTitle;
            this.currentYear = currentYear;
        }

        //Override methods
        public override string ToString()
        {
            return $"Student - Course: {courseTitle}, year {currentYear}, {base.ToString()}";
        }

    }
}
