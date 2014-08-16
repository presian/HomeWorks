using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemoveNames
{
    static void Main()
    {
        ////input
        //Console.Write("How many names you want in first array: ");
        //int namesFirst = int.Parse(Console.ReadLine());
        //List <string> firstArray = new List <string>();
        //for (int  firstcol = 0; firstcol < namesFirst; firstcol++)
        //{
        //    firstArray.Add(Console.ReadLine());
        //}
        //Console.Write("How many names you want in second array: ");
        //int namesSecond = int.Parse(Console.ReadLine());
        //List<string> secondArray = new List<string>();
        //for (int secodcol = 0; secodcol < namesSecond; secodcol++)
        //{
        //    secondArray.Add(Console.ReadLine());
        //}

        //input
        string firstNames = Console.ReadLine();
        string secondNames = Console.ReadLine();
        string[] firstRowNames = firstNames.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] secondRowNames = secondNames.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        List<string> firstArray = firstRowNames.ToList<string>();
        List<string> secondArray = secondRowNames.ToList<string>();
       
        //logic
        for (int secondRow = 0; secondRow < secondArray.Count; secondRow++)
        {
            for (int firstRow = 0; firstRow < firstArray.Count; firstRow++)
            {
                if (firstArray[firstRow] == secondArray[secondRow])
                {
                   firstArray.RemoveAt(firstRow);
                }
            }
        }

        //output
        foreach (var name in firstArray)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}
