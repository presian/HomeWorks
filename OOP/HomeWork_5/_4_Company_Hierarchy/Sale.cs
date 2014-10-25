using System;

namespace _4_Company_Hierarchy
{
    class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentNullException("Every product must have a name");
                }
                this.productName = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                if (value == default(DateTime))
                {
                    throw new ArgumentException("Invalid date");
                }
                this.date = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException("Price", "The price cannot be zero or negative");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return "\nProduct name: " + this.productName
                +"\nDate of sale: " + this.Date
                +"\nPrice: " + this.Price;
        }
    }
}
