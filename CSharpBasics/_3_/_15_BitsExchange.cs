using System;

class BitsExchange
{
    static void Main()
    {

        //input
        Console.Write("Please enter a number (n): ");
        uint n = uint.Parse(Console.ReadLine());
        uint result;

        //create mask
        uint mask1 = 7 << 3;
        uint mask2 = 7 << 24;

        //take bits
        uint bits345 = n & mask1;
        uint bits24_25_26 = n & mask2;
                    
        //bite exchange
        bits345 <<= 21;
        bits24_25_26 >>= 21;

        //place zero in bits 
        result = n & (~mask1);
        result &= (~mask2);
                        
        //output
        result |= bits345;
        result |= bits24_25_26;
        Console.WriteLine(result);

    }
}

