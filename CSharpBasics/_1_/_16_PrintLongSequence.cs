using System;

    class PrintLongSequence
    {
        static void Main()
        {
            Console.WriteLine("This is the first 1000 members of sequence:");
            for (int i = 2, n = -3; i <= 1002; i += 2, n -= 2)
            {
                Console.Write(i + "," + n + ",");
            }
        }
    }

 