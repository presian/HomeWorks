using System;
using System.Collections.Generic;

namespace _4_Company_Hierarchy
{
    class DeveloperEmployee : RegularEmployee, IDeveloperEmployee
    {
        private IList<Project> projectsList;

        public DeveloperEmployee(string firstName, string lastName, long id,
            decimal salary, Department department, IList<Project> projectsList)
            : base(firstName, lastName, id, salary, department)
        {
            this.ProjectsList = projectsList;
        }

        public IList<Project> ProjectsList
        {
            get
            {
                return this.projectsList;
            }
            set
            {
                if (value.Count < 1)
                {
                    throw new Exception("Every developer must have at least one project");
                }
                this.projectsList = value;
            }
        }

        public override string ToString()
        {
            string toPrint = string.Empty;
            foreach (var project in ProjectsList)
            {
                toPrint += project;
            }
            return base.ToString() + toPrint;
        }
    }
}
