using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, "Male")
        {
            
        }
        
        public new void ProduceSound()
        {
            Console.WriteLine("Miau - Miau");
        }
    }
}
