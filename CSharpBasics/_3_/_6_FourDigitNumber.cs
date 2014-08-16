using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please insert four-digit number: ");
        int number =  int.Parse(Console.ReadLine());
        if ((number >= 1000)&&(number<=9999))
        {
            int a = number / 1000;
            int tempa = number % 1000;
            int b  = tempa / 100;
            int tempb = tempa % 100;
            int c = tempb / 10;
            int d = tempb % 10;
            int sum = a + b + c + d;
            Console.WriteLine(sum);
            Console.WriteLine("{3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine("{3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine("{0}{2}{1}{3}", a, b, c, d);

        }
        else
        {
            Console.WriteLine("ERROR!!!  The number must be exactly 4 digits and cannot start with 0.\nPlease try again.");
        }
    }
}
