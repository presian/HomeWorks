//Define a class Computer that holds name, several components and price. The components (processor, graphics card, motherboard, etc.) should be objects of class Component, which holds name, details (optional) and price. 
//•	Define several constructors that take different sets of arguments. Use proper variable types. Use properties to validate the data. Throw exceptions when improper data is entered.
//•	Add a method in the Computer class that displays the name, each of the components' name and price and the total computer price. The total price is the sum of all components' price. Print the prices in BGN currency format.
//•	Create several Computer objects, sort them by price, and print them on the console using the created display method.



using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;


namespace _3_PC_Catalog
{
    class PcCatalog
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");
            Component psu1 = new Component("fortron 300w", (decimal)75.55);
            Component psu2 = new Component("Fortron 400W", (decimal)100.35);
            Component psu3 = new Component("Fortron 550W", (decimal)156.39);

            Component motherBoard1 = new Component("Asrock MHP333", (decimal)125.63);
            Component motherBoard2 = new Component("Asrock MHP335", (decimal)175.33);
            Component motherBoard3 = new Component("Asrock MHP338", (decimal)195.63);

            Component processor1 = new Component("Intel Core i7", (decimal)200.25);
            Component processor2 = new Component("Intel Core i5", (decimal)150.25);
            Component processor3 = new Component("Intel Core i3", (decimal)100.25);

            Component ram1 = new Component("16GB", (decimal)125.35);
            Component ram2 = new Component("8GB", (decimal)100.35);
            Component ram3 = new Component("4GB", (decimal)75.35);

            Component hdd1 = new Component("256GB SSD", (decimal)250.05);
            Component hdd2 = new Component("256GB SSD", (decimal)170.05);
            Component hdd3 = new Component("256GB SSD", (decimal)100.05);

            Component vga1 = new Component("Radeon 825M", (decimal)158.55);
            Component vga2 = new Component("Radeon 824M", (decimal)138.55);
            Component vga3 = new Component("Radeon 823M", (decimal)118.55);

            Component display1 = new Component("27 in FullHD", (decimal)300.59);
            Component display2 = new Component("24 in FullHD", (decimal)230.59);
            Component display3 = new Component("21 in FullHD", (decimal)150.59);

            Computer firstComputer = new Computer("First Computer",new List<Component>(){psu1,motherBoard1,processor1,ram1,hdd1,vga1,display1});
            Computer secondComputer = new Computer("Second Computer", new List<Component>(){psu2,motherBoard2,processor2,ram2,hdd2,vga2,display2});
            Computer thirdComputer = new Computer("Third Computer", new List<Component>(){psu3,motherBoard3,processor3,ram3,hdd3,vga3,display3});

            List<Computer>computers = new List<Computer>(){firstComputer,secondComputer,thirdComputer};

            computers = computers.OrderBy(computer=>computer.Price).ToList();
            foreach (Computer computer in computers)
            {
                computer.PrintingComputer();
            }
            
            
                
        }
    }
}
