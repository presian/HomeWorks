using System;

namespace _1_Galactic_GPS
{
    public struct Location
    {
        // Fields
        private double latitude;
        private double longitude;

        // Constructors
        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Planet = planet;
            this.latitude = latitude;
            this.longitude = longitude;
        }
        // Property
        public Planet Planet { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1} - {2}", this.latitude, this.longitude, this.Planet);
        }
    }

}
