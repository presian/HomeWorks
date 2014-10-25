//Define a class Laptop that holds the following information about a laptop device: model, manufacturer, processor, graphics card, battery, battery life in hours, screen size and price.
//•	Define 2 separate classes (class Laptop holding an instance of class Battery). 
//•	Define several constructors that take different sets of arguments (full laptop/battery information or only part of it). Use proper variable types.
//•	All non-numeric data should be mandatory. All numeric fields should have a default value of 0.
//•	Add a method in the Laptop class that displays information about the given instance. (Tip: override ToString());
//•	Use properties to validate the data. String values cannot be empty, and numeric data cannot be negative. Throw exceptions when improper data is entered. 



using System;

namespace _2_Laptop_Shop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            Battery lion = new Battery("Li-Ion, 4-cells, 2550 mAh");
            Laptop first = new Laptop("N-series",2550);
            Laptop second = new Laptop("G6", "Lenovo", "Core i7","AMD Radeon 8250", (decimal)1550.99);
            Laptop third = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 16, "Intel HD Graphics 4400", 256, "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display", lion, (double)4.5, (decimal)2259.00);

            Console.WriteLine(first.ToString());
            Console.WriteLine();
            Console.WriteLine(second.ToString());
            Console.WriteLine();
            Console.WriteLine(third.ToString());
        }
    }
}
