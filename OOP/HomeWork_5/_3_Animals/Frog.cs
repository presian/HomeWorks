using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Animals
{
    class Frog : Animal
    {
        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        {

        }

        public void ProdiceSound()
        {
            Console.WriteLine("Kwa - Kwa");
        }
    }
}
