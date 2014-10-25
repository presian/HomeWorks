using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age,"Female")
        {
            
        }

        public new void ProduceSound()
        {
            Console.WriteLine("Miau-Miau");
        }
    }
}
