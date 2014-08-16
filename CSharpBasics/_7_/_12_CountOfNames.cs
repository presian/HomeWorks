using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CountOfNames
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] inputNames = input.Split(new char [] {' '}, StringSplitOptions.RemoveEmptyEntries);
            List<string> names = inputNames.ToList<string>();
            names.Sort();
            for (int i = 0; i < names.Count; i++)
            {
                int counter = 0;
                for (int j = i; j < names.Count; j++)
                {
                    if ((i > 0) && (names [i] == names[i-1]))
                    {
                        break;
                    }
                    if (names[i]==names[j])
                    {
                        counter++;
                    }
                }
                if (counter > 0)
                {
                    Console.WriteLine("{0}->{1}",names[i], counter);   
                }
                
            }
        }
    }
