using System;

namespace _4_Company_Hierarchy
{
    class Person : IPerson
    {
        private string firstName;
        private string lastName;
        private long id;

        public Person(string firstName, string lastName, long id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value==string.Empty)
                {
                    throw new ArgumentException("Every person must have a name!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Every person must have a name!");
                }
                this.lastName = value;
            }
        }

        public long Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value < 1000000001)
                {
                    throw new ArgumentOutOfRangeException("ID");
                }
                this.id = value;
            }
        }

        public override string ToString()
        {
            return "\n\nName: " + this.firstName + " " + this.lastName + "\nID: " + this.id;
        }
    }
}
