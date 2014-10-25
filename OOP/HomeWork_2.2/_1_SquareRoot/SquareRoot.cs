//Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.


using System;


namespace _1_SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter positive number: ");
            string input = Console.ReadLine();

            try
            {
                ulong number = ulong.Parse(input);
                Console.WriteLine(String.Format("{0:F5}", Math.Sqrt(number)));
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }  
        }
    }
}
