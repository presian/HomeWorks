using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class AverageLoadTimeCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter the line:");
        Dictionary<string, double> sites = new Dictionary<string, double>();
        Dictionary<string, int> counters = new Dictionary<string, int>();
        //int counter = 0;
        string line = Console.ReadLine();
        while (line != string.Empty)
        {
            string[] logs = line.Split(' ');
            string link = logs[2];
            double loadTime = double.Parse(logs[3]);
            if (!sites.Keys.Contains(link))
            {
                sites[link] = loadTime;
                counters.Add(link, 1);
            }
            else
            {
                sites[link] = sites[link] + loadTime;
                counters[link] += 1;
            }
            Console.WriteLine("Enter new log (If you not, just enter a empty line): ");
            line = Console.ReadLine();
        }
        foreach (var link in sites.Keys)
        {
            Console.WriteLine("{0} -> {1}", link, (sites[link] / counters[link]).ToString("G29"));
        }
        
            
    }
}
