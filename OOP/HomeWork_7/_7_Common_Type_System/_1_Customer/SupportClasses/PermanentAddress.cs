namespace _1_Customer.SupportClasses
{
    class PermanentAddress
    {
        private string country;
        private string city;
        private string street;
        private ushort streetNumber;

        public PermanentAddress(string country, string city, string street, ushort streetNumber)
        {
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.StreetNumber = streetNumber;
        }

        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                this.country = value;
            }
        }

        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }

        public string Street
        {
            get
            {
                return this.street;
            }
            set
            {
                this.street = value;
            }
        }

        public ushort StreetNumber
        {
            get
            {
                return this.streetNumber;
            }
            set
            {
                this.streetNumber = value;
            }
        }

        public override int GetHashCode()
        {
            return Country.GetHashCode() ^ City.GetHashCode() ^ Street.GetHashCode() ^ StreetNumber.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            PermanentAddress permanentAddress = obj as PermanentAddress;

            if (permanentAddress == null)
            {
                return false;
            }

            if (!this.Country.Equals(permanentAddress.Country))
            {
                return false;
            }

            if (!this.City.Equals(permanentAddress.City))
            {
                return false;
            }

            if (!this.Street.Equals(permanentAddress.Street))
            {
                return false;
            }

            if (!this.StreetNumber.Equals(permanentAddress.StreetNumber))
            {
                return false;
            }
            return true;
        }

        public override string ToString()
        {
            return this.Country + ", " + this.City + ", " + this.Street + " #" + this.StreetNumber;
        }
    }
}
