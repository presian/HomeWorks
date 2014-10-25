using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _3_Animals
{
    class AnimalsMainClass
    {
        static void Main()
        {
            Animal[] animals = new Animal[] { 
                new Dog("Balkan", 2, "Male"), 
                new Frog("Django", 2, "Male"),
                new Cat("Petko", 3, "Male"), 
                new Kitten("Ketty", 8), 
                new Tomcat("Tom", 9), 
                new Dog("Sharo", 7, "Male"),
                new Dog("Rex",4,"Male"),
                new Frog("Ceca",5,"Female")};

            var output = from animal in animals
                         group animal by (animal is Cat) ? typeof(Cat): animal.GetType()
                         into g
                         select new { kind = g.Key.Name, averageAge = g.ToList().Average(a => a.Age) };
            foreach (var item in output)
            {
                Console.WriteLine(item.kind + "->" + item.averageAge);
            }
        }
    }
}
