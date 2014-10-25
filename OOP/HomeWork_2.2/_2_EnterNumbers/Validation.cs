using System;

namespace _2_EnterNumbers
{
    class Validation
    {
        public static long NumberValidation()
        {
            long result;
            In:
            string input = Console.ReadLine();
            try
            {
                result = long.Parse(input);
            }
            catch (FormatException)
            {
                Console.Write("Please enter a valid number: ");
                goto In;
            }
            return result;
        }

    }
}
