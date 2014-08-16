using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("How many members of the Fibonacci siquence you want: ");
        int members = int.Parse(Console.ReadLine());
        if (members<1)
        {
            Console.Write("Incorrect number, please try again: ");
            members = int.Parse(Console.ReadLine());
        }
        for (int i = 0, firstmember = 0, secondmember = 1, nextmember = 0; i < members; i++, firstmember = secondmember, secondmember = nextmember)
        {
            Console.Write(firstmember + " ");
            nextmember = firstmember + secondmember;    
        }
    }
}
