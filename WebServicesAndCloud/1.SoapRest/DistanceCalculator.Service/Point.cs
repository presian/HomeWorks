namespace DistanceCalculator.Service
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Point
    {
        int x = 0;
        int y = 0;

        [DataMember]

        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        [DataMember]

        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
    }
}