using Lab1.Interfaces;

namespace Lab1.Classes
{
    public class Roadmap : IRoadmap
    {
        public List<IPoint>? Points { get; set; }

        public Roadmap(List<IPoint>? points)
        {
            Points = points;
        }
    }
}
