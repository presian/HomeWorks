using System;
using System.Collections.Generic;

namespace _1_Shapes
{
    class MainClass
    {
        static void Main()
        {
            IList<IShape> figurs = new List<IShape>();
            figurs.Add(new Circle(5));
            figurs.Add(new Circle(2.55));
            figurs.Add(new Rectangle(2,4));
            figurs.Add(new Rectangle(3.5,5.9));
            figurs.Add(new Triangle(2,3,5));
            figurs.Add(new Triangle(2.5,2.55,3.55));

            foreach (var figur in figurs)
            {
                Console.WriteLine(figur.GetType().Name 
                    + " -> Area: " + figur.CalculateArea() + " => Perimeter: " + figur.CalculatePerimeter() );
            }
        }
    }
}
