//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. If the user enters an invalid number, let the user to enter again.

using System;

namespace _2_EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a start number: ");
            long start = Validation.NumberValidation();
            
            Reinput:
            Console.Write("Please enter a end number: ");
            long end = Validation.NumberValidation();
            if (start>end)
            {
                long temp = start;
                start = end;
                end = temp;
            }
            else if (start==end)
            { 
                Console.WriteLine("\n\n\nFirst and second number cannot be a equal!");
                goto Reinput;
            }
            Console.Write("How many number you want: ");
            long n = Validation.NumberValidation();
            
            
                
                for (int i = 0; i < n; i++)
                {
                    Console.Write(String.Format("Please enter a #{2} number in range [{0}..{1}]: ", start, end, i + 1));
                In:
                    try
                    { 
                    ReadNumber.ReadNumberMethod(start, end);
                    }
                    catch (FormatException)
                    {
                        Console.Write("Please enter number: ");
                        goto In;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.Write(String.Format("Please enter valid number in range [{0}...{1}]: ", start, end));
                        goto In;
                    }
                }
                
            
           
            

        }
    }
}
