using System.Collections.Generic;

namespace _1_School.v1._3
{
    class Class : IDetailable
    {
        private string classTextID;
        private IList<Teacher> teacherOfThisClass;
        private IList<Student> studentsOfThisClass;
        private string details;

        public Class(string classTextId, string details = null)
        {
            this.ClassTextId = classTextId;
            this.Details = details;
        }

        public Class(string id, List<Teacher> teacherOfThisClass, string details)
            : this(id, details)
        {
            this.TeacherOfThisClass = teacherOfThisClass;
        }

        public Class(string classTextId, List<Teacher> teacherOfThisClass, List<Student> studentsOfThisClass, string details)
            : this(classTextId, teacherOfThisClass, details)
        {
            this.StudentsOfThisClass = studentsOfThisClass;
        }

        public IList<Student> StudentsOfThisClass
        {
            get
            {
                return this.studentsOfThisClass;
            }
            set
            {
                this.studentsOfThisClass = value;
            }
        }

        public IList<Teacher> TeacherOfThisClass
        {
            get
            {
                return this.teacherOfThisClass;
            }
            set
            {
                this.teacherOfThisClass = value;
            }
        }

        public string ClassTextId
        {
            get
            {
                return this.classTextID;
            }
            private set
            {
                this.classTextID = value;
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
    }
}
