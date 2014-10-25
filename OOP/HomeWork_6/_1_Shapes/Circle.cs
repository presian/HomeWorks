using System;

namespace _1_Shapes
{
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        private double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;
            }
        }
        public double CalculateArea()
        {
            double result = Math.PI * Math.Pow(this.Radius, 2);
            return result;
        }

        public double CalculatePerimeter()
        {
            double result = 2 * Math.PI * this.Radius;
            return result;
        }
    }
}
