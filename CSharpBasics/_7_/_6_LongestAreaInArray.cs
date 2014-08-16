using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestAreaInArray
{
    static void Main()
    {
        Console.Write("How many strings you want: ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            array[i]= Console.ReadLine();
        }
        int maxSequence = 0;
        string value = null;
        for (int i = 0; i < array.Length ; i++)
        {
            int counter = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array [i] == array [j])
                {
                    counter++;

                }
                if (maxSequence < counter)
                {
                    maxSequence = counter;
                    value = array[i];
                }
            }
        }
        Console.WriteLine(maxSequence);
        for (int i = 0; i < maxSequence; i++)
        {
            Console.WriteLine(value);
        }
    }

}
