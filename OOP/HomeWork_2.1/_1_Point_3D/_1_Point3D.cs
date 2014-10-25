//Create a class Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidean 3D space. Create appropriate constructors. Implement the ToString() to enable printing a 3D point.
//Add a private static read-only field in the Point3D class to hold the start of the coordinate system – the point StartingPoint {0, 0, 0}. Add a static property to return the starting point.
//=======================================================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Point_3D
{
    class Point3D

    {
       static void Main(string[] args)
        {
            
            string outOfProgram = "y";
            Console.Write("Do you want enter a new set of coordinates? (y/n) -> ");
            outOfProgram = Console.ReadLine();
           
            while (outOfProgram == "y")
            {
                Console.Write("Please enter name of point: ");
                string name = Console.ReadLine();
                Console.Write("Enter X: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Enter Y: ");
                double y = double.Parse(Console.ReadLine());
                Console.Write("Enter Z: ");
                double z = double.Parse(Console.ReadLine());
                Point3D point = new Point3D(name, x, y, z);
                Console.WriteLine(point);
                Console.Write("Do you want enter a new set of coordinates? (y/n) -> ");
                outOfProgram = Console.ReadLine();

                Console.WriteLine(startingPoint);
            }
           
        }
        //fields
        private string name;
        private double x;
        private double y;
        private double z;

        //property
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public string Name { get; set; }

        private static readonly Point3D startingPoint;

        //constructors
        public Point3D(string name, double x, double y, double z)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        static Point3D StartingPoint { get { return startingPoint; }}
        static Point3D()
        {
            startingPoint = new Point3D("Starting point", 0,0,0);
        }

        public override string ToString()
        {
            return String.Format("Point {3} is with coordinates: x->{0} | y->{1} | z->{2}",this.x,this.y,this.z, this.name);
        }
    }
}
