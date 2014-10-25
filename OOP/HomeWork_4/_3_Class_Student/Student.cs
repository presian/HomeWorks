using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Class_Student
{
    internal class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;

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

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int GroupNumber
        {
            get { return groupNumber; }
            set { groupNumber = value; }
        }

        public IList<int> Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public Student(string fName, string lName, int age, string fNumber, string phone, string email, int groupNumber,
            IList<int> marks)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.Age = age;
            this.FacultyNumber = fNumber;
            this.Phone = phone;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = marks;
        }

        public override string ToString()
        {
            return "Student: " + this.firstName + " " + this.lastName + "\n"
                    + "Age: " + this.Age + "\n"
                    + "Faculty number: " + this.facultyNumber + "\n"
                    + "Phone: " + this.phone + "\n"
                    + "Email: " + this.email + "\n"
                    + "Group number: " + this.groupNumber + "\n"
                    + "Marks: [" + string.Join(", ",this.Marks) + "]\n=======================================================";
        }
    }
}
