using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        //input
        Console.Write("Please enter start number: ");
        uint startNum = uint.Parse(Console.ReadLine());

        Console.Write("Please enter end number: ");
        uint endNum = uint.Parse(Console.ReadLine());

        uint p = 0;

        //logic
        for (uint i = startNum; i <= endNum; i++)
        {
            if (i % 5 ==0)
	        {
                p++;
	        } 
        }

        //output
        Console.WriteLine(p);
    }
}
