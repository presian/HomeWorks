namespace _1_Shapes
{
    class Triangle : BasicShape
    {
        private double thirdSide;

        public Triangle(double width, double height, double thirdSide)
            : base(width, height)
        {
            this.ThirdSide = thirdSide;
        }

        private double ThirdSide
        {
            get
            {
                return this.thirdSide;
            }
            set
            {
                this.thirdSide = value;
            }
        }
        public override double CalculateArea()
        {
            double result = this.Height * this.Width / 2;
            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = this.Height + this.Width + this.ThirdSide;
            return result;
        }
    }
}
