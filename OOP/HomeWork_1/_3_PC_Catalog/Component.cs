using System;

namespace _3_PC_Catalog
{
    class Component
    {
        //Fields
        private string name;
        private string details;
        private decimal price;

        //Properties
        public string Name {
            get { return this.name;}
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of component is mandatory");
                }
                else
                {
                    this.name = value;
                }
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
                if (value.Length<1)
                {
                    throw new Exception("Details cannot be empty");
                }
                this.details = value;
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
                    throw new ArgumentException("Price cannot be zero, negative or empty");
                }
                else
                {
                    this.price = value;
                }
            } 
        }

        //Constructors
        public Component(string name, decimal price, string details = null)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
