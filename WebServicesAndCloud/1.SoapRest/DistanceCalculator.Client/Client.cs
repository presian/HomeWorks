namespace DistanceCalculator.Client
{
    using System;

    using Service;

    class Client
    {
        static void Main()
        {
            using (var calc = new ServiceCalculator())
            {
                var a = new Point
                {
                    X = 1,
                    Y = 1
                };

                var b = new Point
                {
                    X = 3,
                    Y = 3
                };

                var result = calc.CalcDistance(a, b);

                Console.WriteLine(result);
            }
        }
    }
}
