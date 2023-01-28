using Lab1.Interfaces;

namespace Lab1.Classes
{
    public class Point : IPoint
    {
        public string? Location { get; set; }
        public double Distance { get; set; }

        public Point(string? location, double distance)
        {
            Location = location;
            Distance = distance;
        }
    }
}
