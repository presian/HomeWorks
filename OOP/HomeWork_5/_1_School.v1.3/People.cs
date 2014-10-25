namespace _1_School.v1._3
{
    class People
    {
        private string name;
        private string details;

        public People(string name, string details = null)
        {
            this.Name = name;
            this.Details = details;
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

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }
    }
}
