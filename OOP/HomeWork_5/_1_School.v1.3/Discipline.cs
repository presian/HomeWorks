using System.Collections.Generic;

namespace _1_School.v1._3
{
    class Discipline: IDetailable
    {
        private string name;
        private int numberOfLectures;
        private IList<Student> studentsWithThisDiscipline;
        private string details;

        public Discipline(string name, int numberOfLectures, string details = null)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
        }

        public Discipline(string name, int numberOfLectures, IList<Student> studentsWithThisDiscipline, string details)
            : this(name, numberOfLectures, details)
        {

            this.StudentsWithThisDiscipline = studentsWithThisDiscipline;

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }

        public IList<Student> StudentsWithThisDiscipline
        {
            get
            {
                return this.studentsWithThisDiscipline;
            }
            set
            {
                this.studentsWithThisDiscipline = value;
            }
        }
    }
}
