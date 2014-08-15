using System;

class NullValuesArithmetic
    {
        static void Main()
        {
            int? i = null;
            double? d = null;
            Console.WriteLine("Null Value:" + i);
            Console.WriteLine("Null Value:" + d);

            i += 3;
            d += 8.5;
            Console.WriteLine("Add 3:" + i);
            Console.WriteLine("Add 8.5:" + d);

            i += null;
            d += null;
            Console.WriteLine("Add Null:" + i);
            Console.WriteLine("Add Null:" + d);
        }
    }

