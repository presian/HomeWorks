using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimesInGivenRange
{
    static void Main()
    {
        int startDigit = int.Parse(Console.ReadLine());
        int endDigit = int.Parse(Console.ReadLine());
        FindPrimesInRange(startDigit, endDigit);
        
    }
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> nums = new List<int>();
        for (int candidate = startNum; candidate <= endNum; candidate++)
        {
            nums.Add(candidate);
            if (((candidate & 1) == 0) && (candidate != 2) || (candidate == 1))
            {
                nums.Remove(candidate);
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    nums.Remove(candidate);
                }
            }
        }
        foreach (var number in nums)
        {
            Console.Write(number + " ");
            
        }
        Console.WriteLine();
        return null;
    }
}