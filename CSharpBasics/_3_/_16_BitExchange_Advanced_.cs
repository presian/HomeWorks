using System;

class BitExchange_Advanced_
{
    static void Main()
    {

        //input
        Console.Write("Please enter a number (n): ");
        uint n = uint.Parse(Console.ReadLine());

        Console.Write("Please enter a number (p): ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Please enter a number (q): ");
        int q = int.Parse(Console.ReadLine());

        Console.Write("Please enter a number (k): ");
        uint k = uint.Parse(Console.ReadLine());

        //check for overlapping and range
        if ((k + q) > 32)
        {
            Console.WriteLine("Out of range");
        }
        else if ((k + p) > 32)
        {
            Console.WriteLine("Out of range");
        }
        else if ((p > 31) || (p < 0))
        {
            Console.WriteLine("Out of range");
        }
        else if ((q > 31) || (q < 0))
        {
            Console.WriteLine("Out of range");
        }
        else if ((Math.Abs(p - q)) < k)
        {
            Console.WriteLine("Overlapping");
        }
        else
	    {		 
	    //calculate k for masks
            uint theK = 2;
            for (uint i = 1; i < k; i++)
            {
                theK *= 2;
            }
            //double realK = Math.Pow(2, k) - 1;
            //uint theK = Convert.ToUInt32(realK);
        //make mask
            uint maskP_K = (theK - 1) << p;
            uint maskQ_K = (theK - 1) << q;

        //take bits
            uint bitsP_K = n & maskP_K;
            uint bitsQ_K = n & maskQ_K;

        //bits exchange
            if ((p - q) > 0)
            {
                bitsP_K >>= (p - q);
                bitsQ_K <<= (p - q);
            }
            else
            {
                bitsP_K <<= (q - p);
                bitsQ_K >>= (q - p);
            }
        
        //put zero to the place
            uint result = n & (~maskP_K);
            result &= (~maskQ_K);

        //the result is...
            result |= bitsP_K;
            result |= bitsQ_K;

        //output 
            Console.WriteLine(result); 
        }
    }
}

