using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Student
    {

        private string firstName;
        private string lastName;
        private string city;
        private bool isDomestic;
        private string program;
        private int semester;
        private double gpa;
        private string courses;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                lastName = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            private set
            {
                city = value;
            }
        }

        public bool IsDomestic
        {
            get
            {
                return isDomestic;
            }
            private set
            {
                isDomestic = value;
            }
        }

        public string Program
        {
            get
            {
                return program;
            }
            private set
            {
                program = value;
            }
        }

        public int Semester
        {
            get
            {
                return semester;
            }
            private set
            {
                semester = value;
            }
        }

        public double Gpa
        {
            get
            {
                return gpa;
            }
            private set
            {
                gpa = value;
            }
        }

        public string Courses
        {
            get
            {
                return courses;
            }
            private set
            {
                courses = value;
            }
        }
    }
}



    }
}
