namespace _1_School.v1._3
{
    class Student : People, IDetailable
    {
        private int studentNumber;

        public Student(string name, string details=null):base(name, details)
        {        
        }

        public Student(string name, int studentNumber, string details)
            : base(name,details)
        {
            this.StudentNumber = studentNumber;
        }

        public int StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                this.studentNumber = value;
            }
        }

    }
}
