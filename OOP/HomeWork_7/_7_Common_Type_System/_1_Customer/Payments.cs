namespace _1_Customer
{
    class Payments
    {
        private string productName;
        private decimal price;

        public Payments(string productName, decimal price)
        {
            this.ProductName = productName;
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
                this.productName = value;
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
                this.price = value;
            }
        }

        public override int GetHashCode()
        {
            return ProductName.GetHashCode() ^ Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Payments payments = obj as Payments;

            if (payments == null)
            {
                return false;
            }

            if (!this.ProductName.Equals(payments.ProductName))
            {
                return false;
            }

            if (this.Price!=payments.Price)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return "Product: " + this.ProductName + " -> " + this.Price;
        }
    }
}
