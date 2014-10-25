using System;

namespace _2_EnterNumbers
{
    public static class ReadNumber
    {
        public static void ReadNumberMethod(long start, long end)
        {
            
            long number;

                if (long.TryParse(Console.ReadLine(), out number)==false)
                {
                    throw new FormatException();
                }
                else if (number<start || number>end)
                {
                    throw new ArgumentOutOfRangeException();
                }
        }
    }
}
