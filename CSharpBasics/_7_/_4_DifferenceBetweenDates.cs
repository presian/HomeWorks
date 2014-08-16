using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class DifferenceBetweenDates
{
    static void Main()
    {
        
        Console.Write("Please enter the first date in format dd.MM.yyyy: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Please enter the second date in format dd.MM.yyyy: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        TimeSpan result;
        result = secondDate - firstDate;
        Console.WriteLine("{0}", result.Days);
    }
}


