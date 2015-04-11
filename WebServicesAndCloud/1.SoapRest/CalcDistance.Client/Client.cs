namespace CalcDistance.Client
{
    using System;
    using System.Net;
    
    using DistanceCalculator.Service;

    class Client
    {
        // I'm not sure why, byt if you start project with ctrl + F5 throw exception.
        // If you start project with start button, after that start with ctrl + F5 works!!!

        static void Main()
        {
            var pointA = new Point
            {
                X = 1,
                Y = 1
            };

            var pointB = new Point
            {
                X = 3,
                Y = 3
            };

            using (var client = new WebClient())
            {
                var response =
                    client.UploadString(
                        string.Format(
                            "http://localhost:2052/dist?startPointX={0}&startPointY={1}&endPointX={2}&endPointY={3}",
                            pointA.X, pointA.Y, pointB.X, pointB.Y), "POST", "");

                Console.WriteLine(response);
            }
        }
    }
}
