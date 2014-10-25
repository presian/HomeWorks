using System;

namespace _2_Human_Students_Worker
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentNullException();
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
                if (value == String.Empty)
                {
                    throw new ArgumentNullException();
                }
                this.lastName = value;
            }
        }

    }
}
