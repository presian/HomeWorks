using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongestWordInAText
{
    static void Main()
    {
        Console.WriteLine("Please enter your sentence!");
        string sentence = Console.ReadLine().Trim('.');
        string[] words = sentence.Split(' ');
        string max = words[0];
        for (int word = 0; word < words.Length; word++)
        {
            if ((word>0) && (words[word].Length > max.Length))
            {
                max = words[word];
            }
        }
        Console.WriteLine(max);
    }
}
