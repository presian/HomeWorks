using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractURLsFromText
{
    static void Main()
    {
        Console.WriteLine("Please enter your text!");
        string input = Console.ReadLine();
        string[] text = input.Split(' ');
        List<string> links = new List<string>();
        foreach (var word in text)
        {
            if (word.Length > 5)
            {
                if ((word.Substring(0, 4) == "www.") || (word.Substring(0, 4) == "http"))
                {
                    links.Add(word);
                }
            }
            
        }
        Console.WriteLine();
        foreach (var link in links)
        {
            Console.WriteLine(link);
        }
        Console.WriteLine();
    }
}
