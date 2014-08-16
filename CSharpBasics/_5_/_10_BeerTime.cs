using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        //change culture
        CultureInfo bt = new CultureInfo("en-us");
        Thread.CurrentThread.CurrentCulture = bt;
        Thread.CurrentThread.CurrentUICulture = bt;
            
        //parsing DateTime
        Console.Write("Enter a time in format hh:mm: ");
        DateTime time = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(time);
        DateTime startBeer = DateTime.Parse("1:00 PM");
        DateTime endBeer = DateTime.Parse("3:00 PM");
        if ((time.Hour > startBeer.Hour) && (time.Hour < endBeer.Hour))
        {
            Console.WriteLine("Beer time!");
        }
        else
        {
            Console.WriteLine("Non-beer time!");
        }          
    }
}

