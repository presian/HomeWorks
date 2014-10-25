using System.Collections.Generic;

namespace _1_School.v1._3
{
    class Teacher : People, IDetailable
    {
        private IList<Discipline> teacherDisciplines;

        public Teacher(string name, string details=null)
            : base(name,details)
        {
        }

        public Teacher(string name, List<Discipline> teacherDisciplines, string details = null)
            : base(name, details)
        {
            this.TeacherDisciplines = teacherDisciplines;
            this.Details = details;
        }

        public IList<Discipline> TeacherDisciplines
        {
            get
            {
                return this.teacherDisciplines;
            }
            set
            {
                this.teacherDisciplines = value;
            }
        }
    }
}
