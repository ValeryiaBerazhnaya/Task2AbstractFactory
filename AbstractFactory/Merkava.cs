using System.Xml.Linq;

namespace AbstractFactory
{
    public class Merkava : Tank
    {
        public Merkava()
        {
            Weight = 8000;
            Length = 8.0;
            MaxSpeed = 120;
            ProjectileCaliber = 20;
            ShotsPerMinute = 400;
            CrewSize = 3;
        }
    }
}