using System;

    class AgeAfter10Years
    {
        static void Main()
        {
            Console.Write("Please enter your age:");
            int age = int.Parse(Console.ReadLine());
            int afterTenAge = age + 10;
            Console.WriteLine("Your age now:{0}",age);
            Console.WriteLine("Your age after 10 years:{0}",afterTenAge);
        }
    }
