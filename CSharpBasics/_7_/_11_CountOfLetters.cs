using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountOfLetters
{
    static void Main()
    {
        //input
        string input = Console.ReadLine();

        //make list
        char[] inputLetters = input.ToCharArray();
        List<char> letters = inputLetters.ToList<char>();
        for (int i = 0; i < letters.Count; i++)
        {
            if (letters[i] == ' ')
            {
                letters.Remove(letters[i]);
                i--;
            }
        }
        letters.Sort();
        for (int i = 0; i < letters.Count; i++)
        {
            int counter = 0;
            for (int j = 0; j < letters.Count; j++)
            { 
                if (i > 0 && (letters[i] == letters[i - 1]))
                {
                    break;
                }
                if (letters[i] == letters[j])
                {
                    counter++;
                }
            }
            if (counter > 0)
            {
                Console.WriteLine("{0} -> {1}", letters[i], counter);
            } 
        }
    }
}