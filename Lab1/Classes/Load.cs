using Lab1.Interfaces;

namespace Lab1.Classes
{
    public class Load : ILoad
    {
        public double Weight { get; set; }
        public string Name { get; set; }

        public Load(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }
    }
}
