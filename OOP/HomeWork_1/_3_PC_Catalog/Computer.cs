using System;
using System.Collections.Generic;


namespace _3_PC_Catalog
{
    class Computer
    {

        //Fields
        private string name;
        private List<Component> components = new List<Component>();
        private decimal price;
        

        //Properties
        public string Name { 
            get 
            { 
                return this.name;
            } 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(name, "The name cannot be empty");
                }
                else
                {
                    this.name = value;
                }
            } 
        }

        public decimal Price
        {
            get { return this.price; }
        } 

        public List<Component> Components
        {
            get { return this.components; }
            set {
                if (value==null)
                {
                    throw new Exception("Cannot make computer without any components");
                }
                else
                {
                    this.components = value;
                }
            }
        }
        public Computer(string name, List<Component> components)
        {
            this.name = name;
            this.Components = components;
            foreach (Component component in components)
            {
                price += component.Price;
            }
        }   
        public void PrintingComputer()
        {
            string temp = String.Format("{0:F2}", price);
            decimal tempDecimal = decimal.Parse(temp);
            string output = String.Format("Name: {0} | Price: {1:C}\n\n", this.Name, tempDecimal);
            foreach (Component component in Components)
            {
                temp = String.Format("{0:F2}", component.Price);
                tempDecimal = decimal.Parse(temp);
                output += String.Format("{0} -> {1:C}\n", component.Name, tempDecimal);
            }
            Console.WriteLine(output);
        }


    }
}
