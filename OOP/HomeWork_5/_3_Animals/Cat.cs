using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Animals
{
    class Cat : Animal
    {
        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {

        }

        public new void ProduceSound()
        {
            Console.WriteLine("Miau - Miau");
        }
    }
}
