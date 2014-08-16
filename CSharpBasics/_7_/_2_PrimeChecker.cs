using System;

class PrimeChecker
{
    static void Main()
    {
        Console.Write("What is your number: ");
        ulong n = ulong.Parse(Console.ReadLine());
        bool isPrime = IsPrime(n);
        Console.WriteLine(isPrime);
    }
    static bool IsPrime(ulong num)
    {
        if ((num & 1) == 0)
        {
            if (num == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        for (ulong i = 3; (i * i) <= num; i += 2)
        {
            if ((num % i) == 0)
            {

                return false;
            }
        }
        return num != 1;
    }
}