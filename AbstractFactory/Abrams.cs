using System.Xml.Linq;

namespace AbstractFactory
{
    public class Abrams : Tank
    {
        public Abrams()
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