using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class JoinLists
{
    static void Main()
    {
        //first input
        string firstNumbers = Console.ReadLine();
        string[] firstNumStringArry = firstNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbersRowOne = Array.ConvertAll(firstNumStringArry,int.Parse);
        List<int> firstLine = numbersRowOne.ToList<int>();

        //second input
        string secondNumbers = Console.ReadLine();
        string[] secondNumStringArray = secondNumbers.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
        int[] numbersRowTwo = Array.ConvertAll(secondNumStringArray, int.Parse);
        List<int> secondLine = numbersRowTwo.ToList<int>();
        //List<int> thirdLine = new List<int>();

        //logic
        //for (int row = 0; row < firstLine.Count; row++)
        //{
        //    for (int col = 0; col < secondLine.Count; col++)
        //    {
        //        if (firstLine[row] != secondLine[col])
        //        {
                    
        //            thirdLine.Add(firstLine[row]);
        //        }
        //    }
        //}
        firstLine.AddRange(secondLine);
        firstLine.Sort();
        for (int i = 0; i < firstLine.Count; i++)
        {
            for (int j = i+1; j < firstLine.Count; j++)
            {
                if (firstLine[i] == firstLine[j])
                {
                    firstLine.Remove(firstLine[j]);
                    j--;
                } 
            } 
        }
        
        foreach (var numbers in firstLine)
        {
            Console.Write(numbers + " ");
        }
        Console.WriteLine();
        //output
    }
}
