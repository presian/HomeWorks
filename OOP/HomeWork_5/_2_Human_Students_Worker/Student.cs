using System;

namespace _2_Human_Students_Worker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentNullException();
                }
                this.facultyNumber = value;
            }
        }
    }
}
