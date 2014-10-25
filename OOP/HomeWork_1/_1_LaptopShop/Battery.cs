using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Laptop_Shop
{
    class Battery
    {
        private string name;

        public Battery(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get 
            {
                return this.name;
            }
            set 
            {
                if (value!=null&&value.Length < 1)
                {
                    throw new ArgumentException("The battery field cannot be empty");
                }
                else
                {
                    this.name = value;
                }
                
            }
        }
        public override string ToString()
        {
            return String.Format("{0}",this.Name);
        }
    }
}
