namespace _1_Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            double result = this.Width * this.Height;
            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = this.Height * 2 + this.Width * 2;
            return result;
        }
    }
}
