//Write a static class DistanceCalculator with a static method to calculate the distance between two points in the 3D space. Search in Internet how to calculate distance in the 3D Euclidean space


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Distance_Calculator
{
    class DistanceCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter coordinates for first point\nEnter X : ");
            Point.X1 = long.Parse(Console.ReadLine());
            Console.Write("Enter Y: ");
            Point.Y1 = long.Parse(Console.ReadLine());
            Console.Write("Enter Z: ");
            Point.Z1= long.Parse(Console.ReadLine());

            Console.Write("Please enter coordinates for second point\nEnter X : ");
            Point.X2 = long.Parse(Console.ReadLine());
            Console.Write("Enter Y: ");
            Point.Y2 = long.Parse(Console.ReadLine());
            Console.Write("Enter Z: ");
            Point.Z2 = long.Parse(Console.ReadLine());
            Console.WriteLine(Point.CalculatorForDistace());
        }
    }

    static class Point
    {
        private static double x1;
        private static double y1;
        private static double z1;

        private static double x2;
        private static double y2;
        private static double z2;

        public static double X1 { get; set; }
        public static double Y1 { get; set; }
        public static double Z1 { get; set; }
        public static double X2 { get; set; }
        public static double Y2 { get; set; }
        public static double Z2 { get; set; }


        public static double CalculatorForDistace ()
        {
            double x = Point.X2 - Point.X1;
            double y = Point.Y2 - Point.Y2;
            double z = Point.Z2 - Point.Z1;
            double result = Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2)+Math.Pow(z,2));


            return result;
        }
    }
}
