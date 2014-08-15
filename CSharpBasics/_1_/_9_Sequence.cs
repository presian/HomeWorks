using System;

    class FirstTenOfSequence
    {
        static void Main()
        {
            Console.WriteLine("The first 10 members of the sequence is:");
            for (int i = 2, n=-3; i <= 10; i+=2, n-=2)
            {
                Console.Write(i + "," + n + ","); 
            }
        }
    }
