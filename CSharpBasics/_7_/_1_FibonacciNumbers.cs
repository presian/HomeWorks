using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("What member of Fibonacci sequence you want: ");
        int n = int.Parse(Console.ReadLine());
        Fib(n);
    }
    static void Fib (int n)
    {     
        int firstMember = 0;
        for (int i = 0, secondMember = 1; i <= n; i++)
        {
            
            int thirdMember = firstMember + secondMember;
            firstMember = secondMember;
            secondMember = thirdMember;
            
        }
        Console.WriteLine(firstMember);
    }
}
