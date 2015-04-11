namespace DistanceCalculator.Service
{
    using System;

    public class ServiceCalculator : ICalculator, IDisposable
    {
        public double CalcDistance(Point startPoint, Point endPoint)
        {
            int deltaX = endPoint.X - startPoint.X;
            int deltaY = endPoint.Y- startPoint.Y;
            var distance = Math.Sqrt(deltaX*deltaX + deltaY*deltaY);
            return distance;
        }

        public void Dispose()
        {
        }
    }
}
