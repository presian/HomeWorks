using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SortingNumbers
    {
        static void Main()
        {
            Console.Write("How many number you want: ");
            int n = int.Parse(Console.ReadLine());
            int[] massiveOfN = new int[n];
            for (int i = 0; i < massiveOfN.Length; i++)
            {
                massiveOfN[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(massiveOfN);
            foreach (var number in massiveOfN)
            {
                Console.Write(number + " ");
                Console.WriteLine();
            }
        }
    }
