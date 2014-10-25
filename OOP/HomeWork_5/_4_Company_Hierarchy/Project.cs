using System;

namespace _4_Company_Hierarchy
{
    class Project : IProject
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private ProjectState state;

        public Project(string projectName, DateTime projectStartDate, ProjectState state, string details)
        {
            this.projectName = projectName;
            this.projectStartDate = projectStartDate;
            this.details = details;
            this.state = state;
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Project must have name");
                }
                this.projectName = value;
            }
        }

        public DateTime ProjectStartDate
        {
            get
            {
                return this.projectStartDate;
            }
            set
            {
                if (value == default(DateTime))
                {
                    throw new Exception("Invalid date");
                }
                this.projectStartDate = value;
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

        public ProjectState State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        public void CloseProject()
        {
            this.State = ProjectState.Close;
        }

        public override string ToString()
        {
            return "\n\nProject name: " + this.projectName
                + "\nProject starts at: " + this.projectStartDate
                + "\nProject state: " + this.state
                + "\nDetails: " + this.details;
        }
    }
}
