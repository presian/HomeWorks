namespace _1_Customer
{
    using System;
    using System.Collections.Generic;
    using SupportClasses;

    class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private ulong id;
        private PermanentAddress address;
        private string mobilePhone;
        private string email;
        private IList<Payments> payments;
        private CustomerType customerType;

        public Customer(string firstName, string middleName, string lastName,
            ulong id, PermanentAddress address, string mobilePhone, string email,
            IList<Payments> payments, CustomerType customerType)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.id = id;
            this.address = address;
            this.mobilePhone = mobilePhone;
            this.email = email;
            this.payments = payments;
            this.customerType = customerType;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public ulong Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public PermanentAddress Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return mobilePhone;
            }
            set
            {
                mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public IList<Payments> Payments
        {
            get
            {
                return payments;
            }
            set
            {
                payments = value;
            }
        }

        public CustomerType CustomerType
        {
            get
            {
                return customerType;
            }
            set
            {
                customerType = value;
            }
        }


        public object Clone()
        {
            List<Payments> clonePayList = new List<Payments>();
            foreach (var payment in this.Payments)
            {
                clonePayList.Add(new Payments(payment.ProductName,payment.Price));
            }
            return new Customer(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.Id,
                new PermanentAddress(
                    this.Address.Country,
                    this.Address.City,
                    this.Address.Street,
                    this.Address.StreetNumber),
                this.MobilePhone,
                this.Email,
                clonePayList,
                this.CustomerType);
        }

        public int CompareTo(Customer other)
        {
            string otherFullName = other.FirstName + " " + other.MiddleName + " " + other.LastName;
            string thisFullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;
            if (thisFullName == otherFullName)
            {
                return this.Id.CompareTo(other.Id);
            }
            return thisFullName.CompareTo(otherFullName);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^
                this.MiddleName.GetHashCode() ^
                this.LastName.GetHashCode() ^
                this.Id.GetHashCode() ^
                this.Address.GetHashCode() ^
                this.MobilePhone.GetHashCode() ^
                this.Email.GetHashCode() ^
                this.Payments.GetHashCode() ^
                this.CustomerType.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Customer customer = obj as Customer;

            if (customer == null)
            {
                return false;
            }

            if (!Object.Equals(this.Address, customer.Address))
            {
                return false;
            }

            if (!Object.Equals(this.CustomerType, customer.CustomerType))
            {
                return false;
            }

            if (!Object.Equals(this.Email, customer.Email))
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, customer.FirstName))
            {
                return false;
            }

            if (this.Id != customer.Id)
            {
                return false;
            }

            if (!Object.Equals(this.LastName, customer.LastName))
            {
                return false;
            }

            if (!Object.Equals(this.MiddleName, customer.MiddleName))
            {
                return false;
            }

            if (!Object.Equals(this.MobilePhone, customer.MobilePhone))
            {
                return false;
            }

            if (this.Payments.Count != customer.Payments.Count)
            {
                return false;
            }

            if (this.Payments.Count == customer.Payments.Count)
            {
                for (int i = 0; i < customer.Payments.Count; i++)
                {
                    if (!this.Payments[i].Equals(customer.Payments[i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            string paySum = string.Empty;
            foreach (var payment in payments)
            {
                paySum += "\n        {" + payment + "}";
            }
            return String.Format(
                "Name: {0} {1} {2}\nId: {3}\nAddress: {4}\n" +
                "Mobile phone: {5}\nEmail: {6}\nPayments: {7}\nCustomer type: {8}",
                this.FirstName, this.MiddleName, this.LastName, this.Id,
                this.Address, this.MobilePhone, this.Email, paySum, this.CustomerType);
        }

        public static bool operator ==(Customer firstCustomer, Customer secondCustomer)
        {
            return Customer.Equals(firstCustomer, secondCustomer);
        }

        public static bool operator !=(Customer firstCustomer, Customer secondCustomer)
        {
            return !(Customer.Equals(firstCustomer, secondCustomer));
        }


    }
}
